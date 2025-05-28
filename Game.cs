using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Entities
{
    public static class Game
    {
        public static void InitGame()
        {
            List<EnemyFactory> enemyFactories = new List<EnemyFactory>();
            List<WeaponFactory> weaponFactories = new List<WeaponFactory>();
            List<CommandoFactory> commandoFactories = new List<CommandoFactory>();
            List<int> numbers = new List<int>() { 1, 2, 4, 7, 12, 3, 13, 8, 10, 5, 6, 9 };
            List<string> typesOfEnemy = new List<string>() { "Enemy" };
            List<string> typeOfWeapon = new List<string>() { "Weapon" };
            List<string> typeOfCommando = new List<string>() { "Commando", "SeaCommando", "AirCommando" };
            Random random = new Random();
            EnemyFactory enemyFactory =  EnemyFactory.Constructor();
            enemyFactory.CreatingInstanceses(numbers[random.Next(numbers.Count)],typeOfWeapon[random.Next(numbers.Count)]);
            enemyFactories.Add(enemyFactory);
            WeaponFactory weaponFactory = WeaponFactory.Constructor();
            weaponFactory.CreatingInstanceses(numbers[random.Next(numbers.Count)], typeOfWeapon[random.Next(numbers.Count)]);
            weaponFactories.Add(weaponFactory);
            CommandoFactory commandoFactory = CommandoFactory.Constructor();
            commandoFactory.CreatingInstanceses(numbers[random.Next(numbers.Count)], typeOfCommando[random.Next(numbers.Count)]);
            commandoFactories.Add(commandoFactory);

        }
    }
}
