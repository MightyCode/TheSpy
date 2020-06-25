using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    abstract class EnemyFighter : Fighter
    {
        public EnemyFighter(FightSystem FS) : base(FS) { }
        public abstract void InitParameters();
    }
}
