using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder locatie = new StringBuilder();
            Console.WriteLine("Wat is de locatie van het bestandje?");
            locatie.Append(Console.ReadLine());
            Console.WriteLine("Welk tekstbestandje wil je gebruiken?");
            locatie.Append(@"\" + Console.ReadLine());

            InwonerFactory factory = new InwonerFactory();
            try
            {
                string regel;
                Eiland eiland = new Eiland();
                using (var lezer = new StreamReader(locatie.ToString()))
                {
                    while((regel = lezer.ReadLine()) != null)
                    {
                        IInwoner inwoner = factory.GetSoortInwoner(regel.Substring(0, 1).ToString());
                        inwoner.Naam = regel.Substring(regel.IndexOf("=") + 1);
                        eiland.Add(inwoner);
                    }
                }
                Console.WriteLine();
                eiland.GetReacties();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
