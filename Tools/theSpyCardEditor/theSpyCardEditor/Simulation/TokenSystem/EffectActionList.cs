using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    enum EEffectAction
    {
        Go,
        Add,
        Remove,
        Release,
        Block,
        Computation,
        Invalid
    }

    class EffectActionList
    {
        List<EEffectAction> actions;
        List<string> args1;
        List<string> args2;
        List<string> args3;
        List<string> args4;

        int index = -1;

        public EffectActionList()
        {
            actions = new List<EEffectAction>();
            args1 = new List<string>();
            args2 = new List<string>();
            args3 = new List<string>();
            args4 = new List<string>();
        }

        public void AddCouple(EEffectAction action, string arg1, string arg2, string arg3, string arg4)
        {
            actions.Add(action);
            args1.Add(arg1);
            args2.Add(arg2);
            args3.Add(arg3);
            args4.Add(arg4);
        }

        public EEffectAction CurrentActions => actions[index];
        public string CurrentArg1 => args1[index];
        public string CurrentArg2 => args2[index];
        public string CurrentArg3 => args3[index];
        public string CurrentArg4 => args4[index];

        public bool Next()
        {
            ++index;
            return index < actions.Count;
        }
    }
}
