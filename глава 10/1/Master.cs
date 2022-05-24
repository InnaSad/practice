using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Master : Student
    {
        string specialty;
        double m;
        public Master() : base()
        {
            specialty = null;
            m = 0;
            Input();
        }
        public void Input()
        {
            Console.Write("Введите специальность: ");
            specialty = Console.ReadLine();
            Console.Write("Введите сумму увеличения стипендии: ");
            m = Convert.ToDouble(Console.ReadLine());
        }
        public override void StipendCalc()
        {
            Stipend = (300000 + 10000 * (S - 5)) + m;
        }
        public void GetInfo()
        {
            Console.WriteLine("Имя: {0} \nСредний балл: {1} \nСпециальность: {2} \nСтипендия: {3}", Name, S, specialty, Stipend);
        }
    }
}
