using System;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static double Z1(double a, double b)
        {
            return (Math.Sin(a) + Math.Cos(2 * b - a)) / Math.Cos(a) - Math.Sin(2 * b - a);
        }
        static double Z2(double b)
        {
            return (1 + Math.Sin(2 * b)) / Math.Cos(2 * b);
        }
        static void Main(string[] args)
        {
            Console.Write("Ведите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ведите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Task[] tasks = new Task[2]
            {
                new Task(() => Console.WriteLine(Z1(a,b))),
                new Task(() => Console.WriteLine(Z2(b)))
            };
            foreach (var t in tasks)
                t.Start();
            Task.WaitAll(tasks);
            Task.WaitAny(tasks);
            Console.ReadLine();
        }
    }
}
