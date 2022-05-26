using System;

namespace _4
{
    class Program
    {
        delegate int Array();
        delegate double Avg(Array[] a);
        private static Random random = new Random();
        static int GetRandom()
        {
            return new Random().Next(1, 10);
        }
        static void Main()
        {
            Console.Write("Введите число элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            var array = new Array[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new Array(GetRandom)();
                Console.Write(array[i]() + "  ");
            }
            Avg d = delegate (Array[] a)
            {
                double sr = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sr += a[i]();
                }
                return sr / array.Length;
            };
            Console.WriteLine("\nСреднее ариф = {0:0.00}", d(array));
            Console.ReadLine();
        }
    }
}
