using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Station
    {
        List<Train> Traina = new List<Train>();
        public Train this[int index]
        {
            get
            {
                return Traina[index];
            }
            set
            {
                if (index >= 0 && value is Train)
                {
                    Traina.Add(value);
                    Traina.Sort();
                }
            }
        }
        public void Add()
        {
            int namber = 0;
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.Write("Введите номер поезда: ");
                    namber = Convert.ToInt32(Console.ReadLine());
                    flag = !flag;
                }
                catch
                {
                    Console.WriteLine("Неверный формат номера");
                }
            }
            Console.Write("Введите конечный пункт назначения: ");
            string EndPunct = Console.ReadLine();
            Train Train = new Train(EndPunct, namber);
            Traina.Add(Train);
            Traina.Sort();
        }
        public void ShowLastTime()
        {
            Console.Write("Введите время для сравнения: ");
            Train p1 = new Train("null", 1);
            for (int i = 0; i < Traina.Count; i++)
                if (p1 < this[i])
                    this[i].ShowInfo();
        }
        public void ShowEndPunct()
        {
            Console.Write("Введите пункт назначения: ");
            string punkt = Console.ReadLine();
            int num = 0;
            for (int i = 0; i < Traina.Count; i++)
            {
                if (Traina[i].EndPunct == punkt)
                {
                    Console.WriteLine(Traina[i]);
                    num++;
                }
            }
            if (num == 0)
                Console.WriteLine("В заданный пункт назначения поезда не ходят!");
        }
    }
}
