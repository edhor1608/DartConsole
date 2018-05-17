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
        private int id_leg;
        public static int id_leg_zähler = 0;
        List<Durchgang> durchgänge;
        int legNummer;
        public static int legZähler = 0;
        private int rest;
        private int finish = -1;

        public Leg()
        {
            id_leg = id_leg_zähler;
            id_leg_zähler++;
            legNummer = legZähler;
            durchgänge = new List<Durchgang>();
            //legZähler++;
        }

        public Leg(int id, int legNummer, int rest, int finish)
        {
            id_leg = id;
            this.legNummer = legNummer;
            this.rest = rest;
            this.finish = finish;
            durchgänge = new List<Durchgang>();
        }

        public void SetDurchgänge(List<Durchgang> durchgänge)
        {
            this.durchgänge = durchgänge;
        }

        public int GetId()
        {
            return id_leg;
        }

        public int GetLegNummer()
        {
            return legNummer;
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

        public void SetFinish(int finish)
        {
            this.finish = finish;
        }

        public int GetFinish()
        {
            return finish;
        }

        public bool HasFinished()
        {
            if (finish != -1) return true;
            return false;
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
