using System;

namespace _12_2
{
    class Program
    {
        /// <summary>
        /// Операции со строками
        /// </summary>
        /// <param name="s">Строка</param>
        /// <returns>Результат операции со строкой</returns>
        public delegate string String(string s);
        /// <summary>
        /// Вставляет в строку на указанной позиции(6) указанное слово(вкусные)
        /// </summary>
        /// <param name="s">Заданная строка</param>
        /// <returns>Заданная строка с указанным словом</returns>
        static string Insert(string s)
        {
            string s2 = s.Insert(6, " вкусные");
            Console.WriteLine(s2);
            return s2;
        }
        /// <summary>
        /// Заменяет буквы "е" на "а" во всей строке
        /// </summary>
        /// <param name="s">Заданная строка</param>
        /// <returns>Заданная строка с замененными буквами</returns>
        static string Replace(string s)
        {
            string s2 = s.Replace("е", "а");
            Console.WriteLine(s2);
            return s2;
        }
        /// <summary>
        /// Сцепляет заданную строку со строкой s2
        /// </summary>
        /// <param name="s">Заданная строка</param>
        /// <returns>Заданая строка со строкой s2</returns>
        static string Concat(string s)
        {
            string s2 = " в саду";
            string str = s + s2;
            Console.WriteLine(str);
            return str;
        }
        static void Main(string[] args)
        {
            string str = "Спелые яблоки";
            String s = new String(Insert);
            s += Replace;
            s += Concat;
            s(str);
            Console.ReadLine();
        }
    }
}
