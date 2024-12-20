using System;

namespace Project_Tylda
{
    public class CombatRewards
    {
        public static void GrantRewards(Character player, Character enemy)
        {
            int goldEarned = enemy.Defense * 2; // Złoto na podstawie obrony przeciwnika
            int xpEarned = enemy.Attack * 22; // XP na podstawie ataku przeciwnika

            player.Gold += goldEarned;
            player.Experience += xpEarned;

            Console.WriteLine("\n=== Nagrody za walkę ===");
            Console.WriteLine($"- Złoto zdobyte: {goldEarned}");
            Console.WriteLine($"- Doświadczenie zdobyte: {xpEarned}");
            player.Level = checkNewLevel(player.Experience, player.Level);
        }

        public static int checkNewLevel(int experience, int currentLevel)
        {
            // Bazowy próg doświadczenia na poziom 1
            int baseExperience = 100;

            // Obliczamy nowy poziom na podstawie doświadczenia
            int newLevel = experience / baseExperience;

            if ( newLevel > currentLevel)
            {
                Console.WriteLine("Zdobywasz nowy poziom postaci dzieki zdobytemu doswiadczeniu!");
                Console.WriteLine($"Aktualny poziom: {currentLevel}, Doświadczenie: {experience}, Nowy poziom: {newLevel}");
            }

            return Math.Max(currentLevel, newLevel);
        }
    }
}