using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Herd
    {
        //member variable
        //Instatiated List
        public List<Dinosaur> ListOfDinosaurs = new List<Dinosaur>();         
        

        //constructor
        public Herd()
        {
            //Instatiated Objects
            //Data Type - Object - Constructor - (Dino Type, Max Val 100, Max Value 100, Max Val 10
            Dinosaur dinoOne = new Dinosaur("T-Rex", 10000, 90, 10);
            Dinosaur dinoTwo = new Dinosaur("Spinosaurus", 10000, 95, 8);
            Dinosaur dinoThree = new Dinosaur("Triceratops", 10000, 75, 7);

            //Adding Objects to List 
            ListOfDinosaurs.Add(dinoOne);
            ListOfDinosaurs.Add(dinoTwo);
            ListOfDinosaurs.Add(dinoThree);

            
        }



        //member method
    }
}
