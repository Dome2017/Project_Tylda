using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class CombatSystem
    {
        static Random random = new Random();
        public static void BattleStart(Character player, Character enemy)
        {
            Character playerBaseStats = new Character(player);
            Character enemyBaseStats = new Character(enemy);


            while (player.Hp > 0 && enemy.Hp > 0)
            {
                Console.Clear();
                CombatDisplay.ShowState(player, enemy);
                CombatDisplay.ShowActionMenu();
                CombatActionHandler.ExecutePlayerAction(player, enemy);
                CombatActionHandler.ResetDefense(enemyBaseStats, enemy);
                if (enemy.Hp > 0)
                {
                    Console.WriteLine("***");
                    CombatActionHandler.ExecuteEnemyAction(player, enemy);
                }
                CombatActionHandler.ResetDefense(playerBaseStats, player);
                Common.WaitForUserAction();
            }
            CombatDisplay.ShowBattleResult(player, enemy);
        }
    }
}
