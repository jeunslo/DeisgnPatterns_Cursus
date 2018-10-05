using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            Inwoner.InwonerBuilder builder = new Inwoner.InwonerBuilder();
            Inwoner inwoner = builder.metVoornaam("Olivier")
                                     .metFamilienaam("Gerard")
                                     .metAantalKinderen(1)
                                     .metAantalKeerVerhuisd(3)
                                     .metGehuwd(true)
                                     .MaakInwoner();
            Inwoner anoniemeInwoner = new Inwoner()
            {
                Voornaam = "Olivier",
                Familienaam = "Gerard",
                AantalKinderen = 1,
                AantalKeerVerhuisd = 3,
                Gehuwd = true,
                Gescheiden = false
            };
            Console.WriteLine(inwoner);
            Console.WriteLine(anoniemeInwoner);
            Console.ReadLine();
        }
    }
}
