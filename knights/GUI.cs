using System;
namespace knights
{
    public class GUI
    {
        Knight MyPlayer;
        public Mob MyMob { get; set; }
        Weapon MyWeap;

        public void ShowGui()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.CursorVisible = false;
            //Console.SetCursorPosition(1, 1);
            //Console.Write("You playing Silly Knights Game");

            //Console.SetCursorPosition(1, 3);
            int SW = 60;
            Console.SetCursorPosition(SW, 3);
            Console.Write($"Your knight: {MainClass.PlayerName}");
            string[] StatsNames = { "HP:", "ATK:", "AGI:", "LUCK:" };
            int[] MyStats = { MyPlayer.hp, MyPlayer.atk, Convert.ToInt32(MyPlayer.agi), Convert.ToInt32(MyPlayer.luck) };
            for (int i = 0; i < MyStats.Length; i++)
            {
                Console.SetCursorPosition(SW, 4 + i);
                Console.Write(StatsNames[i]);
                Console.SetCursorPosition(SW + 5, 4 + i);
                Console.Write(MyStats[i]);
            }

            if (MyMob != null)
            {
                string[] MobStatsNames = { "HP:", "ATK:", "AGI:" };
                int[] MobStats = { MyMob.hp, MyMob.atk, Convert.ToInt32(MyMob.agi) };
                Console.SetCursorPosition(SW, 10);
                Console.Write("Enemy:");
                Console.SetCursorPosition(SW + 10, 10);
                Console.Write(MyMob.name);
                for (int i = 0; i < MobStats.Length; i++)
                {
                    Console.SetCursorPosition(SW, 11 + i);
                    Console.Write(MobStatsNames[i]);
                    Console.SetCursorPosition(SW + 5, 11 + i);
                    Console.Write(MobStats[i]);
                }
            }
            if (MyWeap != null && MyPlayer.WeaponIsEquipped)
            {
                Console.SetCursorPosition(SW, 20);
                Console.Write($"Equipped: {MyWeap.name}");

            }
            //Console.SetBufferSize(90, 40);
            //Console.SetCursorPosition(1, 25);
            Console.SetCursorPosition(0, 0);
            Console.Write(@" #####                        
#     # # #      #      #   # 
#       # #      #       # #  
 #####  # #      #        #   
      # # #      #        #   
#     # # #      #        #   
 #####  # ###### ######   #   
                              
#    #                              
#   #  #    # #  ####  #    # ##### 
#  #   ##   # # #    # #    #   #   
###    # #  # # #      ######   #   
#  #   #  # # # #  ### #    #   #   
#   #  #   ## # #    # #    #   #   
#    # #    # #  ####  #    #   #   ");
            Console.WriteLine("\n\n");

        }
        public GUI(Knight player)
        {
            MyPlayer = player;
        }
        public GUI(Knight player, Mob mob)
        {
            MyPlayer = player;
            MyMob = mob;
        }
        public GUI(Knight player, Mob mob, Weapon CurrentWeapon)
        {
            MyPlayer = player;
            MyMob = mob;
            MyWeap = CurrentWeapon;
        }
    }
}
