using System;
using System.Threading;

namespace _3
{
    class Program
    {
        static void Summa(int a, int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(a, i);
            }
            Console.WriteLine("Сумма чисел а в степени n: " + sum);
        }
        static void Mul(int a, int n)
        {
            double mul = 1;
            for (int i = 1; i <= n; i++)
            {
                mul *= Math.Pow(a, i);
            }
            Console.WriteLine("Произведение чисел а в степени n: " + mul);
        }
        static void Main(string[] args)
        {
            Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Thread t1 = new Thread(delegate() { Summa(a, n); Mul(a, n); });
            Thread t2 = new Thread(delegate() { Summa(a, n); });
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
}
