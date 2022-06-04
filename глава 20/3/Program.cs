using System;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static int Summa(int a)
        {
            return a % 10 + a / 10;
        }
        static void PrintResult(int sum)
        {
            Console.WriteLine("Сумма цифр = " + sum);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Task<int> sumTask = new Task<int>(() => Summa(a));
            Task printTask = sumTask.ContinueWith(task => PrintResult(task.Result));
            sumTask.Start();
            printTask.Wait();
            Console.ReadLine();
        }
    }
}
