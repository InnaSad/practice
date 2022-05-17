using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                double f;
                if (-3 < x && x < 3)
                {
                    f =  2 / x;
                    Console.WriteLine("f(x) = " + f);
                }
                else if (x <= -3)
                {
                    f = 5 * x;
                    Console.WriteLine("f(x) = " + f);
                }
                else
                {
                    throw new Exception("Ошибка: выход из диапазона допустимых значений x");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }

}
