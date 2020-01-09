using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Robot
    {
        //member variable
        public string name;
        public double health;
        public double powerLevel;
        public double attackPower;
        public string weapon;

        //constructor
        public Robot(string newName)
        {
            name = newName;
            health = 100; //out of 100
            powerLevel = 50; //out of 50
            attackPower = 2000;
            weapon = null;
        }
        //member method
    }
}
