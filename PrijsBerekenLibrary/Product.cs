using System;
using System.Collections.Generic;
using System.Text;

namespace PrijsBerekenLibrary
{
    public class Product
    {
        public string name { get; private set; }
        public double price { get; private set; }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
