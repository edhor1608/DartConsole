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
        private int id_set;
        public static int id_set_zähler = 0;
        List<Leg> legs;
        Spieler spieler;
        int setNummer;
        public static int setZähler = 0;
        int legsGewonnen = 0;

        public Set(Spieler spieler)
        {
            SetIDFree();
            this.spieler = spieler;
            setNummer = setZähler;
            legs = new List<Leg>();
            //setZähler++;
        }

        public Set(int id_set, Spieler spieler, int setNummer, int legsGewonnen)
        {
            this.id_set = id_set;
            this.spieler = spieler;
            this.setNummer = setNummer;
            this.legsGewonnen = legsGewonnen;
            legs = new List<Leg>();
            //setZähler++;
        }

        public Set(int id_set, String name, int setNummer, int legsGewonnen)
        {
            this.id_set = id_set;
            this.spieler = Dart.GetSpieler(name);
            this.setNummer = setNummer;
            this.legsGewonnen = legsGewonnen;
            legs = new List<Leg>();
            //setZähler++;
        }

        public Set(String name)
        {
            SetIDFree();
            this.spieler = Dart.GetSpieler(name);
            setNummer = setZähler;
            legs = new List<Leg>();
            //setZähler++;
        }

        private void SetIDFree()
        {
            do
            {
                id_set = id_set_zähler;
                id_set_zähler++;
            } while (!Dart.IsSetIDFree(id_set));
        }

        public void SetLegs(List<Leg> legs)
        {
            this.legs = legs;
        }

        public int GetLegsGewonnen()
        {
            return legsGewonnen;
        }

        public int GetSetNummer()
        {
            return setNummer;
        }

        public int GetId()
        {
            return id_set;
        }

        public bool HasPlayed(String name)
        {
            return HasPlayed(Dart.GetSpieler(name));
        }

        public bool HasPlayed(Spieler s)
        {
            if (this.spieler.Equals(s)) return true;
            return false;
        }

        public Spieler GetSpieler()
        {
            return spieler;
        }

        public void AddLeg()
        {
            legs.Add(new Leg());
        }

        public Leg GetAktuellLeg()
        {
            return legs[legs.Count() - 1];
        }

        public void AddLegGewonnen()
        {
            legsGewonnen++;
        }

        public List<Leg> GetLegs()
        {
            return legs;
        }

        public void SubLegGewonnen()
        {
            legsGewonnen--;
        }

        public int GetLegGewonnen()
        {
            return legsGewonnen;
        }
    }
}
