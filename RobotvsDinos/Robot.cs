using System;
namespace RobotvsDinos
{
    public class Robot
    {

        //HAS A
        public string Name;
        public int Health;
        public Weapon weapon;

        //Constructor
        public Robot()
        {
            this.Name = "Voltron";
            this.Health = 100;
            weapon = new Weapon();
        }

        //CAN DO
        public void AttackDino(Dinosaur dinosaur)
        {
            //attack Dino
            int damageDealt = this.weapon.WeaponPower;

            //Reduce Dino Health
            dinosaur.Health -= damageDealt;

            //Check if health is less than or equal to zero
            if (dinosaur.Health <= 0)
            {
                dinosaur.Health = 0;
            }
        }

    }
}
