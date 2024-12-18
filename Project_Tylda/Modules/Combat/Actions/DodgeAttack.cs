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
        public static bool Execute(Character player, Character enemy)
        {
            bool succesDodge = false;
            int dodgeChance = random.Next(1, 11);
            if (dodgeChance <= 5)
            {
                Console.WriteLine($"- {player.Name} wykonuje udany unik");
                succesDodge = true;
            }
            else if (dodgeChance > 5)
            {
                succesDodge = false;    
                Console.WriteLine($"- {player.Name} nie udje się wykonać uniku");
            }
            return succesDodge;
        }
    }
}
