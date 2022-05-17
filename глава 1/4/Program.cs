using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y;
            if (1 <= x && x <= 3)
            {
                y = 2 * Math.Pow(x, 2) - 3 * Math.Pow(Math.E, Math.Sin(x));
                Console.WriteLine(y);
            }
            else if (x > 3)
            {
                y = 3 * Math.Tan(x);
                Console.WriteLine(y);
            }
            Console.ReadLine();
        }
    }
}
