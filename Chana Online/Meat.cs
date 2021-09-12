using System;
using System.Collections.Generic;
using System.Text;

namespace Chana_Online
{
    class Meat : Product
    {
        public double CostperKG { get; set; }
        public double VAT { get; set; }
        public Meat(string name, string imageURL, double costPerKG, double vat) : base(name, imageURL)
        {
            this.CostperKG = costPerKG;
            this.VAT = vat;
        }
    }
}
