using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Archer : RangedUnit
    {
        public Archer(Race race)
        {
            this.Damage = 7;
            this.Hp = 10;
            this._Race = Race.Elf;
        }
    }
}
