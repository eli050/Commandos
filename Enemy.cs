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
        private static EnemyFactory Show = null;
        private EnemyFactory()
        {

        }
        public static EnemyFactory Constructor()
        {
            if (Show == null)
            {
                Show = new EnemyFactory();
            }
            return Show;
        }
        public static Enemy StartShowOfEnemy(string Name, string Status)
        {
            Enemy Show = new Enemy(Name, Status);
            _AddingShow(Show);
            return Show;
        }
        private static void _AddingShow(Enemy enemy)
        {
            EnemyShows.Add(enemy);
        }

    }
}
