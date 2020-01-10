using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Robot
    {
        //member variable
        public string robotName;
        public double robotHealth;
        public double robotPowerLevel;
        public Weapon weapon;      

        //constructor
        public Robot(string newName, double newHealth, double newPowerLevel, Weapon newWeapon)
        {
            robotName = newName;
            robotHealth = newHealth;
            robotPowerLevel = newPowerLevel;
            weapon = newWeapon;
        }
        //member method

        //public double robotAttack()
        public double RobotAttack()
        {
            double result;
            double randomizedNumber;
            Random random = new Random();
            randomizedNumber = random.Next(0, 6);
            result = randomizedNumber * robotPowerLevel * weapon.attackPower;
            Console.WriteLine("You have caused " + result + " HP damage.");
            return result;
        }

        //public double robotShowHealth()
        //{
            
        //    Console.WriteLine("This is the current health of "  )
        //}

    }
}
