using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Rpg
{
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int Speed { get; set; }
        public int Life { get; set; }

        public PlayerCharacter(string name, int power, int speed, int life)
        {
            Name = name;
            Power = power;
            Speed = speed;
            Life = life;
        }
    }
}
