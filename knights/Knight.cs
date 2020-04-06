using System;
namespace knights
{
    public class Knight
    {
        int hp { get; set; }
        int atk { get; set; } 
        int agi { get; set; }
        int luck { get; set; }
        bool WeaponIsEquipped { get; set; }
        string[] shout = new string[4] { "For honor!", "Die, scoundrel!", "Raaagh!", "Harraaaah!" }; 
        //Random rand = new Random(4);
        protected string DoShout(Random rand)
            {
                return shout[rand.Next(0, 4)];
            }
        protected virtual void Special()
            { 
                hp += 4;
            }
        public void EquipWeapon(Weapon weap)
        {
            WeaponIsEquipped = true;
            atk += weap.atk;
            Console.WriteLine(@"Such a trusty {weap.name} I have found!");
        }
        /*public void DoAttack(Mob target)
        {
            WeaponIsEquipped ? 
        }*/
        public Knight()
        {
            hp = 80;
            atk = 5;
            agi = 5;
            luck = 5;
        }
    }
}
