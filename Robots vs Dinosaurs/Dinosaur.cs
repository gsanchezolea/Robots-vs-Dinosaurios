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
        public string dinorType; //types of dinosaurs include the following: Tyrannosaurus, Allosaurus, Triceratops, Stegosaurus, & Ankylosaurus
        public double dinoHealth;
        public double dinoEnergy;
        public double dinoAttackPower;


        //public double attackMove;


        //constructor
        public Dinosaur(string newDinoType, double newHealth, double newEnergy, double newAttackPower)
        {
            dinorType = newDinoType;
            dinoHealth = newHealth;
            dinoEnergy = newEnergy;
            dinoAttackPower = newAttackPower;

            //attackMove = newAttackMove;
        }
        //member method        
        public double DinoAttack()
        {
            double randomizedNumber;
            Random random = new Random();
            randomizedNumber = random.Next(0, 6);

            return randomizedNumber * dinoEnergy * dinoAttackPower;
        }

        //public double HealthLoss()
        //{
        //    double result;
            
        //}
        
    }
}
