using System;

namespace _3
{
    public class ColorPointClass
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public ColorPointClass()
        {
            this.X = 0;
            this.Y = 0;
            this.R = 0;
            this.G = 0;
            this.B = 0;
        }
        public ColorPointClass(int x, int y, int r, int g, int b)
        {
            this.X = x;
            this.Y = y;
            this.R = r;
            this.G = g;
            this.B = b;
        }
        public void Change()
        {
            Console.Write("Введите новое значение красного цвета: ");
            int r1 = int.Parse(Console.ReadLine());
            R = r1;
            Console.Write("Введите новое значение зеленого цвета: ");
            int g1 = int.Parse(Console.ReadLine());
            G = g1;
            Console.Write("Введите новое значение синего цвета: ");
            int b1 = int.Parse(Console.ReadLine());
            B = b1;
            Console.Write("Новый цвет точки = ({0},{1},{2}) ", r1, g1, b1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ColorPointClass m = new ColorPointClass();
            Console.Write("Введите координату Х: ");
            m.X = Int32.Parse(Console.ReadLine());
            Console.Write("Введите координату Y: ");
            m.Y = Int32.Parse(Console.ReadLine());
            Console.Write("Введите координату цвета R: ");
            m.R = Int32.Parse(Console.ReadLine());
            Console.Write("Введите координату цвета G: ");
            m.G = Int32.Parse(Console.ReadLine());
            Console.Write("Введите координату цвета B: ");
            m.B = Int32.Parse(Console.ReadLine());
            if ((m.R < 0 || m.R > 255) || (m.G < 0 || m.G > 255) || (m.B < 0 || m.B > 255))
            {
                Console.WriteLine("Для цвета необходимо вводить числа в диапазоне от 0 до 255.");
                return;
            }
            Console.WriteLine("Координаты точки = ({0}, {1})", m.X, m.Y);
            Console.WriteLine("Цвет точки = ({0},{1},{2}) ", m.R, m.G, m.B);
            m.Change();
            Console.ReadLine();
        }
    }
}
