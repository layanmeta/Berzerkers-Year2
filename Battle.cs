using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerkers
{
    internal class Battle
    {
        private int _result;
        private int _totalAttackerResources;
        private int _totalDefenderResources;
        public List<Unit> ArmyBattle(List<Unit> attackingArmy, List<Unit> defendingArmy)
        {
            while (attackingArmy.Count > 0 && defendingArmy.Count > 0)
            {
                Unit randomAttackingUnit = attackingArmy[Random.Shared.Next(0, attackingArmy.Count)];
                Unit randomDefendingUnit = defendingArmy[Random.Shared.Next(0, defendingArmy.Count)];

                _result = Random.Shared.Next(1, 3);
                if (_result == 1)
                {
                    Console.WriteLine($"{randomAttackingUnit} is attacking {randomDefendingUnit}!");
                    randomAttackingUnit.Attack(randomDefendingUnit);
                    Console.WriteLine($"{randomAttackingUnit}'s HP = {randomAttackingUnit.Hp}");
                    Console.WriteLine($"{randomDefendingUnit}'s HP = {randomDefendingUnit.Hp} \n");
                }
                else
                {
                    randomDefendingUnit.Defend(randomAttackingUnit);
                    Console.WriteLine($"{randomDefendingUnit} is defending from {randomAttackingUnit}!");
                    Console.WriteLine($"{randomAttackingUnit}'s HP = {randomAttackingUnit.Hp}");
                    Console.WriteLine($"{randomDefendingUnit}'s HP = {randomDefendingUnit.Hp} \n");
                }

                if (randomAttackingUnit.Hp <= 0)
                {
                    _totalDefenderResources += randomAttackingUnit.Resources;
                    attackingArmy.Remove(randomAttackingUnit);
                    Console.WriteLine($"{randomAttackingUnit} died and dropped {randomAttackingUnit.Resources} resources! \n");
                }

                if (randomDefendingUnit.Hp <= 0)
                {
                    _totalAttackerResources += randomDefendingUnit.Resources;
                    defendingArmy.Remove(randomDefendingUnit);
                    Console.WriteLine($"{randomDefendingUnit} died and dropped {randomDefendingUnit.Resources} resources! \n");
                }
            }

            List<Unit> winnerArmy;
            if (attackingArmy.Count > 0)
            {
                winnerArmy = attackingArmy;
                Console.WriteLine($"The attaking army won with {_totalAttackerResources} Resources with units left:");
            }
            else
            {
                winnerArmy = defendingArmy;
                Console.WriteLine($"The defending army won with {_totalDefenderResources} Resources with units left:");
            }
            return winnerArmy;
        }
    }
}
