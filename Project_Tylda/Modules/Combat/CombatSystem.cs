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
            Character playerBaseStats = player;
            Character enemyBaseStats = enemy;

            while (player.Hp > 0 && enemy.Hp > 0)
            {
                Console.Clear();
                CombatDisplay.ShowState(player, enemy);
                CombatDisplay.ShowActionMenu();
                CombatActionHandler.ExecutePlayerAction(player, enemy);
                /*if (enemy.Hp > 0)
                {
                    CombatActionHandler.ExecuteEnemyAction(player, enemy);
                }*/
                CombatActionHandler.ExecuteEnemyAction(player, enemy);
                CombatActionHandler.ResetDefence(playerBaseStats, player);
                Common.WaitForUserAction();
            }
            CombatDisplay.ShowBattleResult(player, enemy);
        }
    }
}
