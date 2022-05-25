using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Nurse : Medic
    {
        public int p;
        public int income;
        public Nurse()
        {
            this.p = 0;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Введите количество отработанных часов за неделю: ");
            p = int.Parse(Console.ReadLine());
        }
        public virtual void IncomeNurse()
        {
            income = 10 * p;
        }
        public override void GetInfo()
        {
            IncomeNurse();
            Console.WriteLine("Имя: {0} \nДолжность: {1} \nКоличество отработанных часов за неделю: {2} \nДоход: {3}", name, post, p, income);
        }
    }
}
