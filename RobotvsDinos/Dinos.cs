using System;
namespace RobotvsDinos
{
	public class Dinos
	{
        //HAS A
        public string Name;
        public int Health;
        public int AttackPower;
        
        //Constructor
        public Dinos()
        {
            this.Name = "Grimlock";
            this.Health = 100;
            this.AttackPower = 25;
        }
        //CAN DO
        public void AttackRobot(Robots robots)
        {
            //attack Robot
            int damageDealt = this.AttackPower;

            //Reduce Robot Health
            robots.Health -= damageDealt;

            //Check if health is less than or equal to zero
            if (robots.Health <= 0)
            {
                robots.Health = 0;
            }
        }
    }
}

