using System;
using System.Collections.Generic;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace PrijsBerekenLibrary
{
    public class PrintReceipt
    {
        CalculatePrice calculatePrice;

        public PrintReceipt()
        {

        }
        public void printReceipt(List<Product> products, CalculatePrice calculatedPrices)
        {
            this.calculatePrice = calculatedPrices;
            //create a document object
            var doc = new Document();
            doc.SetMargins(20f,20f,100f,20f);
            //get the current directory
            string path = Environment.CurrentDirectory;
            //get PdfWriter object
            PdfWriter.GetInstance(doc, new FileStream(path + "/receipt.pdf", FileMode.Create));
            //open the document for writing
            doc.Open();
            //write the products to the document
            Paragraph productList = new Paragraph();
            productList.Alignment = 1;

            foreach (Product product in products)
            {
                productList.Add("(Aantal: " + product.amount + ") " + product.name + ": €" + product.price + "\n");
            }
            doc.Add(productList);

            //Add the total prices
            Paragraph totalPricesList = new Paragraph();
            totalPricesList.Alignment = 1;
            totalPricesList.Add("\n\nSubtotaal: " + calculatedPrices.subTotalPrice + "\nBTW: " + calculatedPrices.totalBTW + "\nTotaal: " + calculatedPrices.totalPrice);
            doc.Add(totalPricesList);

            //close the document
            doc.Close();
            //view the result pdf file
            System.Diagnostics.Process.Start(path + "/receipt.pdf");
        }
    }
}
