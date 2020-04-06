using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knights
{
    public class Weapon
    {
        public int atk { get; set; }
        public int durability { get; set; }
        public string name { get; set; }

        public Weapon(int Atk, int Durability, string Name)
        {
            atk = Atk;
            durability = Durability;
            name = Name;

        }
    }
}
