using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class SwapNumbers
    {
        private int num1;
        private int num2;

        public void Swap()
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public void SetNumbers(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public void ShowNumbers()
        {
            Console.WriteLine($"After swapping: {num1}, {num2}");
        }
    }
    internal class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            SwapNumbers swap = new SwapNumbers();
            swap.SetNumbers(num1, num2);
            swap.Swap();
            swap.ShowNumbers();
            Console.ReadLine();
        }
    }
}
