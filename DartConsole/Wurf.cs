using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartConsole
{
    [Serializable]
    class Wurf
    {
        int wurfNummer;
        static int wurfZähler = 1;
        int multiplikator;
        int wert;

        public Wurf(int multi, int wert)
        {
            wurfNummer = wurfZähler;
            wurfZähler++;
            this.multiplikator = multi;
            this.wert = wert;
        }

        public int GetWurfGesamt()
        {
            return multiplikator * wert;
        }

        public int GetMulti()
        {
            return multiplikator;
        }

        public int GetWert()
        {
            return wert;
        }

        public int GetNr()
        {
            return wurfNummer;
        }
    }
}
