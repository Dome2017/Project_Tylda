﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w Project Tylda");
            Main_Menu();



            Console.ReadLine();
        }
        static void Main_Menu()
        {
            Console.WriteLine("=== MENU === \n Nowa gra - 1 \n Wyjście - 2");


            
            bool program_running = true;
            while (program_running == true)
            {
                string player_choice = Console.ReadLine();


                switch (player_choice)
                {
                    case "1":
                        gameView.StartGame();
                        break;
                    case "2":
                        program_running = false;
                        break;
                    default:
                        Console.WriteLine("Nie istnieje taka opcja \nWybierz interesujący Cię element menu");
                        continue;

                }
            }
        }
    }
}
