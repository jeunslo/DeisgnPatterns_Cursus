using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon[] personen = new Persoon[] { new Persoon("Jean", "Smits", "heer"),
                                                 new Persoon("Jeanine", "Desmet", "mevrouw")};
            foreach (Persoon persoon in personen)
            {
                Console.WriteLine(persoon.MaakBriefHoofding(x => "Dag " + x.Voornaam));
            }

            foreach (Persoon persoon in personen)
            {
                //persoon.algoritme += new Aanspreking(x => "Geachte " + x.Titel + " " + x.Familienaam);
                Console.WriteLine(persoon.MaakBriefHoofding(x => "Geachte " + x.Titel + " " + x.Familienaam));
            }
        }
    }
}
