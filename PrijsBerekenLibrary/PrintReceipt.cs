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
        public PrintReceipt()
        {

        }
        public void printReceipt()
        {
            //create a document object
            var doc = new Document();
            //get the current directory
            string path = Environment.CurrentDirectory;
            //get PdfWriter object
            PdfWriter.GetInstance(doc, new FileStream(path + "/pdfdoc.pdf", FileMode.Create));
            //open the document for writing
            doc.Open();
            //write a paragraph to the document
            doc.Add(new Paragraph("Hello World"));
            //close the document
            doc.Close();
            //view the result pdf file
            System.Diagnostics.Process.Start(path + "/pdfdoc.pdf");
        }
    }
}
