using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab3
{
    public class Player
    {
        public string Name { get; set; }
        public IUnit Unit { get; set; }

        public Player(string name)
        {
            Name = name;
            Unit = new Unit(name + " Unit", 100, 20);
        }
    }

}
