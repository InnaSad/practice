using System;

namespace _2
{
    public class Product : Detail
    {
        int count;
        string name_product;
        public Product() : base()
        {
            this.count = 0;
            this.name_product = String.Empty;
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите название изделия");
            name_product = Console.ReadLine();
            Console.WriteLine("Введите количество механизмов в изделии");
            count = Convert.ToInt32(Console.ReadLine());
        }
        public override string Vivod()
        {
            return base.Vivod() + " Название изделия - " + name_product + " Количество механизмов в изделии - " + count + " ";
        }
    }
    public class Knot : Detail
    {
        string name_knot;
        public Knot() : base()
        {
            this.name_knot = String.Empty;
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите название узла ");
            name_knot = Console.ReadLine();
        }
        public override string Vivod()
        {
            return base.Vivod() + " Название узла - " + name_knot + " ";
        }

    }
    public class Mechanism : Detail
    {
        string name_mechanism;
        public Mechanism() : base()
        {
            this.name_mechanism = String.Empty;
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите название механизма");
            name_mechanism = Console.ReadLine();
        }
        public override string Vivod()
        {
            return base.Vivod() + " Название механизма - " + name_mechanism + " ";
        }
    }
    public class Detail
    {
        string name_detail, material;
        int number;
        public Detail()
        {
            this.name_detail = String.Empty;
            this.number = 0;
            this.material = String.Empty;
            Vvod();
        }
        public void Vvod()
        {
            Console.WriteLine("Введите название детали");
            name_detail = Console.ReadLine();
            Console.WriteLine("Введите номер детали");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите материал детали");
            material = Console.ReadLine();
        }
        public virtual string Vivod()
        {
            return "Название детали - " + name_detail + " Номер детали - " + number + " Материал детали - " + material + " ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            oper: Console.WriteLine("1-создание механизма, 2-создание узла, 3-создание изделия");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    Mechanism mechanism = new Mechanism();
                    Console.WriteLine(mechanism.Vivod());
                    break;
                case "2":
                    Knot knot = new Knot();
                    Console.WriteLine(knot.Vivod());
                    break;
                case "3":
                    Product product = new Product();
                    Console.WriteLine(product.Vivod());
                    break;
                default:
                    Console.WriteLine("Выберите одну из предложенных операций:");
                    goto oper;
            }
            Console.ReadLine();
        }
    }
}
