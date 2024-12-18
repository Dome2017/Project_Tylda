using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class DodgeAttack
    {
        static Random random = new Random();
        public static void Execute(Character player, Character enemy)
        {
            int dodgeChance = random.Next(1, 11);
            if (dodgeChance <= 5)
            {
                Console.WriteLine($"- {player.Name} wykonuje udany unik");
            }
            else if (dodgeChance > 5)
            {
                Console.WriteLine($"- {player.Name} nie udje się wykonać uniku");
                //NPC attack here
            }
        }
    }
}
