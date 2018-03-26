using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartConsole
{
    class Spiel
    {
        List<Spieler> spieler;
        List<Set> sets;

        public bool hasPlayed(Spieler spieler)
        {
            return this.spieler.Contains(spieler);
        }
    }
}
