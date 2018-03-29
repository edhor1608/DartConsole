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
        public static int legZähler = 0;
        private int rest;

        public Leg()
        {
            legNummer = legZähler;
            durchgänge = new List<Durchgang>();
            //legZähler++;
        }

        public void SetRest(int rest)
        {
            this.rest = rest;
        }

        public void RedRest(int wurf)
        {
            this.rest -= wurf;
        }

        public int GetRest()
        {
            return rest;
        }

        public int AnzahlDurchgänge()
        {
            return durchgänge.Count();
        }

        public void AddDurchgang()
        {
            durchgänge.Add(new Durchgang());
        }

        public Durchgang GetDurchgangAktuell()
        {
            return durchgänge[AnzahlDurchgänge()-1];
        }
    }
}
