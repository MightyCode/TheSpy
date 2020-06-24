using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    public enum EETokenType
    {
        Action,
        Value,
        Word,
        Assignement,
        Symbol,
        Incorrect,
        EndOneEffect,
        End
    }

    class EffectToken
    {
        public EETokenType Type { get; }
        public string String { get; }

        public EffectToken(EETokenType type, string str)
        {
            this.Type = type;
            this.String = str;
        }

        public override string ToString()
        {
            return String;
        }

        public int Value => Convert.ToInt32(String);
    }
}
