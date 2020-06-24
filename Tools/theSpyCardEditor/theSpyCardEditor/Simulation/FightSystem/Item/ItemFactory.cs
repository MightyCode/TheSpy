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
        private static Dictionary<String, Item> items = new Dictionary<string, Item>();
        public static Dictionary<string, Item>.KeyCollection Keys => items.Keys;

        public static void InitItems()
        {
            items = new Dictionary<string, Item>()
            {
                { "stoneCut",  new ItemStoneCut()}
            };
        }

        public static Item GetItem(string name)
        {
            if (items == null)
            {
                InitItems();
            }

            if (items.ContainsKey(name))
            {
                return items[name];
            }

            return null;
        }
    }
}
