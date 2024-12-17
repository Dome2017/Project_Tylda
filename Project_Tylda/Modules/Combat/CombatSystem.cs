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
                        SwordCut();
                        break;
                    case "2":
                        SpecialAttack();
                        break;
                    case "3":
                        DodgeAttack();
                        break;
                    case "4":
                        DefensiveStance();
                        break;
                    case "5":
                        HelathPotion();
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
        public static void SwordCut()
        {
            EnemiesCreator.enemyCharacter.Hp = PlayerCharacterCreator.playerCharacter.Attack - EnemiesCreator.enemyCharacter.Defense - EnemiesCreator.enemyCharacter.Hp;
        }
        public static void SpecialAttack()
        {
            EnemiesCreator.enemyCharacter.Hp = PlayerCharacterCreator.playerCharacter.Attack * 2 - EnemiesCreator.enemyCharacter.Defense - EnemiesCreator.enemyCharacter.Hp;
            PlayerCharacterCreator.playerCharacter.Hp = PlayerCharacterCreator.playerCharacter.Hp - 15;
        }
        public static void DodgeAttack()
        {
            int dodgeChance = random.Next(1, 11);
            if (dodgeChance <= 5)
            {
                Console.WriteLine($"{PlayerCharacterCreator.playerCharacter.Name} wykonuje udany unik");
            }
            else if (dodgeChance > 5)
            {
                Console.WriteLine($"{PlayerCharacterCreator.playerCharacter.Name} nie udje się wykonać uniku");
                //NPC attack here
            }
        }
        public static void DefensiveStance()
        {
            PlayerCharacterCreator.playerCharacter.Defense = PlayerCharacterCreator.playerCharacter.Defense * 2;
        }
        public static void HelathPotion()
        {
            PlayerCharacterCreator.playerCharacter.Hp += 20;
        }

    }
}
