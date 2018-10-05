using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPlaatsingsMethode
{
    public delegate string VervoersType();
    public class Vervoering
    {
        public decimal Temperatuur { get; set; }
        public Wind WindType { get; set; }


        public void SteekMeerOver(VervoersType vervoer)
        {
            Console.WriteLine("Inpakken");
            Console.WriteLine(vervoer());
            Console.WriteLine("Uitpakken");
        }
        
    }
    public enum Wind
    {
        zacht, medium, hard
    }
}
