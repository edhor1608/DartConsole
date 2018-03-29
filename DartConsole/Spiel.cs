using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartConsole
{
    [Serializable]
    class Spiel
    {
        Dictionary<String, Spieler> spieler;
        List<Set> sets;
        int setsToWin;
        int legsToWin;
        const int start=501;
        private int spielerAktuell = 0;

        public Spiel()
        {
            spieler = new Dictionary<string, Spieler>();
            sets = new List<Set>();
            Init();
            Starting();
        }

        public bool HasPlayed(Spieler spieler)
        {
            return this.spieler.ContainsValue(spieler);
        }

        public void ShowSpieler()
        {
            Console.WriteLine("--------");
            for (int i = 0; i < spieler.Count(); i++)
            {
                Console.WriteLine("Spieler " + (i+1) + ": " + spieler.ElementAt(i).Value.GetName());
            }
            Console.WriteLine("Zum fortfahren beliebige Taste drücken");
            Console.ReadKey();
        }

        public void Init()
        {
            setsToWin = Dart.Int_Dialog("Sets (First to)");
            legsToWin = Dart.Int_Dialog("Legs (First to)");
            SpielerAuswählen();
            ShowSpieler();
        }

        public void SpielerAuswählen()
        {
            bool b = true;
            Console.WriteLine("Welche Spieler spielen mit?");
            do
            {
                Console.WriteLine("Name:");
                String name = Console.ReadLine().ToLower();
                if (Dart.IsSpielerVorhanden(name))
                {
                    spieler.Add(Dart.GetSpieler(name).GetName(),Dart.GetSpieler(name));
                    Console.WriteLine("Spieler hinzugefügt");
                }
                else
                {
                    Console.WriteLine("Spieler nicht vorhanden");
                    if (Dart.YN_Dialog("Spieler erstellen?"))
                    {
                        Spieler s= Dart.AddSpielerConsole(name);
                        if (s != null)
                        {
                            spieler.Add(s.GetName(),s);
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
            Console.WriteLine(i);
            Console.ReadKey();
            return sets.ElementAt(i);
        }

        public Wurf Wurf()
        {
            bool invalide = true;
            int multiplikator;
            int wert;
            do
            {
                multiplikator = Dart.Int_Dialog("Multiplikator", 1, 3);
                wert = Dart.Int_Dialog("Wert", 1, 20, 25);
                if (multiplikator == 3 && wert == 25)
                {
                    Console.WriteLine("Ungültige Eingabe");
                    invalide = true;
                }
                else
                {
                    Console.WriteLine("-> "+multiplikator+"x"+wert);
                    invalide = !Dart.YN_Dialog("Wurf korrekt?");
                }
            } while (invalide);
            return new Wurf(multiplikator, wert);
        }

        private void SpielerWeiter()
        {
            spielerAktuell++;
            if (spielerAktuell == spieler.Count)
            {
                spielerAktuell = 0;
            }
        }

        public void Starting()
        {
            do
            {
                Set.setZähler++;
                for(int s = 0; s < spieler.Count(); s++)
                {
                    sets.Add(new Set(spieler.ElementAt(s).Value));
                }
                do
                {
                    Leg.legZähler++;
                    for (int s = 0; s < spieler.Count(); s++)
                    {
                        GetSetAktuell(s).AddLeg();
                    }
                    do
                    {
                        for (int s = 0; s < spieler.Count(); s++)
                        {
                            GetSetAktuell(s).GetAktuellLeg().AddDurchgang();
                        }
                        for (int w = 0; w < 3; w++)
                        {
                            GetSetAktuell(spielerAktuell).GetAktuellLeg().RedRest(GetSetAktuell(spielerAktuell).GetAktuellLeg().GetDurchgangAktuell().AddWurf(Wurf(),w));
                        }
                        SpielerWeiter();
                    } while (true);
                }while (true) ;
            } while (true) ;
        }
    }
}
