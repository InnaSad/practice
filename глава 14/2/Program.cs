using System;
using System.Threading;
using System.Diagnostics;

namespace _2
{
    class Program
    {
        static void Summa()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Thread t1 = new Thread(new ThreadStart(Summa));
            Thread t2 = new Thread(new ThreadStart(Summa));
            t1.Start();
            t2.Start();
            sWatch.Stop();
            Console.WriteLine("Время выполнения потока = "+ sWatch.ElapsedMilliseconds.ToString() + " мс");
            Console.ReadLine();
        }
    }
}
