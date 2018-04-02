using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartConsole
{
    class Statistik
    {
        static bool running = true;
        public static void Starting()
        {
            running = true;
            Spieler spieler = SpielerAuswählen();
            while (running)
            {
                Menu(spieler);
            }
        }

        private static void Menu(Spieler s)
        {
            bool invalid = true;
            while (invalid)
            {
                Console.Clear();
                Console.WriteLine("--- Statistik Menü ---");
                Console.WriteLine("(1)Zeige letztes Spiel\n(2)Spieler hinzufügen\n(3)Spiel starten\n(4)Statistik aufrufen\n(5)Beenden");
                invalid = false;
                try
                {
                    int i = Convert.ToInt32(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            ShowSpiel(GetLastGame(s), s);
                            Dart.Confirm_Dialog();
                            break;
                        case 2:
                            //AddSpielerConsoleMehrere();
                            break;
                        case 3:
                            //AddSpiel();
                            break;
                        case 4:
                            Statistik.Starting();
                            break;
                        case 5:
                            running = false;
                            break;
                        default:
                            Console.WriteLine("FLASCHE EINGABE");
                            invalid = true;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("FALSCHE EINGABE");
                    invalid = true;
                }
            }
        }

        private static void ShowSpiel(Spiel sp, Spieler s)
        {
            Console.Clear();
            Console.WriteLine("Spiel vom: "+sp.GetDatum().ToString("g"));
            Dart.WriteChar('~',30);
            Console.WriteLine("Gesamt - Avg: "+AvgD_Spiel_NotFinish(sp, s)+" -> W: "+AvgW_Spiel_NotFinish(sp,s)+"| D: XX%");
            List<Set> sets = sp.GetSetsPlayer(s);
            for(int set = 0; set < sets.Count(); set++)
            {
                Dart.WriteChar(' ', 2, false);
                Console.WriteLine("Set "+(set+1)+ " - Avg: " + AvgD_Set_NotFinish(sets.ElementAt(set)) + " -> W: " + AvgW_Set_NotFinish(sets.ElementAt(set)) + "| D: XX%");
                List<Leg> legs = sets.ElementAt(set).GetLegs();
                for (int leg = 0; leg < legs.Count(); leg++)
                {
                    Dart.WriteChar(' ', 4, false);
                    Console.WriteLine("Leg " + (leg + 1)+ " - Avg: " + AvgD_Leg_NotFinish(legs.ElementAt(leg)) + " -> W: " + AvgW_Leg_NotFinish(legs.ElementAt(leg)) + "| D: XX%");
                    List<Durchgang> durchgänge = legs.ElementAt(leg).GetDurchgänge();
                    for (int ds = 0; ds < durchgänge.Count(); ds++)
                    {
                        Dart.WriteChar(' ', 6, false);
                        Console.WriteLine("Aufnahme " + (ds + 1));
                        Wurf[] würfe = durchgänge.ElementAt(ds).GetWürfe();
                        for (int w = 0; w < durchgänge.ElementAt(ds).GetAnzahlWürfe(); w++)
                        {
                            Dart.WriteChar(' ',8, false);
                            Console.WriteLine("Wurf "+(w+1)+": "+würfe[w].GetMulti()+"x"+ würfe[w].GetWert());
                        }
                    }
                }
            }
        }

        private static Spieler SpielerAuswählen()
        {
            bool invalid = true;
            String name = "";
            while (invalid)
            {
                try
                {
                    Console.Clear();
                    name = Dart.String_Dialog("Welcher Spieler ?", true);
                    if (!Dart.IsSpielerVorhanden(name)) throw new Exception();
                    invalid = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Spieler nicht vorhanden");
                    invalid = true;
                }
            }
            return Dart.GetSpieler(name);
        }

        public static Spiel GetLastGame(Spieler s)
        {
            return Dart.SearchSpielePlayedBy(s).Last();
        }

        public static double Avg_Durchgang(Durchgang d)
        {
            if (d.GetAnzahlWürfe() == 0) return 0;
            return d.GetDurchgangWert() / d.GetAnzahlWürfe();
        }

        public static double AvgD_Gesamt_NotFinish(Spieler s)
        {
            return SummeGesamtDurchgängeNotFinish(s) / AnzahlGesamtDurchgängeNotFinish(s);
        }

        public static double AvgD_Gesamt_NotFinish(String s)
        {
            return SummeGesamtDurchgängeNotFinish(s) / AnzahlGesamtDurchgängeNotFinish(s);
        }

        public static double AvgW_Gesamt_NotFinish(Spieler s)
        {
            return AvgD_Gesamt_NotFinish(s) / 3;
        }

        public static double AvgW_Gesamt_NotFinish(String s)
        {
            return AvgD_Gesamt_NotFinish(s) / 3;
        }

        public static double AvgD_Spiel_NotFinish(Spiel s, Spieler spieler)
        {
            return SummeSpielDurchgängeNotFinish(s, spieler) / AnzahlSpielDurchgängeNotFinish(s, spieler);
        }

        public static double AvgD_Spiel_NotFinish(Spiel s, String name)
        {
            return SummeSpielDurchgängeNotFinish(s, name) / AnzahlSpielDurchgängeNotFinish(s, name);
        }

        public static double AvgW_Spiel_NotFinish(Spiel s, String name)
        {
            return AvgD_Spiel_NotFinish(s, name) / 3;
        }

        public static double AvgW_Spiel_NotFinish(Spiel s, Spieler spieler)
        {
            return AvgD_Spiel_NotFinish(s, spieler) / 3;
        }

        public static double AvgD_Set_NotFinish(Set s)
        {
            return SummeSetDurchgängeNotFinish(s) / AnzahlSetDurchgängeNotFinish(s);
        }

        public static double AvgW_Set_NotFinish(Set s)
        {
            return AvgD_Set_NotFinish(s) / 3;
        }

        public static double AvgD_Leg_NotFinish(Leg l)
        {
            return SummeLegDurchgängeNotFinish(l) / AnzahlLegDurchgängeNotFinish(l);
        }

        public static double AvgW_Leg_NotFinish(Leg l)
        {
            return AvgD_Leg_NotFinish(l) / 3;
        }

        public static double AnzahlLegDurchgängeNotFinish(Leg l)
        {
            int anzahl = 0;
            for (int i = 0; i < l.AnzahlDurchgänge(); i++)
            {
                if (!l.GetDurchgänge().ElementAt(i).IsFinishBereich()) anzahl++;
            }
            return anzahl;
        }

        public static double SummeLegDurchgängeNotFinish(Leg l)
        {
            int summe = 0;
            for (int i = 0; i < l.AnzahlDurchgänge(); i++)
            {
                if (!l.GetDurchgänge().ElementAt(i).IsFinishBereich()) summe += l.GetDurchgänge().ElementAt(i).GetDurchgangWert();
            }
            return summe;
        }

        public static double AnzahlSetDurchgängeNotFinish(Set s)
        {
            double anzahl = 0;
            for (int i = 0; i < s.GetLegs().Count(); i++)
            {
                anzahl += AnzahlLegDurchgängeNotFinish(s.GetLegs().ElementAt(i));
            }
            return anzahl;
        }

        public static double SummeSetDurchgängeNotFinish(Set s)
        {
            double summe = 0;
            for (int i = 0; i < s.GetLegs().Count(); i++)
            {
                summe += SummeLegDurchgängeNotFinish(s.GetLegs().ElementAt(i));
            }
            return summe;
        }

        public static double AnzahlSpielDurchgängeNotFinish(Spiel s, String name)
        {
            return AnzahlSpielDurchgängeNotFinish(s, Dart.GetSpieler(name));
        }

        public static double AnzahlSpielDurchgängeNotFinish(Spiel s, Spieler spieler)
        {
            double anzahl = 0;
            List<Set> sets = s.GetSetsPlayer(spieler);
            for (int i = 0; i < sets.Count(); i++)
            {
                anzahl += AnzahlSetDurchgängeNotFinish(sets.ElementAt(i));
            }
            return anzahl;
        }

        public static double SummeSpielDurchgängeNotFinish(Spiel s, String name)
        {
            return SummeSpielDurchgängeNotFinish(s, Dart.GetSpieler(name));
        }

        public static double SummeSpielDurchgängeNotFinish(Spiel s, Spieler spieler)
        {
            double summe = 0;
            List<Set> sets = s.GetSetsPlayer(spieler);
            for (int i = 0; i < sets.Count(); i++)
            {
                summe += SummeSetDurchgängeNotFinish(sets.ElementAt(i));
            }
            return summe;
        }

        public static double AnzahlGesamtDurchgängeNotFinish(Spieler spieler)
        {
            double anzahl = 0;
            List<Spiel> spiele = Dart.SearchSpielePlayedBy(spieler);
            for (int i = 0; i < spiele.Count(); i++)
            {
                anzahl += AnzahlSpielDurchgängeNotFinish(spiele.ElementAt(i),spieler);
            }
            return anzahl;
        }

        public static double AnzahlGesamtDurchgängeNotFinish(String s)
        {
            return AnzahlGesamtDurchgängeNotFinish(Dart.GetSpieler(s));
        }

        public static double SummeGesamtDurchgängeNotFinish(Spieler spieler)
        {
            double summe = 0;
            List<Spiel> spiele = Dart.SearchSpielePlayedBy(spieler);
            for (int i = 0; i < spiele.Count(); i++)
            {
                summe += SummeSpielDurchgängeNotFinish(spiele.ElementAt(i), spieler);
            }
            return summe;
        }

        public static double SummeGesamtDurchgängeNotFinish(String spieler)
        {
            return SummeGesamtDurchgängeNotFinish(Dart.GetSpieler(spieler));
        }
    }
}
