using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("{0:.0} * {1:.0} = {2:.0}", a, b, a * b);
            Console.ReadLine();
        }
    }
}
