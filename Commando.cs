using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Entities
{
    public class Commando
    {
        public string name;
        public string nameCode;
        public string[] tools = new string[5];
        public string status;
        public Commando(string Name , string NameCode,string Status, string[] Tools)
        {
            name = Name;
            nameCode = NameCode;
            status = Status;
            tools = Tools;
            
        }
        //Prints to the consul that the soldier is leaving
        public void Walk()
        {
            status = "walk";
            Console.WriteLine("The commando soldier is walking.");
        }
        //Prints to the consul that the soldier is hiding
        public void Hide()
        {
            status = "hide";
            Console.WriteLine("The commando soldier is hiding.");
        }
        //Prints to the console that a command
        //with code name X is valid.
        public void Attack()
        {
            status = "attack";
            Console.WriteLine($"The commando soldier with the code name {nameCode} is attacking.");
        }
     
    }

}
