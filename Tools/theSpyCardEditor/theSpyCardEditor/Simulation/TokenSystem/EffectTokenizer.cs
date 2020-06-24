using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class EffectTokenizer
    {
        public readonly string[] ACTIONS = new string[]
        {
            "go", "add", "remove", "release", "block"
        };

        public readonly string[] ASSIGNEMENT = new string[]
        {
            "=", "+=", "-=", "*=", "/="
        };

        public const string SYMBOLS = "=+-*/%()";

        private string line;
        private int next;

        public EffectTokenizer(string line)
        {
            this.line = line;
            next = 0;
        }

        public EffectToken Get()
        {
            while (next < line.Length && Ignore())
            {
                ++next;
            }

            if (next >= line.Length)
            {
                return new EffectToken(EETokenType.End, "");
            }

            char first = line[next];

            if (char.IsDigit(first))
            {
                return GetNumber();
            }
            else if (SYMBOLS.Contains(first))
            {
                return GetSymbols();
            }
            else if (IsValidFirstCharForWord(first))
            {
                return GetParameter();
            }
            else if (first == ';') {
                ++next;
                return new EffectToken(EETokenType.EndOneEffect, ";");
            }
            else
            {
                ++next;
                return new EffectToken(EETokenType.Incorrect, "");
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

        EffectToken GetNumber()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(line[next]);
            ++next;

            while (next < line.Length && char.IsDigit(line.ElementAt(next)))
            {
                stringBuilder.Append(line[next]);
                ++next;
            }

            return new EffectToken(EETokenType.Value, stringBuilder.ToString());
        }

        EffectToken GetSymbols()
        {
            char current = line[next];
            ++next;

            if (current == '=')
            {
                return new EffectToken(EETokenType.Assignement, current + "");
            } else if (ASSIGNEMENT.Contains(current + "" + line[next]))
            {
                ++next;
                return new EffectToken(EETokenType.Assignement, current + "" + line[next-1] + "");
            }

            return new EffectToken(EETokenType.Symbol, current + "");
        }

        EffectToken GetParameter()
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
            if (ACTIONS.Contains(parameter))
            {
                return new EffectToken(EETokenType.Action, parameter);
            }
            else
            {
                return new EffectToken(EETokenType.Word, parameter);
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
