using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeCursus
{
    public class Bestelling
    {
        public Bestelling()
        {
            
        }
        public List<IKost> BestellingList { get; set; }
        public decimal Kost()
        {
            decimal totalePrijs = 0m;
            foreach (var item in BestellingList)
            {
                totalePrijs += item.Kost();
            }
            return totalePrijs;
        }
        //public List<EenvoudigeKoffie> KoffieList { get; set; }
        //public List<Taart> TaartList { get; set; }
        //public decimal GetKost()
        //{
        //    decimal totalePrijs = 0m;
        //    foreach (var item in TaartList)
        //    {
        //        totalePrijs += item.Kost();
        //    }
        //    foreach (var item2 in KoffieList)
        //    {
        //        totalePrijs += item2.GetKost();
        //    }
        //    return totalePrijs;
        //}
    }
}
