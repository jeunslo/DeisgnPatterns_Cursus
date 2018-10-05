using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungalowCursus
{
    public abstract class BungalowDecorator : IPersoneelTaken
    {
        public BungalowDecorator(IPersoneelTaken taken)
        {
            Taken = taken;
        }

        public IPersoneelTaken Taken { get; set; }
        public abstract void ToonTaak();
    }
}
