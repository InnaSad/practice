using System;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Введите ФИО: ");
            string s = Console.ReadLine();
            s = s.ToLower();
            s = s.Replace(" ", "");
            char[] fio = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToArray();
            for (int i = 0; i < s.Length; i += 1)
            {
                for (int j = 0; j < fio.GetLength(0); j += 1)
                {
                    if (s[i] == fio[j]) sum += j;
                }
            }
            Console.WriteLine("Сумма: " + sum);
            string sum1 = Convert.ToString(sum);
            char[] sum2 = sum1.ToArray();
            while (sum2.GetLength(0) > 1)
            {
                sum = 0;
                for (int i = 0; i < sum2.GetLength(0); i += 1)
                {
                    sum = (int)char.GetNumericValue(sum2[i]) + sum;
                }
                sum1 = Convert.ToString(sum);
                sum2 = sum1.ToArray();
                Console.WriteLine("Сумма чисел: " + sum);
            }
            Console.WriteLine("Код личности: " + sum);
            Console.ReadLine();
        }
    }
}
