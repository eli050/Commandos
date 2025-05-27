using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Entities
{
    public class Weapon
    {
        public string name;
        public string manufacturerName;
        public int amountOfBullets;
        public Weapon(string Name,
            string ManufacturerName , int AmountOfBullets)
        {
            name = Name;
            manufacturerName = ManufacturerName;
            amountOfBullets = AmountOfBullets;
        }
        //Prints a shot and reduces one bullet
        public void Shoot()
        {
            amountOfBullets -= 1;
            Console.WriteLine("A shot was fired.");
        }
    }
}
