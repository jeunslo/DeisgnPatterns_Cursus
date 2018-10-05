using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeCursus
{
    public class MetAardbei : TaartAdorner
    {
        public MetAardbei(IKost taart) : base(taart)
        {

        }

        public override decimal Kost()
        {
            return base.Taart.Kost() + 5m;
        }
    }
}
