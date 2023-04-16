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
            int dividend, divisor, quotient, remainder;

            Console.WriteLine("Enter dividend: ");
            dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter divisor: ");
            divisor = int.Parse(Console.ReadLine());

            quotient = dividend / divisor;
            remainder = dividend % divisor;

            Console.WriteLine($"Quotient = {quotient}");
            Console.WriteLine($"Remainder = {remainder}");
            Console.ReadLine();
        }
    }
}
