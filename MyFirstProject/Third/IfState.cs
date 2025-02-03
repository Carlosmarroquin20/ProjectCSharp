using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class IfSate
    {
        public static void Run()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine("Mi name is: " + name + " and my age is: " + age);

            if (age <0 || age > 110)
            {
                Console.WriteLine("Invalid age");
            }
            else
            {
                if (age >= 18 && age <= 24)
                {
                    Console.WriteLine("You're between 18 and 24");


                }
                else if (age >= 25)
                {
                    Console.WriteLine("You are 25 or older!");
                }

            }
            Console.ReadLine();
        }
    }
}
