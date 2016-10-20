using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Rpg
{
    public class Monster
    {
        //public enum Species
        //{
            
        //}
        public string Name { get; set; }
        public int Size { get; set; }
        public int Power { get; set; }
        public int Speed { get; set; }
        public int Life { get; set; }

        public Monster(string name, int size, int power, int speed, int life)
        {
            Name = name;
            Size = size;
            Power = power;
            Speed = speed;
            Life = life;
        }
    }
}
