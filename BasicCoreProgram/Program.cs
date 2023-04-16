using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{

    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide an argument for N.");
                return;
            }

            int n;
            if (!Int32.TryParse(args[0], out n))
            {
                Console.WriteLine("Invalid input for N. Please enter an integer between 0 and 30.");
                return;
            }

            if (n < 0 || n > 30)
            {
                Console.WriteLine("N should be between 0 and 30 inclusive.");
                return;
            }

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("2^{0} = {1}", i, (int)Math.Pow(2, i));
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
