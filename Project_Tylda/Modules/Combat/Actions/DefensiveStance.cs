using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class DefensiveStance
    {
        public static void Execute(Character player, Character enemy)
        {
            player.Defense = player.Defense * 2;
            Console.WriteLine($"- {player.Name} przybiera postawę defensywna zwiększając swoje pkt obrony do {player.Defense}");
        }
    }
}
