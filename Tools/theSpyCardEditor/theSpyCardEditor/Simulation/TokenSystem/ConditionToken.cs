using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    public enum ECTokenType
    {
        If, 
        Else,
        OpenParenthesis,
        CloseParenthesis,
        OpenBacket,
        CloseBraket,
        BoolToBoolOperator,
        NumToBoolOperator,
        NumToNumOperator,
        InvertOperator,
        Word,
        Value,
        End,
        Incorrect,
    }

    class ConditionToken
    {
        public ECTokenType Type { get; }
        public string String { get; }

        public ConditionToken(ECTokenType type, string str)
        {
            this.Type = type;
            this.String = str;
        }

        public override string ToString()
        {
            return String;
        }

        public bool IsOperator(string op)
        {
            if (Type == ECTokenType.NumToBoolOperator ||
                Type == ECTokenType.NumToNumOperator ||
                Type == ECTokenType.BoolToBoolOperator)
            {
                return String.Equals(op);
            } else
            {
                return false;
            }
        }

        public int Value => Convert.ToInt32(String);
    }
}
