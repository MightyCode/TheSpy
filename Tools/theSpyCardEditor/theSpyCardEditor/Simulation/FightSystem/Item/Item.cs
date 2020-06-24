using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    abstract class Item
    {
        public readonly bool HasActif, HasPassif;

        public Item(bool hasPassif, bool hasActif)
        {
            this.HasActif = hasActif;
            this.HasPassif = hasPassif;
        }

        public abstract string Name();

        public abstract string Description();

        public abstract void BeginPassif();

        public abstract void PassifEachTurn();
    }
}
