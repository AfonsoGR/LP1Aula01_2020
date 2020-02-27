using System;

namespace Argumentos
{
    class Program
    { /// <summary>
      /// Code starts here.
      /// </summary>
      /// <param name="args"> Reads arguments </param>
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
