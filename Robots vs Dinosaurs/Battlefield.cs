using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Battlefield
    {
        Fleet fleet;
        Herd herd;

        


        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
            

        }
        //member method
        public void SelectRobot()


        {

            Console.WriteLine("Please select a Robot to Attack " + herd.ListOfDinosaurs[0].dinoType + " with.");
            Console.WriteLine("1) C3PO, 2) R2D2, 3) T-1000");
            string character = Console.ReadLine();

            switch (character)
            {

                case "C3PO":
                    Console.WriteLine("You have selected: " + fleet.ListOfRobots[0].robotName);                   
                    herd.ListOfDinosaurs[0].dinoHealth -= fleet.ListOfRobots[0].RobotAttack();
                    
                    break;

                case "R2D2":                  
                    Console.WriteLine("You have selected: " + fleet.ListOfRobots[1].robotName);
                    herd.ListOfDinosaurs[0].dinoHealth -= fleet.ListOfRobots[1].RobotAttack();
                    break;

                case "T-1000":                    
                    Console.WriteLine("You have selected: " + fleet.ListOfRobots[2]);
                    herd.ListOfDinosaurs[0].dinoHealth -= fleet.ListOfRobots[2].RobotAttack();
                    break;

                default:
                    Console.WriteLine("Incorrect character, please try again.");
                    SelectRobot();
                    break;

            }

            SelectDino();
        }
        public void SelectDino()


        {

            Console.WriteLine("Please select a Dinosaur to Attack " + fleet.ListOfRobots[0].robotName + " with.");
            Console.WriteLine("1) T-Rex, 2) Spinosaurus, 3) Triceratops");
            string character = Console.ReadLine();

            switch (character)
            {
                case "T-Rex":
                    Console.WriteLine("You have selected: " + herd.ListOfDinosaurs[0].dinoType);
                    fleet.ListOfRobots[0].robotHealth -= herd.ListOfDinosaurs[0].DinoAttack();

                    
                    break;

                case "Spinosaurus":
                    Console.WriteLine("You have selected: " + herd.ListOfDinosaurs[1].dinoType);
                    fleet.ListOfRobots[0].robotHealth -= herd.ListOfDinosaurs[1].DinoAttack();
                   
                    break;

                case "Triceratops":
                    Console.WriteLine("You have selected: " + herd.ListOfDinosaurs[2].dinoType);
                    fleet.ListOfRobots[0].robotHealth -= herd.ListOfDinosaurs[2].DinoAttack();
                    
                    break;

                default:
                    Console.WriteLine("Incorrect character, please try again.");
                    SelectDino();
                    break;
            }
         
        }

        public void RunGame()
        {
            Console.WriteLine("Welcome to Robots vs Dinosaurs");
            Console.WriteLine("Click Enter to Run Game");
            Console.ReadLine();
            SelectRobot();   

        }

        public void robotShowStats()
        {
            //Console.Write("Current Stats");
            //Console.WriteLine(
            //Console.WriteLine(fleet.ListOfRobots[].robotHealth));
            //Console.WriteLine("Press any key to continue");
            //Console.ReadLine();
        }

    }

}
