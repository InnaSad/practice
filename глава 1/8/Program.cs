using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вещественное число a (-5<=a<=5): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите целое число n (1<=n<=10): ");
            int n = Convert.ToInt32(Console.ReadLine());
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= a;
                Console.WriteLine(Math.Round(result,4));
            }
            Console.ReadLine();
        }
    }
}
