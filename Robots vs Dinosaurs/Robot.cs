using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Robot
    {
        //Member Variable
        public string robotName;
        public double robotHealth;
        public double robotPowerLevel;
        public Weapon weapon;
        public bool robotAlive;

        //Constructor
        public Robot(string newName, double newHealth, double newPowerLevel, Weapon newWeapon)
        {
            robotName = newName;
            robotHealth = newHealth;
            robotPowerLevel = newPowerLevel;
            weapon = newWeapon;
            robotAlive = true;
        }

        //Member Method        
        public double RobotAttack()
        {
            double result;
            double randomizedNumber;

            Random random = new Random();
            randomizedNumber = random.Next(0, 6);
            result = randomizedNumber * robotPowerLevel * weapon.attackPower;
            if (randomizedNumber == 0)
            {
                Console.WriteLine("Missed!");
            }
            else
            {
                Console.WriteLine("You have caused " + result + " HP damage.");                
            }
            return result;
        }        
    }
}
