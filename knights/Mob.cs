using System;
namespace knights
{
    public class Mob
    {
        public int hp { get; set; }
        public int atk { get; set; }
        public double agi { get; set; }
        public string name { get; set; }
        /*int aggroVision { get; set; }
        bool aggro { get; set; }*/
        enum Loot
        {
            Poor = 1,
            Moderate = 2,
            Rich = 3,
            Enormous = 4
        }

        public Mob()
        {
            Random rand = new Random();
            hp = rand.Next(1, 100);
            atk = rand.Next(1, 20);
            agi = 10;
            //agi = (1 / Convert.ToDouble(atk)) * 100;
            name = "Mob";
            Console.WriteLine($"You fighting {name} with {hp} hp, {atk} attack and {agi} agility.");
        }
    }
}
