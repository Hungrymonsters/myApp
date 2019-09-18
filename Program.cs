using System;

namespace myApp
{
    class Program
    {
        static void PlayWithIntegers()
        {
            int a = 9;
            int b = 14;
            int c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = b / a;
            Console.WriteLine(c);
            c = b % a;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
        }

        static void PlayWithDouble()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e  + f) / g;
            Console.WriteLine(h);

            double i = 1.0 / 3.0;
            Console.WriteLine(i);

            // The M suffix on the numbers is how you indicate that a constant should use the decimal type        
            decimal j = 1.0M / 3.0M;
            Console.WriteLine(j);
        }

        static void MyFirstFunction()
        {
            Console.WriteLine("Hello World!");
        }

        static void Main(string[] args)
        {
            MyFirstFunction();
            //PlayWithIntegers();

            //MyClass c1 = new MyClass();
            //Console.WriteLine($"Call MyClass ReturnMessage function from Program: {c1.ReturnMessage()}");

            //MyClass.MinMax();
            //PlayWithDouble();
            MyClass.LogicalOps();
            MyClass.MakeLoop();
        }
    }
}
