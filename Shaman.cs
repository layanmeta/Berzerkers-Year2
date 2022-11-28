using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    sealed class Shaman : MeleeUnit
    {
        public Shaman()
        {
            this.Damage = new Dice(1,20,3);
            this.HitChance = new Dice(1, 10, 3);
            this.DefenceRating = new Dice(2, 8, 1);
            this.LootCapacity = 1;
            this.Resources = 2;
            this.Hp = 15;
            this.Race = Race.Elf;
        }
    }
}
