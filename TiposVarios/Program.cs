using System;

namespace TiposVarios
{
    class Program
    {
        /// <summary>
        /// Exercise revolving around different kinds of variables
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Inter and real variables
            int inter = 5;
            float floaty = 2.5f;
            double pi = 3.1415;
            long longBoi = 99999L;
            decimal deximus = 6.969m;
            uint uinter = 4;

            // Char variables
            char copyrightSymbol = '\u00A9';
            char zeroDash = '\u00D8';

            // Bool variables
            bool alivent = false;
            bool deadnt = true;

            // Display the variables in the console
            Console.WriteLine(inter);
            Console.WriteLine(floaty);
            Console.WriteLine(pi);
            Console.WriteLine(longBoi);
            Console.WriteLine(deximus);
            Console.WriteLine(uinter);
            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(zeroDash);
            Console.WriteLine("Are you ok? " + alivent);
            Console.WriteLine("Are you ok 2.0? " + deadnt);
        }
    }
}
