using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Droid : RangedUnit
    {
        private bool firstHit = true;
        public Droid()
        {
            this.Damage = 4;
            this.Hp = 20;
            this._Race = Race.Elf;
        }

        //does double damage on first attack only
        public override void Attack(Unit defender)
        {
            if (firstHit == true)
            {
                defender.TakeDamage(this.Damage * 2);
                firstHit = false;
            }
            else
            {
                defender.TakeDamage(this.Damage);
            }
        }
    }
}
