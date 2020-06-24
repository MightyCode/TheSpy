using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    abstract class Item
    {
        public bool HasPassif { get; private set; }
        public bool HasActif { get; private set; }

        public EItemClass ItemClass { get; private set; }
        public EItemType ItemType { get; private set; }


        public Item(bool hasPassif, bool hasActif, EItemClass itemClass, EItemType itemType)
        {
            this.HasPassif = hasPassif;
            this.HasActif = hasActif;

            this.ItemClass = itemClass;
            this.ItemType = itemType;
        }

        public abstract void BeginFight(Fighter enemy);

        public abstract void BeginPassif(Fighter enemy);

        public abstract void PassifEachTurn(Fighter enemy);

        public abstract void Action(Fighter enemy);
    }
}
