using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Warrior : MeleeUnit
    {
        public Warrior()
        {
            this.Damage = new Dice(2,20,5);
            this.HitChance = new Dice(1, 20, 1);
            this.DefenceRating = new Dice(2, 12, 1);
            this.LootCapacity = 4;
            this.Resources = 1;
            this.Hp = 15;
            this.Race = Race.Orc;
        }
    }
}
