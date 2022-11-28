using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    abstract class MeleeUnit : Unit
    {
        public override void Attack(Unit defender)
        {
            int rollToHit = HitChance.Roll();
            int enemyDefendRoll = DefenceRating.Roll();
            if (rollToHit >= enemyDefendRoll)
            {
                defender.TakeDamage(Damage.Roll() +2);
            }
        }

        public override void Defend(Unit attacker)
        {
            int rollToHit = HitChance.Roll();
            int enemyDefendRoll = DefenceRating.Roll();
            if (rollToHit >= enemyDefendRoll)
            {
                attacker.TakeDamage(Damage.Roll() - 1);
            }
        }
    }
}
