using System;

namespace Furniture
{
    public class Wardrobe : Furnitures
    {
        public string form;
        public string material;
        public int cost;
        public int height;
        public Wardrobe(string form, string material, int cost, int height)
        {            
            this.form = form;
            this.material = material;
            this.cost = cost;
            this.height = height;
        }
        public override void Opisanie()
        {
            Console.WriteLine("Шкаф {0} Материал: {1} Цена: {2} Высота: {3}", form, material, cost, height);
        }
        public override void Height()
        {
            if (height >= 200) Console.WriteLine("Шкаф высокий");
            if (height >= 100 && height < 200) Console.WriteLine("Шкаф средний");
            else if (height < 100) Console.WriteLine("Шкаф низкий");
        }
    }
}
