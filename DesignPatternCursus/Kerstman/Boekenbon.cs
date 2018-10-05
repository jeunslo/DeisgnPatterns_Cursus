using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstman
{
    public class Boekenbon : Speelgoed
    {
        public Boekenbon() { }
        public Boekenbon(decimal prijs) : base(prijs) { }
        public override void CadeauKeuze()
        {
            Console.WriteLine("Kerstman geeft een boekenbon.");
        }
    }
}
