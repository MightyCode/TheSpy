using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class PlayerStatus
    {
        Dictionary<string, Item> items;

        public EItemClass GlobalItemClass { get; private set; }
        public EItemClass GlobalEquipedItemClass { get; private set; }

        public int damageFight;
        public int speedFight;
        public int defenceFight;

        public int damageTemp;
        public int speedTemp;
        public int defenceTemp;

        public PlayerStatus()
        {
            items = new Dictionary<string, Item>()
            {
                { "weapon1", null },
                { "weapon2", null },
                { "weapon3", null },
                { "defence", null },
                { "equipement", null },
                { "bonus1", null },
                { "bonus2", null }
            };

            GlobalEquipedItemClass = EItemClass.Null;
            GlobalItemClass = EItemClass.Null;
        }

        public void SetItem(string locationName, string newItem)
        {
            if (ItemFactory.Items.ContainsKey(newItem))
            {
                items[locationName] = ItemFactory.Items[newItem];
            }

            CheckTypeStatus();
        }

        public Item GetItem(string locationName) => items[locationName];

        private void CheckTypeStatus()
        {
            bool first = false;
            EItemClass type = EItemClass.Null;

            foreach (string key in items.Keys)
            {
            }
        }
    }
}
