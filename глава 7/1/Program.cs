using System;
using System.Text.RegularExpressions;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string s = Console.ReadLine();
            Regex regex = new Regex(@"[\w\d\,\s]*\?|[\w\d\,\s]*\!");
            MatchCollection matches = regex.Matches(s);
            Console.WriteLine("Вопросительные и восклицательные предложения: ");
            if (matches.Count > 0)
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            else
                Console.WriteLine("Совпадений не найдено");
            Console.ReadLine();
        }
    }
}
