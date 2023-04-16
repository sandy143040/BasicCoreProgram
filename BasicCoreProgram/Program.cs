using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
   
    internal class Program
    {
        public static int GetLargest(int a, int b, int c)
        {
            if (a > b && a > c)
                return a;
            else if (b > a && b > c)
                return b;
            else
                return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers:");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int largest = GetLargest(num1, num2, num3);

            Console.WriteLine("The largest number is {0}", largest);
            Console.ReadLine();
        }
    }
}
