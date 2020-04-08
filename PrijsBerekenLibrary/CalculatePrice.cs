using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrijsBerekenLibrary
{

    public class CalculatePrice
    {
        public double totalPrice { get; private set; }
        public double subTotalPrice { get; private set; }
        public double totalBTW { get; private set; }

        public CalculatePrice()
        {

        }

        public void calculatePrice(List<Product> products)
        {
            foreach (Product product in products)
            {
                subTotalPrice = Math.Round(subTotalPrice + product.amount * product.price, 2);
                totalPrice = Math.Round(totalPrice + product.amount * (product.price * 1.21), 2);
            }
            totalBTW = totalPrice - subTotalPrice;
        }
    }
}
