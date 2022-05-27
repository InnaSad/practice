using System;

namespace _1
{
    class Program
    {
        public delegate void Color(string color);
        static void Red(string color)
        {
            color = "Красный";
            Console.WriteLine(color);
        }
        static void Green(string color)
        {
            color = "Зеленый";
            Console.WriteLine(color);
        }
        static void Blue(string color)
        {
            color = "Синий";
            Console.WriteLine(color);
        }
        static void Black(string color, Color bl)
        {
            color = "Черный";
            bl(color);
        }
        static void Main(string[] args)
        {
            Color color = null;
            color += Red;
            color += Green;
            color += Blue;
            color("");
            Color black = Console.WriteLine;
            Black("", black);
            Console.ReadLine();
        }
    }
}
