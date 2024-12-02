using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Tylda
{
    public class Character
    {
        public string Name { get; set; }  
        public int Hp { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }

        public Character(string name, int hp, int defense, int attack)
        {
            this.Name = name;
            this.Hp = hp;
            this.Defense = defense;
            this.Attack = attack;
            
        }

    }
    public class characterCreator
    {
        public static void CharacterChose()
        {
            Console.WriteLine("=== Wybór Postaci ===\n\n");
            Console.Write("Nadaj imię swojej postaci: ");
            string PlayerCharacterName = Console.ReadLine();
            Character PlayerCharacter = new Character(PlayerCharacterName, 100, 10, 20);
            Console.WriteLine("\n" + PlayerCharacter.Name + "zmienna: " + PlayerCharacterName);
            ViewInformation(PlayerCharacter);
        }
        public static void ViewInformation(Character characterToShow)
        {
            Console.WriteLine("Name: " + characterToShow.Name);
            Console.WriteLine("Hp: " + characterToShow.Hp);
            Console.WriteLine("Defense: " + characterToShow.Defense);
            Console.WriteLine("Attack: " + characterToShow.Attack);
        }
    }
}
