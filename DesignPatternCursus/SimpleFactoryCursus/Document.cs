using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCursus
{
    public abstract class Document
    {
        public string Bestandsnaam { get; set; }

        protected Document(string bestandsnaam)
        {
            Bestandsnaam = bestandsnaam;
        }
        public abstract void Print();
        public abstract void PrintPreview();
    }
}
