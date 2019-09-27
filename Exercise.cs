using System;

namespace myApp
{
    class Exercise
    {
        static void Main(string[] args)
        {
            tryBreak();
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