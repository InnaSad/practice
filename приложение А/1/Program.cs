using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цену тетради: ");
            double cena_tetr = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество тетрадей: ");
            double kolvo_tetr = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите цену карандаша: ");
            double cena_karand = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество карандашей: ");
            double kolvo_karand = Convert.ToDouble(Console.ReadLine());
            double stoimost = cena_tetr * kolvo_tetr + cena_karand * kolvo_karand;
            Console.Write("Стоимость покупки равна " + stoimost);
            Console.ReadLine();
        }
    }
}
