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


            Console.Clear();
            CombatDisplay.ShowState(player, enemy);
            CombatDisplay.ShowActionMenu();


            bool inFight = true;
            while (inFight)
            {
                var playerAction = Console.ReadLine();
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
                    default:
                        Console.WriteLine("Nie istnieje taka opcja");
                        Console.WriteLine("Wybierz interesujący Cię element menu");
                        continue;
                }
                if (EnemiesCharacterCreator.enemyCharacter.Hp <= 0)
                {
                    Console.WriteLine($"{PlayerCharacterCreator.playerCharacter.Name} wygrywa walkę");
                    inFight = false;
                }
                else if (PlayerCharacterCreator.playerCharacter.Hp <= 0)
                {
                    Console.WriteLine($"{EnemiesCharacterCreator.enemyCharacter.Name} wygrywa walkę");
                    inFight = false;
                }
            }
        }
    }
}
