using System;

namespace myApp
{
    class Exercise
    {
        static void Main(string[] args)
        {
            // tryBreak();
            
            // Take optional arguments 
            for (int i = 0 ; i < args.Length ; i ++)
            {
                Console.WriteLine("Argument given: "+ $"{args[i]}");
                if ( args[i] == "-t") tryBreak();
            }
        }

        static void tryBreak()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5) break;
                Console.WriteLine(i);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }
}