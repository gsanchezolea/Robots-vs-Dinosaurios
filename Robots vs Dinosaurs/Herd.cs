using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Herd
    {
        //Member Variable      
        public List<Dinosaur> ListOfDinosaurs = new List<Dinosaur>();

        public bool HerdAlive;
        
        //Constructor
        public Herd()
        {
            HerdAlive = true;
            
            Dinosaur dinoOne = new Dinosaur("T-Rex", 1000, 50, 40);
            Dinosaur dinoTwo = new Dinosaur("Spinosaurus", 1000, 50, 40);
            Dinosaur dinoThree = new Dinosaur("Triceratops", 1000, 50, 40);
            
            ListOfDinosaurs.Add(dinoOne);
            ListOfDinosaurs.Add(dinoTwo);
            ListOfDinosaurs.Add(dinoThree);            
        }
        //Member Method
        public bool HerdLifeStatus()
        {
            if (ListOfDinosaurs[0].dinosaurAlive || ListOfDinosaurs[1].dinosaurAlive || ListOfDinosaurs[2].dinosaurAlive)
            {
                bool result;
                HerdAlive = true;
                result = HerdAlive;
                return result;
            }
            else
            {
                bool result;
                HerdAlive = false;
                result = HerdAlive;
                return result;
            }
        }      
    }
}
