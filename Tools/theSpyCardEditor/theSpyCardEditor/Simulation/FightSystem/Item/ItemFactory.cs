using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    enum EItemType
    {
        Weapon, Defence, Equipement, Bonus, Null
    }

    enum EItemClass
    {
        Science, Spell, Support, Null
    }

    class ItemFactory
    {
        public static Dictionary<String, Item> Items = new Dictionary<string, Item>()
        {


        };
    }
}
