using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Entities
{
    public class Commando
    {
        protected string name;
        public string codeName { get; set;}
        protected string[] tools = new string[5];
        protected string status;
        public Commando(string Name , string Codename,string[] Tools,string Status = "")
        {
            name = Name;
            codeName = Codename;
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
        public virtual void Attack()
        {
            status = "attack";
            Console.WriteLine($"The commando soldier with the code name {codeName} is attacking.");
        }
        public void SayName(string commanderRank)
        {
            if (commanderRank == "GENERAL")
            {
                Console.WriteLine(name);
            }
            else if (commanderRank == "COLONEL")
            {
                Console.WriteLine(codeName);
            }
            else
            {
                Console.WriteLine("You do not have permission to access that name.");
            }
        }
     
    }
    public class AirCommando : Commando
    {
        public AirCommando(string Name, string Codename, string[] Tools, string Status = ""):
            base(Name, Codename, Tools, Status)
        {

        }
        //Prints something about parachuting
        public void Parachuting()
        {
            Console.WriteLine("I'm falling!!!!!");
        }
        //Prints to the console that a command
        //with code name X is valid.
        public override void Attack()
        {
            status = "attack";
            Console.WriteLine($"Air commando soldier with the code name {codeName} attacks!");
        }
    }
    public class SeaCommando : Commando
    {
        public SeaCommando(string Name, string Codename, string[] Tools, string Status = "") :
            base(Name, Codename, Tools, Status)
        {

        }
        // Prints something about swimming
        public void Swimming()
        {
            Console.WriteLine("I'm swimming in the sea!!!!!");
        }
        //Prints to the console that a command
        //with code name X is valid.
        public override void Attack()
        {
            status = "attack";
            Console.WriteLine($"Sea commando with the code name {codeName} attacking!");
        }
    }

}
