using Commandos.Entities;
using System;
namespace Commandos
{
    class Program
    {
        static void Main()
        {
            string[] tools = new string[] { "Hammer", "chisel", "rope", "bag", "waterbottle" };
            Commando commando = new Commando("eli", "XDE123", "walk", tools);
            Weapon weapon = new Weapon("gun", "Zastava Arms", 12);
            Console.WriteLine(commando.name);
            Console.WriteLine(commando.nameCode);
            Console.WriteLine(commando.status);
            foreach(string tool in commando.tools)
            {
                Console.WriteLine(tool);
            }
            Console.WriteLine(weapon.name);
            Console.WriteLine(weapon.manufacturerName);
            Console.WriteLine(weapon.amountOfBullets);
            commando.Walk();
            Console.WriteLine(commando.status);
            commando.Hide();
            Console.WriteLine(commando.status);
            commando.Attack();
            Console.WriteLine(commando.status);
            weapon.Shoot();
            Console.WriteLine(weapon.amountOfBullets);
            
        }
    }
}