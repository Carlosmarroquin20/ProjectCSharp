using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class DataTypes
    {
        static void Main(string[] args)
        {
            double age = 10;
            // + - * /

            age /= 3;
            Console.WriteLine(age);

            string name = "Ema";
            name += " is programming!";
            
            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            Console.WriteLine(name);

            int i = 0;
            i++;
            Console.WriteLine(i);


            Console.ReadLine();
        }
    }
}
