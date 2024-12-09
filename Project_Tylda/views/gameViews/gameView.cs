using Project_Tylda.views.gameViews.enemyChose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    internal class gameView
    {
        public static void StartGame()
        {
            Console.Clear();
            characterCreator.CharacterChose();
            enemiesToChose.ChoseEnemy();
        }
    }
}
