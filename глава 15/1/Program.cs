using System;

namespace _1
{
    public class MyList<T>
    {
        protected int index = 0;
        protected T[] Values = new T[5];
        public int Count { get { return Values == null ? 0 : Values.Length; } }
        public void Add(T value)
        {
            Values[index] = value;
            index++;
        }
        public void ShowValues()
        {
            for (int i = 0; i < index; i++) 
                Console.Write(Values[i] + "  ");
        }
        public T this[int index]
        {
            get
            {
                if (Values == null)
                    throw new NullReferenceException();
                else
                {
                    if (index < 0 || index > Values.Length - 1)
                        throw new IndexOutOfRangeException();
                    else
                        return Values[index];
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> arr = new MyList<int>();
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите элемент массива: ");
                int a = int.Parse(Console.ReadLine());
                arr.Add(a);
            }
            arr.ShowValues();
            Console.Write("\nВведите индекс элемента массива: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Элемент под индексом " + index + " = " + arr[index]);
            Console.WriteLine("Количество элементов: " + arr.Count);
            Console.ReadLine();
        }
    }
}
