using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstman
{
    public abstract class Speelgoed
    {
        protected Speelgoed() { }
        protected Speelgoed(decimal prijs)
        {
            Prijs = prijs;
        }
        public decimal Prijs { get; set; }

        public abstract void CadeauKeuze();
    }
}
