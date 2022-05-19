using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку с цифрами: ");
            string s = Console.ReadLine();
            int proz = 1;
            int min = 0;
            foreach (char ch in s)
            {
                if (int.TryParse(ch.ToString(), out int digit))
                    proz *= digit;
                    min = digit;
                if (min >= digit)
                    min = digit;
            }
            Console.WriteLine("Произведение цифр = " + proz);
            Console.WriteLine("Минимальная цифра = " + min);
            Console.ReadLine();
        }
    }
}
