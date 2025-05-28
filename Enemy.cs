using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Entities
{
    public class Enemy 
    {
        public string name;
        public static int life = 100;
        public string status;
        public Enemy(string Name, string Status)
        {
            name = Name;
            status = Status;
        }
        public void Shout()
        {
            Console.WriteLine("I am ENEMY!!!!!😈");
        }
    }
    public class EnemyFactory
    {
        public static List<Enemy> EnemyShows = new List<Enemy>();
        private static EnemyFactory? show = null;
        private EnemyFactory()
        {

        }
        public static EnemyFactory Constructor()
        {
            if (show == null)
            {
                show = new EnemyFactory();
            }
            return show;
        }
        public static void CreatingInstanceses(int amount, string type)
        { 
            switch (type)
            {
                case "Enemy":
                    for (int i = 0; i < amount; i++)
                    {
                        _AddingShow(_ReceivingEValues());
                    }
                    break;
            }

        }
        private static Enemy _ReceivingEValues()
        {
            Console.WriteLine("enter name: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("enter status: ");
            string status = Console.ReadLine()!;
            Enemy show = _StartShowOfEnemy(name, status);
            return show;
        }
        private static Enemy _StartShowOfEnemy(string Name, string Status)
        {
            Enemy Show = new Enemy(Name, Status);
            return Show;
        }
        private static void _AddingShow(Enemy enemy)
        {
            EnemyShows.Add(enemy);
        }

    }
}
