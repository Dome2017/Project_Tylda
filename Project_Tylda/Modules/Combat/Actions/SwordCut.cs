using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class SwordCut
    {
        public static void Execute(Character player, Character enemy)
        {
            int damage = player.Attack - enemy.Defense;
            damage = Math.Max(damage, 0);
            enemy.Hp = enemy.Hp - damage;
            Console.WriteLine($"- {player.Name} atakuje mieczem");
            Console.WriteLine($"- {enemy.Name} otrzymał {damage} pkt obrażeń");
        }
    }
}
