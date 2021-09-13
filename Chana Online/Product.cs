using System;
using System.Collections.Generic;
using System.Text;

namespace Chana_Online
{
    class Product
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public double TotalCost { get; set; }
        public double VAT { get; set; }
        public string Quantity { get; set; }


        public Product(string name, string imageURL, double vat, string quantity)
        {
            this.Name = name;
            this.ImageURL = imageURL;
            this.TotalCost = 0;
            this.VAT = vat;
            this.Quantity = "0";
        }

    }
}
