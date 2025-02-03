using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO
{
    internal class Input_Ouput
    {
        public static void Run() 
        {
            Console.WriteLine("Hello my name is Ema");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            var age = Console.ReadLine();

            Console.WriteLine("Mi name is: " + name + " and my age is: " + age);


            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
