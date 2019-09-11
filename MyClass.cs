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
        }
    }
}