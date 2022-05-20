using System;
using System.Text.RegularExpressions;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string s = Console.ReadLine();
            string[] strings = Regex.Split(s, @"\s+");
            foreach (string word in strings)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
