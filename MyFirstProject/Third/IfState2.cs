using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class IfState2
    {
        public static void Run()
        {
            Console.Write("Enter the first number:  ");
            int numberA = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the second number:  ");
			int numberB = Convert.ToInt32(Console.ReadLine());
            
            int answer = numberA * numberB;

		    Console.Write("Value of " + numberA  + " * " + numberB + " is??? " );
            int userAnswer = Convert.ToInt32(Console.ReadLine());

			if (userAnswer == answer)
			{
				Console.WriteLine("Correct! The answer is " + answer);
			}
			else
			{
				Console.WriteLine("Incorrect! The correct answer is " + answer);
			}

			Console.ReadLine();
		}
    }
}
