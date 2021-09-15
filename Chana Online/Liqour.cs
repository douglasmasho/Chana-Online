using System;
using System.Collections.Generic;
using System.Text;

namespace Chana_Online
{
    class Liqour : Product
    {
        public double Cost { get; set; }

        public Liqour(string name, string imageURL, double cost, double vat = 0.2) : base(name, imageURL, vat, "0")
        {
            this.Cost = cost;
        }
    }
}

