﻿using System;
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
            Starting();
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

        public void ShowSpieler()
        {
            Console.Clear();
            Console.WriteLine("Liste der Spieler");
            Dart.WriteChar('-',20);
            for (int i = 0; i < spieler.Count(); i++)
            {
                Console.WriteLine("Spieler " + (i + 1) + ": " + spieler.ElementAt(i).Value.GetUsername());
            }
            Console.WriteLine("Zum fortfahren beliebige Taste drücken");
            Console.ReadKey();
        }

        public void Init()
        {
            datum = DateTime.Now;
            Console.Clear();
            Console.WriteLine("Neues Spiel");
            Dart.WriteChar('-', 20);
            setsToWin = Dart.Int_Dialog("Sets (First to)", 1);
            legsToWin = Dart.Int_Dialog("Legs (First to)", 1);
            SpielerAuswählen();
            setsGewonnen = new int[spieler.Count];
            for (int i = 0; i < setsGewonnen.Length; i++)
            {
                setsGewonnen[i] = 0;
            }
            ShowSpieler();
        }

        public DateTime GetDatum()
        {
            return datum;
        }

        public void SpielerAuswählen()
        {
            bool b = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Neues Spiel / Sets " + setsToWin + " - Legs " + legsToWin + " \\");
                Dart.WriteChar('-', 20);
                Console.WriteLine("Welche Spieler spielen mit?");
                String name = Dart.String_Dialog("Name",true);
                if (Dart.IsSpielerVorhanden(name))
                {
                    spieler.Add(Dart.GetSpieler(name).GetUsername(), Dart.GetSpieler(name));
                    Console.WriteLine("Spieler hinzugefügt");
                }
                else
                {
                    Console.WriteLine("Spieler nicht vorhanden");
                    if (Dart.YN_Dialog("Spieler erstellen?"))
                    {
                        Spieler s = Dart.AddSpieler(name);
                        if (s != null)
                        {
                            spieler.Add(s.GetUsername(), s);
                            Console.WriteLine("Spieler hinzugefügt");
                        }
                        else
                        {
                            Console.WriteLine("Spielererstellung unvollständig");
                        }
                    }
                }
                b = Dart.YN_Dialog("Weitere Spieler hinzufügen?");
            } while (b);
        }

        public Set GetSetAktuell(int s)
        {
            int i = sets.Count() - (spieler.Count() - s);
            return sets.ElementAt(i);
        }

        public Wurf Wurf()
        {
            bool invalide = true;
            int multiplikator;
            int wert;
            do
            {
                multiplikator = Dart.Int_Dialog("Multiplikator", 0, 3);
                wert = Dart.Int_Dialog("Wert", 0, 20, 25);
                if (multiplikator == 3 && wert == 25)
                {
                    Console.WriteLine("Ungültige Eingabe");
                    invalide = true;
                }
                else
                {
                    Console.WriteLine("-> " + multiplikator + "x" + wert + "\n");
                    invalide = false;
                    //invalide = !Dart.YN_Dialog("Wurf korrekt?");
                }
            } while (invalide);
            return new Wurf(multiplikator, wert);
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
                    //Console.WriteLine(spieler.ElementAt(i).Key + " hat den Set gewonnen");
                    //Dart.Confirm_Dialog();
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
                    //Console.WriteLine(spieler.ElementAt(i).Key + " hat das Spiel gewonnen");
                    //Dart.Confirm_Dialog();
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

        private void ShowInfos(int w)
        {
            Console.Clear();
            int maxLAll = MaxLengthSpielerAll();
            int tAll = maxLAll / 8;
            Console.WriteLine("Set " + (Set.setZähler) + " / Leg " + (Leg.legZähler));
            Dart.WriteChar('_',30 + tAll * 8);
            Console.Write("Name");
            for (int i = 0; i < tAll;i++)
            {
                Console.Write("\t");
            }
            Console.Write("\tSets");
            Console.Write("\tLegs");
            Console.Write("\tRest");
            Console.WriteLine();
            Dart.WriteChar('-', 30+tAll*8);
            for (int s = 0; s < spieler.Count(); s++)
            {
                Console.Write(GetSetAktuell(s).GetSpieler().GetUsername());
                int tE = tAll - GetSetAktuell(s).GetSpieler().GetUsername().Length / 8;
                for (int i = 0; i < tE; i++)
                {
                    Console.Write("\t");
                }
                Console.Write("\t" + setsGewonnen[s]);
                Console.Write("\t" + GetSetAktuell(s).GetLegGewonnen());
                Console.Write("\t" + GetSetAktuell(s).GetAktuellLeg().GetRest());
                if (s == spielerAktuell)
                {
                    Console.Write(" <-");
                }
                if (Dart.checkout.ContainsKey(GetSetAktuell(s).GetAktuellLeg().GetRest()))
                {
                    Console.Write("\t"+Dart.checkout[GetSetAktuell(s).GetAktuellLeg().GetRest()]);
                }
                Console.WriteLine();
            }
            Dart.WriteChar('_', 30 + tAll * 8);
            Console.Write(" -");
            for (int i = 0; i < w;i++)
            {
                Console.Write(" "+GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[i].GetMulti()+"x"+ GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[i].GetWert() + " -");
            }
            Console.Write("> " + GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().GetDurchgangWert());
            Console.WriteLine();

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

        public void Starting()
        {
            do
            {
                AddSet();
                do
                {
                    AddLeg();
                    do
                    {
                        Console.Clear();
                        AddDurchgangSpielerAktuell();
                        do
                        {
                            GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().SetAnzahlWürfe(0);
                            if (legGewonnen)
                            {
                                GetSetAktuell(spielerAktuell).SubLegGewonnen();
                                legGewonnen = false;
                                GetSetAktuell(spielerAktuell).GetAktuellLeg().SetFinish(-1);
                            }
                            if (noDouble)
                            {
                                noDouble = false;
                            }
                            if (durchgangInvalide && !noScore)
                            {
                                GetSetAktuell(spielerAktuell).GetAktuellLeg().SetRest(GetSetAktuell(spielerAktuell).GetAktuellLeg().GetRest() + GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().GetDurchgangWert());
                            }
                            noScore = false;
                            int w = 0;
                            bool durchgangLaufend = true;
                            while (w < 3 && durchgangLaufend)
                            {
                                Console.Clear();
                                ShowInfos(w);
                                Console.WriteLine();
                                Console.WriteLine("Aufnahme " + GetSetAktuell(spielerAktuell).GetAktuellLeg().AnzahlDurchgänge()
                                    + " / Wurf " + (w + 1)
                                    //+ " / Spieler " + (spielerAktuell + 1) + " - (" + GetSetAktuell(spielerAktuell).GetSpieler().GetName() + ")"
                                    //+ " / Rest " + GetSetAktuell(spielerAktuell).GetAktuellLeg().GetRest()
                                    );
                                //if (Dart.checkout.ContainsKey(GetSetAktuell(spielerAktuell).GetAktuellLeg().GetRest()))
                                //{
                                //   Console.WriteLine("-> Checkout: " + Dart.checkout[GetSetAktuell(spielerAktuell).GetAktuellLeg().GetRest()]);
                                //}
                                int wurf = GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().AddWurf(Wurf(), w);
                                int rInfo = GetSetAktuell(spielerAktuell).GetAktuellLeg().RedRest(wurf);
                                ShowInfos(w+1);
                                switch (rInfo)
                                {
                                    case 1:
                                        if (GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[w].GetMulti() == 2)
                                        {
                                            durchgangLaufend = false;
                                            legGewonnen = true;
                                            GetSetAktuell(spielerAktuell).AddLegGewonnen();
                                            GetSetAktuell(spielerAktuell).GetAktuellLeg().SetFinish(GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().GetDurchgangWert());
                                        }
                                        else
                                        {
                                            durchgangLaufend = false;
                                            GetSetAktuell(spielerAktuell).GetAktuellLeg().SetRest(GetSetAktuell(spielerAktuell).GetAktuellLeg().GetRest() + GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().GetDurchgangWert());
                                            noDouble = true;
                                        }
                                        break;
                                    case 2:
                                        durchgangLaufend = false;
                                        GetSetAktuell(spielerAktuell).GetAktuellLeg().SetRest(GetSetAktuell(spielerAktuell).GetAktuellLeg().GetRest() + GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().GetDurchgangWert());
                                        noScore = true;
                                        break;
                                }
                                w++;
                            }
                            durchgangInvalide = true;
                        } while (!Dart.YN_Dialog(
                        //"Wurf 1: " + GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[0].GetMulti()
                        //+ "x" + GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[0].GetWert()
                        //+ "\nWurf 2: " + GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[1].GetMulti()
                        //+ "x" + GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[1].GetWert()
                        //+ "\nWurf 3: " + GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[2].GetMulti()
                        //+ "x" + GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[2].GetWert() + 
                        "\nWürfe korrekt?"));
                        if (noScore || noDouble)
                        {
                            Console.WriteLine("Ungültiger Wurf --- No Score");
                        }
                        if (legGewonnen)
                        {
                            Console.WriteLine(GetSetAktuell(spielerAktuell).GetSpieler().GetUsername() + " hat das Leg gewonnen");
                            Dart.Confirm_Dialog();
                        }
                        SpielerWeiter();
                    } while (!legGewonnen);
                    if (SearchSetWin())
                    {
                        setGewonnen = true;
                    }
                } while (!setGewonnen);
                if (SearchSpielWin())
                {
                    spielGewonnen = true;
                }
            } while (!spielGewonnen);

        }
    }
}
