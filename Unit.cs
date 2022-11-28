using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    abstract class Unit
    {
        //Need to change int to Dice Damage
        public virtual Dice Damage { get; protected set; }
        public virtual int Hp { get; protected set; }
        public virtual Race Race { get; protected set; }
        public virtual WeatherEffects Weather { get; protected set; }
        public virtual int LootCapacity { get; protected set; }
        public virtual int Resources { get; protected set; }

        protected Dice HitChance = new Dice();
        protected Dice DefenceRating = new Dice();

        public virtual void TakeDamage(int dmg)
        {
            Hp -= dmg;
        }

        public virtual void Attack(Unit defender)
        {
            int rollToHit = HitChance.Roll();
            int enemyDefendRoll = defender.DefenceRating.Roll();
            if (rollToHit >= enemyDefendRoll)
            {
                defender.TakeDamage(Damage.Roll());
            }
        }

        public virtual void Defend(Unit attacker)
        {
            int rollToHit = HitChance.Roll();
            int enemyDefendRoll = attacker.DefenceRating.Roll();
            if (rollToHit >= enemyDefendRoll)
            {
                attacker.TakeDamage(Damage.Roll());
            }
        }

        public void WeatherEffect(WeatherEffects weather)
        {

        }
    }
    public enum Race
    {
        Elf,
        Orc,
        Human,
    }

    public enum WeatherEffects
    {
        rainy,
        windy,
    }
}
