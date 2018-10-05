using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicBall
{
    class Program
    {
        static void Main(string[] args)
        {
            var eightBall = Magic8.GetInstance();
            string vraag;
            do
            {
                Console.WriteLine("Stel jouw vraag:");
                vraag = Console.ReadLine();
                Console.WriteLine(eightBall.GetRandomAnwser());
                Console.WriteLine();
            }
            while (vraag != "stop");
        }
    }
}
