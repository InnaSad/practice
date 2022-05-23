using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Station station = new Station();
            int Kol = 4;
            for (int i = 0; i < Kol; i++)
            {
                station.Add();
            }
            station[0].ShowInfo();
            station[1].ShowInfo();
            station[2].ShowInfo();
            station[3].ShowInfo();
            station.ShowLastTime();
            station.ShowEndPunct();
            Console.ReadLine();
        }
    }
}
