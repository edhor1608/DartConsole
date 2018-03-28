using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.Serialization.Formatters.Binary;

namespace DartConsole
{
    [Serializable]
    class Dart
    {
        static List<Spiel> spiele;
        static Dictionary<String, Spieler> spieler;
        static Dictionary<int, String> checkout = new Dictionary<int, string>();
        static FileStream stream;
        static BinaryFormatter formatter = new BinaryFormatter();
        static bool running = true;

        public static void Speichern()
        {
            try
            {
                stream = new FileStream(@"C:\Users\rohde\Dart\Spieler.dat", FileMode.Create);
                formatter.Serialize(stream, spieler);
                stream.Close();
                stream = new FileStream(@"C:\Users\rohde\Dart\Spiele.dat", FileMode.Create);
                formatter.Serialize(stream, spiele);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                stream.Close();
            }
        }

        public static void Lesen()
        {
            try
            {
                stream = new FileStream(@"C:\Users\rohde\Dart\Spieler.dat", FileMode.OpenOrCreate);
                spieler = (Dictionary<String, Spieler>)formatter.Deserialize(stream);
                stream.Close();
                stream = new FileStream(@"C:\Users\rohde\Dart\Spiele.dat", FileMode.OpenOrCreate);
                spiele = (List<Spiel>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (System.Runtime.Serialization.SerializationException e)
            {
                //Console.WriteLine(e.ToString());
            }
            finally
            {
                stream.Close();
            }
        }

        private static void Init()
        {
            CreateCheckout();
            System.IO.Directory.CreateDirectory(@"C:\Users\rohde\Dart");
            spieler = new Dictionary<string, Spieler>();
            spiele = new List<Spiel>();
            Lesen();
        }

        public static void AddSpieler(String name, int alter, String eMail)
        {
            if (spieler.ContainsKey(name))
            {
                Console.WriteLine("SPIELER BEREITS VORHANDEN");
            }
            else
            {
                spieler.Add(name, new Spieler(name, alter, eMail));
            }
        }

        public static void AddSpielerConsole()
        {
            Console.Clear();
            bool invalid;
            int alter = 0;
            String name = "";
            String eMail = "";
            //----------------
            invalid = true;
            while (invalid)
            {
                Console.WriteLine("Name:");
                name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("KEINE EINGABE");
                    invalid = true;
                }
                else
                {
                    invalid = false;
                }
            }
            //-------------
            invalid = true;
            while (invalid)
            {
                invalid = false;
                try
                {
                    Console.WriteLine("Alter:");
                    String eingabe = Console.ReadLine();
                    if (eingabe != "") alter = int.Parse(eingabe);
                }
                catch (Exception e)
                {
                    Console.WriteLine("FALSCHE EINGABE");
                    invalid = true;
                }
            }
            //------------
            invalid = true;
            while (invalid)
            {
                Console.WriteLine("eMail:");
                eMail = Console.ReadLine();
                if (eMail != "")
                {
                    if (Spieler.ValidateMailAddress(eMail))
                    {
                        invalid = false;
                    }
                    else
                    {
                        Console.WriteLine("INVALIDE EMAIL");
                        invalid = true;
                    }
                }
                else
                {
                    invalid = false;
                }
            }
            //-------------
            if (spieler.ContainsKey(name))
            {
                Console.WriteLine("SPIELER BEREITS VORHANDEN");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Angaben korrekt? (y/n)");
                Console.WriteLine("Name: " + name);
                if (alter == 0)
                {
                    Console.WriteLine("Alter: KEINE ANGABE");
                }
                else
                {
                    Console.WriteLine("Alter: " + alter);
                }
                if (eMail == "")
                {
                    Console.WriteLine("eMail: KEINE ANGABE");
                }
                else
                {
                    Console.WriteLine("eMail: " + eMail);
                }
                String eingabe = Console.ReadLine();
                if (eingabe == "Y" || eingabe == "y")
                {
                    spieler.Add(name, new Spieler(name, alter, eMail));
                    Console.WriteLine("Spieler hizugefügt");
                }
                else if (eingabe == "N" || eingabe == "n")
                {
                    AddSpielerConsole();
                }
            }
            Speichern();
        }

        public static void AddSpielerConsoleMehrere()
        {
            do
            {
                AddSpielerConsole();
            } while (YN_Dialog("Weitere Spieler hizufügen"));
        }

        public static void AddSpiel()
        {
            spiele.Add(new Spiel());
        }

        public static List<Spiel> SearchSpielePlayedBy(Spieler spieler)
        {
            return spiele.FindAll((Spiel x) => x.HasPlayed(spieler));
        }

        public static List<Spiel> SearchSpielePlayedBy(String name)
        {
            return spiele.FindAll((Spiel x) => x.HasPlayed(GetSpieler(name)));
        }

        public static Spieler GetSpieler(String name)
        {
            return spieler[name];
        }

        private static void CreateCheckout()
        {
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\rohde\Dropbox\Programmieren\VisualStudio\DartConsole\DartConsole\data\checkout.txt");
                //System.IO.StreamReader file = new System.IO.StreamReader(@"\data\checkout.txt");
                //BufferedReader rd = new BufferedReader(new FileReader(checkout.txt"));
                String line = null;
                String[] lineNew = null;
                int i = 170;
                while ((line = file.ReadLine()) != null)
                {
                    lineNew = line.Split(';');
                    line = "";
                    for (int j = 0; j < lineNew.Length; j++)
                    {
                        line = line + " " + lineNew[j];
                        line.Trim();
                    }
                    line.Trim();
                    //Console.WriteLine(line);
                    checkout.Add(i, line);
                    i--;
                }
                //for (int j = 170; j > 40; j--)
                //{
                //    Console.WriteLine(j + " " + checkout[j]);
                //}
                file.Close();
            }
            catch (FileNotFoundException e) { }
            catch (IOException e) { }
        }

        static void ShowSpieler()
        {
            Console.WriteLine("Spieler:");
            for (int i = 0; i < spieler.Count; i++)
            {
                Console.WriteLine(spieler.ElementAt(i).Value.getName() + ", " + spieler.ElementAt(i).Value.getAlter() + ", " + spieler.ElementAt(i).Value.getEMail());
            }
            Console.WriteLine("Zum fortfahren beliebige Taste drücken");
            Console.ReadKey();
        }

        static bool YN_Dialog(String s)
        {
            Console.WriteLine(s + " (y/n)");
            String eingabe = "";
            while (eingabe != "Y" || eingabe != "y" || eingabe != "N" || eingabe != "n")
            {
                eingabe = Console.ReadLine();
                if (eingabe == "Y" || eingabe == "y")
                {
                    return true;
                }
                else if (eingabe == "N" || eingabe == "n")
                {
                    return false;
                }
            }
            return false;
        }

        static void Menu()
        {
            bool invalid = true;
            while (invalid)
            {
                Console.Clear();
                Console.WriteLine("--- Menü ---");
                Console.WriteLine("(1)Zeige alle Spieler\n(2)Spieler hinzufügen\n(3)Spiel starten\n(4)Statistik aufrufen\n(5)Beenden");
                invalid = false;
                try
                {
                    int i = Convert.ToInt32(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            ShowSpieler();
                            break;
                        case 2:
                            AddSpielerConsoleMehrere();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            running = false;
                            //Console.WriteLine("Zum Beenden beliebige Taste drücken");
                            //Console.ReadKey();
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

        static void Main(string[] args)
        {
            Init();
            while (running)
            {
                Menu();
            }
            Speichern();
        }
    }
}
