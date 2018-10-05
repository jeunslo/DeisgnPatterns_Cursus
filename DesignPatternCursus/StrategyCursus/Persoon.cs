using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCursus
{
    public delegate string Aanspreking(Persoon persoon);
    public class Persoon
    {
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public string Titel { get; set; }
        public Persoon(string voornaam, string familienaam, string titel)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
            Titel = titel;
        }
        //public event Aanspreking algoritme;
        public string MaakBriefHoofding(Aanspreking algoritme)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Brussel,");
            builder.Append(DateTime.Now.ToString("d/M/yyyy"));
            builder.Append("\n");
            builder.Append(algoritme(this));
            builder.Append("\n");
            return builder.ToString();
        }
    }
}
