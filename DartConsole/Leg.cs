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
        private int rest;

        public Leg()
        {
            legNummer = legZähler;
            legZähler++;
        }

        public void SetRest(int rest)
        {
            this.rest = rest;
        }

        public int GetRest()
        {
            return rest;
        }

        public int AnzahlDurchgänge()
        {
            return durchgänge.Count();
        }

        public void addDurchgang()
        {
            durchgänge.Add(new Durchgang());
        }

        public Durchgang GetDurchgangAktuell()
        {
            return durchgänge[AnzahlDurchgänge()-1];
        }
    }
}
