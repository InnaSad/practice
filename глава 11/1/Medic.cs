using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    abstract class Medic
    {
        public string name;
        public string post;
        public Medic()
        {
            this.name = null;
            this.post = null;
        }
        public virtual void Input()
        {
            Console.Write("Введите имя медработника: ");
            name = Console.ReadLine();
            Console.Write("Введите должность медработника: ");
            post = Console.ReadLine();
        }
        public virtual void GetInfo()
        {
            Console.WriteLine("Имя: {0} \nДолжность: {1}", name, post);
        }
    }
}
