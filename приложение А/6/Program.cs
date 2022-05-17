using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 4.3;
            double y = (1 + Math.Sqrt(Math.Abs(3 - Math.Pow(x, 2)))) / Math.Atan(Math.Pow(x, 2)) - Math.Pow(Math.Sin(Math.Sqrt(x)),Math.E);
            Console.Write("y = " + y);
            Console.ReadLine();
        }
    }
}
