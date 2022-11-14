using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Warrior : MeleeUnit
    {
        public Warrior()
        {
            this.Damage = 6;
            this.Hp = 15;
            this._Race = Race.Orc;
        }
    }
}
