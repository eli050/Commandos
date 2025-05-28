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
    public class WeaponFactory
    {
        public static List<Weapon> WeaponShows = new List<Weapon>();
        private static WeaponFactory? Show = null;
        private WeaponFactory()
        {

        }
        public static WeaponFactory Constructor()
        {
            if (Show == null)
            {
                Show = new WeaponFactory();
            }
            return Show;
        }
        public void CreatingInstanceses(int amount, string type)
        {
            switch (type)
            {
                case "Weapon":
                    for (int i = 0; i < amount; i++)
                    {
                        _AddingShow(_ReceivingWValues());
                    }
                    break;
            }

        }
        private static Weapon _ReceivingWValues()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Enter manufacturer name: ");
            string manufacturerName = Console.ReadLine()!;
            Console.WriteLine("Enter amount of bullets");
            int amount = int.Parse(Console.ReadLine()!);
            Weapon show = _StartShowOfWeapon(name, manufacturerName,amount);
            return show;
        }
        private static Weapon _StartShowOfWeapon(string Name,
            string ManufacturerName, int AmountOfBullets)
        {
            Weapon Show = new Weapon(Name, ManufacturerName, AmountOfBullets);
            return Show;
        }
        private static void _AddingShow(Weapon weapon)
        {
            WeaponShows.Add(weapon);
        }

    }
}


