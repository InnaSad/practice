using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            metka: Console.WriteLine("Выберите транспортное средство:  a - автомобиль, в - велосипед, м - мотоцикл, с - самолет, п - поезд:");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "а":
                    Console.WriteLine("Максимальная скорость автомобиля - 350 км/ч");
                    break;
                case "в":
                    Console.WriteLine("Максимальная скорость велосипеда - 50 км/ч");
                    break;
                case "м":
                    Console.WriteLine("Максимальная скорость мотоцикла - 402 км/ч");
                    break;
                case "с":
                    Console.WriteLine("Максимальная скорость самолета - 1153 км/ч");
                    break;
                case "п":
                    Console.WriteLine("Максимальная скорость поезда - 603 км/ч");
                    break;
                default:
                    Console.WriteLine("Вы не выбрали транспортное средство!");
                    goto metka;
            }
            Console.ReadLine();
        }
    }
}
