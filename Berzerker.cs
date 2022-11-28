using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Berzerker : RangedUnit
    {
        public Berzerker()
        {
            this.Damage = new Dice(1, 14, -1);
            this.HitChance = new Dice(1, 20, 1);
            this.DefenceRating = new Dice(2, 8, 1);
            this.LootCapacity = 2;
            this.Resources = 1;
            this.Hp = 13;
            this.Race = Race.Orc;
        }
    }
}
