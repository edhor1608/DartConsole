﻿using System;
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
        public static int setZähler = 0;
        int legsGewonnen = 0;

        public Set(Spieler spieler)
        {
            this.spieler = spieler;
            setNummer = setZähler;
            legs = new List<Leg>();
            //setZähler++;
        }

        public Set(String name)
        {
            this.spieler = Dart.GetSpieler(name);
            setNummer = setZähler;
            //setZähler++;
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
