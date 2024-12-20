using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class DefensiveStance
    {
        public static void Execute(Character attacker, Character defender)
        {
            attacker.Defense = attacker.Defense * 2;
            Console.WriteLine($"- {attacker.Name} przybiera postawę defensywna zwiększając swoje pkt obrony do {attacker.Defense}");
        }
    }
}
