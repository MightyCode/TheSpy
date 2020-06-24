using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    interface NumExpression
    {
        int Value(Dictionary<string, int> parameters);
    }

    abstract class NumExpressionFactory
    {
        // "factories" to build expressions

        public static NumExpression Constante(int valeur)
        {
            return new NumExprConstante(valeur);
        }

        public static NumExpression Parameters(string parameter)
        {
            return new NumExprParameter(parameter);
        }

        public static NumToNumBinaryOperator BinaryOperation(NumExpression left, string ope, NumExpression right)
        {
            return new NumToNumBinaryOperator(left, ope, right);
        }
    }
}
