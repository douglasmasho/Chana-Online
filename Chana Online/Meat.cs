using System;
using System.Collections.Generic;
using System.Text;

namespace Chana_Online
{
    class Meat : Product
    {
        public double CostperKG { get; set; }
        public Meat(string name, string imageURL, double costPerKG) : base(name, imageURL)
        {
            this.CostperKG = costPerKG;
        }
    }
}
