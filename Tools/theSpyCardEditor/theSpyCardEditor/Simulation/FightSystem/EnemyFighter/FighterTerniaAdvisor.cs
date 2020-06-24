using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class FighterTerniaAdvisor : EnemyFighter
    {
        bool turn;

        public FighterTerniaAdvisor() : base()
        {
            turn = false;

            Init();
        }

        public override void Init()
        {
            ((Fighter)this).Init();
        }

        public override string WitchAction()
        {
            turn = !turn;
            return (turn) ? ACTION_ATTACK: ACTION_NOTHING;
        }


        public override string Action(string action)
        {


            return "";
        }
    }
}
