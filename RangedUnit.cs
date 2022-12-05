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
            int rollToHit = HitChance.RandomRangedGeneration();
            int enemyDefendRoll = DefenceRating.RandomRangedGeneration();
            if (rollToHit >= enemyDefendRoll)
            {
                defender.TakeDamage(Damage.RandomRangedGeneration() -1);
            }
        }

        public override void Defend(Unit attacker)
        {
            int rollToHit = HitChance.RandomRangedGeneration();
            int enemyDefendRoll = DefenceRating.RandomRangedGeneration();
            if (rollToHit >= enemyDefendRoll)
            {
                attacker.TakeDamage(Damage.RandomRangedGeneration() + 1);
            }
        }
    }
}
