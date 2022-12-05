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
            this.Damage = new Dice(1, 6, -2);
            this.HitChance = new Dice(1, 6, 1);
            this.DefenceRating = new Dice(3, 6, 2);
            this.LootCapacity = 3;
            this.Resources = 1;
            this.Hp = 20;
            this.Race = Race.Orc;
        }

        //takes half damage as tank
        public override void Defend(Unit attacker)
        {
            int rollToHit = HitChance.RandomRangedGeneration();
            int enemyDefendRoll = DefenceRating.RandomRangedGeneration();
            if (rollToHit >= enemyDefendRoll)
            {
                attacker.TakeDamage(Damage.RandomRangedGeneration() / 2);
            }
        }
    }
}