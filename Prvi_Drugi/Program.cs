using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvi_Drugi
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box("ShippingBox#1");
            Product product1 = new Product("Slušalice", 350, 2.5);
            Product product2 = new Product("Mehanička tipkovnica", 450, 3.5);
            box.Add(product1);
            box.Add(product2);

            ShippingService price = new ShippingService(5);
            double BoxWeight = 0;
            BoxWeight += box.Weight;

            Console.WriteLine(box.Description());
            Console.WriteLine(price.ToString() + price.Price(BoxWeight) + " kn");
        }
    }
}
