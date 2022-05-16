using System;

namespace _2
{
    class Program
    {
        static double f(double x)
        {
            double y;
            if (Math.Abs(x) < 2) y = Math.Sqrt(5 * Math.Pow(x, 2) + 5);
            else if (2 <= Math.Abs(x) && Math.Abs(x) < 10) y = Math.Abs(x) / Math.Sqrt(5 * Math.Pow(x, 2) + 5);
            else y = 0;
            return y;
        }
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i += h)
            {
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
            }
            Console.ReadLine();
        }
    }
}
