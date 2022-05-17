using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите действительные числа a: ");
            double max = 0;
            for (int i = 1; i <= n; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                if (Math.Abs(a) > max)
                {
                    max = Math.Abs(a);
                }
            }
            Console.Write("Максимальное число по модулю: " + max);
            Console.ReadLine();
        }
    }
}
