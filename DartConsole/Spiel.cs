using System;
using System.Collections.Generic;
using System.Linq;

namespace DartConsole
{
    [Serializable]
    class Spiel
    {
        private int id_spiel;
        public static int id_spiel_zähler = 0;
        Dictionary<String, Spieler> spieler;
        List<Set> sets;
        int setsToWin;
        int legsToWin;
        const int start = 501;
        private int spielerAktuell = 0;
        int[] setsGewonnen;
        private DateTime datum;
        bool setGewonnen;
        bool legGewonnen;
        bool durchgangInvalide;
        bool noScore;
        bool noDouble;
        bool spielGewonnen = false;

        public Spiel()
        {
            SetIDFree();
            spieler = new Dictionary<string, Spieler>();
            sets = new List<Set>();
            Init();
        }

        public int GetSpielerAktuell()
        {
            return spielerAktuell;
        }

        public Spiel(Dictionary<string, Spieler> spieler, int sets, int legs, int rest)
        {
            SetIDFree();
            this.sets = new List<Set>();
            this.spieler = spieler;
            setsToWin = sets;
            legsToWin = legs;
            //start = rest;
            datum = DateTime.Now;
            setsGewonnen = new int[spieler.Count];
            for (int i = 0; i < setsGewonnen.Length; i++)
            {
                setsGewonnen[i] = 0;
            }
        }

        public Spiel(int id_spiel, DateTime datum, int start, int setsToWin, int legsToWin)
        {
            this.id_spiel = id_spiel;
            this.datum = datum;
            this.setsToWin = setsToWin;
            this.legsToWin = legsToWin;
            spieler = new Dictionary<string, Spieler>();
            sets = new List<Set>();
        }

        private void SetIDFree()
        {
            do
            {
                id_spiel = id_spiel_zähler;
                id_spiel_zähler++;
            } while (!Dart.IsSpielIDFree(id_spiel));
        }

        public void SetSets(List<Set> sets)
        {
            this.sets = sets;
        }

        public void SetSpieler(Dictionary<String, Spieler> spieler)
        {
            this.spieler = spieler;
        }

        public void SetSetsGewonnen(int[] setsGewonnen)
        {
            this.setsGewonnen = setsGewonnen;
        }

        public int[] GetSetsGewonnen()
        {
            return setsGewonnen;
        }

        public Dictionary<String, Spieler> GetSpieler()
        {
            return spieler;
        }

        public int GetId()
        {
            return id_spiel;
        }

        public int GetSetsToWin()
        {
            return setsToWin;
        }

        public int GetLegsToWin()
        {
            return legsToWin;
        }

        public bool HasPlayed(Spieler spieler)
        {
            return this.spieler.ContainsValue(spieler);
        }

        public void Init()
        {
            datum = DateTime.Now;
            setsGewonnen = new int[spieler.Count];
            for (int i = 0; i < setsGewonnen.Length; i++)
            {
                setsGewonnen[i] = 0;
            }
        }

        public DateTime GetDatum()
        {
            return datum;
        }

        public Set GetSetAktuell(int s)
        {
            int i = sets.Count() - (spieler.Count() - s);
            return sets.ElementAt(i);
        }

        public void SpielerWeiter()
        {
            spielerAktuell++;
            if (spielerAktuell == spieler.Count)
            {
                spielerAktuell = 0;
            }
        }

        public bool SearchSetWin()
        {
            for (int i = 0; i < spieler.Count(); i++)
            {
                if (GetSetAktuell(i).GetLegGewonnen() >= legsToWin)
                {
                    setsGewonnen[i]++;
                    return true;
                }
            }
            return false;
        }

        public bool SearchSpielWin()
        {
            for (int i = 0; i < setsGewonnen.Length; i++)
            {
                if (setsGewonnen[i] >= setsToWin)
                {
                    return true;
                }
            }
            return false;
        }

        public int MaxLengthSpielerAll()
        {
            int l = 0;
            for (int i = 0; i < spieler.Count(); i++)
            {
                if (spieler.ElementAt(i).Key.Count() > l)
                {
                    l = Dart.LengthSpieler(spieler.ElementAt(i).Value);
                }
            }
            return l;
        }

        public List<Set> GetSetsAll()
        {
            return sets;
        }

        public List<Set> GetSetsPlayer(Spieler s)
        {
            return sets.FindAll((Set x) => x.HasPlayed(s));
        }

        public List<Set> GetSetsPlayer(String s)
        {
            return sets.FindAll((Set x) => x.HasPlayed(s));
        }

        public void AddSet()
        {
            Set.setZähler++;
            Leg.legZähler = 0;
            setGewonnen = false;
            for (int s = 0; s < spieler.Count(); s++)
            {
                sets.Add(new Set(spieler.ElementAt(s).Value));
            }
            //AddLeg();
        }

        public void AddLeg()
        {
            Leg.legZähler++;
            Durchgang.durchgangZähler = 0;
            legGewonnen = false;
            for (int s = 0; s < spieler.Count(); s++)
            {
                GetSetAktuell(s).AddLeg();
                GetSetAktuell(s).GetAktuellLeg().SetRest(start);
            }
            //AddDurchgangSpielerAktuell();
        }

        public void AddDurchgangSpielerAktuell()
        {
            GetSetAktuell(spielerAktuell).GetAktuellLeg().AddDurchgang();
            durchgangInvalide = false;
            noScore = false;
            noDouble = false;
        }
    }
}
