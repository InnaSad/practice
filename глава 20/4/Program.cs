using System;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Tan(int x)
        {
            Console.WriteLine(Math.Tan(x));
        }
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Parallel.For(2, 12, Tan);
            Console.ReadLine();
        }
    }
}
