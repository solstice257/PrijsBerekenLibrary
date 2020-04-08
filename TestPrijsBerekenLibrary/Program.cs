using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrijsBerekenLibrary;

namespace TestPrijsBerekenLibrary
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("Melk", 2.0));
            products.Add(new Product("Cola", 6.0));
            products.Add(new Product("Nootjes", 8.5));

            PrintReceipt print = new PrintReceipt();
            print.printReceipt(products);
            
        }
    }
}
