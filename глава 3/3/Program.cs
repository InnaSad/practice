using System;

namespace _3
{
    class Program
    {
        static void f(double x, out double y)
        {
            y = 0;
            if (Math.Abs(x) < 2) y = Math.Sqrt(5 * Math.Pow(x, 2) + 5);
            else if (2 <= Math.Abs(x) && Math.Abs(x) < 10) y = Math.Abs(x) / Math.Sqrt(5 * Math.Pow(x, 2) + 5);
            else y = 0;
            Console.WriteLine("f(" + x + ") " + "= " + Math.Round(y,4));
        }
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());
            double y = 0;
            for (double i = a; i <= b; i += h)
            {
                f(i, out y);
            }
            Console.ReadLine();
        }
    }
}
