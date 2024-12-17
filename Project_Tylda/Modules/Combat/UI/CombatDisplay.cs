using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class CombatDisplay
    {
        public static void ActionMenu()
        {
            Console.WriteLine("Akcje walki:");
            Console.WriteLine("1 - Atak mieczem");
            Console.WriteLine("2 - Atak specjalny");
            Console.WriteLine("3 - Unik");
            Console.WriteLine("4 - Obrona");
            Console.WriteLine("5 - Mikstura zdrowia");
            Console.Write("\n Wybierz akcję: ");
        }
    }
}
