using Project_Tylda.views.gameViews.enemyChose;
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
            CharacterCreator.CharacterChose();
            enemiesToChose.ChoseEnemy();
        }
    }
}
