using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCursus
{
    public class Versnellingsbak
    {
        private static Versnellingsbak _uniekeInstantie;
        private int versnelling;
        private Versnellingsbak() { }
        public static Versnellingsbak GetInstance()
        {
            if (_uniekeInstantie == null)
                _uniekeInstantie = new Versnellingsbak();
            return _uniekeInstantie;
        }

        public void VersnellingKiezen(int naarVersnelling)
        {
            if (naarVersnelling < -1 || naarVersnelling > 5)
            {
                Console.WriteLine("verkeerde versnelling");
            }
            else
            {
                if (versnelling == -1)
                    Console.WriteLine("Van achteruit naar {0}e versnelling", naarVersnelling);
                else
                {
                    if (naarVersnelling == -1)
                        Console.WriteLine("Van versnelling {0} naar achteruit", versnelling);
                    if (naarVersnelling > -1 && naarVersnelling < 6)
                    {
                        Console.WriteLine("Van versnelling {0} naar {1}e versnelling", versnelling, naarVersnelling);
                    }
                }
                versnelling = naarVersnelling;
            }
        }
    }
}
