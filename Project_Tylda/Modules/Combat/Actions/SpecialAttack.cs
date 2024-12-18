using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class SpecialAttack
    {
        public static void Execute(Character player, Character enemy)
        {
            int damage = (player.Attack * 2) - enemy.Defense;
            damage = Math.Max(damage, 0);
            enemy.Hp = enemy.Hp - damage;
            player.Hp = player.Hp - 15;
            Console.WriteLine($"- {player.Name} wykonuje atak specjalny zadając {damage} i traci 15 pkt Hp");
            Console.WriteLine($"- {enemy.Name} otrzymuje {damage} pkt obrażeń");
        }
    }
}
