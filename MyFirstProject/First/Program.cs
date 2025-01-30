using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age = 22;
            var age = 22;
            Console.WriteLine(age);

            //long bigNumber = 488888l;
            var bigNumber = 77777L;
            Console.WriteLine(bigNumber);

            var negative = -3.4D;
            Console.WriteLine(negative);

            var precision = 5.000001F;
            Console.WriteLine(precision);

            var money = 14.99M;
            Console.WriteLine(money);

            var name = "name";
            Console.WriteLine(name);

            var letter = 'a';
            Console.WriteLine(letter);

            Console.ReadLine();
        }
    }
}
