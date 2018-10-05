using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            var deMotor = Motor.GetInstance();
            deMotor.Start();

            var mijnMotor = Motor.GetInstance();
            mijnMotor.Start();
            var mijnVersnelling = Versnellingsbak.GetInstance();
            mijnVersnelling.VersnellingKiezen(1);
            mijnVersnelling.VersnellingKiezen(7);
            mijnVersnelling.VersnellingKiezen(-1);
            mijnVersnelling.VersnellingKiezen(2);
            mijnMotor.Stop();


            Console.ReadLine();
        }
    }
}
