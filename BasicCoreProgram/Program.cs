using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
   
    internal class Program
    {
        static void vowelOrConsonant(char x)
        {
            if (x == 'a' || x == 'e' || x == 'i' ||
                              x == 'o' || x == 'u')
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter an alphabet");
            char x = char.Parse(Console.ReadLine());
            vowelOrConsonant(x);
            Console.ReadLine();
        }
    }
}
