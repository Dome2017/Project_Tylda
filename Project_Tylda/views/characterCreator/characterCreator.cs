﻿using System;
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
        public static void CharacterChose()
        {
            Console.WriteLine("=== Wybór Postaci ===\n\n");
            Console.Write("Nadaj imię swojej postaci: ");
            string PlayerCharacterName = Console.ReadLine();
            var PlayerCharacter = new Character(PlayerCharacterName, 100, 10, 20);
            ViewInformation(PlayerCharacter);
        }
        private static void ViewInformation(Character characterToShow)
        {
            Console.WriteLine("Name: " + characterToShow.Name);
            Console.WriteLine("Hp: " + characterToShow.Hp);
            Console.WriteLine("Defense: " + characterToShow.Defense);
            Console.WriteLine("Attack: " + characterToShow.Attack);
        }
    }
}
