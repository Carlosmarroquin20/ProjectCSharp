using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise2
{
    internal class Odd_EvenChecker
    {
        public static void Run()
        {
            int num1 = 10;
            int num2 = 2;
            int remainder = num1 % num2;
            Console.WriteLine(remainder);

            num1 = 11;
            remainder = num1 % num2;
            Console.WriteLine(remainder);


            Console.ReadLine();
        }
    }
}
