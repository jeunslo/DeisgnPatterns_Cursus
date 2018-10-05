using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeCursus
{
    public class Taart : IKost
    {
        public decimal Prijs { get; set; }

        public decimal Kost()
        {
            Prijs = 3m;
            return Prijs;
        }
    }
}
