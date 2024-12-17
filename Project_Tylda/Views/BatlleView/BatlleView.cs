using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class BatlleView
    {
        public static void ActionMenu()
        {
            Console.WriteLine($"Rozpoczyna się walka międzi {PlayerCharacterCreator.playerCharacter.Name} a {EnemiesCreator.enemyCharacter.Name}\n\n");
            Console.Write($"|  {PlayerCharacterCreator.playerCharacter.Name} = {PlayerCharacterCreator.playerCharacter.Hp}");
            Console.Write("  |====|  ");
            Console.Write($"{EnemiesCreator.enemyCharacter.Name} = {EnemiesCreator.enemyCharacter.Hp}  |\n\n");
            CombatMenu.CombatActions();
        }
    }
    
}
