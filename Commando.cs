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
        public void Walk()
        {

        }
        public void Hide()
        {

        }
        public void Attack()
        {

        }
        public void AddTools()
        {

        }

    }

}
