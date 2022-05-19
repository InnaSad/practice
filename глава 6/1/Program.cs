using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray(0, str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLower(arr[i]))
                    Console.Write(Char.ToUpper(arr[i]));
                else
                    Console.Write(Char.ToLower(arr[i]));
            }
            Console.ReadLine();
        }
    }
}
