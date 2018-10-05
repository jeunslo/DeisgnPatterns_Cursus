using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeCursus
{
    public class MetSlagroom : TaartAdorner
    {
        public MetSlagroom(IKost taart) : base(taart)
        {

        }
        public override decimal Kost()
        {
            return base.Taart.Kost() + 1m;
        }
    }
}
