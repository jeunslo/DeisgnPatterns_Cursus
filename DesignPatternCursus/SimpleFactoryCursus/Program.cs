using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            //DocumentFactory factory = new DocumentFactory();
            DocumentFactory factory = DocumentFactory.GetInstance();
            Document document = factory.Open("liedje.docx");
            document.PrintPreview();
            document.Print();
        }
    }
}
