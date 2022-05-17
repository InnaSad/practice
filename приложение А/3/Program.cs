using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ведите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ведите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double z1 = (Math.Sin(a) + Math.Cos(2 * b - a)) / Math.Cos(a) - Math.Sin(2 * b - a);
            double z2 = (1 + Math.Sin(2 * b)) / Math.Cos(2 * b);
            Console.WriteLine("z1 = " + z1);
            Console.WriteLine("z2 = " + z2);
            Console.ReadLine();
        }
    }
}
