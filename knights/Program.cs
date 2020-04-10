using System;

namespace knights
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Knight player = new Knight();
            Mob mob1 = new Mob();
            Combat combat = new Combat(player, mob1);
            while (combat.spawn)
            {
                combat.Sequence();
            }
            Console.WriteLine("fin");
        }
    }
}
