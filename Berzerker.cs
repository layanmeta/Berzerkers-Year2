using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Berzerker : RangedUnit
    {
        public Berzerker()
        {
            this.Damage = 5;
            this.Hp = 13;
            this._Race = Race.Orc;
        }
    }
}
