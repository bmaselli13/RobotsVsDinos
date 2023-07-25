using System;
using System.Xml.Linq;

namespace RobotvsDinos
{
    public class Battlefield
    {
        //Member Variables
        Robot robot;
        Dinosaur dinosaur;
        Weapon weapon;

        //Constructor
        public Battlefield()
        {
            dinosaur = new Dinosaur();
            robot = new Robot();
            weapon = new Weapon();

        }

        //Member Methods

        //Method for displaying Welcome Message
        public void DisplayWelcome()
        {
            Console.WriteLine($"Welcome to Arena! Where it's Prehistoric vs Futuristic!\n");
            Console.WriteLine("BEGIN!\n");
        }

        //Method to Display the winner!
        public void DisplayWinner()

        {
            if (dinosaur.Health <= 0)
            {
                Console.WriteLine($"{robot.Name} Wins!");
            }
            else if (robot.Health <= 0)
            {
                Console.WriteLine($"{dinosaur.Name} Wins!");
            }

        }




        //method RunGame which calls other methods in order
        public void RunGame()
        {
            DisplayWelcome();
            //Method to run Main Battle Sequence, allowing dinos and bots to attack each
            //other
            //Dinosaur to have the ability to attack a Robot on a Battlefield.
            //This attack method should lower a Robot’s health by the value of
            //the Dinosaur’s attackPower and inform the user of what happened.
            //Robot to have the ability to attack a Dinosaur on a Battlefield.
            //This attack method should lower the Dinosaur’s health by the value
            //of the attackPower of the Robot’s activeWeapon and inform the user
            //of what happened.
            //Battle to conclude once either the Robot or the Dinosaur has its
            //health points reduced to zero.

            while (dinosaur.Health > 0 && robot.Health > 0) 
            {
                //Dino Attacks
                dinosaur.AttackRobot(robot);

                //Display Dino name attacking Robot name
                Console.WriteLine($"{dinosaur.Name} hits {robot.Name} for {dinosaur.AttackPower} damage\n");
                Console.WriteLine($"{robot.Name} health is now at {robot.Health} points\n\n");

                if (robot.Health > 0)
                {
                    //Robot Attacks
                    robot.AttackDino(dinosaur);

                    //Display Robot name attacking Dino name
                    Console.WriteLine($"{robot.Name} hits {dinosaur.Name} with {weapon.Name} for {weapon.WeaponPower} damage\n");
                    Console.WriteLine($"{dinosaur.Name} health is now at {dinosaur.Health} points\n\n");
                }              

            }            

            DisplayWinner();

        }
    }
}
        

            