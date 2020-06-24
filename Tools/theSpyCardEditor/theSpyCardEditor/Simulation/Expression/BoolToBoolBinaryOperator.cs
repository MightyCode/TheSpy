using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class BoolToBoolBinaryOperator : BoolExpression
    {
        private readonly BoolExpression expressionLeft;
        private readonly BoolExpression expressionRight;

        private readonly string ope;

        public BoolToBoolBinaryOperator(BoolExpression expressionLeft, string ope, BoolExpression expressionRight)
        {
            this.expressionLeft = expressionLeft;
            this.expressionRight = expressionRight;
            this.ope = ope;
        }

        public bool Value(Dictionary<string, int> parameters)
        {
            switch (ope)
            {
                case "&&":
                    return expressionLeft.Value(parameters) && expressionRight.Value(parameters);
                case "||":
                    return expressionLeft.Value(parameters) || expressionRight.Value(parameters);
                case "!":
                    return !expressionLeft.Value(parameters);
            }

            return false;
        }
    }
}
