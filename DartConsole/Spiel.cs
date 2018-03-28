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
        List<Spieler> spieler;
        List<Set> sets;
        int setsToWin;
        int legsToWin;
        int start;

        public Spiel()
        {
            spieler = new List<Spieler>();
            sets = new List<Set>();
            this.start = 501;
            Init();
        }

        public bool HasPlayed(Spieler spieler)
        {
            return this.spieler.Contains(spieler);
        }

        public void Init()
        {
            setsToWin = Dart.Int_Dialog("Sets");
            legsToWin = Dart.Int_Dialog("Legs");
            SpielerAuswählen();
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
                    spieler.Add(Dart.GetSpieler(name));
                    Console.WriteLine("Spieler hinzugefügt");
                }
                else
                {
                    Console.WriteLine("Spieler nicht vorhanden");
                    if (Dart.YN_Dialog("Spieler erstellen?"))
                    {
                        Spieler s= Dart.AddSpielerConsole();
                        if (s != null)
                        {
                            spieler.Add(s);
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
    }
}
