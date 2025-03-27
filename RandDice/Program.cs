using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int seed = int.Parse(args[1]);

            Random rand = new Random(seed);
            int soma = 0;

            for(int i = 0; i < n; i++)
            {
                 soma += rand.Next(1, 7);
            }

            Console.WriteLine(soma);     
        }
    }
}
