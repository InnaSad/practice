using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Doctor : Medic
    {
        public int p;
        public int income;
        public Doctor()
        {
            this.p = 0;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Введите количество принятых пациентов за неделю: ");
            p = int.Parse(Console.ReadLine());
        }
        public virtual void IncomeDoctor()
        {
            income = 8 * p;
        }
        public override void GetInfo()
        {
            IncomeDoctor();
            Console.WriteLine("Имя: {0} \nДолжность: {1} \nКоличество принятых пациентов за неделю: {2} \nДоход: {3}", name, post, p, income);
        }
    }
}
