using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            Random rand = new Random();
            double sum = 0;
            Console.Write("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10) + rand.NextDouble();
                Console.Write(Math.Round(array[i], 1) + "\t");
                sum += array[i];
            }
            Console.WriteLine();
            Console.Write("Отсортированный массив: ");
            Array.Sort(array);
            foreach (double i in array)
                Console.Write(Math.Round(i, 1) + "\t");
            Console.WriteLine();          
            Console.WriteLine("Среднее арифметическое: {0:0.00}", sum / array.Length);            
            Console.Write("Измненный массив: ");
            for (int i = 0; i < array.Length; i++)
            { 
                if (array[i] < 0)
                {
                    array[i] += 0.5;
                }
                else if (array[i] > 0 && array[i] < sum / array.Length)
                {
                    array[i] = 0.1;
                }
                Console.Write(Math.Round(array[i], 1) + "\t");
            }
            Console.ReadLine();
        }
    }
}
