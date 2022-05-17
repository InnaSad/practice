using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            int m = 10;
            int a = 0;
            double b = Math.PI / 4;
            double h = (b - a) / m;
            for (double i = a; i < b; i += h)
            {
                double y = Math.Tan(x);
                Console.WriteLine(Math.Round(y,3));
                x = x + h;
            }
            Console.ReadLine();
        }
    }
}
