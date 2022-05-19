using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double[] array = new double[5];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.NextDouble();
                Console.WriteLine("{0:0.00}",array[i]);
                sum += array[i];
            }
            Console.WriteLine("Среднее арифметическое = {0:0.00} ", sum / array.Length);
            Console.ReadLine();
        }
    }
}
