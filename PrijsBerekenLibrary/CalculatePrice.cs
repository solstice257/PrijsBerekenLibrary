using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrijsBerekenLibrary
{

    public class CalculatePrice
    {
        double totalPrice;
        double subTotalPrice;
        double totalBTW;
        public CalculatePrice()
        {

        }

        public void calculatePrice(List<Product> products)
        {
            foreach (Product product in products)
            {
                subTotalPrice = subTotalPrice + product.price;
                totalPrice = totalPrice + (product.price * 1.21);
            }
            totalBTW = totalPrice - subTotalPrice;
        }
    }
}
