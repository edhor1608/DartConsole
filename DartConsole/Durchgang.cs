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
        public static int durchgangZähler = 1;
        Wurf[] würfe = new Wurf[3];

        public Durchgang()
        {
            durchgangNummer = durchgangZähler;
            //durchgangZähler++;
            würfe[0] = new Wurf(0,0);
            würfe[1] = new Wurf(0, 0);
            würfe[2] = new Wurf(0, 0);
        }

        public int AddWurf(Wurf w, int i)
        {
            würfe[i] = w;
            return w.GetWurfGesamt();
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
