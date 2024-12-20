using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class SpecialAttack
    {
        public static void Execute(Character attacker, Character defender)
        {
            int damage = (attacker.Attack * 2) - defender.Defense;
            damage = Math.Max(damage, 0);
            defender.Hp = defender.Hp - damage;
            attacker.Hp = attacker.Hp - 15;
            Console.WriteLine($"- {attacker.Name} wykonuje atak specjalny zadając {damage} i traci 15 pkt Hp");
            Console.WriteLine($"- {defender.Name} otrzymuje {damage} pkt obrażeń");
        }
    }
}
