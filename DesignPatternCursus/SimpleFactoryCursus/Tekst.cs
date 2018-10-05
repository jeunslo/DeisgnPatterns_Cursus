using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCursus
{
    public class Tekst : Document
    {
        public Tekst(string bestandsnaam) : base(bestandsnaam) { }
        public override void Print()
        {
            Console.WriteLine("Een afdruk van een tekst"); 
        }
        public override void PrintPreview()
        {
            Console.WriteLine("Een afdrukvoorbeeld van een tekst");
        }
    }
}
