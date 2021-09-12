using System;
using System.Collections.Generic;
using System.Text;

namespace Chana_Online
{
    class Grocery : Product
    {
        public double Cost { get; set; }
        public double VAT { get; set; }
        public Grocery(string name, string imageURL, double cost, double vat) : base(name, imageURL)
        {
            this.Cost = cost;
            this.VAT = vat;
        }
    }
}
