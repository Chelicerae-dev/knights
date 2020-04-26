using System;
namespace knights
{
    public class Knight
    {
        public int hp { get; set; }
        public int MaxHp { get; set; }
        public int atk { get; set; }
        public double agi { get; set; }
        public double luck { get; set; }
        public int WeapDurability { get; set; }
        public bool WeaponIsEquipped { get; set; }
        public double Crit { get; set; }
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
            Console.WriteLine($"Such a trusty {weap.name} I have found!");
            WeapDurability = weap.durability;
            atk += weap.atk;
            agi -= weap.weight / (luck / 2);

        }
        public void UnequipWeapon(Weapon weap, string reason)
        {
            atk -= weap.atk;
            WeaponIsEquipped = false;
            switch (reason)
            {
                case "broken":
                    Console.WriteLine($"{weap.name} has broken and no longer equipped.");
                    break;
                case "unequipped":
                    Console.WriteLine($"{weap.name} unequipped.");
                    break;
            }
        }
        
    /*public void DoAttack(Mob target)
    {
        WeaponIsEquipped ? 
    }*/
    public Knight()
        {
            Crit = 0.15;
            hp = 120;
            MaxHp = 120;
            atk = 15;
            agi = 20;
            luck = 10;
        }
    }
}
