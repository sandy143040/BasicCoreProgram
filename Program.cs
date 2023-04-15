using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class Program
    {
        static bool checkYear(int year)
        {
            // If a year is multiple of 400, 
            // then it is a leap year
            if (year % 400 == 0)
                return true;

            // Else If a year is multiple of 100,
            // then it is not a leap year
            if (year % 100 == 0)
                return false;

            // Else If a year is multiple of 4,
            // then it is a leap year
            if (year % 4 == 0)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Write(checkYear(input) ? "Leap Year" :
                                 "Not a Leap Year");
            Console.ReadLine();
        }
    }
}
