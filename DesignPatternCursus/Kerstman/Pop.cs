using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstman
{
    public class Pop : Speelgoed
    {
        public Pop() { }
        public Pop(decimal prijs) : base(prijs) { }
        public override void CadeauKeuze()
        {
            Console.WriteLine("Kerstman geeft een pop.");
        }
    }
}
