using System;

namespace _2
{
    class MyDictionary<Tkey, Tval>
    {
        private int counter = 0;
        private Tkey[] keysArray = null;
        private Tval[] valsArray = null;
        public int Counter
        {
            get { return this.counter; }
        }
        public void Add(Tkey key, Tval val)
        {
            this.counter++;

            Array.Resize(ref keysArray, counter);
            keysArray[counter - 1] = key;

            Array.Resize(ref valsArray, counter);
            valsArray[counter - 1] = val;
        }
        public void ShowValues()
        {
            for (int i = 0; i < counter; i++)
                Console.Write(valsArray[i] + "  ");
        }
        public Tval this[Tkey key]
        {
            get
            {
                int ind = 0;
                for (int i = 0; i < keysArray.Length; i++)
                {
                    if (key.Equals(keysArray[i]))
                        ind = i;
                }
                return valsArray[ind];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, int> arr = new MyDictionary<int, int>();
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите элемент массива: ");
                int a = int.Parse(Console.ReadLine());
                arr.Add(i, a);
            }
            arr.ShowValues(); ;
            Console.Write("\nВведите индекс элемента массива: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Элемент под индексом " + index + " = " + arr[index]);
            Console.WriteLine("Количество элементов: " + arr.Counter);
            Console.ReadLine();
        }
    }
}
