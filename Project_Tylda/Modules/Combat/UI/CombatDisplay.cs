using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    public class CombatDisplay
    {
        public static void ShowActionMenu()
        {
            Console.WriteLine("Akcje walki:");
            Console.WriteLine("1 - Atak mieczem");
            Console.WriteLine("2 - Atak specjalny");
            Console.WriteLine("3 - Unik");
            Console.WriteLine("4 - Obrona");
            Console.WriteLine("5 - Mikstura zdrowia");
            Console.Write("\n Wybierz akcję: ");
        }
        public static void ShowState(Character player, Character enemy)
        {
            Console.WriteLine("________________________________________________________");
            Console.WriteLine($"{player.Name}: HP = {player.Hp}, {enemy.Name}: HP = {enemy.Hp}");
        }
        public static void ShowBattleResult(Character player, Character enemy)
        {
            Console.WriteLine("");
            
            if(player.Hp > 0)
            {
                Console.WriteLine($"{player.Name} wygrywa walkę!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{enemy.Name} wygrywa walkę.");
            }
        }
    }
}
