using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCursus
{
    public class Presentatie : Document
    {
        public Presentatie(string bestandsnaam) : base(bestandsnaam) { }

        public override void Print()
        {
            Console.WriteLine("Een afdruk van een presentatie");
        }

        public override void PrintPreview()
        {
            Console.WriteLine("Een afdrukvoorbeeld van een presentatie");
        }
    }
}
