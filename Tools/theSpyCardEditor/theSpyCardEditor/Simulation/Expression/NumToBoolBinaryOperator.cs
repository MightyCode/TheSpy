using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class NumToBoolBinaryOperator : BoolExpression
    {
        private readonly NumExpression expressionLeft;
        private readonly NumExpression expressionRight;

        private readonly string ope;

        public NumToBoolBinaryOperator(NumExpression expressionLeft, string ope, NumExpression expressionRight)
        {
            this.expressionLeft = expressionLeft;
            this.expressionRight = expressionRight;
            this.ope = ope;
        }

        public bool Value(Dictionary<string, int> parameters)
        {
            switch (ope)
            {
                case ">":
                    return expressionLeft.Value(parameters) > expressionRight.Value(parameters);
                case ">=":
                    return expressionLeft.Value(parameters) >= expressionRight.Value(parameters);
                case "<":
                    return expressionLeft.Value(parameters) < expressionRight.Value(parameters);
                case "<=":
                    return expressionLeft.Value(parameters) <= expressionRight.Value(parameters);
                case "==":
                    Console.WriteLine(expressionLeft.Value(parameters) + " " + expressionRight.Value(parameters));
                    return expressionLeft.Value(parameters) == expressionRight.Value(parameters);
                case "!=":
                    return expressionLeft.Value(parameters) != expressionRight.Value(parameters);
            }

            return false;
        }
    }
}
