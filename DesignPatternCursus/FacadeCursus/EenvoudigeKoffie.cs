using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeCursus
{
    public class EenvoudigeKoffie : IKoffie, IKost
    {
        public decimal Prijs { get; set; }

        public string GetBereidingswijze()
        {
            return "Neem een koffie ";
        }

        public decimal GetKost()
        {
            Prijs = 4m;
            return Prijs;
        }

        public decimal Kost()
        {
            Prijs = 4m;
            return Prijs;
        }
    }
}
