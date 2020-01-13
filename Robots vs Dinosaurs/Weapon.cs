using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Weapon
    {
        //Member Variables
        public string weaponType;
        public double attackPower;

   


        //Constructor
        public Weapon(string newWeapon, double newAttackPower)
        {
            weaponType = newWeapon;
            attackPower = newAttackPower;

            
        }
        //Member Methods
    }
}
