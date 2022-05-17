using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write((a % 100) * 10 + a / 100);
            Console.ReadLine();
        }
    }
}
