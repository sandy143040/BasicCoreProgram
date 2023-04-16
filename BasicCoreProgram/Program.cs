using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class CoinFlipper
    {
        private int numFlips;
        private int numHeads;
        private int numTails;

        public CoinFlipper(int numFlips)
        {
            if (numFlips <= 0)
            {
                throw new ArgumentException("Number of flips must be a positive integer");
            }
            this.numFlips = numFlips;
            this.numHeads = 0;
            this.numTails = 0;
        }

        public void FlipCoin()
        {
            Random rand = new Random();
            for (int i = 0; i < numFlips; i++)
            {
                if (rand.NextDouble() < 0.5)
                {
                    numHeads++;
                }
                else
                {
                    numTails++;
                }
            }
        }

        public void PrintPercentage()
        {
            double percentHeads = ((double)numHeads / numFlips) * 100;
            double percentTails = ((double)numTails / numFlips) * 100;
            Console.WriteLine("Percentage of Heads: " + percentHeads.ToString("F2") + "%");
            Console.WriteLine("Percentage of Tails: " + percentTails.ToString("F2") + "%");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Functional Programming");
            Console.WriteLine("Please Enter Value");
            int numFlips = Convert.ToInt32(Console.ReadLine());
            CoinFlipper flipper = new CoinFlipper(numFlips);
            flipper.FlipCoin();
            flipper.PrintPercentage();
            Console.ReadLine();
        }
    }
}
