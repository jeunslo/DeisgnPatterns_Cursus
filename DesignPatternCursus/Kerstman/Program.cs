using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoe oud ben je?");
            if (int.TryParse(Console.ReadLine(), out int leeftijd))
            {
                var factory = SpeelgoedFactory.GetInstance();
                Speelgoed speelgoed = factory.SelecteerCadeauOpLeeftijd(leeftijd);
                speelgoed.CadeauKeuze();
            }
        }
    }
}
