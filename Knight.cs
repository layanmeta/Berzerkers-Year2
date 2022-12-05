using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Knight : MeleeUnit
    {
        private readonly int _critMultiply = 3;
        public Knight()
        {
            this.Damage = new Dice(2,20,1);
            this.HitChance = new Dice(1, 10, 3);
            this.DefenceRating = new Dice(2, 6, 1);
            this.LootCapacity = 6;
            this.Resources = 1;
            this.Hp = 20;
            this.Race = Race.Human;
        }

        //50% chance to crit
        public override void Attack(Unit defender)
        {
            int rollToHit = HitChance.RandomRangedGenerator();
            int enemyDefendRoll = DefenceRating.RandomRangedGenerator();
            if (rollToHit >= enemyDefendRoll)
            {
                Random rnd = new Random();
                int critChance = rnd.Next(0, 100);
                if (critChance >= 50)
                {
                    defender.TakeDamage(Damage.RandomRangedGenerator() * _critMultiply);
                }
                else
                {
                    defender.TakeDamage(Damage.RandomRangedGenerator());
                }
            }
        }
    }
}
