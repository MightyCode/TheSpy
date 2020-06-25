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

        /*
            One turn attack, one turn nothing
        */ 

        public FighterTerniaAdvisor(FightSystem FS) : base(FS)
        {
            turn = false;

            Init();
        }

        public override void InitParameters()
        {
        }

        public override string WhichAction()
        {
            turn = !turn;
            return (turn) ? ACTION_ATTACK: ACTION_NOTHING;
        }

        public override void BeginFight()
        {
            
        }

        public override void StartTurn()
        {
            
        }

        public override void EndTurn()
        {
           
        }

        public override void InAction(string action)
        {
            
        }
    }
}
