using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    internal class GameView
    {
        public static void StartGame()
        {
            Console.Clear();
            PlayerCharacterCreator.ChooseCharacter();
            Console.Clear();
            EnemiesCharacterCreator.ChooseEnemy();
            Console.Clear();
            BattleView.ActionMenu();
        }
    }
}
