using System;
namespace RobotvsDinos
{
    public class Robots
    {

        //HAS A
        public string Name;
        public int Health;
        public Weapons weapons;

        //Constructor
        public Robots()
        {
            this.Name = "Voltron";
            this.Health = 100;
            weapons = new Weapons();
        }

        //CAN DO
        public void AttackDino(Dinos dinos)
        {
            //attack Dino
            int damageDealt = this.weapons.WeaponPower;

            //Reduce Dino Health
            dinos.Health -= damageDealt;

            //Check if health is less than or equal to zero
            if (dinos.Health <= 0)
            {
                dinos.Health = 0;
            }
        }

    }
}
