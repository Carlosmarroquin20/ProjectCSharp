using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class CalculatorExample
    {
        public static void Run () 
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation (+, -, *, /, %): ");
            string operation = Console.ReadLine();

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"The result of {num1} + {num2} is: {result}");
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"The result of {num1} - {num2} is: {result}");
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"The result of {num1} * {num2} is: {result}");
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"The result of {num1} / {num2} is: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed!");
                    }
                    break;

                case "%":
                    if (num2 != 0)
                    {
                        result = num1 % num2;
                        Console.WriteLine($"The result of {num1} % {num2} is: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed!");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation. Please choose +, -, *, /, or %.");
                    break;
            }

            Console.WriteLine("Thank you for using the Calculator!");
            Console.ReadLine();
        }
    }
}
