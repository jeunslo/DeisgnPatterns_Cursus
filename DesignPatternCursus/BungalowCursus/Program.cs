using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungalowCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersoneelTaken bungalow = new Bungalow();
            Console.WriteLine("Wil je een barbeque bij de bungalow? j/n");
            System.ConsoleKeyInfo antwoord = Console.ReadKey();
            Console.WriteLine();
            while (antwoord.Key != ConsoleKey.J && antwoord.Key != ConsoleKey.N)
            {  
                Console.WriteLine("Voer j of n in");
                antwoord = Console.ReadKey();
            }
            bungalow = antwoord.Key == ConsoleKey.J ? new Barbecue(bungalow) : bungalow;

            Console.WriteLine("Wil je een fiets bij de bungalow? j/n");
            antwoord = Console.ReadKey();
            Console.WriteLine();
            while (antwoord.Key != ConsoleKey.J && antwoord.Key != ConsoleKey.N)
            {
                Console.WriteLine("Voer j of n in");
                antwoord = Console.ReadKey();
            }
            Console.WriteLine();
            bungalow = antwoord.Key == ConsoleKey.J ? new Fiets(bungalow) : bungalow;
            Console.WriteLine("Taken:");
            bungalow.ToonTaak();
            Console.ReadLine();
        }
    }
}
