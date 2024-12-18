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
            var player = PlayerCharacterCreator.CreatePlayerCharacter();
            var enemy = EnemiesCharacterCreator.ChooseEnemy();
            CombatSystem.BattleStart(player, enemy);
        }
    }
}
