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
            decimal @decimal = 6.969m;
            uint ui = 4;

            // Char variables
            char copyrightSymbol = '\u00A9';
            char zeroDash = '\u00D8';

            // Bool variables
            bool alivet = false;
            bool dead = true;

            // Display the variables in the console
            Console.WriteLine(inter);
            Console.WriteLine(floaty);
            Console.WriteLine(pi);
            Console.WriteLine(longBoi);
            Console.WriteLine(@decimal);
            Console.WriteLine(ui);
            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(zeroDash);
            Console.WriteLine("Are you ok? " + alive);
            Console.WriteLine("Are you ok 2.0? " + dead);
        }
    }
}
