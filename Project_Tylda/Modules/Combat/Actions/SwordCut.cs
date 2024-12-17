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
            enemy.Hp = player.Attack - enemy.Defense - enemy.Hp;
        }
    }
}
