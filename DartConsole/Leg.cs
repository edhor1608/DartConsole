using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartConsole
{
    [Serializable]
    class Leg
    {
        List<Durchgang> durchgänge;
        int legNummer;
        static int legZähler = 1;

        public Leg()
        {
            legNummer = legZähler;
            legZähler++;
        }
    }
}
