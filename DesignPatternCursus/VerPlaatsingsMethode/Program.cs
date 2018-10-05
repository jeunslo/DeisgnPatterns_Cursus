using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPlaatsingsMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vervoering> vervoeringList = new List<Vervoering>
            {
                new Vervoering{ Temperatuur = 37, WindType = Wind.zacht },
                new Vervoering{ Temperatuur = 37, WindType = Wind.hard },
                new Vervoering{ Temperatuur = 37, WindType = Wind.medium }
            };

            foreach (var vervoer in vervoeringList)
            {
                switch (vervoer.WindType)
                {
                    case Wind.zacht:
                        vervoer.SteekMeerOver(() => "Schaatsen over het ijs");
                        break;
                    case Wind.medium:
                        vervoer.SteekMeerOver(() => "Zeilen over het meer");
                        break;
                    case Wind.hard:
                        vervoer.SteekMeerOver(() => "Varen over het meer met motorboot");
                        break;
                    default:
                        throw new Exception("Verkeerde windtype");
                }
            }
        }
    }
}
