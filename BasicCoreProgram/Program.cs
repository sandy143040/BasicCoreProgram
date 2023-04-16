using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Program
    {
        static double nthHarmonic(int N)
        {
            // H1 = 1
            float harmonic = 1;

            // loop to apply the formula
            // Hn = H1 + H2 + H3 ... +
            // Hn-1 + Hn-1 + 1/n
            for (int i = 2; i <= N; i++)
            {
                harmonic += (float)1 / i;
            }

            return harmonic;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Value:");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.Write(nthHarmonic(input));
            Console.ReadLine();
        }
    }
}
