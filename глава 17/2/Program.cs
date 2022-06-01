using System;
using Furniture;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 2;
            Furnitures[] furniture = new Furnitures[n];
            furniture[0] = new Wardrobe("прямой", "дерево", 900, 290);
            furniture[1] = new Sofa("угловой", "натуральная кожа", 1500, 20);
            foreach(Furnitures elem in furniture)
            {
                elem.Opisanie();
                elem.Height();
            }
            Console.ReadLine();
        }
    }
}
