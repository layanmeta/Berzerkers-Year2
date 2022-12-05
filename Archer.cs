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
            this.Damage = new Bag(15); ;
            this.HitChance = new Bag(5);
            this.DefenceRating = new Bag(10);
            this.LootCapacity = 4;
            this.Resources = 2;
            this.Hp = 10;
            this.Race = Race.Elf;
        }
    }
}
