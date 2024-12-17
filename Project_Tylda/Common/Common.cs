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
    }
}
