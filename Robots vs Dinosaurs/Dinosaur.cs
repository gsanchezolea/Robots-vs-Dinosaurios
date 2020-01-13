using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Dinosaur
    {
        //Member Variable
        public string dinosaurType; 
        public double dinosaurHealth;
        public double dinosaurEnergy;
        public double dinosaurAttackPower;
        public bool dinosaurAlive;      

        //Constructor
        public Dinosaur(string newDinoType, double newHealth, double newEnergy, double newAttackPower)
        {
            dinosaurType = newDinoType;
            dinosaurHealth = newHealth;
            dinosaurEnergy = newEnergy;
            dinosaurAttackPower = newAttackPower;
            dinosaurAlive = true;            
        }

        //Member Method        
        public double DinosaurAttack()
        {
            double result;
            double randomizedNumber;
            Random random = new Random();
            randomizedNumber = random.Next(0, 6);
            result = randomizedNumber * dinosaurEnergy * dinosaurAttackPower;
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
