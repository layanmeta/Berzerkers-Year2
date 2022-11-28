using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    internal class AddingUnits
    {
        public void PrintBattle()
        {
            //Declare and create 2 armies 
            Archer elf1 = new Archer();
            Droid elf2 = new Droid();
            Shaman elf3 = new Shaman();
            Berzerker orc1 = new Berzerker();
            Giant orc2 = new Giant();
            Warrior orc3 = new Warrior();
            Knight human1 = new Knight();
            Mage human2 = new Mage();
            Priest human3 = new Priest();

            List<Unit> elfArmy = new List<Unit>();
            List<Unit> orcArmy = new List<Unit>();
            List<Unit> humanArmy = new List<Unit>();

            elfArmy.Add(elf1);
            elfArmy.Add(elf2);
            elfArmy.Add(elf3);

            orcArmy.Add(orc1);
            orcArmy.Add(orc2);
            orcArmy.Add(orc3);

            humanArmy.Add(human1);
            humanArmy.Add(human2);
            humanArmy.Add(human3);

            //Armies need to fight each other
            Console.WriteLine("attacker army: ");
            elfArmy.ForEach(x => Console.WriteLine(x));


            Console.WriteLine("defender army: ");
            orcArmy.ForEach(x => Console.WriteLine(x));

            Battle battle = new();
            List<Unit> winnerArmy = battle.ArmyBattle(elfArmy, humanArmy);

            //Declare Winner
            winnerArmy.ForEach(x => Console.WriteLine(x));
        }
    }
}
