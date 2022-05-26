using System;

namespace _3
{
    class Program
    {
        public delegate string String(string s);
        static string Insert(string s)
        {
            string s2 = s.Insert(6, " вкусные");
            Console.WriteLine(s2);
            return s2;
        }
        static string Replace(string s)
        {
            string s2 = s.Replace("е", "а");
            Console.WriteLine(s2);
            return s2;
        }
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
