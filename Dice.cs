using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    internal class Dice
    {
        public uint Scalar { get; set; }
        public uint BaseDie { get; set; }
        public int Modifier { get; set; } 

        public Dice()
        {

        }

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
                result += rnd.Next(1, (int)BaseDie);
            }
            result += Modifier;
            return result;
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
}
