using System;
using System.Collections.Generic;

namespace myApp
{
    /* class MyLearning
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
    } */

    public class NumberGenerator
    {
    int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        
        public int GetNumber(int index)
        {
            if (index < 0 || index >= numbers.Length) {
                throw new IndexOutOfRangeException();
            }
            return numbers[index];
        }
    }

    public class Example
    {
        public static void Main()
        {
            fib();
            Console.WriteLine("");

            var gen = new NumberGenerator();
            int index = 10;
            try {
                int value = gen.GetNumber(index);
                Console.WriteLine($"Retrieved {value}");
            }
            catch (IndexOutOfRangeException e) 
            {
                Console.WriteLine($"{e.GetType().Name}: {index} is outside the bounds of the array");
            }
        }

        public static void fib()
        {
            var fibonacciNumbers = new List<int> {1, 1};

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

                foreach (var item in fibonacciNumbers)
                    Console.WriteLine(item); 
           
        }
    }

}