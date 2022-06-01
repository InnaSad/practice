using System;
using System.IO;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"f.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string s;
            int n = 0;
            while ((s = reader.ReadLine()) != null)
            {
                n++;
            }
            reader.Close();
            int[] mas = new int[n];
            FileStream file1 = new FileStream(@"f.txt", FileMode.Open);
            StreamReader reader1 = new StreamReader(file1);
            int max = 0;
            int min = 255;
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(reader1.ReadLine());
                if (max < mas[i])
                    max = mas[i];
                if (min > mas[i])
                    min = mas[i];
            }
            Console.WriteLine("Сумма наибольшего и наименьшего значений компонент - " + (max + min));
            Console.ReadLine();
        }
    }
}
