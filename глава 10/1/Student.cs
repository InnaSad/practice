using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Student
    {
        private string name;
        private double s;
        private double stipend;
        public Student()
        {
            name = null;
            s = 0;
            stipend = 0;
            Input();
        }
        public void GetInfo()
        {
            Console.WriteLine("Имя:{0} | Средний балл:{1} | Стипендия:{2}", name, s, stipend);
        }
        public virtual void StipendCalc()
        {
            stipend = 300000 + 10000 * (s - 5);
        }
        public string Name { get { return name; } set { name = value; } }
        public double S { get { return s; } set { s = value; } }
        public double Stipend { get { return stipend; } set { stipend = value; } }
        public void Input()
        {
            Console.Write("Введите имя студента: ");
            name = Console.ReadLine();
            Console.Write("Введите средний балл: ");
            s = Convert.ToDouble(Console.ReadLine());
        }
    }
}
