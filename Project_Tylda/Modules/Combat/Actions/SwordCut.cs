using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class SwordCut
    {
        public static void Execute(Character attacker, Character defender)
        {
            int damage = attacker.Attack - defender.Defense;
            damage = Math.Max(damage, 0);
            defender.Hp = defender.Hp - damage;
            Console.WriteLine($"- {attacker.Name} atakuje mieczem");
            Console.WriteLine($"- {defender.Name} otrzymał {damage} pkt obrażeń");
        }
    }
}
