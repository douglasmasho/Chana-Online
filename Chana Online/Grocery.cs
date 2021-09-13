using System;
using System.Collections.Generic;
using System.Text;

namespace Chana_Online
{
    class Grocery : Product
    {
        public double Cost { get; set; }

        public Grocery(string name, string imageURL, double cost, double vat) : base(name, imageURL,vat,"0")
        {
            this.Cost = cost;
        }
    }
}
