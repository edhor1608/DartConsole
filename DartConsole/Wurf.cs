using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartConsole
{
    [Serializable]
    class Wurf
    {
        private int id_wurf;
        public static int id_wurf_zähler = 0;
        int wurfNummer;
        public static int wurfZähler = 1;
        int multiplikator;
        int wert;
        int multiZiel;
        int wertZiel;

        public Wurf(int multi, int wert)
        {
            SetIDFree();
            wurfNummer = wurfZähler;
            wurfZähler++;
            this.multiplikator = multi;
            this.wert = wert;
        }

        public Wurf(int id, int wurfNummer, int multi, int wert)
        {
            id_wurf = id;
            this.wurfNummer = wurfNummer;
            this.multiplikator = multi;
            this.wert = wert;
        }

        public bool IsGetroffenExakt()
        {
            if (multiZiel == multiplikator && wertZiel == wert)
            {
                return true;
            }
            return false;
        }

        public bool IsGetroffenWert()
        {
            if (wertZiel == wert)
            {
                return true;
            }
            return false;
        }

        public bool IsGetroffenMulti()
        {
            if (multiZiel == multiplikator)
            {
                return true;
            }
            return false;
        }

        public void SetMultiZiel(int multi)
        {
            multiZiel = multi;
        }

        public void SetWertZiel(int wert)
        {
            wertZiel = wert;
        }

        public int GetMultiZiel()
        {
            return multiZiel;
        }

        public int GetWertZiel()
        {
            return wertZiel;
        }

        private void SetIDFree()
        {
            do
            {
                id_wurf = id_wurf_zähler;
                id_wurf_zähler++;
            } while (!Dart.IsWurfIDFree(id_wurf));
        }

        public int GetId()
        {
            return id_wurf;
        }

        public int GetWurfNummer()
        {
            return wurfNummer;
        }

        public int GetWurfGesamt()
        {
            return multiplikator * wert;
        }

        public int GetMulti()
        {
            return multiplikator;
        }

        public int GetWert()
        {
            return wert;
        }

        public int GetNr()
        {
            return wurfNummer;
        }
    }
}
