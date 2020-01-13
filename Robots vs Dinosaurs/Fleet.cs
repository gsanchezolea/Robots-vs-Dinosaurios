using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Fleet
    {
        //Member Variable        
        public List<Robot> ListOfRobots = new List<Robot>();

        public bool FleetAlive;

        //Constructor
        public Fleet()
        {
            FleetAlive = true;

            Weapon weaponZapper = new Weapon("Tazer", 40);
            Weapon atomBlaster = new Weapon("Plasma Gun", 40);
            Weapon liquidKnife = new Weapon("Knife", 40);

            Robot robotOne = new Robot("C-3PO", 1000, 50, atomBlaster);
            Robot robotTwo = new Robot("R2-D2", 1000, 50, weaponZapper);
            Robot robotThree = new Robot("T-1000", 1000, 50, liquidKnife);

            ListOfRobots.Add(robotOne);
            ListOfRobots.Add(robotTwo);
            ListOfRobots.Add(robotThree);
        }

        //Member Method
        public bool FleetLifeStatus()
        {
            if (ListOfRobots[0].robotAlive || ListOfRobots[1].robotAlive || ListOfRobots[2].robotAlive)
            {
                bool result;
                FleetAlive = true;
                result = FleetAlive;
                return result;
            }
            else
            {
                bool result;
                FleetAlive = false;
                result = FleetAlive;
                return result;
            }
        }      
    }
}
