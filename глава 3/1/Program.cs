using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Fx(a) > Fx(b) ? "Наибольшее значение функция принимает в точке a" : "Наибольшее значение функция принимает в точке b");
            Console.ReadLine();
        }
        static double Fx(double x)
        {
            return Math.Pow(x, 3) - Math.Sin(x);
        }
    }
}
