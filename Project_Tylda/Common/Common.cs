using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class Common
    {
        public static void WaitForUserAction()
        {
            Console.WriteLine();
            Console.WriteLine("#---------------------------------------------#");
            Console.WriteLine("# Kliknij dowolny przycisk żeby przejść dalej #");
            Console.WriteLine("#---------------------------------------------#");
            ConsoleKeyInfo key = Console.ReadKey();
        }
        public static void ShowCharacterParameters(Character character)
        {
            Console.WriteLine("");
            Console.WriteLine("Aktualny stan postaci:");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Name: " + character.Name);
            Console.WriteLine("Hp: " + character.Hp);
            Console.WriteLine("Defense: " + character.Defense);
            Console.WriteLine("Attack: " + character.Attack);
            Console.WriteLine("Level: " + character.Level);
            Console.WriteLine("Experience: " + character.Experience);
            Console.WriteLine("Gold: " + character.Gold);
            Console.WriteLine("---------------------------------------------");
            WaitForUserAction();
        }
    }
}
