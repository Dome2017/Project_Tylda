using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Tylda
{
    public class PlayerCharacterCreator
    {
        public static Character playerCharacter;
        public static Character CreatePlayerCharacter()
        {
            Console.Clear();
            Console.WriteLine("=== Wybór Postaci ===");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Nadaj imię swojej postaci: ");
            string playerCharacterName = Console.ReadLine();
            playerCharacter = new Character(playerCharacterName, 100, 10, 20);
            ShowPlayerCharacterParameters(playerCharacter);
            Common.WaitForUserAction();
            return playerCharacter;
        }

        public static void ShowPlayerCharacterParameters(Character characterToShow)
        {
            Console.Clear();
            Console.WriteLine("Twoja postać to:");
            Console.WriteLine("Name: " + characterToShow.Name);
            Console.WriteLine("Hp: " + characterToShow.Hp);
            Console.WriteLine("Defense: " + characterToShow.Defense);
            Console.WriteLine("Attack: " + characterToShow.Attack);
        }
    }
}
