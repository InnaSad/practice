using System;

namespace Furniture
{
    public class Sofa : Furnitures
    {
        public string form;
        public string material;
        public int cost;
        public int height;
        public Sofa(string form, string material, int cost, int height)
        {            
            this.form = form;
            this.material = material;
            this.cost = cost;
            this.height = height;
        }
        public override void Opisanie()
        {
            Console.WriteLine("Диван {0} Материал: {1} Цена: {2} Высота: {3}", form, material, cost, height);
        }
        public override void Height()
        {
            if (height >= 100) Console.WriteLine("Диван высокий");
            if (height >= 50 && height < 100) Console.WriteLine("Диван средний");
            else if (height < 50) Console.WriteLine("Диван низкий");
        }
    }
}
