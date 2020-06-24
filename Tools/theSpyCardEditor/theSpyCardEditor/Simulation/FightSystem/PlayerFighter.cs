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

        public PlayerFighter(PlayerInventory PI) : base()
        {
            this.PI = PI;
        }

        public override string WitchAction()
        {
            return CurrentAction;
        }

        public override string Action(string action)
        {
            return "";
        }
    }
}
