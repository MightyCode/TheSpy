using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor{
    interface BoolExpression
    {
        bool Value(Dictionary<string, int> parameters);
    }
    abstract class BoolExpressionFactory
    {
        public static BoolToBoolBinaryOperator BinaryOperation(BoolExpression left, string ope, BoolExpression right)
        {
            return new BoolToBoolBinaryOperator(left, ope, right);
        }

        public static NumToBoolBinaryOperator NumBinaryComparation(NumExpression left, string ope, NumExpression right)
        {
            return new NumToBoolBinaryOperator(left, ope, right);
        }
    }
}
