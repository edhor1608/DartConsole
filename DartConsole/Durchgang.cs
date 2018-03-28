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
    }
}
