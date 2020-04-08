using System;
using System.Collections.Generic;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using it = iTextSharp.text;


namespace PrijsBerekenLibrary
{
    public class PrintReceipt
    {
        public PrintReceipt()
        {

        }
        public void printReceipt(List<Product> products)
        {
            //create a document object
            var doc = new Document();
            //get the current directory
            string path = Environment.CurrentDirectory;
            //get PdfWriter object
            PdfWriter.GetInstance(doc, new FileStream(path + "/pdfdoc.pdf", FileMode.Create));
            //open the document for writing
            doc.Open();
            //write the products to the document
            foreach (Product product in products)
            {
                doc.Add(new Paragraph(product.name + ": €" + product.price));
            }
            //close the document
            doc.Close();
            //view the result pdf file
            System.Diagnostics.Process.Start(path + "/pdfdoc.pdf");
        }
    }
}
