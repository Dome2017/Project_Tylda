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
        public static int playerUsablePotionsLeft = 2;
        public static int enemyUsablePotionsLeft = 2;

        public static void ExecuteEnemyAction(Character player, Character enemy)
        {
            var enemyAction = random.Next(1, 6);
            if (enemyUsablePotionsLeft == 0)
            {
                enemyAction = random.Next(1, 5);
            }
            else
            {

            }
            switch (enemyAction)
            {
                case 1:
                    SwordCut.Execute(enemy, player, ifPlayerDodgeSuccess);
                    break;
                case 2:
                    SpecialAttack.Execute(enemy, player, ifPlayerDodgeSuccess);
                    break;
                case 3:
                    ifEnemyDodgeSuccess = DodgeAttack.Execute(enemy, player);
                    break;
                case 4:
                    DefensiveStance.Execute(enemy, player);
                    break;
                case 5:
                    HealthPotion.Execute(enemy, player);
                    enemyUsablePotionsLeft = enemyUsablePotionsLeft - 1;
                    break;
            }
            ifPlayerDodgeSuccess = false;
        }
        public static void ExecutePlayerAction(Character player, Character enemy)
        {

            var playerAction = Console.ReadLine();
            Console.Clear();
            switch (playerAction)
            {
                case "1":
                        SwordCut.Execute(player, enemy, ifEnemyDodgeSuccess);
                    break;
                case "2":
                    SpecialAttack.Execute(player, enemy, ifEnemyDodgeSuccess);
                    break;
                case "3":
                    ifPlayerDodgeSuccess = DodgeAttack.Execute(player, enemy);
                    break;
                case "4":
                    DefensiveStance.Execute(player, enemy);
                    break;
                case "5":
                    if (playerUsablePotionsLeft == 0)
                    {
                        Console.WriteLine("!!!Wykorzystano wszystkie eliksiry zdrowia, odsłoniłeś się na atak przeciwnika próbując znaleźć eliksir!!!");
                        break;
                    }
                        HealthPotion.Execute(player, enemy);
                    playerUsablePotionsLeft = playerUsablePotionsLeft - 1;
                    if (playerUsablePotionsLeft == 0)
                    {
                        Console.WriteLine("!!!Nie masz już eliksirów życia, użycie elkisriru odsłoni cię na atak przeciwnika!!!");
                    }
                        break;
            }
            ifEnemyDodgeSuccess = false;
        }
        public static void ResetDefense(Character baseCharacter, Character characterInAction)
        {
            if (characterInAction.Defense != baseCharacter.Defense)
            {
                characterInAction.Defense = baseCharacter.Defense;
                Console.WriteLine($"{characterInAction.Name} ma przywrócony bazowy poziom pkt oborny ({characterInAction.Defense})");
            }
        }
    }
}