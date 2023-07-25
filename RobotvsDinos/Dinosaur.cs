using System;
namespace RobotvsDinos
{
	public class Dinosaur
	{
        //HAS A
        public string Name;
        public int Health;
        public int AttackPower;
        
        //Constructor
        public Dinosaur()
        {
            this.Name = "Grimlock";
            this.Health = 100;
            this.AttackPower = 25;
        }
        //CAN DO
        public void AttackRobot(Robot robot)
        {
            //attack Robot
            int damageDealt = this.AttackPower;

            //Reduce Robot Health
            robot.Health -= damageDealt;

            //Check if health is less than or equal to zero
            if (robot.Health <= 0)
            {
                robot.Health = 0;
            }
        }
    }
}

