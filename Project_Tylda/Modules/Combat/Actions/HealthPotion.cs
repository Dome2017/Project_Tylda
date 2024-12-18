using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class HealthPotion
    {
        public static void Execute(Character player, Character enemy)
        {
            player.Hp += 20;
            Console.WriteLine($"- {player.Name} wypija miksturę leczącą zysjkując 20 pkt Hp");
        }
    }
}
