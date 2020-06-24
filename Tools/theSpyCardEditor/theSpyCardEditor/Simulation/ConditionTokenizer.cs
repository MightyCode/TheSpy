using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class ConditionTokenizer
    {
        public const string SINGLE_OPERATOR = "><!+-/*%";
        public const string DOUBLE_OPERATOR = "=&|";
        public readonly List<char> NumOperator = new List<char>() { '+', '-', '/', '*', '%'};

        private string line;
        private int next;

        public ConditionTokenizer(string line)
        {
            this.line = line;
            next = 0;
        }

        public ConditionToken Get()
        {
            while (next < line.Length && Ignore())
            {
                ++next;
            }

            if (next >= line.Length)
            {
                return new ConditionToken(ECTokenType.End, "");
            }

            char first = line[next];

            if (char.IsDigit(first))
            {
                return GetNumber();
            }
            else if (SINGLE_OPERATOR.Contains(first) || DOUBLE_OPERATOR.Contains(first))
            {
                return GetOperator();
            }
            else if (IsValidFirstCharForWord(first))
            {
                return GetParameter();
            }

            ++next;
            if (first == '(')
            {
                return new ConditionToken(ECTokenType.OpenParenthesis, "(");
            }
            else if (first == ')')
            {
                return new ConditionToken(ECTokenType.CloseParenthesis, ")");
            }
            else if (first == '{')
            {
                return new ConditionToken(ECTokenType.OpenBacket, "{");
            }
            else if (first == '}')
            {
                return new ConditionToken(ECTokenType.CloseBraket, "}");
            }
            else
            {
                return new ConditionToken(ECTokenType.Incorrect, "");
            }
        }

        bool Ignore()
        {
            char cur = line[next];
            if (char.IsWhiteSpace(cur) || cur == '\r' || cur == '\n' || cur == '\t')
            {
                return true;
            }

            return false;
        }

        ConditionToken GetNumber()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(line[next]);
            ++next;

            while (next < line.Length && char.IsDigit(line.ElementAt(next)))
            {
                stringBuilder.Append(line[next]);
                ++next;
            }

            return new ConditionToken(ECTokenType.Value, stringBuilder.ToString());
        }

        ConditionToken GetOperator()
        {
            char current = line[next];
            ++next;

            if (DOUBLE_OPERATOR.Contains(current)){
                
                if (DOUBLE_OPERATOR.Contains(line[next]))
                {
                    ++next;
                    if (current == '&' || current == '|') return new ConditionToken(ECTokenType.BoolToBoolOperator, current + "" + current);
                    else return new ConditionToken(ECTokenType.NumToBoolOperator, current + "" + current);


                } else
                {
                    return new ConditionToken(ECTokenType.Incorrect, current + "");
                }
            } else if (current == '>' || current == '<')
            {
                if (line[next] == '=')
                {
                    ++next;
                    return new ConditionToken(ECTokenType.NumToBoolOperator, current + "=");
                } else
                {
                    return new ConditionToken(ECTokenType.NumToBoolOperator, current + "");
                }
            } else if (current == '!')
            {
                if (line[next] == '=')
                {
                    ++next;
                    return new ConditionToken(ECTokenType.NumToBoolOperator, "!=");
                } else
                {
                    return new ConditionToken(ECTokenType.InvertOperator, "!");
                }
            } else if (NumOperator.Contains(current)){
                return new ConditionToken(ECTokenType.NumToNumOperator, current + "");
            }

            return new ConditionToken(ECTokenType.Incorrect, current + "");
        }

        ConditionToken GetParameter()
        {
            string parameter = "";
            parameter += line[next];
            ++next;

            bool end = false;

            while (next < line.Length && !end)
            {
                end = !IsValidCharForWord(line[next]);

                if (!end)
                {
                    parameter += line[next];
                    ++next;
                }
            }

            // Securities
            if (parameter.Equals("if"))
            {
                return new ConditionToken(ECTokenType.If, parameter);
            }
            else if (parameter.Equals("else"))
            {
                return new ConditionToken(ECTokenType.Else, parameter);
            }
            else
            {
                return new ConditionToken(ECTokenType.Word, parameter);
            }

        }

        static bool IsValidFirstCharForWord(char c)
        {
            return (c == '_' || char.IsLetter(c));
        }

        static bool IsValidCharForWord(char c)
        {
            return (char.IsLetterOrDigit(c) || c == '_');
        }
    }
}
