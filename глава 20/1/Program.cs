using System;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static int Transposition(int a)
        {
            return (a % 100) * 10 + a / 100;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Task task1 = new Task(() => Console.WriteLine(Transposition(a)));
            task1.Start();
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine(Transposition(a)));
            Task task3 = Task.Run(() => Console.WriteLine(Transposition(a)));
            Console.ReadLine();
        }
    }
}
