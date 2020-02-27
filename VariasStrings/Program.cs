using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // String variables
            string first = "A tab\t followed" 
                + "by a new line\n followed by a unicode symbol \u03A9";
            string second = @"Verbatim string, this does not add a tab \t";
            string third = @"This does not add a unicode symbol \u03A9 due 2 @";
            string fourth = "\"This string is between 'aspas'\"";
            string fifth = @"""This string is also in between 'aspas'""";
            
            // Print the strings
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(fourth);
            Console.WriteLine(fifth);
        }
    }
}
