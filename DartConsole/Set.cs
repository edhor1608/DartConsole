using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartConsole
{
    [Serializable]
    class Set
    {
        List<Leg> legs;
        Spieler spieler;
        int setNummer;
        static int setZähler = 1;

        public Set(Spieler spieler)
        {
            this.spieler = spieler;
            setNummer = setZähler;
            setZähler++;
        }

        public Set(String name)
        {
            this.spieler = Dart.GetSpieler(name);
            setNummer = setZähler;
            setZähler++;
        }

        
    }
}
