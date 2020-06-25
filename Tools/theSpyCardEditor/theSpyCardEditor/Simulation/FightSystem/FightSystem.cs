using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class FightSystem
    {
        public Fighter Player;
        public Fighter AI;

        public Fighter Winner { get; set; } = null;

        public FightSystem(Dictionary<string, int> parameters, PlayerInventory PI, string enemy)
        {
            Player = new PlayerFighter(this, PI);
            AI = EnemyFighterFactory.GetEnemy(enemy);

            Player.BeginFight();
            AI.BeginFight();
        }

        public void DoTurn()
        {
            Player.InitTurn();
            AI.InitTurn();

            Player.StartTurn();
            AI.StartTurn();

            string action1 = Player.WhichAction();
            string action2 = AI.WhichAction();

            if (Player.FightParameters["turnSpeed"] >= AI.FightParameters["turnSpeed"])
            {
                Player.InAction(action1);
                if (AI.FightParameters["turnLife"])
            } else
            {

            }

            Player.EndTurn();
            AI.InitTurn();
        }
    }
}
