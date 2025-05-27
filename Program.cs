using Commandos.Entities;
using System;
namespace Commandos
{
    class Program
    {
        static void Main()
        {
            string[] tools = new string[] { "Hammer", "chisel", "rope", "bag", "waterbottle" };
            List<Commando> commando = new List<Commando>()
            {
                new Commando("eli","ZXSD4",tools),
                new AirCommando("eli","ZXSD4",tools),
                new SeaCommando("eli","ZXSD4",tools)
            };
            foreach (Commando commando1 in commando)
            {
                commando1.Attack();
            }
        }
    }
}