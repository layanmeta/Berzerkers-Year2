using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Priest : RangedUnit
    {
        public Priest()
        {
            this.Damage = 4;
            this.Hp = 20;
            this._Race = Race.Human;
        }

        //50% chance to heal once being attacked
        public override void Defend(Unit attacker)
        {
            Random rnd = new Random();
            int healChance = rnd.Next(0, 100);
            if (healChance >= 50)
            {
                attacker.TakeDamage(this.Damage);
                Hp += 5;
            }
            else
            {
                attacker.TakeDamage(this.Damage);
            }
        }
    }
}
