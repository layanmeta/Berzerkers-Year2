using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    abstract class Unit
    {
        public virtual IRandomProvider Damage { get; protected set; }
        public virtual int Hp { get; protected set; }
        public virtual Race Race { get; protected set; }
        public virtual WeatherEffects Weather { get; protected set; }
        public virtual int LootCapacity { get; protected set; }
        public virtual int Resources { get; protected set; }

        protected IRandomProvider HitChance = new Dice();
        protected IRandomProvider DefenceRating = new Dice();

        public virtual void TakeDamage(int dmg)
        {
            Hp -= dmg;
        }

        public virtual void Attack(Unit defender)
        {
            int rollToHit = HitChance.RandomRangedGenerator();
            int enemyDefendRoll = defender.DefenceRating.RandomRangedGenerator();
            if (rollToHit >= enemyDefendRoll)
            {
                defender.TakeDamage(Damage.RandomRangedGenerator());
            }
        }

        public virtual void Defend(Unit attacker)
        {
            int rollToHit = HitChance.RandomRangedGenerator();
            int enemyDefendRoll = attacker.DefenceRating.RandomRangedGenerator();
            if (rollToHit >= enemyDefendRoll)
            {
                attacker.TakeDamage(Damage.RandomRangedGenerator());
            }
        }

        public void WeatherEffect(WeatherEffects weather)
        {

        }

    }

    struct Dice : IRandomProvider
    {
        public uint Scalar { get; set; }
        public uint BaseDie { get; set; }
        public int Modifier { get; set; }

        public Dice(uint x, uint y, int z)
        {
            this.Scalar = x;
            this.BaseDie = y;
            this.Modifier = z;
        }

        public int Roll()
        {
            int result = 0;
            Random rnd = new Random();
            for (int i = 0; i < Scalar; i++)
            {
                result += rnd.Next(1, (int)BaseDie + 1);
            }
            result += Modifier;
            return result;
        }

        public int RandomRangedGenerator()
        {
            return Roll();
        }

        public override string ToString()
        {
            return $"Dice({Scalar}d,{BaseDie},{Modifier})";
        }

        public override bool Equals(object? obj)
        {
            Dice d = (Dice)obj;
            return Scalar == d.Scalar && BaseDie == d.BaseDie && Modifier == d.Modifier;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    struct Bag : IRandomProvider
    {
        public List<int> startingList;
        public List<int> backupList;

        public Bag(int top)
        {
            startingList = new List<int>();
            for (int i = 0; i < top; i++)
            {
                startingList.Add(i);
            }
            backupList = new List<int>();
        }

        int ChooseNum()
        {
            int result = Random.Shared.Next(0, startingList.Count);
            int chosenNum = startingList[result];

            backupList.Add(chosenNum);
            startingList.Remove(result);

            if (startingList.Count <= 0)
            {
                Shuffle();
            }
            return chosenNum;
        }

        public int RandomRangedGenerator()
        {
            return ChooseNum();
        }

        public void Shuffle()
        {
            startingList = backupList;
            backupList.Clear();
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
