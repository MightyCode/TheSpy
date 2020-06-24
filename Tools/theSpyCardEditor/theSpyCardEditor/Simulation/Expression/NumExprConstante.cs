using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class NumExprConstante : NumExpression
    {
        private readonly int value;

        public NumExprConstante(int value)
        {
            this.value = value;
        }

        public int Value(Dictionary<string, int> parameters)
        {
            return value;
        }
    }
}
