using System;
using System.Collections.Generic;
namespace knights
{

    class MainClass
    {
        /*public static Mob Spawn()
        {
            Mob mob = new Mob();
            return mob;
        }
        */
        public static Knight player = new Knight();
        public static GUI InitialGUI = new GUI(player);
        public static string PlayerName; 
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            PlayerName = Console.ReadLine();
            InitialGUI.ShowGui();
            RandomEvent RandEvent = new RandomEvent();
            while (player.hp > 0)
            {
                int i = 1;
                //Console.Write($"Turn {i}");

                RandEvent.DoEvent();
                //InitialGUI.ShowGui();
                i++;
            }
            
            Console.WriteLine("fin");
        }
    }
}
