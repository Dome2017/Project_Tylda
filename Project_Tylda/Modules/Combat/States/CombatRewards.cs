using System;

namespace Project_Tylda
{
    public class CombatRewards
    {
        public static void GrantRewards(Character player, Character enemy)
        {
            int goldEarned = enemy.Defense * 2; // Złoto na podstawie obrony przeciwnika
            int xpEarned = enemy.Attack * 5; // XP na podstawie ataku przeciwnika

            player.Gold += goldEarned;
            player.Experience += xpEarned;

            Console.WriteLine("\n=== Nagrody za walkę ===");
            Console.WriteLine($"- Złoto zdobyte: {goldEarned}");
            Console.WriteLine($"- Doświadczenie zdobyte: {xpEarned}");
        }
    }
}