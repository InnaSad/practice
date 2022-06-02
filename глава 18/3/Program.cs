using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pln PlnList = new Pln();
            Dictionary<int, string> Date = new Dictionary<int, string>(3);
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите дату: ");
                string date = Console.ReadLine();
                Console.Write("Введите план: ");
                string plan = Console.ReadLine();
                Console.Write("Введите статус плана: ");
                string status = Console.ReadLine();
                PlnList.Add(new Status(date, plan, status));
                Date[i + 1] = plan;
            }
            Console.WriteLine("============ ");
            foreach (KeyValuePair<int, string> keyValue in Date)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine("============ ");
            foreach (Status x in PlnList)
                x.PrintPlan();
            PlnList.RemoveAt(1);
            Console.WriteLine("============ ");
            Pln cl = (Pln)PlnList.Clone();
            foreach (Status x in cl) x.PrintPlan();
            Console.ReadLine();
        }
    }
}
