using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Knight : MeleeUnit
    {
        protected int critMultiply = 3;
        public Knight()
        {
            this.Damage = 4;
            this.Hp = 20;
            this._Race = Race.Human;
        }
        //50% chance to crit
        public override void Attack(Unit defender)
        {
            Random rnd = new Random();
            int critChance = rnd.Next(0, 100);
            if (critChance >= 50)
            {
                defender.TakeDamage(this.Damage * critMultiply);
            }
            else
            {
                defender.TakeDamage(this.Damage);
            }
        }

    }
}
