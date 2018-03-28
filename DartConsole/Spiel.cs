using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartConsole
{
    [Serializable]
    class Spiel
    {
        List<Spieler> spieler;
        List<Set> sets;

        public bool HasPlayed(Spieler spieler)
        {
            return this.spieler.Contains(spieler);
        }


    }
}
