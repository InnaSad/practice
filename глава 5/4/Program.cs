using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int m = 12;
            int[,] firma = new int[m, n];
            Random rand = new Random();
            Console.WriteLine("Доходы фирмы: ");
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                    {
                    firma[i, j] = rand.Next(50);
                    Console.Write(firma[i, j] + "\t");
                }
                Console.WriteLine();
            }            
            double sum = 0;
            for(int j = 0; j < n; j++)
            {
                sum += firma[8, j];
            }
            Console.WriteLine("Общий доход фирмы за сентябрь: "+ sum);
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            if (sum > a) Console.WriteLine("Общий доход фирмы за сентябрь превышает заданное число");
            else Console.WriteLine("Общий доход фирмы за сентябрь не превышает заданное число");
            Console.ReadLine();
        }
    }
}
