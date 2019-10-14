using System;

namespace myApp
{
    class Exercise
    {
        static void Main(string[] args)
        {
            // Take optional arguments 
            for (int j = 0 ; j < args.Length ; j ++)
            {
                Console.WriteLine($"Argument given: {args[j]}");
                if ( args[j] == "-t") tryBreak();
                else if ( args[j] == "-i") innerLoop();
                else if ( args[j] == "-m") Switch();
                else if ( args[j] == "-c") TestCon();
                else if ( args[j] == "-s") shortIf();
                else break;
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

        public static void Switch()
        {
            Console.Write("Enter your selection (1, 2, or 3): ");
            string s = Console.ReadLine();
            int n = Int32.Parse(s);

            switch (n)
            {
                case 1:
                    Console.WriteLine("Current value is {0}", 1);
                    break;
                case 2:
                    Console.WriteLine("Current value is {0}", 2);
                    break;
                case 3:
                    Console.WriteLine("Current value is {0}", 3);
                    break;
                default:
                    Console.WriteLine("Sorry, invalid selection.");
                    break;
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static void TestCon()
        {
            for (int i = 1 ; i <= 6 ; i ++)
            {
                if (i < 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static void shortIf()
        {
            int input = new Random().Next(-5, 5);

            string classify1;
            string classify2;
            if (input >= 0)
            {
                classify1 = "nonnegative";
            }
            else
            {
                classify1 = "negative";
            }

            classify2 = (input >= 0) ? "nonnegative" : "negative";

            Console.WriteLine($"Input {input} is {classify1} and {classify2}");
        }
    }
}