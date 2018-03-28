using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartConsole
{
    [Serializable]
    class Durchgang
    {
        int durchgangNummer;
        static int durchgangZähler = 1;
        Wurf[] würfe = new Wurf[3];

        public Durchgang()
        {
            durchgangNummer = durchgangZähler;
            durchgangZähler++;
        }

        public void AddWurf(int i, int multi, int wert)
        {
            würfe[i+1] = new Wurf(multi, wert);
        }

        public int GetDurchgangWert()
        {
            return würfe[0].GetWurfGesamt() + würfe[1].GetWurfGesamt() + würfe[2].GetWurfGesamt();
        }

        public Wurf[] GetWürfe()
        {
            return würfe;
        }
    }
}
