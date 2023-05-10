using System;

namespace Homework_number_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int damage = 100;
            int armor = 100;

            Hero hero = new Hero(health, damage, armor);

            hero.ShowHeroInfo();
        }
    }

    class Hero
    {
        private int _health;
        private int _damage;
        private int _armor;

        public Hero(int health, int damage, int armor)
        {
            _health = health;
            _damage = damage;
            _armor = armor;
        }

        public void ShowHeroInfo()
        {
            Console.WriteLine($"XP -{_health} DM -{_damage} AR - {_armour}");
        }
    }
}
