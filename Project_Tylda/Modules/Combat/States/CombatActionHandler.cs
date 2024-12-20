using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class CombatActionHandler
    {
        static Random random = new Random();
        public static bool ifPlayerDodgeSuccess = false;  
        public static bool ifEnemyDodgeSuccess = false;
        public static void ExecuteEnemyAction(Character player, Character enemy)
        {
            var enemyAction = random.Next(1, 6);
            switch (enemyAction)
            {
                case 1:
                    if (ifPlayerDodgeSuccess == false)
                    {
                        SwordCut.Execute(enemy, player);
                    }
                    else
                    {
                        Console.WriteLine($"- {enemy.Name} chybił atak");
                        ifPlayerDodgeSuccess = false;
                    }
                    break;
                case 2:
                    if (ifPlayerDodgeSuccess == true)
                    {
                        SpecialAttack.Execute(enemy, player);
                    }
                    else
                    {
                        Console.WriteLine($"- {enemy.Name} chybił atak");
                        ifPlayerDodgeSuccess = false;
                    }
                    break;
                case 3:
                    ifEnemyDodgeSuccess = DodgeAttack.Execute(enemy, player);
                    break;
                case 4:
                    DefensiveStance.Execute(enemy, player);
                    break;
                case 5:
                    HealthPotion.Execute(enemy, player);
                    break;
            }
        }
        public static void ExecutePlayerAction(Character player, Character enemy)
        {

            var playerAction = Console.ReadLine();
            Console.Clear();
            switch (playerAction)
            {
                case "1":
                    if (ifEnemyDodgeSuccess == false)
                    {
                        SwordCut.Execute(player, enemy);
                    }
                    else
                    {
                        Console.WriteLine($"- {player.Name} chybił atak");
                        ifEnemyDodgeSuccess = false;
                    }
                    break;
                case "2":
                    if (ifEnemyDodgeSuccess == true)
                    {
                        SpecialAttack.Execute(player, enemy);
                    }
                    else
                    {
                        Console.WriteLine($"- {player.Name} chybił atak");
                        ifEnemyDodgeSuccess = false;
                    }
                    break;
                case "3":
                    ifPlayerDodgeSuccess = DodgeAttack.Execute(player, enemy);
                    break;
                case "4":
                    DefensiveStance.Execute(player, enemy);
                    break;
                case "5":
                    HealthPotion.Execute(player, enemy);
                    break;
            }
            
        }
        public static void ResetDefense(Character baseCharacter, Character characterInAction)
        {
            if (characterInAction.Defense != baseCharacter.Defense)
            {
                characterInAction.Defense = baseCharacter.Defense;
                Console.WriteLine($"przywrócono bazowy poziom pkt oborny ({characterInAction.Defense})");
            }
        }
    }
}