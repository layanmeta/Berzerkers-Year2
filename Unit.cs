using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    abstract class Unit
    {
        public virtual int Damage { get; protected set; } 
        public virtual int Hp { get; set; }
        public virtual Race _Race { get; set; }

        public virtual void TakeDamage(int dmg)
        {
            Hp -= dmg;
        }
        public virtual void Attack(Unit defender)
        {
            defender.TakeDamage(this.Damage);
        }
        public virtual void Defend(Unit attacker)
        {
            attacker.TakeDamage(this.Damage);
        }
    }
    public enum Race
    {
        Elf,
        Orc,
        Human,
    }
}
