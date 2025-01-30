using System;

namespace MyFirstProject
{
    internal class Const_Keyword
    {
        public static void Run () 
        {
            const int vat = 20;

            int balance = 1000;
            const double percentVAT = vat / 100D;
            const double percent = 0.2D;

            Console.WriteLine(balance * (vat / 100D));
            Console.WriteLine(balance * percentVAT);
            Console.WriteLine(balance * percent);

            Console.WriteLine (vat);
            Console.ReadLine ();
            


        }
    }
}
