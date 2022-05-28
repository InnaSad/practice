using System;
using System.Threading;

namespace _1
{
    class Program
    {
        static void FirstThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(10);
            }
        }
        static void SecondThread()
        {
            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(10);
            }
        }
        static void ThirdThread()
        {
            for (int i = 20; i < 30; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(10);
            }
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            Thread thread2 = new Thread(new ThreadStart(SecondThread));
            Thread thread3 = new Thread(new ThreadStart(ThirdThread));
            thread1.Start();
            thread1.Priority = ThreadPriority.Highest;
            thread2.Start();
            thread2.Priority = ThreadPriority.Normal;
            thread3.Start();
            thread3.Priority = ThreadPriority.Lowest;
            Console.ReadLine();
        }
    }
}
