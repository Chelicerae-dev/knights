using System;
namespace knights
{
    public class RandomEvent
    {
        Combat DoCombat(Knight player, Mob mob)
        {
            Combat combat = new Combat(player, mob);
            return combat;
        }
        static Mob Spawn()
        {
            Mob mob = new Mob();
            return mob;
        }
        public Mob mob;
        public void DoEvent()
        {
            Random EventSelect = new Random();

            switch (EventSelect.Next(1, 4))
            {
                case 1:
                    Mob mob = Spawn();
                    MainClass.InitialGUI.MyMob = mob;
                    MainClass.InitialGUI.ShowGui();
                    DoCombat(MainClass.player, mob).Sequence();
                    MainClass.InitialGUI.ShowGui();
                    break;
                case 2:

                    MainClass.player.hp = ((MainClass.player.MaxHp - MainClass.player.hp) <= 10 ) ? MainClass.player.hp += 10 : MainClass.player.hp += (MainClass.player.MaxHp - MainClass.player.hp);
                    Console.WriteLine($"Rare moment of peace. HP restored to {MainClass.player.hp}.");
                    break;
                default:
                    goto case 1;

            }

        }
        public RandomEvent()
        {
        }
    }
}
