using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theSpyCardEditor
{
    class SimulationComputations
    {
        public static ConditionTokenizer reader;
        public static ConditionToken lct;

        public static EffectTokenizer Ereader;
        public static EffectToken Etoken;

        #region detect parameters

        public static Dictionary<string, int> ComputeParametersAvailable(Dictionary<EMode, List<Card>> cards)
        {
            Dictionary<string, int> parameters = new Dictionary<string, int>(GameProperties.BasicParameters);

            ConditionTokenizer reader;
            ConditionToken lct;
            int parenthesisCount = 0;
            string value;

            foreach (KeyValuePair<EMode, List<Card>> pair in cards.AsQueryable())
            {
                foreach (Card card in pair.Value)
                {
                    foreach (string key in card.Properties.Keys)
                    {
                        if (!key.ToLower().Contains("conditions")) continue;

                        value = card.Properties[key].Value;

                        if (value.Count() <= 0) continue;

                        if (key.Equals("NecessaryConditions"))
                        {
                            if (value.First() != '(') value = "(" + value + ")";
                        }

                        reader = new ConditionTokenizer(value);
                        lct = reader.Get();

                        while (lct.Type != ECTokenType.End)
                        {
                            //Console.WriteLine(lct.Type);

                            if (lct.Type == ECTokenType.Word && parenthesisCount != 0)
                            {
                                if (!parameters.ContainsKey(lct.String))
                                {
                                    parameters.Add(lct.String, 0);
                                }
                            }
                            else if (lct.Type == ECTokenType.OpenParenthesis)
                            {
                                ++parenthesisCount;
                            }
                            else if (lct.Type == ECTokenType.CloseParenthesis)
                            {
                                --parenthesisCount;
                            }
                            else if (lct.Type == ECTokenType.Incorrect)
                            {
                                string error = "Error at card " + card.Properties["Id"].Value +
                                    ", mode " + pair.Key + ", property " + key;
                                Console.WriteLine(error);
                                MessageBox.Show(error);
                                return null;
                            }

                            lct = reader.Get();
                        }
                    }
                }
            }

            return parameters;
        }
        #endregion

        #region get label from condition
        public static List<string> GetLabels(Dictionary<string, int> parameters, string content)
        {
            CreateNewReader(content);
            return GetLabels(new List<string>(), parameters);
        }

        public static List<string> GetLabels(List<string> labels, Dictionary<string, int> parameters)
        {
            bool condition = false;
            bool inSubBracket = false;
            bool ifEncounter = false;
            bool elseEncounter = false;

            // Close if end of counter a } and no inSubBracket
            while (lct.Type != ECTokenType.End && (lct.Type != ECTokenType.CloseBraket || inSubBracket))
            {
                //Console.WriteLine(lct.Type);
                if (inSubBracket)
                {
                    if (lct.Type == ECTokenType.CloseBraket)
                    {
                        //Console.WriteLine("->End of brocken bracket");
                        inSubBracket = false;
                    }

                    lct = reader.Get();
                }
                else
                {
                    if (lct.Type == ECTokenType.If && (!ifEncounter || elseEncounter))
                    {
                        ifEncounter = true;
                        elseEncounter = false;
                        lct = reader.Get();
                    }
                    else if (lct.Type == ECTokenType.OpenParenthesis)
                    {
                        if (ifEncounter)
                        {
                            lct = reader.Get();
                            condition = EvaluateBooleanExpression().Value(parameters);
                            //Console.WriteLine("->Condition evaluated " + condition);
                        }
                        else
                        {
                            Console.WriteLine("No parenthesis after if -> " + lct.Type);
                            return null;
                        }
                        lct = reader.Get();
                    }
                    else if (lct.Type == ECTokenType.OpenBacket)
                    {
                        if ((ifEncounter && !condition) || (elseEncounter && condition))
                        {
                            inSubBracket = true;
                            //Console.WriteLine("->OpenBracketBrocken");
                            lct = reader.Get();
                        }
                        else if ((ifEncounter && condition) || (elseEncounter && !condition))
                        {
                            lct = reader.Get();
                            //Console.WriteLine("->Go in sub if");
                            labels = GetLabels(labels, parameters);
                            //Console.WriteLine("->After the sub if");
                        }
                        else
                        {
                            //Console.WriteLine("->Bracket without condition");
                            return null;
                        }
                    }
                    else if (lct.Type == ECTokenType.Word)
                    {
                        //Console.WriteLine("->Add a label " + lct.String);
                        labels.Add(lct.String);
                        lct = reader.Get();
                    }
                    else if (lct.Type == ECTokenType.Else)
                    {
                        elseEncounter = true;
                        ifEncounter = false;
                        lct = reader.Get();
                    }
                }

            }

            //Console.WriteLine("->normalEnd");
            lct = reader.Get();
            return labels;
        }
        #endregion

        #region boolean expression (including numerical expression in it -> 1 + 1 = 2)
        public static BoolExpression EvaluateBooleanExpression(string condition)
        {
            CreateNewReader(condition);
            return EvaluateBooleanExpression();
        }

        public static BoolExpression EvaluateBooleanExpression()
        {
            bool invert = false;
            string ope;

            if (lct.Type == ECTokenType.InvertOperator)
            {
                invert = true;
                lct = reader.Get();
            }

            BoolExpression value = GetBoolExpression();
            BoolExpression otherValue;
            if (invert)
            {
                value = BoolExpressionFactory.BinaryOperation(value, "!", null);
            }

            while (lct.Type == ECTokenType.BoolToBoolOperator)
            {
                ope = lct.String;
                lct = reader.Get();
                if (lct.Type == ECTokenType.InvertOperator)
                {
                    lct = reader.Get();
                    otherValue = BoolExpressionFactory.BinaryOperation(GetBoolExpression(), "!", null);
                }
                else
                {
                    otherValue = GetBoolExpression();
                }

                value = BoolExpressionFactory.BinaryOperation(value, ope, otherValue);
                lct = reader.Get();
            }

            return value;
        }

        public static BoolExpression GetBoolExpression()
        {
            if (lct.Type == ECTokenType.OpenParenthesis)
            {

                lct = reader.Get();
                return EvaluateBooleanExpression();
            }

            return BoolExpressionFactory.NumBinaryComparation
                (EvaluateNumberExpression(), GetComparatorOperator(), EvaluateNumberExpression());
        }

        public static string GetComparatorOperator()
        {
            if (lct.Type == ECTokenType.NumToBoolOperator)
            {
                string ope = lct.String;
                lct = reader.Get();

                return ope;
            }

            Console.WriteLine("No operator between two boolean value :" + lct.Type + ", " + lct.String);
            return "";
        }
        #endregion

        #region Numerical expression
        public static NumExpression EvaluateNumberExpression(string content)
        {
            CreateNewReader(content);
            return EvaluateNumberExpression();
        }

        public static NumExpression EvaluateNumberExpression()
        {
            bool minus = false;

            if (lct.Type == ECTokenType.InvertOperator)
            {
                minus = true;
                lct = reader.Get();
            }

            NumExpression value = GetTermExpression();
            if (minus) value = NumExpressionFactory.BinaryOperation(NumExpressionFactory.Constante(-1), "*", value);

            while (lct.IsOperator("+") || lct.IsOperator("-"))
            {
                // We can have minus after + but not -
                if (lct.IsOperator("+"))
                {
                    lct = reader.Get();

                    // Case where minus after +
                    if (lct.IsOperator("-"))
                    {
                        lct = reader.Get();
                        value = NumExpressionFactory.BinaryOperation(value, "-", GetTermExpression());
                        // Case no minus
                    }
                    else
                    {
                        value = NumExpressionFactory.BinaryOperation(value, "+", GetTermExpression());
                    }
                }
                else if (lct.IsOperator("-"))
                {
                    lct = reader.Get();
                    value = NumExpressionFactory.BinaryOperation(value, "-", GetTermExpression());
                }
            }

            return value;
        }
        public static NumExpression GetTermExpression()
        {
            NumExpression value = GetNumberExpression();
            NumExpression otherValue;
            string ope;

            while (lct.IsOperator("*") || lct.IsOperator("/") || lct.IsOperator("%"))
            {
                ope = lct.String;

                lct = reader.Get();
                if (lct.IsOperator("-"))
                {
                    lct = reader.Get();
                    otherValue = NumExpressionFactory.BinaryOperation(NumExpressionFactory.Constante(-1), "*", GetNumberExpression());
                }
                else
                {
                    otherValue = GetNumberExpression();
                }

                value = NumExpressionFactory.BinaryOperation(value, ope, otherValue);
            }

            return value;
        }

        public static NumExpression GetNumberExpression()
        {
            NumExpression value;

            // Number
            if (lct.Type == ECTokenType.Value)
            {
                value = NumExpressionFactory.Constante(lct.Value);
                lct = reader.Get();
                // Variable
            }
            else if (lct.Type == ECTokenType.Word)
            {
                value = NumExpressionFactory.Parameters(lct.String);
                lct = reader.Get();
            }
            else if (lct.Type == ECTokenType.OpenParenthesis)
            {
                lct = reader.Get();
                value = EvaluateNumberExpression();
                if (lct.Type == ECTokenType.CloseParenthesis) lct = reader.Get();
                // Error
                else Console.WriteLine("Nothing after parenthesis");
            }
            else
            {
                //Throw a Error
                value = NumExpressionFactory.Constante(0);
            }

            return value;
        }
        #endregion

        #region weight and initialBlock
        // toReturn[0] is weight, toReturn[1] is draw block
        public static int[] CumputeWeightAndInitialeBlock(string message)
        {
            message = message.Replace(" ", "").Replace(")", "");

            int[] toReturn = new int[] { 0, 0 };
            string[] part;
            part = message.Split('(');

            if (part.Length > 1)
            {
                if (part[0].Equals("inf"))
                {
                    toReturn[0] = -1;
                }
                else if (part[0].Equals("/"))
                {
                    toReturn[0] = -2;
                }
                else
                {
                    toReturn[0] = Convert.ToInt32(part[0].Replace(" ", ""));
                }

                toReturn[1] = Convert.ToInt32(part[1]);
            }
            else
            {
                if (message.Equals("inf"))
                {
                    toReturn[0] = -1;
                }
                else if (message.Equals("/"))
                {
                    toReturn[0] = -2;
                }
                else
                {
                    toReturn[0] = Convert.ToInt32(message.Replace(" ", ""));
                }
            }


            return toReturn;
        }
        #endregion

        #region get text with labels
        public static string ReturnTextFromLabels(string text, List<string> labels)
        {
            string result = "";

            int index = 0, bracketPos;
            string[] parts = text.Split(' ');

            // IF { next to label or { alone
            while (index < text.Length)
            {
                bracketPos = text.IndexOf('{', index);

                if (bracketPos == -1)
                {
                    result += text.Substring(index, text.Length - index);
                    index = text.Length;
                }
                else
                {
                    int endBefore = 0;
                    if (labels.Contains(GetWordBefore(text, bracketPos - 1, out endBefore)))
                    {
                        if (endBefore > index)
                            result += text.Substring(index, (endBefore - 1) - index);

                        index = ComputeIndexAfterOpenBraket(text, bracketPos);

                        result += text.Substring(index, (text.IndexOf("}", bracketPos)) - index - 1);
                    }
                    else
                    {
                        if (endBefore > index)
                            result += text.Substring(index, (endBefore - 1) - index);
                    }

                    index = text.IndexOf("}", bracketPos) + 2;
                }

                ++index;
            }

            if (IsEmptyProperty(result)) return "";

            return result;
        }

        private static int ComputeIndexAfterOpenBraket(string text, int bracketPos)
        {
            if (bracketPos + 1 >= text.Length)
            {
                return bracketPos;
            }
            else if (text[bracketPos + 1] == '\r' || text[bracketPos + 1] == '\n')
            {
                return bracketPos + 2;
            }
            else
            {
                return bracketPos + 1;
            }
        }

        private static string GetWordBefore(string text, int endIndex, out int begin)
        {
            bool end = false;

            // Potential space between { and word
            while (endIndex >= 0 && !end)
            {
                if (SpaceLikeCharacter(text[endIndex]))
                {
                    --endIndex;
                }
                else
                {
                    end = true;
                }
            }

            begin = endIndex;
            end = false;

            while (begin >= 1 && !end)
            {
                if (SpaceLikeCharacter(text[begin]))
                {
                    end = true;
                    ++begin;
                }
                else
                {
                    --begin;
                }
            }

            if (begin <= -1) begin = 0;


            return text.Substring(begin, endIndex - (begin - 1));
        }

        #endregion

        #region create effect action list
        public static EffectActionList CreateActionList(Card card, string content, Dictionary<string, int> parameters)
        {
            EffectActionList EAL = new EffectActionList();
            CreateNewEffectReader(content);

            while (Etoken.Type != EETokenType.End)
            {

                if (Etoken.Type == EETokenType.Action)
                {
                    ParseAction(EAL, card);
                }
                else if (Etoken.Type == EETokenType.Word)
                {
                    string assign = "";
                    string arg = "";
                    string parameter = Etoken.String;

                    Etoken = Ereader.Get();

                    EEffectAction action = EEffectAction.Computation;

                    if (Etoken.Type == EETokenType.Assignement)
                    {
                        assign = Etoken.String;
                        Etoken = Ereader.Get();

                        while (Etoken.Type != EETokenType.EndOneEffect)
                        {
                            arg += " " + Etoken.String;

                            Etoken = Ereader.Get();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Missing Assignements symbol on card " + card.Properties["Id"].Value);
                    }


                    EAL.AddCouple(action, parameter, assign, arg, "");
                }

                Etoken = Ereader.Get();
            }

            return EAL;
        }

        public static void ParseAction(EffectActionList EAL, Card card)
        {
            EEffectAction action;
            string arg1, arg2, arg3, arg4;

            switch (Etoken.String)
            {
                // go Emode id (instance)
                case "go":
                    action = EEffectAction.Go;
                    Etoken = Ereader.Get();
                    arg1 = Etoken.String;
                    Etoken = Ereader.Get();
                    arg2 = Etoken.String;
                    Etoken = Ereader.Get();
                    if (Etoken.Type != EETokenType.EndOneEffect)
                    {
                        arg3 = Etoken.String;
                        Etoken = Ereader.Get();
                        Console.WriteLine(Etoken.String);
                    }
                    else arg3 = "0";

                    arg4 = "";
                    break;

                // add (new) (id)
                case "add":
                    action = EEffectAction.Add;
                    arg1 = reader.Get().String;

                    Etoken = Ereader.Get();
                    if (arg1.Equals("new"))
                    {
                        if (Etoken.Type != EETokenType.EndOneEffect)
                        {
                            arg2 = Etoken.String;
                            Etoken = Ereader.Get();
                        }
                        else arg2 = card.Properties["Id"].Value;
                    }
                    else arg2 = "";

                    arg3 = "";
                    arg4 = "";
                    break;

                // block (id) (instance) roundNumber
                case "block":
                    action = EEffectAction.Block;
                    Etoken = Ereader.Get();
                    string value;

                    if (Etoken.Type == EETokenType.Value)
                    {
                        arg1 = card.Properties["Id"].Value;
                        value = Etoken.String;
                        Etoken = Ereader.Get();
                    }
                    else
                    {
                        arg1 = Etoken.String;
                        Etoken = Ereader.Get();
                        value = Etoken.String;
                    }


                    if (Etoken.Type == EETokenType.Value)
                    {
                        arg2 = value;
                        arg3 = Etoken.String;
                        Etoken = Ereader.Get();
                    }
                    else
                    {
                        arg2 = "0";
                        arg3 = value;
                    }

                    arg4 = "";
                    break;

                //  remove (id)
                case "remove":
                    action = EEffectAction.Remove;

                    arg1 = reader.Get().String;
                    Etoken = Ereader.Get();
                    if (Etoken.Type != EETokenType.EndOneEffect)
                    {
                        arg2 = Etoken.String;
                        Etoken = Ereader.Get();
                    }
                    else arg2 = card.Properties["Id"].Value;

                    arg3 = "";
                    arg4 = "";
                    break;

                //  release id
                case "release":
                    action = EEffectAction.Release;
                    arg1 = reader.Get().String;

                    Etoken = Ereader.Get();
                    arg2 = "";
                    arg3 = "";
                    arg4 = "";
                    break;
                default:
                    action = EEffectAction.Invalid;
                    arg1 = "";
                    arg2 = "";
                    arg3 = "";
                    arg4 = "";
                    break;
            }

            EAL.AddCouple(action, arg1, arg2, arg3, arg4);
            Etoken = Ereader.Get();
        }
        #endregion

        #region general checks
        public static bool IsEmptyProperty(string property)
        {
            if (property.Equals("")) return true;
            if (property.Equals(" ")) return true;

            for (int i = 0; i < property.Length; ++i)
            {
                if (!SpaceLikeCharacter(property[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool SpaceLikeCharacter(char ch)
        {
            return ch == ' ' || ch == '\n' || ch == '\t' || ch == '\r';
        }
        #endregion

        public static void CreateNewEffectReader(string line)
        {
            Ereader = new EffectTokenizer(line);
            Etoken = Ereader.Get();
        }

        public static void CreateNewReader(string line)
        {
            reader = new ConditionTokenizer(line);

            /*do
            {
                lct = reader.Get();
                Console.Write(lct.Type + " ");
            } while (lct.Type != ELCTokenType.End);
            Console.WriteLine("");

            reader = new LabelConditionTokenizer(line);*/
            lct = reader.Get();
        }
    }
}
