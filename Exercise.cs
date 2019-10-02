using System;

namespace myApp
{
    class Exercise
    {
        static void Main(string[] args)
        {
            // Take optional arguments 
            for (int i = 0 ; i < args.Length ; i ++)
            {
                Console.WriteLine($"Argument given: {args[i]}");
                if ( args[i] == "-t") tryBreak();
            }

            innerLoop();
        }

        static void tryBreak()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5) break;
                Console.WriteLine(i);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void innerLoop()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7};
            char[] letters ={ 'a', 'b', 'c', 'd', 'e', 'f'};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("num = {0}", numbers[i]);

                for (int j = 0; j < letters.Length; j++)
                {
                    if (i ==j)
                    {
                        break;
                    }
                    Console.Write(" {0} ", letters[j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }
}