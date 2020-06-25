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
        public override void BeginFight(Fighter enemy){}

        public override void BeginTurn(Fighter enemy){}

        public override void EndTurn(Fighter enemy){}

        public override void InAction(Fighter enemy){}
    }
}
