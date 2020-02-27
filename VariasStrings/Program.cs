using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex06 variables
            double xx = 0.12345;
            int ii = 18;

            // String variables
            string first = "A tab\t followed" 
            + "by a new line\n followed by a unicode symbol \u03A9";
            string second = @"Verbatim string, this does not add a tab \t";
            string third = @"This does not add a unicode symbol \u03A9 due 2 @";
            string fourth = "\"This string is between 'aspas'\"";
            string fifth = @"""This string is also in between 'aspas'""";
            string x = "onions";
            string y = "shrek likes ";
            string z = y + x;
            string a = "bananas";
            string b = "berries";
            string c = $"eating {a} and {b} is very good"; 
            string zc = $@"I'm an verbatim and interpoled string" 
            + "as u can see ahead{z} {c}";
            string alpha = String.Format("Arg {0} and {1}", x, y);
            string beta = String.Format("Arg {0} and {1}", y, x);
            string charlie = String.Format("Arg {1} and {0}", x, y);

            // Print the strings
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(fourth);
            Console.WriteLine(fifth);
            Console.WriteLine(z);
            Console.WriteLine(c);
            Console.WriteLine(zc);
            Console.WriteLine(alpha);
            Console.WriteLine(beta);
            Console.WriteLine(charlie);

            // Ex06 Strings and prints
            string stringXX = $"xx = {xx:f2}";
            Console.WriteLine(stringXX);
            
            string stringXXPercentage = $"xx percentage = {xx:p1}";
            Console.WriteLine(stringXXPercentage);

            string stringIIHexadecimal = $"ii's value in hexadecimal = {ii:x}";
            Console.WriteLine(stringIIHexadecimal);

            string stringIICoin = $"ii's value in coin = {ii:c}";
            Console.WriteLine(stringIICoin);
        }
    }
}
