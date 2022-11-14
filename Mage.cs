using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Mage : RangedUnit
    {
        public Mage()
        {
            this.Damage = 10;
            this.Hp = 5;
            this._Race = Race.Human;
        }
    }
}
