using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A();
            B classB = new B();
            Console.WriteLine($"класс A, поле с = {classA.c}");
            Console.WriteLine($"класс B, поле с2 = {classB.c2}");
            Console.ReadLine();
        }
    }
}
