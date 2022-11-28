using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Mage : RangedUnit
    {
        public Mage()
        {
            this.Damage = new Dice(2,20,3);
            this.HitChance = new Dice(3, 20, 3);
            this.DefenceRating = new Dice(1, 8, 1);
            this.LootCapacity = 1;
            this.Resources = 2;
            this.Hp = 5;
            this.Race = Race.Human;
        }
    }
}
