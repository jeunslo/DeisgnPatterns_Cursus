using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungalowCursus
{
    public class Barbecue : BungalowDecorator
    {
        public Barbecue(IPersoneelTaken taken) : base(taken)
        {

        }
        public override void ToonTaak()
        {
            base.Taken.ToonTaak();
            Console.WriteLine("Plaats een barbecue bij de bungalow.");
        }
    }
}
