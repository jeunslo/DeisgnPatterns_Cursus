using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class Eiland
    {
        public List<IInwoner> Inwoners { get; set; } = new List<IInwoner>();
        public void Add(IInwoner inwoner)
        {
            Inwoners.Add(inwoner);
        }

        public void GetReacties()
        {
            foreach (var inwoner in Inwoners)
            {
                inwoner.Reactie();
            }
        }
    }
}
