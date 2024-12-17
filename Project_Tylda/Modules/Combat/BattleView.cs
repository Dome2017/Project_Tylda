using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class BattleView
    {
        public static void ActionMenu()
        {
            Console.Clear();
            Console.WriteLine($"Rozpoczyna się walka międzi {PlayerCharacterCreator.playerCharacter.Name} a {EnemiesCharacterCreator.enemyCharacter.Name}\n\n");
            Console.Write($"|  {PlayerCharacterCreator.playerCharacter.Name}: HP = {PlayerCharacterCreator.playerCharacter.Hp}");
            Console.Write("  |====|  ");
            Console.Write($"{EnemiesCharacterCreator.enemyCharacter.Name}: HP = {EnemiesCharacterCreator.enemyCharacter.Hp}  |\n\n");
            CombatMenu.CombatActions();
        }
    }
    
}
