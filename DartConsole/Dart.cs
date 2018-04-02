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
        static Object[] daten = new Object[2];
        public static Dictionary<int, String> checkout = new Dictionary<int, string>();
        static FileStream stream;
        static BinaryFormatter formatter = new BinaryFormatter();
        static bool running = true;

        public static void Speichern()
        {
            //FileStream stream;
            try
            {
                daten[0] = spieler;
                daten[1] = spiele;
                stream = new FileStream(@"C:\Users\Public\Dart\Daten.dat", FileMode.Create);
                formatter.Serialize(stream, daten);
                stream.Close();
                //stream = new FileStream(@"C:\Users\Public\Dart\Spiele.dat", FileMode.Create);
                //formatter.Serialize(stream, spiele);
                //stream.Close();
                //stream = new FileStream(@"C:\Users\Public\Dart\Spieler.dat", FileMode.Create);
                //formatter.Serialize(stream, spieler);
                //stream.Close();

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
                stream = new FileStream(@"C:\Users\Public\Dart\Daten.dat", FileMode.OpenOrCreate);
                daten = (Object[])formatter.Deserialize(stream);
                spieler = (Dictionary<String, Spieler>)daten[0];
                spiele = (List<Spiel>)daten[1];
                //stream = new FileStream(@"C:\Users\Public\Dart\Spieler.dat", FileMode.OpenOrCreate);
                //spieler = (Dictionary<String, Spieler>)formatter.Deserialize(stream);
                //stream.Close();
                //stream = new FileStream(@"C:\Users\Public\Dart\Spiele.dat", FileMode.OpenOrCreate);
                //spiele = (List<Spiel>)formatter.Deserialize(stream);
                //stream.Close();

                Console.WriteLine(spiele.ElementAt(0).GetSetAktuell(0).GetAktuellLeg().GetDurchgangAktuell().GetDurchgangWert());
                Dart.Confirm_Dialog();
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
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\Dart");
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

        public static Spieler AddSpielerConsole(String name = "")
        {
            Console.Clear();
            bool invalid;
            int alter = 0;
            String eMail = "";
            //----------------
            name = String_Dialog("Name",true);
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
                Console.WriteLine("SPIELER BEREITS VORHANDEN -> NICHT HINZUGEFÜGT");
                return null;
            }
            else
            {
                Console.Clear();
                //Console.WriteLine("Angaben korrekt? (y/n)");
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
                if (YN_Dialog("Angaben korrekt?"))
                {
                    spieler.Add(name, new Spieler(name, alter, eMail));
                    Speichern();
                    Console.WriteLine("Spieler erstellt");
                    return GetSpieler(name);
                }
                else
                {
                    AddSpielerConsole();
                    return null;
                }
            }
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
            return spiele.FindAll((Spiel x) => x.HasPlayed(GetSpieler(name.ToLower())));
        }

        public static Spieler GetSpieler(String name)
        {
            return spieler[name.ToLower()];
        }

        public static bool IsSpielerVorhanden(String name)
        {
            return spieler.ContainsKey(name);
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

        public static void ShowSpieler()
        {
            Console.WriteLine("Spieler:");
            for (int i = 0; i < spieler.Count; i++)
            {
                Console.WriteLine(spieler.ElementAt(i).Value.GetName() + ", " + spieler.ElementAt(i).Value.GetAlter() + ", " + spieler.ElementAt(i).Value.GetEMail());
            }
            Confirm_Dialog();
        }

        public static bool YN_Dialog(String s)
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

        public static void Confirm_Dialog(String s = "Zum fortfahren beliebige Taste drücken")
        {
            Console.WriteLine(s);
            Console.ReadKey();
        }

        public static String String_Dialog(String s, bool lower)
        {
            String sR = "";
            bool invalid = true;
            while (invalid)
            {
                Console.WriteLine(s);
                if (lower)
                {
                    sR = Console.ReadLine().ToLower();
                }
                else
                {
                    sR = Console.ReadLine();
                }
                if (sR == "" || sR == null)
                {
                    Console.WriteLine("KEINE EINGABE");
                    invalid = true;
                }
                else
                {
                    invalid = false;
                }
            }
            return sR;
        }

        public static int Int_Dialog(String s, int min = int.MinValue,int max = int.MaxValue,int einzeln = int.MaxValue)
        {
            int integer = 0;
            bool invalid = true;
            while (invalid)
            {
                invalid = false;
                try
                {
                    Console.WriteLine(s+":");
                    String eingabe = Console.ReadLine();
                    integer = int.Parse(eingabe);
                    if ((integer < min || integer > max) && integer != einzeln)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("FALSCHE EINGABE");
                    invalid = true;
                }
            }
            return integer;
        }

        private static void Menu()
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
                            AddSpiel();
                            break;
                        case 4:
                            Statistik.Starting();
                            break;
                        case 5:
                            running = false;
                            Speichern();
                            //Console.WriteLine("Zum Beenden beliebige Taste drücken");
                            //Console.ReadKey();
                            break;
                        case 6:
                            Wurf w = new Wurf(3,20);
                            Wurf w2 = new Wurf(3,19);
                            Wurf w3 = new Wurf(2,12);
                            Durchgang d1 = new Durchgang(false);
                            Durchgang d2 = new Durchgang(false);
                            Durchgang d3 = new Durchgang(true);
                            Leg l = new Leg();
                            Set s = new Set("test");
                            Spiel sp = new Spiel();
                            Spieler spi = new Spieler("test");

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

        public static void WriteChar(char c, int j, bool line=true)
        {
            for (int i = 0; i < j; i++)
            {
                Console.Write(c);
            }
            if (line) Console.WriteLine();
        }

        public static int MaxLengthSpielerAll()
        {
            int l = 0;
            for (int i = 0; i < spieler.Count(); i++)
            {
                if (spieler.ElementAt(i).Key.Count() > l)
                {
                    l = LengthSpieler(spieler.ElementAt(i).Value);
                }
            }
            return l;
        }

        public static int LengthSpieler(Spieler s)
        {
            return s.GetName().Count();
        }

        static void Main(string[] args)
        {
            //Console.SetWindowSize(250,250);
            Init();
            while (running)
            {
                Menu();
            }
            Speichern();
        }
    }
}
