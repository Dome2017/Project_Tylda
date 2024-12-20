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
        public int Level { get; set; }
        public int Gold { get; set; } 
        public int Experience { get; set; }
        
        public Character(string name, int hp, int defense, int attack, int? level = null)
        {
            this.Name = name;
            this.Hp = hp;
            this.Defense = defense;
            this.Attack = attack;
            this.Level = level ?? 1;
            this.Gold = 0;
            this.Experience = 0;
        }
        public Character(Character baseCharacter)
        {
            Name = baseCharacter.Name;
            Hp = baseCharacter.Hp;
            Defense = baseCharacter.Defense;
            Attack = baseCharacter.Attack;
            Level = baseCharacter.Level;
            Gold = baseCharacter.Gold;
            Experience = baseCharacter.Experience;
        }
    }
}