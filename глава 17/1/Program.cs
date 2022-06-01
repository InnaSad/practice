using System;
using Shape;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(a, b, c);
            triangle.IsTriangle();
            Console.WriteLine("Периметр треугольника = " + triangle.Perimetr(a, b, c));
            Console.WriteLine("Площадь треугольника = " + triangle.Square(a, b, c));
            Console.WriteLine("Введите стороны прямоугольника: ");
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(length, width);
            Console.WriteLine("Периметр треугольника = " + rectangle.Perimetr(length, width));
            Console.WriteLine("Площадь треугольника = " + rectangle.Square(length, width));
            Console.ReadLine();
        }
    }
}
