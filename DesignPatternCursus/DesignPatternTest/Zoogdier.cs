using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class Zoogdier : IInwoner
    {
        public string Naam { get; set; }
        public void Reactie()
        {
            Console.WriteLine("{0} schuilt in zijn hol.", Naam);
        }
    }
}
