using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstman
{
    public class SpeelgoedFactory
    {
        private static SpeelgoedFactory _uniekeFactory;
        private SpeelgoedFactory() { }
        public static SpeelgoedFactory GetInstance()
        {
            if (_uniekeFactory == null)
                _uniekeFactory = new SpeelgoedFactory();
            return _uniekeFactory;
        }
        public Speelgoed SelecteerCadeauOpLeeftijd(int leeftijd)
        {
            if (leeftijd <= 5)
                return new Pop();
            else
            {
                if (leeftijd > 12)
                    return new Boekenbon();
                else
                    return new GezelschapsSpel();
            }
        }
    }
}
