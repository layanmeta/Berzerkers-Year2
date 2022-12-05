﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    abstract class RangedUnit : Unit
    {
        public virtual float Range { get; protected set; }

        public override void Attack(Unit defender)
        {
            int rollToHit = HitChance.RandomRangedGenerator();
            int enemyDefendRoll = DefenceRating.RandomRangedGenerator();
            if (rollToHit >= enemyDefendRoll)
            {
                defender.TakeDamage(Damage.RandomRangedGenerator() -1);
            }
        }

        public override void Defend(Unit attacker)
        {
            int rollToHit = HitChance.RandomRangedGenerator();
            int enemyDefendRoll = DefenceRating.RandomRangedGenerator();
            if (rollToHit >= enemyDefendRoll)
            {
                attacker.TakeDamage(Damage.RandomRangedGenerator() + 1);
            }
        }
    }
}
