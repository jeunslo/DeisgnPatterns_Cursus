using FacadeCursus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            IKost koffie1 = new MetMelk(new EenvoudigeKoffie());
            IKost koffie2 = new EenvoudigeKoffie();
            IKost koffie3 = new MetChocolade(new MetMelk(new EenvoudigeKoffie()));
            IKost taart = new Taart();
            IKost taart2 = new MetSlagroom(new MetAardbei(new Taart()));
            IKost mixUp = new MetSlagroom(new MetMelk(new EenvoudigeKoffie()));
            //Bestelling bestelling = new Bestelling
            //{
            //    KoffieList = new List<IKoffie> { koffie1, koffie2, koffie3 },
            //    TaartList = new List<IKost> { taart, taart2 }
            //};
            //Bestelling bestelling = new Bestelling
            //{
            //    List = new List<IKoffie> { koffie1, koffie2, koffie3 },
            //    TaartList = new List<IKost> { taart, taart2 }
            //};
            //Console.WriteLine(bestelling.Kost());
            //decimal taartprix = 0m;
            //bestelling.TaartList.ForEach(x => taartprix += x.Kost());
            //Console.WriteLine("Taarprix {0}", taartprix);
            //bestelling.KoffieList.ForEach(x => Console.WriteLine(x.GetBereidingswijze()));
            
        }
    }
}
