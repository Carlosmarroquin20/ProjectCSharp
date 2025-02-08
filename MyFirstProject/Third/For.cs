using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class For
    {
        public static void Run()
        {
            /*Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");
            Console.WriteLine("Hi");*/
            /*for (int i = 0; i <= 10; i += 2)
           {
               Console.WriteLine(i);
           }*/

            Console.WriteLine("What do you want to repeat????");
            string word = Console.ReadLine();
            Console.Write("Enter the number of times you want to repeat: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                Console.WriteLine("Here are your " + n + " " +  word);

                for (int i = 0; i < n; i++)
                {
                    
                    Console.WriteLine(word);
                }
            }




            Console.ReadLine();
        }
    }
}
