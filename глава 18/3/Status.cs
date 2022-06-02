using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Status : Plans
    {
        string status;
        public Status(string date, string plan, string status)
        : base(date, plan)
        {
            this.status = status;
        }
        override public void PrintPlan()
        {

            Console.WriteLine("План на " + date + ": " + plan + " Статус: " + status);
        }
    }
}
