using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int summa = a % 10 + a / 10;
            Console.Write("Сумма цифр равна " + summa);
            Console.ReadLine();
        }
    }
}
