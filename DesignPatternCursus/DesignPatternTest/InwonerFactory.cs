using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class InwonerFactory
    {
        public IInwoner GetSoortInwoner(string letter)
        {
            switch(letter)
            {
                case "V":
                    return new Vogel();
                case "Z":
                    return new Zoogdier();
                default:
                    throw new Exception("Er is een verkeerde letter voor de soort.");
            }
        }
    }
}
