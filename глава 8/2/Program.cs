using System;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        enum Employs
        {
            Manager = 200,
            Teacher = 310,
            Director = 270
        };
        static class Accauntant
        {
            public static bool AskForBonus(Employs emp, int workedHours)
            {
                return (int)emp < workedHours;
            }
        }
        static void Main(string[] args)
        {
            var empHours = new Dictionary<Employs, int>
            {
                [Employs.Manager] = 200,
                [Employs.Teacher] = 330,
                [Employs.Director] = 250
            };
            foreach (var pair in empHours)
            {
                Console.WriteLine($"{ pair.Key }: { Accauntant.AskForBonus(pair.Key, pair.Value) }");
            }
            Console.ReadLine();
        }
    }
}

