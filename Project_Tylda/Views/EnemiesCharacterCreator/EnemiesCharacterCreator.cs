using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_Tylda
{    
    public class EnemiesCharacterCreator
    {
        public static Character enemyCharacter;
        public static Character ChooseEnemy()
        {
            Console.Clear();
            Console.WriteLine("===Wybór Przeciwnika===\n\n");
            bool doShowEnemyMenu = true;
            while (doShowEnemyMenu)
            {
                Console.WriteLine("Wybierz przeciwnika");
                Console.WriteLine("1 - Zbir poziom łatwy");
                Console.WriteLine("2 - Łotr poziom średni");
                string enemyChoose = Console.ReadLine();
                switch (enemyChoose)
                {
                    case "1":
                        enemyCharacter = new Character("Zbir", 20, 2, 10);
                        ShowEnemyParameters(enemyCharacter);
                        doShowEnemyMenu = false;
                        break;
                    case "2":
                        enemyCharacter = new Character("Łotr", 50, 10, 12);
                        ShowEnemyParameters(enemyCharacter);
                        doShowEnemyMenu = false;
                        break;
                    default:
                        Console.WriteLine("Nie istnieje taka opcja");
                        Console.WriteLine("Wybierz interesujący Cię element menu");
                        continue;
                }
            }
            Common.WaitForUserAction();
            return enemyCharacter;
        }
        public static void ShowEnemyParameters(Character enemyParameters)
        {
            Console.WriteLine("Name: " + enemyParameters.Name);
            Console.WriteLine("Hp: " + enemyParameters.Hp);
            Console.WriteLine("Defense: " + enemyParameters.Defense);
            Console.WriteLine("Attack: " + enemyParameters.Attack);
            Console.WriteLine("Level: " + enemyParameters.Level);
        }
    }
}
