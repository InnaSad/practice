using System;

namespace Shape
{
    public class Rectangle
    {
        public int length;
        public int width;
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public int Perimetr(int length, int width)
        {
            return 2 * (length + width);
        }
        public double Square(int length, int width)
        {
            return length * width;
        }
    }
}
