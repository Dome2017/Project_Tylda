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
        public static void InFightAction()
        {
            bool inFight = true;
            while (inFight)
            {
                var playerAction = Console.ReadLine();
                switch (playerAction)
                {
                    case "1":
                        EnemiesCreator.enemyCharacter.Hp = PlayerCharacterCreator.playerCharacter.Attack - EnemiesCreator.enemyCharacter.Defense - EnemiesCreator.enemyCharacter.Hp;
                        break;
                    case "2":
                        EnemiesCreator.enemyCharacter.Hp = PlayerCharacterCreator.playerCharacter.Attack * 2 - EnemiesCreator.enemyCharacter.Defense - EnemiesCreator.enemyCharacter.Hp;
                        PlayerCharacterCreator.playerCharacter.Hp = PlayerCharacterCreator.playerCharacter.Hp - 15;
                        break;
                    case "3":
                        int dodgeChance = random.Next(1, 11);
                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    default:
                        Console.WriteLine("Nie istnieje taka opcja");
                        Console.WriteLine("Wybierz interesujący Cię element menu");
                        continue;
                }
                if (EnemiesCreator.enemyCharacter.Hp <= 0)
                {
                    Console.WriteLine($"{PlayerCharacterCreator.playerCharacter.Name} wygrywa walkę");
                    inFight = false;
                }
                else if (PlayerCharacterCreator.playerCharacter.Hp <= 0)
                {
                    Console.WriteLine($"{EnemiesCreator.enemyCharacter.Name} wygrywa walkę");
                    inFight = false;
                }
            }
        }
        public static void NpcAction()
        {

        }
    }
}
