using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class GameProperties
    {
        public static Dictionary<string, int> BasicParameters = new Dictionary<string, int>()
        {
            { "money", 50 },
            { "population", 50 },
            { "cover", 50 },
            { "worship", 50 },
            { "life", 100 },
            { "rand", 0 },
            { "rand1", 0 },
            { "rand2", 0 },
            { "rand3", 0 },
            { "globalDamage", 0 },
            { "globalLife", 0 },
            { "globalSpeed", 0 },
            { "globalDefence", 0 },
        };
    }
}
