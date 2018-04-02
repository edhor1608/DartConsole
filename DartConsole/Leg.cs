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

        public int RedRest(int wurf)
        {
            this.rest -= wurf;
            // Finish
            if (this.rest == 0)
            {
                return 1;
            }
            //No Socre
            else if (this.rest < 0 || this.rest == 1)
            {
                return 2;
            }
            // Normal
            return 0;
        }

        public int GetRest()
        {
            return rest;
        }

        public int AnzahlDurchgänge()
        {
            return durchgänge.Count();
        }

        public List<Durchgang> GetDurchgänge()
        {
            return durchgänge;
        }

        public void AddDurchgang()
        {
            if (rest > 170)
            {
                durchgänge.Add(new Durchgang(false));
            }
            else
            {
                durchgänge.Add(new Durchgang(true));
            }
        }

        public Durchgang GetDurchgangAktuell()
        {
            return durchgänge[AnzahlDurchgänge() - 1];
        }
    }
}
