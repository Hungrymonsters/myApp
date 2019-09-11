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

        static void MyFirstFunction()
        {
            Console.WriteLine("Hello World!");
        }

        static void Main(string[] args)
        {
            MyFirstFunction();
            PlayWithIntegers();

            MyClass c1 = new MyClass();
            Console.WriteLine($"Call MyClass ReturnMessage function from Program: {c1.ReturnMessage()}");

            MyClass.MinMax();
        }
    }
}
