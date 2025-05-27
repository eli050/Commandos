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
        public static string[] tools = new string[5];
        public string status;
        public Commando(string Name , string NameCode,string Status)
        {
            name = Name;
            nameCode = NameCode;
            status = Status;
            
        }
        //Prints to the consul that the soldier is leaving
        public void Walk()
        {

        }
        //Prints to the consul that the soldier is hiding
        public void Hide()
        {

        }
        //Prints to the console that a command
        //with code name X is valid.
        public void Attack()
        {

        }
        //Adds tools to Commando
        public void AddTools()
        {

        }

    }

}
