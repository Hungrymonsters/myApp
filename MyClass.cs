using System;

namespace myApp
{
    public class MyClass
    {
        public string ReturnMessage()
        {
            return "Happy coding!";
        }

        public static void MinMax()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            double dmax = double.MaxValue;
            double dmin = double.MinValue;
            Console.WriteLine($"The range of double is {dmin} to {dmax}");
        }

        public static void LogicalOps()
        {
            int a = 4, b = 3, c = 5;
            if ((a + b > 10) || (a > b))
            {
                Console.Write("The answer is greater than 10\r\n");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else Console.WriteLine("The answer is not greater than 10\0" +
                "And the first number " + a + " is not greater then the second " + b);

            if ((a + b + c >= 10) && (a == b))
            {
                Console.Write("The answer is greater than or equal to 10\r\n");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else Console.WriteLine("The answer is not than or equal to 10\0" +
                "And the first number " + a + " is not equal to the second " + b);

        }
    }
}
