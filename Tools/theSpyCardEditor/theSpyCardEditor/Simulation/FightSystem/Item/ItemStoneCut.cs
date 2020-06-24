using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class ItemStoneCut : Item
    {
        public ItemStoneCut() : base(false, true, EItemClass.Science, EItemType.Weapon) 
        { }

        public override void Action(Fighter enemy)
        {
            throw new NotImplementedException();
        }

        public override void BeginFight(Fighter enemy)
        {
            throw new NotImplementedException();
        }

        public override void BeginPassif(Fighter enemy)
        {
            throw new NotImplementedException();
        }

        public override void PassifEachTurn(Fighter enemy)
        {
            throw new NotImplementedException();
        }
    }
}
