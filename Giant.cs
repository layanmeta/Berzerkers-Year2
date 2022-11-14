using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Giant : MeleeUnit
    {
        public Giant()
        {
            this.Damage = 2;
            this.Hp = 20;
            this._Race = Race.Orc;
        }

        //takes half damage as tank
        public override  void Defend(Unit attacker)
        {
            attacker.TakeDamage(this.Damage/2);
        }
    }
}
