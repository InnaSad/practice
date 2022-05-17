using System;

namespace _3
{
    class Program
    {
        static void TrianglePS(double a)
        {
            double P = a * 3;
            double S = (Math.Sqrt(3) / 4) * Math.Pow(a, 2);
            Console.WriteLine("P = " + P);
            Console.WriteLine("S = {0:0.00}", S);
        }
        static void Main(string[] args)
        {
            try
            {
                int length = 3;
                for (int i = 1; i <= length; i++)
                {
                    Console.Write("Введите число а: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    TrianglePS(a);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
