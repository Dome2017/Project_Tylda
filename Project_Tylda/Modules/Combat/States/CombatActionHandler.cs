using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class CombatActionHandler
    {
        public static bool ifPlayerDodgeSuccess = false;  
        public static bool isEnemyDodgeSuccess = false;
        public static void ExecuteEnemyAction(Character player, Character enemy)
        {
            if (ifPlayerDodgeSuccess == false)
            {
                Console.WriteLine($"\n- {enemy.Name} kontratakuje!");
                int damage = Math.Max(0, enemy.Attack - player.Defense);
                player.Hp -= damage;
                Console.WriteLine($"- {player.Name} otrzymuje {damage} obrażeń.");
            }
            else
            {
               Console.WriteLine($"- {enemy.Name} chybił atak");
                ifPlayerDodgeSuccess = false;
            }
            
        }
        public static void ExecutePlayerAction(Character player, Character enemy)
        {

            var playerAction = Console.ReadLine();
            Console.Clear();
            switch (playerAction)
            {
                case "1":
                    if (isEnemyDodgeSuccess == true)
                    {
                        SwordCut.Execute(player, enemy);
                    }
                    else
                    {
                        Console.WriteLine($"- {player.Name} chybił atak");
                        isEnemyDodgeSuccess = false;
                    }
                    break;
                case "2":
                    if (isEnemyDodgeSuccess == true)
                    {
                        SpecialAttack.Execute(player, enemy);
                    }
                    else
                    {
                        Console.WriteLine($"- {player.Name} chybił atak");
                        isEnemyDodgeSuccess = false;
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
            characterInAction.Defense = baseCharacter.Defense;
            Console.WriteLine($"przywrócono bazowy poziom pkt oborny ({characterInAction.Defense})");
        }
    }
}