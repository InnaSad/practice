using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Plans
    {
        public string date;
        public string plan;
        public Plans(string date, string plan)
        {
            this.date = date;
            this.plan = plan;
        }
        virtual public void PrintPlan()
        {
            Console.WriteLine("План на " + date + ": " + plan);
        }
    }
}
