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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);
            Console.Write("You playing Silly Knights Game");

            //Console.SetCursorPosition(1, 3);

            Console.SetCursorPosition(30, 3);
            Console.Write($"Your knight: {MainClass.PlayerName}");
            string[] StatsNames = { "HP:", "ATK:", "AGI:", "LUCK:" };
            int[] MyStats = { MyPlayer.hp, MyPlayer.atk, Convert.ToInt32(MyPlayer.agi), Convert.ToInt32(MyPlayer.luck) };
            for (int i = 0; i < MyStats.Length; i++)
            {
                Console.SetCursorPosition(35, 4 + i);
                Console.Write(StatsNames[i]);
                Console.SetCursorPosition(40, 4 + i);
                Console.Write(MyStats[i]);
            }

            if (MyMob != null)
            {
                string[] MobStatsNames = { "HP:", "ATK:", "AGI:" };
                int[] MobStats = { MyMob.hp, MyMob.atk, Convert.ToInt32(MyMob.agi) };
                Console.SetCursorPosition(30, 10);
                Console.Write("Enemy:");
                Console.SetCursorPosition(40, 10);
                Console.Write(MyMob.name);
                for (int i = 0; i < MobStats.Length; i++)
                {
                    Console.SetCursorPosition(35, 11 + i);
                    Console.Write(MobStatsNames[i]);
                    Console.SetCursorPosition(40, 11 + i);
                    Console.Write(MobStats[i]);
                }
            }
            if (MyWeap != null && MyPlayer.WeaponIsEquipped)
            {
                Console.SetCursorPosition(35, 20);
                Console.Write($"Equipped: {MyWeap.name}");

            }
            //Console.SetBufferSize(90, 40);
            //Console.SetCursorPosition(1, 25);
            Console.WriteLine("");
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
