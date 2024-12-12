using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda.views.gameViews.enemyChose
{
    public class Enemy
    {
        public string Name { get; set; }   
        public int Hp { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }

        public Enemy(string name, int hp, int defense, int attack)
        {
            this.Name = name;
            this.Hp = hp;
            this.Defense = defense;
            this.Attack = attack;
        }
    }
    public class enemiesToChose
    {
        public static void ChoseEnemy()
        {
            Console.WriteLine("\n\n===Wybór Przeciwnika===\n\n");
            Console.WriteLine("Wybierz przeciwnika\n1 - Zbir poziom łatwy\n2 - Łotr poziom średni");
            string enemyChoice = Console.ReadLine();
            bool choosingEnemy = true;
            while (choosingEnemy)
            {
                switch (enemyChoice)
                {
                    case "1":
                        Enemy enemyCharacterLvLEasy = new Enemy("Zbir", 20, 2, 5);
                        ViewEnemyInformation(enemyCharacterLvLEasy);
                        choosingEnemy = false;
                        break;
                    case "2":
                        Enemy enemyCharacterLvLMedium = new Enemy("Łotr", 50, 10, 12);
                        ViewEnemyInformation(enemyCharacterLvLMedium);
                        choosingEnemy = false;
                        break;
                    default:
                        Console.WriteLine("Nie istnieje taka opcja \nWybierz interesujący Cię element menu");
                        continue;
                }
                
            }
        }
        public static void ViewEnemyInformation(Enemy EnemyInfoShow)
        {
            Console.WriteLine("Name: " + EnemyInfoShow.Name);
            Console.WriteLine("Hp: " + EnemyInfoShow.Hp);
            Console.WriteLine("Defense: " + EnemyInfoShow.Defense);
            Console.WriteLine("Attack: " + EnemyInfoShow.Attack);
        }
    }


}
