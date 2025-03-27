using System;
using System.Threading.Tasks.Dataflow;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public enum PowerUp
        {
            Health,
            Shield
        }
        public Enemy(string name, float health, float shield)
        {
            SetName(name);
            this.health = health;
            this.shield = shield;
        }

        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void SetName(string newName)
        {
            if (newName.Length > 8)
            {
                newName = newName.Substring(0, 8);
            }
            name = newName;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp powerUp, float value)
        {
            if (powerUp == PowerUp.Health)
            {
                health += value;
                if (health > 100) health = 100;
            }
            else if (powerUp == PowerUp.Shield)
            {
                shield += value;
                if (shield > 100) shield = 100;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{name} {health} {shield}");
        }

        private static void Main(string[] args)
        {
            //int numEnemies = int.Parse(args[0]);
            //Enemy[] enemies = new Enemy[numEnemies];

            //for (int i = 0; i < numEnemies; i++)
            //{
                //Console.Write($"Nome do inimigo {i + 1}: ");
                //string name = Console.ReadLine();
                //enemies[i] = new Enemy(name, 100, 0);
           // }

            //foreach (var enemy in enemies)
            //{
                //Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
            //}

            Enemy enemy1 = new Enemy("Darth Vader", 100, 0);
            Enemy enemy2 = new Enemy("Khan Noonien Singh", 100, 0);

            enemy1.DisplayInfo();
            enemy2.DisplayInfo();

            enemy1.PickupPowerUp(PowerUp.Health, 20);
            enemy2.PickupPowerUp(PowerUp.Shield, 50);
            enemy1.DisplayInfo();
            enemy2.DisplayInfo();

            enemy1.PickupPowerUp(PowerUp.Health, 100); 
            enemy1.DisplayInfo();
            enemy2.PickupPowerUp(PowerUp.Shield, 60);
            enemy2.DisplayInfo();
        }
    }
}
