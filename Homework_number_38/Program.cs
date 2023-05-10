using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int damage = 100;
            int armour = 100;

            Hero hero = new Hero(health, damage, armour);

            hero.ShowHeroInfo();
        }
    }

    class Hero
    {
        private int _health;
        private int _damage;
        private int _armour;

        public Hero(int health, int damage, int armour)
        {
            _health = health;
            _damage = damage;
            _armour = armour;
        }

        public void ShowHeroInfo()
        {
            Console.WriteLine($"XP -{_health} DM -{_damage} AR - {_armour}");
        }
    }
}
