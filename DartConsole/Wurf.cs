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
