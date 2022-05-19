using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива(<10): ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите диапазон: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            Random rand = new Random();
            Console.WriteLine("Матрица: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(a, b);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.Write("Введите число c: ");
            int c = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] > c) sum += Math.Pow(matrix[i, j], 2);
                }
            Console.WriteLine("Сумма квадратов элементов больше с = " + sum);
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    s += matrix[i, j];
                }
                Console.WriteLine("Среднее арифметическое " + i + " строки = {0:0.00}", s / n);
                s = 0;
            }
            Console.ReadLine();
        }
    }
}
