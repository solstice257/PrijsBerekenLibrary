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
            doc.SetMargins(100f,20f,100f,20f);
            //get the current directory
            string path = Environment.CurrentDirectory;
            //get PdfWriter object
            PdfWriter.GetInstance(doc, new FileStream(path + "/receipt.pdf", FileMode.Create));
            //open the document for writing
            doc.Open();
            PdfPTable productTable = new PdfPTable(5);

            productTable.AddCell("Product");
            productTable.AddCell("Prijs");
            productTable.AddCell("Aantal");
            productTable.AddCell("Totaal");
            productTable.AddCell("Btw %");

            //write the products to the document

            foreach (Product product in products)
            {
                productTable.AddCell(product.name);
                productTable.AddCell("€" + Convert.ToString(product.price));
                productTable.AddCell(Convert.ToString(product.amount));
                productTable.AddCell("€" + Convert.ToString(product.price * product.amount));
                productTable.AddCell("21%");
            }

            productTable.HorizontalAlignment = Element.ALIGN_LEFT;
            doc.Add(productTable);
 
            PdfPTable priceTable = new PdfPTable(3);

            priceTable.WidthPercentage = 50f;
            priceTable.HorizontalAlignment = Element.ALIGN_LEFT;

            doc.Add(new Paragraph("\n"));

            //Add the total prices
            priceTable.AddCell("Subtotaal");
            priceTable.AddCell("BTW");
            priceTable.AddCell("Totaal");

            priceTable.AddCell("€" + Convert.ToString(calculatedPrices.subTotalPrice));
            priceTable.AddCell("€" + Convert.ToString(calculatedPrices.totalBTW));
            priceTable.AddCell("€" + Convert.ToString(calculatedPrices.totalPrice));

            doc.Add(priceTable);

            //close the document
            doc.Close();
            //view the result pdf file
            System.Diagnostics.Process.Start(path + "/receipt.pdf");
        }
    }
}
