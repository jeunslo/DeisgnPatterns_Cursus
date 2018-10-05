using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungalowCursus
{
    public class Fiets : BungalowDecorator
    {
        public Fiets(IPersoneelTaken taken) : base(taken)
        {

        }
        public override void ToonTaak()
        {
            base.Taken.ToonTaak();
            Console.WriteLine("Plaats fietsen bij de bungalow.");
        }
    }
}
