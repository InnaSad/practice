using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            metka: Console.Write("Введите четное двузначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a >= 10) && (a <= 99))
            {
                if ((a % 2) == 0)
                {
                    Console.WriteLine("Данное число является четным двузначным числом");
                }
                else
                {
                    Console.WriteLine("Данное число не является четным числом");
                    goto metka;
                }
            }
            else
            {
                Console.WriteLine("Данное число не является двузначным числом");
                goto metka;
            }
            Console.ReadLine();
        }
    }
}
