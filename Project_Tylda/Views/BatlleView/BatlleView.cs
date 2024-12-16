using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class BatlleView
    {
        /*CharacterCreator.ShowPlayerCharacterParameters(CharacterCreator.playerCharacter);*/
        public static void ActionMenu()
        {
            Console.WriteLine("===Walka===\n\n");
            Console.WriteLine($"{PlayerCharacterCreator.playerCharacter.Name} = {PlayerCharacterCreator.playerCharacter.Hp}  |====|  {EnemiesCreator.enemyCharacter.Name} = {EnemiesCreator.enemyCharacter.Hp}");
        }
    }
    
}
