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
          
            fleet = 
        }
        //member method

        
         public void SelectRobot()


        {
            Console.WriteLine("Welcome to Robots vs Dinosaurs");
            Console.WriteLine("In this game you will play as a Robot");
            Console.WriteLine("Please select a Robot");
            Console.WriteLine("1) C3PO, 2) R2D2, 3) T-1000");
            string character = Console.ReadLine();

            switch (character)
            {
                case "C3PO":
                    //" ";
                    Console.WriteLine("You have selected: " + character);
                    break;

                case "R2D2":
                    //" ";
                    Console.WriteLine("You have selected: " + character);
                    break;

                case "T-1000":
                    //" ";
                    Console.WriteLine("You have selected: " + character);
                    break;

                default:
                    Console.WriteLine("Incorrect character, please try again.");
                    SelectRobot();                   
                    break;
                    
            }
            Console.ReadLine();
        }






    }
    //Console.WriteLine("Please select a Dinosaur");
    //Console.WriteLine("1) T-Rex, 2) Spinosaurus, 3) Triceratops");
    //Console.ReadLine();

}
