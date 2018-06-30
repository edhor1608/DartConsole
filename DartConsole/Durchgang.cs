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
        private int id_durchgang;
        public static int id_durchgang_zähler = 0;
        int durchgangNummer;
        public static int durchgangZähler = 1;
        Wurf[] würfe = new Wurf[3];
        int anzahlWürfe;
        bool finishBereich;

        public Durchgang(bool finishBereich)
        {
            SetIDFree();
            durchgangNummer = durchgangZähler;
            durchgangZähler++;
            würfe[0] = new Wurf(0,0);
            würfe[1] = new Wurf(0, 0);
            würfe[2] = new Wurf(0, 0);
            Wurf.id_wurf_zähler = Wurf.id_wurf_zähler - 3;
            Wurf.wurfZähler = Wurf.wurfZähler - 3;
            anzahlWürfe = 0;
            this.finishBereich = finishBereich;
        }

        public Durchgang(int id, int durchgangNummer, int anzahlWürfe, int finish)
        {
            id_durchgang =id;
            this.durchgangNummer = durchgangNummer;
            this.anzahlWürfe = anzahlWürfe;
            if (finish == 1)
            {
                finishBereich = true;
            }
            else
            {
                finishBereich = false;
            }
        }

        private void SetIDFree()
        {
            do
            {
                id_durchgang = id_durchgang_zähler;
                id_durchgang_zähler++;
            } while (!Dart.IsDurchgangIDFree(id_durchgang));
        }

        public void SetAnzahlWürfe(int anzahl)
        {
            anzahlWürfe = anzahl;
        }

        public void ResetWürfe()
        {
            würfe = new Wurf[3];
            würfe[0] = new Wurf(0, 0);
            würfe[1] = new Wurf(0, 0);
            würfe[2] = new Wurf(0, 0);
            anzahlWürfe = 0;
        }

        public void SetWürfe(Wurf[] würfe)
        {
            this.würfe = würfe;
        }

        public int GetId()
        {
            return id_durchgang;
        }

        public int GetDurchgangNummer()
        {
            return durchgangNummer;
        }

        public int AddWurf(Wurf w, int i)
        {
            anzahlWürfe++;
            würfe[i] = w;
            return w.GetWurfGesamt();
        }

        public bool IsFinishBereich()
        {
            return finishBereich;
        }

        public int GetDurchgangWert()
        {
            return würfe[0].GetWurfGesamt() + würfe[1].GetWurfGesamt() + würfe[2].GetWurfGesamt();
        }

        public int GetAnzahlWürfe()
        {
            return anzahlWürfe;
        }

        public Wurf[] GetWürfe()
        {
            return würfe;
        }
    }
}
