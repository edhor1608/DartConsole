using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartConsole
{
    class Dart
    {
        List<Spiel> spiele;
        List<Spieler> spieler;

        public List<Spiel> SearchSpiele(Spieler spieler)
        {
            return spiele.FindAll((Spiel x) => x.hasPlayed(spieler));
        }
    }
}
