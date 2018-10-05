using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class Vogel : IInwoner
    {
        public string Naam { get; set; }
        public void Reactie()
        {
            Console.WriteLine("{0} vliegt hoger op.", Naam);
        }
    }
}
