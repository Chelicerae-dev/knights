using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knights
{
    class Combat
    {
        int damage { get; set; }
        Random random = new Random();
        Knight player { get; set; }
        Mob mob { get; set; }
        public bool spawn = true;
        public void DoAttack()
        {
            double HitChance = (player.agi - mob.agi) * player.luck / 100;
            double rand = random.Next(1, 100);
            Console.WriteLine($"Hit chance was {HitChance} of {rand/100}");
            bool MobEvade = HitChance <= rand/100 ? true : false;
            double CritChance = player.Crit + (player.luck / 77);
            bool IsCrit = CritChance >= random.NextDouble() ? true : false;
            Console.WriteLine($"You attack {mob.name}.");
            if (MobEvade)
            {
                Console.WriteLine($"{mob.name} evaded your attack.");
                damage = 0;
            }
            else
            {
                switch (IsCrit)
                {
                    case true:
                        damage = player.atk * 2;
                        Console.WriteLine("You landed critical hit!");
                        if (player.WeaponIsEquipped == true)
                        {
                            player.WeapDurability -= 2;
                        }
                        break;
                    case false:
                        damage = player.atk;
                        if (player.WeaponIsEquipped == true)
                        {
                            player.WeapDurability -= 1;
                        }
                        break;
                }
            }
            mob.hp -= damage;
            Console.WriteLine($"You inflicted {damage} damage to {mob.name}.");
        }
        public void MobAttack()
        {
            double MobRand = random.NextDouble();
            double PlayerEvadeChance = (player.agi - mob.agi) * player.luck * random.NextDouble() / 100;
            
            bool PlayerEvade = PlayerEvadeChance >= MobRand ? true : false;
            Console.WriteLine($"Your evade chance is {PlayerEvadeChance} of {MobRand}");
            bool IsCrit = 0.1 >= random.NextDouble() ? true : false;
            Console.WriteLine($"{mob.name} attacks you!");
            if (PlayerEvade)
            {
                //Console.WriteLine($"You evaded {mob.name}'s attack.");
                damage = 0;
            }
            else
            {
                switch (IsCrit)
                {
                    case true:
                        damage = mob.atk * 2;
                        //Console.WriteLine($"{mob.name} landed critical hit!");
                        break;
                    case false:
                        damage = mob.atk;
                        break;
                }
            }
            player.hp -= damage;
            Console.WriteLine($"{mob.name} inflicted {damage} damage to you.");
        }

        public void Sequence()
        {
            while (player.hp > 0)
            {
                MainClass.InitialGUI.ShowGui();
                Console.WriteLine("Press A for attack");
                char action =  Console.ReadKey().KeyChar;
                switch (action)
                {
                    case 'a':
                        DoAttack();
                        Console.WriteLine($"Mob has {mob.hp} hp remained");
                        break;
                    default:
                        break;
                }
                if (mob.hp > 0)
                {
                    //Console.WriteLine($"{mob.name}'s turn!");
                    MobAttack();
                    Console.WriteLine($"You have {player.hp} hp remained");
                }
                else
                {
                    Console.WriteLine($"{mob.name} defeated!");
                    break;

                }
                System.Threading.Thread.Sleep(1000);
            }
            if (player.hp <= 0)
            {
                Console.WriteLine("You died");
                spawn = false;
                return;
            }
            else
            {
                return;
            }
        }
        
        public Combat(Knight Player, Mob Mob_)
        {
            player = Player;
            mob = Mob_;
        }
    }
}
