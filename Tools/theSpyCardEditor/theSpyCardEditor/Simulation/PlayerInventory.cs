using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class PlayerInventory
    {
        public const string EMPLACEMENT_WEAPON1 = "weapon1";
        public const string EMPLACEMENT_WEAPON2 = "weapon2";
        public const string EMPLACEMENT_WEAPON3 = "weapon3";
        public const string EMPLACEMENT_DEFENCE = "defence";
        public const string EMPLACEMENT_EQUIPMENT = "equipment";
        public const string EMPLACEMENT_BONUS1 = "bonus1";
        public const string EMPLACEMENT_BONUS2 = "bonus2";

        Dictionary<string, ItemCard> items;

        public EItemClass GlobalItemClass { get; private set; }
        public EItemClass GlobalEquipedItemClass { get; private set; }

        public PlayerInventory() : base()
        {
            items = new Dictionary<string, ItemCard>()
            {
                { EMPLACEMENT_WEAPON1, null },
                { EMPLACEMENT_WEAPON2, null },
                { EMPLACEMENT_WEAPON3, null },
                { EMPLACEMENT_DEFENCE, null },
                { EMPLACEMENT_EQUIPMENT, null },
                { EMPLACEMENT_BONUS1, null },
                { EMPLACEMENT_BONUS2, null }
            };

            GlobalEquipedItemClass = EItemClass.Null;
            GlobalItemClass = EItemClass.Null;
        }

        public void SetItem(string locationName, Card card)
        {
            Item newItem = ItemFactory.GetItem(card.Properties["Id"].Value);

            if (newItem != null)
            {
                items[locationName] = new ItemCard(newItem, card);
                CheckTypeStatus();
            }
        }

        public ItemCard GetItem(string locationName) => items[locationName];

        private void CheckTypeStatus()
        {
            // Todo
            bool nullMet = false;
            bool firstMet = false;
            EItemClass type = EItemClass.Null;

            foreach (string key in items.Keys)
            {
                nullMet = nullMet || (items[key].Item.ItemClass == EItemClass.Null);

                if (firstMet)
                {
                    if (!ItemFactory.SameArchtype(type, items[key].Item.ItemClass))
                    {
                        type = EItemClass.Null;
                        break;
                    }
                } else
                {
                    if (items[key].Item.ItemClass != EItemClass.Null)
                    {
                        type = items[key].Item.ItemClass;
                        firstMet = true;
                    }
                }
            }

            GlobalEquipedItemClass = type;
            GlobalItemClass = (nullMet) ? EItemClass.Null : type;
        }
    }
}
