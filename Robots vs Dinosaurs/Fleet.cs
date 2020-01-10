using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Fleet
    {
        //member variable
        List<Robot> listOfRobots = new List<Robot>();



        //constructor
        public Fleet()
        {
            // Weapon Instantiation

            Weapon weaponZapper = new Weapon("Tazer", 20);
            Weapon atomBlaster = new Weapon("Plasma Gun", 20);
            Weapon liquidKnife = new Weapon("Knife", 20);

            //Instatiated Objects
            //
            Robot robotOne = new Robot("C3P0", 75, 65, atomBlaster);
            Robot robotTwo = new Robot("R2D2", 80, 75, weaponZapper);
            Robot robotThree = new Robot("T-1000", 80, 75, liquidKnife);

            //Adding Objects to List

            listOfRobots.Add(robotOne);
            listOfRobots.Add(robotTwo);
            listOfRobots.Add(robotThree);



        }
        



        //member method
    }
}
