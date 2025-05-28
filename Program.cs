using Commandos.Entities;
using System;
namespace Commandos
{
    class Program
    {
        static void Main()
        {
            CommandoFactory test = CommandoFactory.Constructor();
            test.CreatingInstanceses(2, "Commando");
            foreach(Commando commando in CommandoFactory.instansShow)
            {
                commando.Attack();
            }
        }
    }
}