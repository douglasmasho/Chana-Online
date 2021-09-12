using System;
using System.Collections.Generic;
using System.Text;

namespace Chana_Online
{
    class Product
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }

        public Product(string name, string imageURL)
        {
            this.Name = name;
            this.ImageURL = imageURL;
        }

    }
}
