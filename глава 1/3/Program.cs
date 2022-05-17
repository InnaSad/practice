using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стоимость 1 кг конфет (1<=A<=100, целое число): ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i += 1)
            {
                Console.WriteLine(i + " кг конфет стоит " + a * i + " руб");
            }
            Console.ReadLine();
        }
    }
}
