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
        public int weight { get; set; }
        public static List<Weapon> WeaponList = new List<Weapon>()
        {
            new Weapon(10, 3, "Halberd", 10),
            new Weapon(5, 6, "Shortswotd", 5),
            new Weapon(3, 8, "Dagger", 3),
            new Weapon(1, 3, "Stick", 1),
            new Weapon(7, 5, "Longsword", 7),
            new Weapon(10, 10, "Legendary Sword", 8)
        };

        public Weapon(int Atk, int Durability, string Name, int Weight)
        {
            atk = Atk;
            durability = Durability;
            name = Name;
            weight = Weight;
        }
    }
}
