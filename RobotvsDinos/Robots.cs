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
            int damageDealt = (weapons.AttackPower);

            //Reduce Dino Health
            dinos.Health = damageDealt;
            if (dinos.Health < 0)
            {
                dinos.Health = 0;
            }
        }

    }
}
