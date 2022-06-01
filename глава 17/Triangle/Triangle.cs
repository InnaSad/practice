using System;

namespace Shape
{
    public class Triangle
    {
        public int a;
        public int b;
        public int c;
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void IsTriangle()
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                Console.WriteLine("Это не треугольник!");
            else if (a == b && b == c)
                Console.WriteLine("Это равносторонний треугольник!");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Это равнобедренный треугольник!");
            else
                Console.WriteLine("Это разносторонний треугольник!");
        }
        public int Perimetr(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Square(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
