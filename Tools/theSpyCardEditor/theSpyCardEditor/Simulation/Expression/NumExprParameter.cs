using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class NumExprParameter : NumExpression
    {
        private readonly string parameter;

        public NumExprParameter(string parameter)
        {
            this.parameter = parameter;
        }

        public int Value(Dictionary<string, int> parameters)
        {
            return parameters[parameter];
        }
    }
}
