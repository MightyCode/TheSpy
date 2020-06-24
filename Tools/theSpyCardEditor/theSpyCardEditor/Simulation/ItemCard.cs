using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class ItemCard
    {
        public readonly Item Item;
        public readonly Card Card;

        public ItemCard(Item item, Card card)
        {
            Item = item;
            Card = card;
        }
    }
}
