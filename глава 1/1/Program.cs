using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите расстояние (в метрах): ");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.Write("Расстояние в полных километрах: " + s/1000);
            Console.ReadLine();
        }
    }
}
