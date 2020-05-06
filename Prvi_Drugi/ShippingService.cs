using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvi_Drugi
{
    class ShippingService
    {
        private double PricePerKg;

        public ShippingService(double priceperkg) { this.PricePerKg = priceperkg; }

        public double Price(double weight)
        {
            return PricePerKg * weight;
        }

        public override string ToString()
        {
            return "Cijena dostave: ";
        }
    }
}
