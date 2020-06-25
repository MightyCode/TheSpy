using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class PlayerFighter : Fighter
    {
        public string CurrentAction { get; set; } = ACTION_NOTHING;

        PlayerInventory PI;

        public PlayerFighter(FightSystem FS, PlayerInventory PI) : base(FS)
        {
            this.PI = PI;
        }

        public override string WhichAction()
        {
            return CurrentAction;
        }

        public override void BeginFight()
        {
           foreach(KeyValuePair<string, ItemCard> pair in PI.AllItems())
           {
                if (pair.Value.Item.HasPassif)
                {

                }
           }
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
