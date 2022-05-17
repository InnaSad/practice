using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (M % N == 0)
            {
                Console.WriteLine(M / N);
            }
            else
            {
                Console.WriteLine("M на N нацело не делится");
            }
            Console.ReadLine();
        }
    }
}
