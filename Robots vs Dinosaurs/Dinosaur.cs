using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Dinosaur
    {
        //member variable
        public string type; //types of dinosaurs include the following: Tyrannosaurus, Allosaurus, Triceratops, Stegosaurus, & Ankylosaurus
        public double health;
        public double energy;
        public double attackPower;

        //constructor
        public Dinosaur()
        {
            type = null;
            health = 80; //out of 100
            energy = 40; //out of 50
            attackPower = 1500; //out of 2000
        }


        //member method
    }
}
