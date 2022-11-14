using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Shaman : MeleeUnit
    {
        public Shaman()
        {
            this.Damage = 4;
            this.Hp = 20;
            this._Race = Race.Elf;
        }
    }
}
