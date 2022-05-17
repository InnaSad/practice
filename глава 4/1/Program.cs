using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("x = ");
                double x = Convert.ToDouble(Console.ReadLine());
                double y1 = (Math.Sin(x) / x - 5) + Math.Pow(x, 3);
                double y2 = Math.Log(x) - (Math.Cos(x) / 3 * x + 6);
                Console.WriteLine("y = " + y1);
                Console.WriteLine("y = " + y2);
            }
            catch (FormatException ex) 
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            } 
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
