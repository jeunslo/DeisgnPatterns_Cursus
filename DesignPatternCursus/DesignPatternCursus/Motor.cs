using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCursus
{
    public class Motor
    {
        private static Motor _uniekeInstantie;
        private bool gestart;
        private Motor() { }

        public static Motor GetInstance()
        {
            if (_uniekeInstantie == null)
                _uniekeInstantie = new Motor();
            return _uniekeInstantie;
        }

        public void Start()
        {
            if(!gestart)
            {
                gestart = true;
                Console.WriteLine("Motor werd gestart.");
            }
            else
                Console.WriteLine("Motor werd reeds gestart.");
        }

        public void Stop()
        {
            if(gestart)
            {
                gestart = false;
                Console.WriteLine("Motor werd gestopt");
            }
            else
                Console.WriteLine("Motor werd reeds gestopt.");
        }
    }
}
