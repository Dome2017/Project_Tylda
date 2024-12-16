using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_Tylda
{    
    public class EnemiesCreator
    {
        public static Character enemyCharacter;
        public static void ChooseEnemy()
        {
            Console.WriteLine("\n\n===Wybór Przeciwnika===\n\n");
            bool doShowEnemyMenu = true;
            enemyCharacter = new Character("",0,0,0);
            while (doShowEnemyMenu)
            {
                Console.WriteLine("Wybierz przeciwnika\n1 - Zbir poziom łatwy\n2 - Łotr poziom średni");
                string enemyChoose = Console.ReadLine();
                switch (enemyChoose)
                {
                    case "1":
                        enemyCharacter = new Character("Zbir", 20, 2, 5);
                        ShowEnemyParameters(enemyCharacter);
                        doShowEnemyMenu = false;
                        break;
                    case "2":
                        enemyCharacter = new Character("Łotr", 50, 10, 12);
                        ShowEnemyParameters(enemyCharacter);
                        doShowEnemyMenu = false;
                        break;
                    default:
                        Console.WriteLine("Nie istnieje taka opcja \nWybierz interesujący Cię element menu");
                        continue;
                }
                break;
            }
            Console.WriteLine("\nKliknij dowolny przycisk żeby przejść dalej\n");
            Console.ReadKey(true);
        }
        public static void ShowEnemyParameters(Character enemyParameters)
        {
            Console.WriteLine("Name: " + enemyParameters.Name);
            Console.WriteLine("Hp: " + enemyParameters.Hp);
            Console.WriteLine("Defense: " + enemyParameters.Defense);
            Console.WriteLine("Attack: " + enemyParameters.Attack);
        }
    }
}
