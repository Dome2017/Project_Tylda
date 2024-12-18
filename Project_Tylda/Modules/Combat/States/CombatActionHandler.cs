using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class CombatActionHandler
    {
        public static void ExecuteEnemyAction(Character player, Character enemy)
        {
            Console.WriteLine($"\n- {enemy.Name} kontratakuje!");
            int damage = Math.Max(0, enemy.Attack - player.Defense);
            player.Hp -= damage;
            Console.WriteLine($"- {player.Name} otrzymuje {damage} obrażeń.");
        }
        public static void ExecutePlayerAction(Character player, Character enemy)
        {

            var playerAction = Console.ReadLine();
            Console.Clear();
            switch (playerAction)
            {
                case "1":
                    SwordCut.Execute(player, enemy);
                    break;
                case "2":
                    SpecialAttack.Execute(player, enemy);
                    break;
                case "3":
                    DodgeAttack.Execute(player, enemy);
                    break;
                case "4":
                    DefensiveStance.Execute(player, enemy);
                    break;
                case "5":
                    HealthPotion.Execute(player, enemy);
                    break;
            }
            
        }
        public static void ResetDefence(Character baseCharacter, Character characterInAction)
        {
            characterInAction.Defense = baseCharacter.Defense;
        }
    }
}
