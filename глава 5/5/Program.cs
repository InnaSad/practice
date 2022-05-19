using System;

namespace _5
{
    class Program
    {
        static double Factorial(double n)
        {
            if (n == 1) return n;
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double f = Factorial(n - 3) / Factorial(n);
            Console.WriteLine($"f(n) = {f}");
            Console.ReadLine();
        }
    }
}
