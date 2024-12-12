﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{    
    public class EnemiesCreator
    {
        public static void ChooseEnemy()
        {
            Console.WriteLine("\n\n===Wybór Przeciwnika===\n\n");
            Console.WriteLine("Wybierz przeciwnika\n1 - Zbir poziom łatwy\n2 - Łotr poziom średni");
            string enemyChoose = Console.ReadLine();
            bool doShowEnemyMenu = true;
            while (doShowEnemyMenu)
            {
                switch (enemyChoose)
                {
                    case "1":
                        var enemyCharacterLvLEasy = new EnemyCharacter("Zbir", 20, 2, 5);
                        ShowEnemyInformation(enemyCharacterLvLEasy);
                        doShowEnemyMenu = false;
                        break;
                    case "2":
                        var enemyCharacterLvLMedium = new EnemyCharacter("Łotr", 50, 10, 12);
                        ShowEnemyInformation(enemyCharacterLvLMedium);
                        doShowEnemyMenu = false;
                        break;
                    default:
                        Console.WriteLine("Nie istnieje taka opcja \nWybierz interesujący Cię element menu");
                        continue;
                }
            }
        }
        public static void ShowEnemyInformation(EnemyCharacter enemyParameters)
        {
            Console.WriteLine("Name: " + enemyParameters.Name);
            Console.WriteLine("Hp: " + enemyParameters.Hp);
            Console.WriteLine("Defense: " + enemyParameters.Defense);
            Console.WriteLine("Attack: " + enemyParameters.Attack);
        }
    }
}