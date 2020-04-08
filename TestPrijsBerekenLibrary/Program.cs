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
            PrintReceipt print = new PrintReceipt();
            print.printReceipt();
            
        }
    }
}
