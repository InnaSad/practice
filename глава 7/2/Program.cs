using System;
using System.Text.RegularExpressions;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string s = Console.ReadLine();
            if (Regex.IsMatch(s, @"\p{IsCyrillic}"))
                Console.WriteLine("Текст на русском языке");
            else
                Console.WriteLine("Текст не на русском языке");
            Console.ReadLine();
        }
    }
}
