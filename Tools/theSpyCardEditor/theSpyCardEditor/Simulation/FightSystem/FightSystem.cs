using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class FightSystem
    {
        Fighter player;
        Fighter ia;

        public FightSystem(Dictionary<string, int> parameters)
        {
            player = new Fighter(parameters.);
            ia = new Fighter();
        }
    }
}
