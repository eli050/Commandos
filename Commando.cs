using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
    public class CommandoFactory
    {
        public static List<Commando> instansShow = new List<Commando>();
        private static CommandoFactory? initInstans = null;
        private CommandoFactory()
        {
           
        }
        public static CommandoFactory Constructor()
        {
            if (initInstans == null)
            {
                initInstans = new CommandoFactory();
            }
            return initInstans;
        }
        public void CreatingInstanceses(int amount, string type)
        {
            switch (type)
            {
                case "Commando":
                    for (int _ = 0; _ < amount; _++)
                    {
                        _AddingShow(_ReceivingCValues());
                    }
                    break;
                case "SeaCommando":
                    for (int _ = 0; _ < amount; _++)
                    {
                        SeaCommando seaCommando = (SeaCommando)_ReceivingCValues();
                        _AddingShow(seaCommando);
                    }
                    break;
                case "AirCommando":
                    for (int _ = 0; _ < amount; _++)
                    {
                        AirCommando seaCommando = (AirCommando)_ReceivingCValues();
                        _AddingShow(seaCommando);
                    }
                    break;


            }

        }
        private static Commando _ReceivingCValues()
        {
            List<string> tools = new List<string>();
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Enter code name");
            string codeName = Console.ReadLine()!;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"Enter tool number {i}: ");
                string tool = Console.ReadLine()!;
                tools.Add(tool);
            }
            Console.WriteLine("Enter status: (Optional, if you don't want to press Enter)");
            string status = Console.ReadLine()!;
            Commando commando = _StartShowOfCommando(name, codeName, tools.ToArray(),status);
            return commando;
            
        }
        private static Commando _StartShowOfCommando(string name, string codeName,
            string[] tools, string status = "")
        {
            Commando commando = new Commando(name, codeName, tools, status);
            return commando;

        }
        private static void _AddingShow(Commando show)
        {
            instansShow.Add(show);
        }
    }

}
