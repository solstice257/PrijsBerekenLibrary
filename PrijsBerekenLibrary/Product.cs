using System;
using System.Collections.Generic;
using System.Text;

namespace PrijsBerekenLibrary
{
    public class Product
    {
        public string name { get; private set; }
        public double price { get; private set; }
        public int amount { get; private set; }

        public Product(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }
    }
}
