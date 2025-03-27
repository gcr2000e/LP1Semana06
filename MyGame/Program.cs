using System;
using System.Threading.Tasks.Dataflow;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
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

        private static void Main(string[] args)
        {
            int numEnemies = int.Parse(args[0]);
            Enemy[] enemies = new Enemy[numEnemies];

            for (int i = 0; i < numEnemies; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string name = Console.ReadLine();
                enemies[i] = new Enemy(name, 100, 0);
            }

            foreach (var enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
            }
        }
    }
}
