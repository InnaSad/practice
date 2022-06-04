using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Sum(int x)
        {
            int result = 0;
            for (int i = 0; i < x; i++)
            {
                result += i;
            }
            Console.WriteLine("Сумма = " + result);
        }
        static void Mul(int x)
        {
            int result = 1;
            for (int i = 0; i < x; i++)
            {
                result *= i;
            }
            Console.WriteLine("Произведение = " + result);
        }
        static void Main(string[] args)
        {
            ParallelLoopResult result1 = Parallel.ForEach<int>(new List<int>() { 74, 23, 65, 98 }, Sum);
            ParallelLoopResult result2 = Parallel.ForEach<int>(new List<int>() { 74, 23, 65, 98 }, Mul);
            Console.ReadLine();
        }
    }
}
