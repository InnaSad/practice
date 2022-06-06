using System;
using System.Threading;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread process1 = new Thread(() =>
            {
                Singleton singleton = Singleton.GetInstance("Арбуз");
                Console.WriteLine(singleton.Value);
            });
            Thread process2 = new Thread(() =>
            {
                Singleton singleton = Singleton.GetInstance("Дыня");
                Console.WriteLine(singleton.Value);
            });
            process1.Start();            
            process1.Join();
            process2.Start();
            process2.Join();
            Console.ReadLine();
        }
    }    
}
