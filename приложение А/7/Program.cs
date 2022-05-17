using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты (x1,y1): ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты (x2,y2): ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты (x3,y3): ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double S = 0.5 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));
            Console.WriteLine("Площадь треугольника: " + S);
            double AB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double AC = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            double BC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double P = AB + AC + BC;
            Console.WriteLine("Периметр треугольника: " + "{0:0.0}",P);
            Console.ReadLine();
        }
    }
}
