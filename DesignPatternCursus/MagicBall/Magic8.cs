using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicBall
{
    public class Magic8
    {
        private Magic8() { }
        private int randomInt;
        private static Magic8 _uniqueInstance;
        private static string[] antwoorden =
        {
            "Zoals ik het zie, ja.",
            "Het is zeker.",
            "Hoogst waarschijnlijk.",
            "Ziet er goed uit",
            "Zonder twijfel.",
            "Ja.","Zeker.",
            "Je mag er op rekenen.",
            "Vraag dat later nog eens.",
            "Dit wil je niet weten.",
            "Ik kan dit nu niet voorspellen.",
            "Concentreer je en stel je vraag opnieuw.",
            "Je moet er niet op rekenen.",
            "Nee.","Ziet er niet goed uit.",
            "Zeer twijfelachtig."
        };
        public static Magic8 GetInstance()
        {
            if (_uniqueInstance == null)
                _uniqueInstance = new Magic8();
            return _uniqueInstance;
        }

        public string GetRandomAnwser()
        {
            Random rdm = new Random();
            int tempInt;
            do
            {
                tempInt = rdm.Next(0, 15);
            }
            while (tempInt == randomInt);
            randomInt = tempInt;
            return antwoorden[randomInt];
        }

    }
}
