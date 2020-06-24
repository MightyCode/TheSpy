using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class NumToNumBinaryOperator : NumExpression
    {
        private readonly NumExpression expressionLeft;
        private readonly NumExpression expressionRight;

        private readonly string ope;

        public NumToNumBinaryOperator(NumExpression expressionLeft, string ope, NumExpression expressionRight)
        {
            this.expressionLeft = expressionLeft;
            this.expressionRight = expressionRight;
            this.ope = ope;
        }

        public int Value(Dictionary<string, int> parameters)
        {
            switch (ope)
            {
                case "+":
                    return expressionLeft.Value(parameters) + expressionRight.Value(parameters);
                case "-":
                    return expressionLeft.Value(parameters) - expressionRight.Value(parameters);
                case "*":
                    return expressionLeft.Value(parameters) * expressionRight.Value(parameters);
                case "/":
                    return expressionLeft.Value(parameters) / expressionRight.Value(parameters);
                case "%":
                    return expressionLeft.Value(parameters) % expressionRight.Value(parameters);
            }

            return expressionLeft.Value(parameters);
        }
    }
}
