using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class EvenOrOddNumbers
    {
        public static string FindEvenOrOdd(int number)
        {
            if (number % 2 == 0)
                return "Given number is even number";
            else
                return "Given number is odd number";
        }
    }
    internal class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer number to find even or odd");
            int input = Convert.ToInt32(Console.ReadLine());
            string res = EvenOrOddNumbers.FindEvenOrOdd(input);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
