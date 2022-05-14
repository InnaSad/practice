using System;

namespace _1
{
    class A
    {
        public int a;
        public int b;
        public A (int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public double Div()
        {
            return a / b;
        }
        public double Root()
        {
            return Math.Pow(a + b, (1.0 / 3.0));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            A x = new A(a, b);
            Console.WriteLine("Частное = " + x.Div());
            Console.WriteLine("Корень кубический суммы чисел = " + x.Root());
            Console.ReadLine();
        }
    }
}
