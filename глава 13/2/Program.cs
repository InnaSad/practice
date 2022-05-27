using System;

namespace _2
{
    public class MyInfo
    {
        public event EventHandler<NameChange> nameEvent = delegate { };
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = "Вася";
                nameEvent(this, new NameChange(string.Format("Имя было изменено с {0} на {1}", name, value)));
                name = value;
            }
        }
    }
    public class NameChange 
    {
        public readonly string Message;
        public NameChange(string msg)
        {
            Message = msg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string n = Console.ReadLine();
            MyInfo p = new MyInfo();
            p.nameEvent += new EventHandler<NameChange>(p_nameEvent);
            p.Name = n;
            Console.ReadLine();
        }
        static void p_nameEvent(object sender, NameChange e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
