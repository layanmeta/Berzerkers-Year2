using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Archer : RangedUnit
    {
        public Archer()
        {
            this.Damage = new Dice(3,20,1);
            this.HitChance = new Dice(1, 8, 2);
            this.DefenceRating = new Dice(1, 6, 1);
            this.LootCapacity = 4;
            this.Resources = 2;
            this.Hp = 10;
            this.Race = Race.Elf;
        }
    }
}
