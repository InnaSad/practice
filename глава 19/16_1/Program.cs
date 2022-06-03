using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _16_1
{
    /// <summary>
    /// Класс "Количество символов"
    /// </summary>
    class SymbolCount
    {
        /// <summary>
        /// Подсчитывает количество символов в каждой строке файла
        /// </summary>
        /// <param name="filePath">Файл</param>
        /// <returns>Количество символов в каждой строке файла</returns>
        public static List<int> SymCount(string filePath)
        {
            var countsCharInLines = new List<int>();
            using (var reader = new StreamReader(filePath, detectEncodingFromByteOrderMarks: true))
            {
                var line = String.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    var count = line.Length;
                    countsCharInLines.Add(count);
                }
            }
            return countsCharInLines;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a) Содержимое файла: ");
            var filePath = @"D:f1.txt";
            var filePath1 = @"D:f2.txt";
            using (StreamReader sr = new StreamReader(filePath))
            {
                String line = sr.ReadToEnd();
                Console.WriteLine(line);
                sr.Close();
            }
            int count = File.ReadAllLines(filePath).Length;
            Console.WriteLine($"b) Количество строк в файле: {count}");
            var numbers = SymbolCount.SymCount(filePath);
            int k = 1;
            foreach (var num in numbers)
            {
                Console.WriteLine($"c) Количество символов в {k}-ой строке: { num.ToString()}");
                k++;
            }
            string[] readText = File.ReadAllLines(filePath);
            string[] writeText = new string[readText.Length - 1];
            Array.Copy(readText, 0, writeText, 0, readText.Length - 1);
            File.WriteAllLines(filePath1, writeText);
            Console.WriteLine("e) Строки s1 и s2: ");
            Console.WriteLine(string.Join("\r\n", File.ReadLines(filePath).Take(2)));
            Console.WriteLine("f) Самая длинная строка: ");
            Console.WriteLine(string.Join("\r\n", File.ReadAllLines(filePath).Where(s => s.Length == File.ReadAllLines(filePath).Max(m => m.Length)).First()));
            Console.WriteLine("g) Строки, начинающиеся с буквы 'П': ");
            char firstChar = 'П';
            Console.WriteLine(string.Join("\r\n", File.ReadAllLines(filePath).Where(s => s[0] == firstChar)));
            string pathoutput = @"D:f3.txt";
            File.WriteAllLines(pathoutput, File.ReadAllLines(filePath).Reverse());
            Console.ReadLine();
        }
    }
}
