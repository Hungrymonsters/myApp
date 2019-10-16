using System;

namespace myApp
{
    class MyLearning
    {
        static void Main(string[] args)
        {
            int radius = 5;
            double result = CalculateArea(radius);
            Console.WriteLine("The area is {0:0.00}", result);
        }

        static double CalculateArea(int r)
        {
            double area = r * r * Math.PI;
            return area;
        }
    }
}