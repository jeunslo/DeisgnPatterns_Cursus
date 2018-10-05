using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeCursus
{
    public class MetChocolade : KoffieDecorator
    {
        public MetChocolade(IKost koffie) : base(koffie)
        {

        }
        //public override string GetBereidingswijze()
        //{
        //    return base.Koffie.GetBereidingswijze() + "Met chocolade";
        //}

        //public override decimal GetKost()
        //{
        //    return base.Koffie.GetKost() + 2m;
        //}

        public override decimal Kost()
        {
            return base.Koffie.Kost() + 2m;
        }
    }
}
