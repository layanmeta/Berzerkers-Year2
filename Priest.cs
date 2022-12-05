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
            this.Damage = new Dice(1,4,3);
            this.HitChance = new Dice(1, 12, 1);
            this.DefenceRating = new Dice(2, 8, 1);
            this.LootCapacity = 2;
            this.Resources = 2;
            this.Hp = 20;
            this.Race = Race.Human;
        }

        //50% chance to heal once being attacked
        public override void Defend(Unit attacker)
        {
            int rollToHit = HitChance.RandomRangedGeneration();
            int enemyDefendRoll = DefenceRating.RandomRangedGeneration();
            if (rollToHit >= enemyDefendRoll)
            {
                Random rnd = new Random();
                int healChance = rnd.Next(0, 100);
                if (healChance >= 50)
                {
                    attacker.TakeDamage(Damage.RandomRangedGeneration());
                    Hp += 5;
                }
                else
                {
                    attacker.TakeDamage(Damage.RandomRangedGeneration());
                }
            }
        }
    }
}
