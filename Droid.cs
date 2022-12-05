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
            this.Damage = new Dice(2,8,1);
            this.HitChance = new Dice(1, 12, 1);
            this.DefenceRating = new Dice(1, 10, 1);
            this.LootCapacity = 6;
            this.Resources = 1;
            this.Hp = 20;
            this.Race = Race.Elf;
        }

        //does double damage on first attack only
        public override void Attack(Unit defender)
        {
            int rollToHit = HitChance.RandomRangedGeneration();
            int enemyDefendRoll = DefenceRating.RandomRangedGeneration();
            if (rollToHit >= enemyDefendRoll)
            {
                if (firstHit == true)
                {
                    defender.TakeDamage(Damage.RandomRangedGeneration() * 2);
                    firstHit = false;
                }
                else
                {
                    defender.TakeDamage(Damage.RandomRangedGeneration());
                }
            }
        }
    }
}
