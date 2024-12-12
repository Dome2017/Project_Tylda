using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Tylda
{
    public class CharacterCreator
    {
        public static PlayerCharacter playerCharacter;
        public static void ChooseCharacter()
        {
            Console.WriteLine("=== Wybór Postaci ===\n\n");
            Console.Write("Nadaj imię swojej postaci: ");
            string playerCharacterName = Console.ReadLine();
            playerCharacter = new PlayerCharacter(playerCharacterName, 100, 10, 20);
            ShowPlayerCharacterParameters(playerCharacter);
        }

        public static void ShowPlayerCharacterParameters(PlayerCharacter characterToShow)
        {
            Console.WriteLine("Name: " + characterToShow.Name);
            Console.WriteLine("Hp: " + characterToShow.Hp);
            Console.WriteLine("Defense: " + characterToShow.Defense);
            Console.WriteLine("Attack: " + characterToShow.Attack);
        }
    }
}
