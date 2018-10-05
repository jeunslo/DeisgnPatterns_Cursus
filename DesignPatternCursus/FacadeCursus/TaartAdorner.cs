using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeCursus
{
    public abstract class TaartAdorner : IKost
    {
        public IKost Taart { get; set; }
        public TaartAdorner(IKost taart)
        {
            Taart = taart;
        }
        public abstract decimal Kost();
    }
}
