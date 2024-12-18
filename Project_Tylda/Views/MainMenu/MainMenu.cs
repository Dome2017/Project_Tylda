using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    internal class MainMenu
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("+=== MENU ===+");
            Console.WriteLine("1 - Nowa gra");
            Console.WriteLine("2 - Wyjście");
            bool program_running = true;
            while (program_running)
            {
                string player_choice = Console.ReadLine();
                switch (player_choice)
                {
                    case "1":
                        GameView.StartGame();
                        break;
                    case "2":
                        program_running = false;
                        break;
                    default:
                        Console.WriteLine("Nie istnieje taka opcja");
                        Console.WriteLine("Wybierz interesujący Cię element menu");
                        Console.WriteLine("1 - Nowa gra");
                        Console.WriteLine("2 - Wyjście");
                        continue;
                }
            }
        }
    }
}
