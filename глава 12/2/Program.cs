using System;

namespace _2
{
    class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите операцию: 1 – сложение, 2 – вычитание, 3 – умножение, 4 – деление");
            int operation = int.Parse(Console.ReadLine());
            switch(operation)
            {
                case 1:
                    Operation add = (x, y) => x + y;
                    Console.WriteLine("x + y = " + add(x, y));
                    break;
                case 2:
                    Operation sub = (x, y) => x - y;
                    Console.WriteLine("x - y = " + sub(x, y));
                    break;
                case 3:
                    Operation mul = (x, y) => x * y;
                    Console.WriteLine("x * y = " + mul(x, y));
                    break;
                case 4:
                    try
                    {
                        Operation div = (x, y) => x / y;
                        Console.WriteLine("x / y = " + div(x, y));
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
