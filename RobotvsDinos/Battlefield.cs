using System;
using System.Xml.Linq;

namespace RobotvsDinos
{
    public class Battlefield
    {
        //Member Variables
        Robots robots;
        Dinos dinos;
        Weapons weapons;

        //Constructor
        public Battlefield()
        {
            dinos = new Dinos();
            robots = new Robots();
            weapons = new Weapons();

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
            if (dinos.Health <= 0)
            {
                Console.WriteLine($"{robots.Name} Wins!");
            }
            else if (robots.Health <= 0)
            {
                Console.WriteLine($"{dinos.Name} Wins!");
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



            //int dinoStrike = dinos.AttackRobot(dinos.AttackPower);
            //int botStrike = robots.AttackDino(Weapons weapons);


            while (dinos.Health > 0 && robots.Health > 0)
            {
                //Dino Attacks
                dinos.AttackRobot(robots);

                //Display Dino name attacking Robot name
                Console.WriteLine($"{dinos.Name} hits {robots.Name} for {dinos.AttackPower}\n");

                //Reduce Robot Health
                //if ()
                //{

                //}

                //Robot Attacks
                robots.AttackDino(dinos);

                //Display Robot name attacking Dino name
                Console.WriteLine($"{robots.Name} hits {dinos.Name} with {weapons.Name} for {robots.weapons.AttackPower}\n");

                //Reduce Dino Health

                DisplayWinner();

            }

             
        }
    }
}
        

            