using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeCursus
{
    public abstract class KoffieDecorator : /*IKoffie,*/ IKost
    {
        public IKost Koffie { get; set; }
        public KoffieDecorator(IKost koffie)
        {
            Koffie = koffie;
        }

        //public abstract decimal GetKost();

        //public abstract string GetBereidingswijze();

        public abstract decimal Kost();
    }
}
