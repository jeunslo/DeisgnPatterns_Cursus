using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCursus
{
    public class Inwoner
    {
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public int AantalKinderen { get; set; }
        public int AantalKeerVerhuisd { get; set; }
        public bool Gehuwd { get; set; }
        public bool Gescheiden { get; set; }
        public Inwoner() { }
        public Inwoner(string voornaam, string familienaam, int aantalKinderen, int aantalKeerVerhuisd, bool gehuwd, bool gescheiden)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
            AantalKeerVerhuisd = aantalKeerVerhuisd;
            AantalKinderen = aantalKinderen;
            Gehuwd = gehuwd;
            Gescheiden = gescheiden;
        }

        public override string ToString()
        {
            return Voornaam +' '+ Familienaam;
        }

        public class InwonerBuilder
        {
            public string Voornaam { get; set; }
            public string Familienaam { get; set; }
            public int AantalKinderen { get; set; }
            public int AantalKeerVerhuisd { get; set; }
            public bool Gehuwd { get; set; }
            public bool Gescheiden { get; set; }
            public InwonerBuilder metVoornaam(string voornaam)
            {
                Voornaam = voornaam;
                return this;
            }
            public InwonerBuilder metFamilienaam(string familienaam)
            {
                Familienaam = familienaam;
                return this;
            }
            public InwonerBuilder metAantalKinderen(int aantalKinderen)
            {
                AantalKinderen = aantalKinderen;
                return this;
            }
            public InwonerBuilder metAantalKeerVerhuisd(int aantalKeerVerhuisd)
            {
                AantalKeerVerhuisd = aantalKeerVerhuisd;
                return this;
            }
            public InwonerBuilder metGehuwd(bool gehuwd)
            {
                Gehuwd = gehuwd;
                return this;
            }
            public InwonerBuilder metGescheiden(bool gescheiden)
            {
                Gescheiden = gescheiden;
                return this;
            }
            public Inwoner MaakInwoner()
            {
                return new Inwoner(Voornaam, Familienaam, AantalKinderen, AantalKeerVerhuisd, Gehuwd, Gescheiden);
            }
        }
    }
}
