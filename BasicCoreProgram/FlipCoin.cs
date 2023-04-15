using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class Coin
    {
        private int numFlips;
        private int heads;
        private int tails;

        public Coin(int numFlips)
        {
            this.numFlips = numFlips;
            this.heads = 0;
            this.tails = 0;
        }

        public void Flip()
        {
            Random rand = new Random();

            for (int i = 0; i < numFlips; i++)
            {
                if (rand.NextDouble() < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }
        }

        public void PrintPercentages()
        {
            double headsPercentage = (double)heads / numFlips * 100;
            double tailsPercentage = (double)tails / numFlips * 100;

            Console.WriteLine($"Heads: {headsPercentage}%");
            Console.WriteLine($"Tails: {tailsPercentage}%");
        }
    }

    internal class FlipCoin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of times to flip the coin:");
            int numFlips = Convert.ToInt32(Console.ReadLine());

            Coin coin = new Coin(numFlips);
            coin.Flip();
            coin.PrintPercentages();
            Console.ReadLine();
        }
    }
}
