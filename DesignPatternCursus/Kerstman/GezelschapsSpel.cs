using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstman
{
    public class GezelschapsSpel : Speelgoed
    {
        public GezelschapsSpel() { }
        public GezelschapsSpel(decimal prijs) : base(prijs) { }
        public override void CadeauKeuze()
        {
            Console.WriteLine("Kerstman geeft een gezelschapsspel.");
        }
    }
}
