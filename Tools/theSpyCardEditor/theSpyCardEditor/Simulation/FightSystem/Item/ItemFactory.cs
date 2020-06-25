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

        // RETODO, degeulasse puisque charge trop de classe -> faire un switch

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

        public static bool IfScientificItem(Item item) =>  IfScientificItem(item.ItemClass);
        public static bool IfScientificItem(EItemClass itemClass) => itemClass == EItemClass.Science;

        public static bool IfMagicItem(Item item) => IfMagicItem(item.ItemClass);

        public static bool IfMagicItem(EItemClass itemClass) => itemClass == EItemClass.Support || itemClass == EItemClass.Spell;

        public static bool SameArchtype(Item item1, Item item2)
        {
            return SameArchtype(item1.ItemClass, item2.ItemClass);
        }

        public static bool SameArchtype(EItemClass class1, EItemClass class2)
        {
            if (class1 == EItemClass.Null)  return (class2 == EItemClass.Null);
            if (IfMagicItem(class1))        return (IfMagicItem(class2));
            if (IfScientificItem(class1))   return (IfScientificItem(class2));
        }
    }
}
