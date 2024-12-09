using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda.views.gameViews.enemyChose
{
    public class enemy
    {
        public string Name { get; set; }   
        public int Hp { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }

        public enemy(string name, int hp, int defense, int attack)
        {
            this.Name = name;
            this.Hp = hp;
            this.Defense = defense;
            this.Attack = attack;
        }
    }
    
}
