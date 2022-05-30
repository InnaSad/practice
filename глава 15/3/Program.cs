using System;
using _1;

namespace _3
{
    static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] arr = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
                arr[i] = list[i];
            return arr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> arr = new MyList<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите элемент массива: ");
                int a = int.Parse(Console.ReadLine());
                arr.Add(a);
            }
            int[] array = arr.GetArray();
            foreach (int item in array)
                Console.Write(item + "  ");
            Console.ReadLine();
        }
    }
}
