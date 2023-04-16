using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Program
    {
        public static void primeFactors(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write("{0} ", i);
                    n /= i;
                }
            }
            if (n > 1)
            {
                Console.Write("{0} ", n);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number to find its prime factors: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            primeFactors(n);
            
            Console.ReadLine();
        }
    }
}
