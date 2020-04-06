using System;
namespace knights
{
    public class Mob
    {
        int hp { get; set; }
        int atk { get; set; }
        int agi { get; set; }
        int aggroVision { get; set; }
        bool aggro { get; set; }
        enum Loot {
            Poor = 1,
            Moderate = 2,
            Rich = 3,
            Enormous = 4 
        }

        }
        public Mob()
        {
        }
    }
}
