using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeCursus
{
    public class MetMelk : KoffieDecorator
    {
        public MetMelk(IKost koffie) : base(koffie)
        {

        }

        //public override string GetBereidingswijze()
        //{
        //    return base.Koffie.GetBereidingswijze() + "Met melk";
        //}

        //public override decimal GetKost()
        //{
        //    return base.Koffie.GetKost() + 1m;
        //}

        public override decimal Kost()
        {
            return base.Koffie.Kost() + 1m;
        }
    }
}
