using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DartConsole
{
    [Serializable]
    class Dart
    {
        public static List<Spiel> spiele;
        public static Dictionary<String, Spieler> spieler;
        //static Object[] daten = new Object[2];
        public static Dictionary<int, String> checkout = new Dictionary<int, string>();
        //static FileStream stream;
        DBConnect co = new DBConnect();

        /// <summary>	
        /// testet, ob übergebener Wert schon eine WurfID ist	
        /// </summary>	
        /// <param name="i">eine mögliche WurfID</param>	
        /// <returns>true, wenn WurfID noch nicht vergeben</returns>
        public static bool IsWurfIDFree(int i)
        {
            for (int z = 0; z < spiele.Count; z++)
            {
                for (int y = 0; y < spiele.ElementAt(z).GetSetsAll().Count; y++)
                {
                    for (int x = 0; x < spiele.ElementAt(z).GetSetsAll().ElementAt(y).GetLegs().Count; x++)
                    {
                        for (int w = 0; w < spiele.ElementAt(z).GetSetsAll().ElementAt(y).GetLegs().ElementAt(x).GetDurchgänge().Count; w++)
                        {
                            for (int v = 0; v < 3; v++)
                            {
                                if (spiele.ElementAt(z).GetSetsAll().ElementAt(y).GetLegs().ElementAt(x).GetDurchgänge().ElementAt(w).GetWürfe()[v].GetId() == i)
                                {
                                    Console.WriteLine("-----------------");
                                    Console.ReadKey();
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>	
        /// testet, ob übergebener Wert schon eine DurchgangID ist	
        /// </summary>	
        /// <param name="i">eine mögliche DurchgangID</param>	
        /// <returns>true, wenn DurchgangID noch nicht vergeben</returns>
        public static bool IsDurchgangIDFree(int i)
        {
            for (int z = 0; z < spiele.Count; z++)
            {
                for (int y = 0; y < spiele.ElementAt(z).GetSetsAll().Count; y++)
                {
                    for (int x = 0; x < spiele.ElementAt(z).GetSetsAll().ElementAt(y).GetLegs().Count; x++)
                    {
                        for (int w = 0; w < spiele.ElementAt(z).GetSetsAll().ElementAt(y).GetLegs().ElementAt(x).GetDurchgänge().Count; w++)
                        {

                            if (spiele.ElementAt(z).GetSetsAll().ElementAt(y).GetLegs().ElementAt(x).GetDurchgänge().ElementAt(w).GetId() == i)
                            {
                                Console.WriteLine("-----------------");
                                Console.ReadKey();
                                return false;
                            }

                        }
                    }
                }
            }
            return true;
        }

        /// <summary>	
        /// testet, ob übergebener Wert schon eine LegID ist	
        /// </summary>	
        /// <param name="i">eine mögliche LegID</param>	
        /// <returns>true, wenn LegID noch nicht vergeben</returns>
        public static bool IsLegIDFree(int i)
        {
            for (int z = 0; z < spiele.Count; z++)
            {
                for (int y = 0; y < spiele.ElementAt(z).GetSetsAll().Count; y++)
                {
                    for (int x = 0; x < spiele.ElementAt(z).GetSetsAll().ElementAt(y).GetLegs().Count; x++)
                    {


                        if (spiele.ElementAt(z).GetSetsAll().ElementAt(y).GetLegs().ElementAt(x).GetId() == i)
                        {
                            Console.WriteLine("-----------------");
                            Console.ReadKey();
                            return false;
                        }


                    }
                }
            }
            return true;
        }

        /// <summary>	
        /// testet, ob übergebener Wert schon eine SetID ist	
        /// </summary>	
        /// <param name="i">eine mögliche SetID</param>	
        /// <returns>true, wenn SetID noch nicht vergeben</returns>
        public static bool IsSetIDFree(int i)
        {
            for (int z = 0; z < spiele.Count; z++)
            {
                for (int y = 0; y < spiele.ElementAt(z).GetSetsAll().Count; y++)
                {



                    if (spiele.ElementAt(z).GetSetsAll().ElementAt(y).GetId() == i)
                    {
                        Console.WriteLine("-----------------");
                        Console.ReadKey();
                        return false;
                    }



                }
            }
            return true;
        }

        /// <summary>	
        /// testet, ob übergebener Wert schon eine SpielID ist	
        /// </summary>	
        /// <param name="i">eine mögliche SpielID</param>	
        /// <returns>true, wenn SpielID noch nicht vergeben</returns>
        public static bool IsSpielIDFree(int i)
        {
            for (int z = 0; z < spiele.Count; z++)
            {




                if (spiele.ElementAt(z).GetId() == i)
                {
                    Console.WriteLine("-----------------");
                    Console.ReadKey();
                    return false;
                }




            }
            return true;
        }

        public static void Speichern()
        {
            //FileStream stream;
            try
            {
                //daten[0] = spieler;
                //daten[1] = spiele;
                //stream = new FileStream(@"C:\Users\Public\Dart\Daten.dat", FileMode.Create);
                //formatter.Serialize(stream, spiele);
                //stream.Close();

                SaveSpielerToDB();
                SaveSpieleToDB();
                SaveSetsToDB();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //stream.Close();
            }
        }

        /// <summary>	
        /// liest Daten aus der Datenbank komplett ein und erstellt alle Objekte, inklusive Verweise	
        /// </summary>
        public static void Lesen()
        {
            try
            {
                //stream = new FileStream(@"C:\Users\Public\Dart\Daten.dat", FileMode.OpenOrCreate);
                //spiele = (List<Spiel>)formatter.Deserialize(stream);
                //spieler = (Dictionary<String, Spieler>)daten[0];
                //spiele = (List<Spiel>)daten[1];

                spieler = GetSpielerFromDB();
                spiele = GetSpieleFromDB();

                //--- Test ---
                //Test();
                //------------

                //daten = Deserialize(DBConnect.SelectBinary());

                //stream = new FileStream(@"C:\Users\Public\Dart\Spieler.dat", FileMode.OpenOrCreate);
                //spieler = (Dictionary<String, Spieler>)formatter.Deserialize(stream);
                //stream.Close();
                //stream = new FileStream(@"C:\Users\Public\Dart\Spiele.dat", FileMode.OpenOrCreate);
                //spiele = (List<Spiel>)formatter.Deserialize(stream);
                //stream.Close();

                //Console.WriteLine(spiele.ElementAt(0).GetSetAktuell(0).GetAktuellLeg().GetDurchgangAktuell().GetDurchgangWert());
                //Dart.Confirm_Dialog();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Console.ReadKey();
            }
            finally
            {
                //stream.Close();
            }
        }

        private static void Test()
        {
            // SPIEL ID
            try
            {
                Console.WriteLine("ID " + spiele.ElementAt(0).GetId());
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            // SPIELER SPIEL
            try
            {
                spiele.First().ShowSpieler();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            // SETS GEWONNEN SPIEL 1
            try
            {
                Console.WriteLine("SetsGewonnen " + spiele.First().GetSetsGewonnen()[0]);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            // SET 1 SPIEL 1 ID
            try
            {
                Console.WriteLine("Set1 ID " + spiele.First().GetSetsAll().First().GetId());
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            // SET 1 SPIEL 1 Spieler ID
            try
            {
                Console.WriteLine("Set1 Spieler ID " + spiele.First().GetSetsAll().First().GetSpieler().GetId());
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            // LEG 1 SET 1 SPIEL 1 ID
            try
            {
                Console.WriteLine("LEG1 ID " + spiele.First().GetSetsAll().First().GetLegs().First().GetId());
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            // Durchgang 1 LEG 1 SET 1 SPIEL 1 ID
            try
            {
                Console.WriteLine("DURCHGANG1 ID " + spiele.First().GetSetsAll().First().GetLegs().First().GetDurchgänge().First().GetId());
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            // Wurf 1 D 1 L 1 S 1 S 1
            try
            {
                Console.WriteLine("Wurf " + spiele.First().GetSetsAll().First().GetLegs().First().GetDurchgänge().First().GetWürfe()[0].GetWurfGesamt());
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        public static void Init()
        {
            CreateCheckout();
            //System.IO.Directory.CreateDirectory(@"C:\Users\Public\Dart");
            spieler = new Dictionary<string, Spieler>();
            spiele = new List<Spiel>();
            Lesen();
            Spieler.id_spieler_zähler = DBConnect.GetMaxIDSpieler() + 1;
            Spiel.id_spiel_zähler = DBConnect.GetMaxIDSpiel() + 1;
            Set.id_set_zähler = DBConnect.GetMaxIDSet() + 1;
            Leg.id_leg_zähler = DBConnect.GetMaxIDLeg() + 1;
            Durchgang.id_durchgang_zähler = DBConnect.GetMaxIDDurchgang() + 1;
            Wurf.id_wurf_zähler = DBConnect.GetMaxIDWurf() + 1;
        }

        /// <summary>
        /// Hashed einen übergebenen String mit sha256
        /// </summary>
        /// <param name="value">String welcher gehashed werden soll</param>
        /// <returns>gehashter String</returns>
        public static String HashString(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        /// <summary>
        /// fügt einen Spieler hinzu mit übergebenen Daten
        /// </summary>
        /// <param name="name"></param>
        /// <param name="alter"></param>
        /// <param name="eMail"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="geburtstag"></param>
        public static void AddSpieler(String name, int alter, String eMail, String firstName, String lastName, DateTime geburtstag, String passwd)
        {
            if (spieler.ContainsKey(name))
            {
                Console.WriteLine("SPIELER BEREITS VORHANDEN");
            }
            else
            {
                String passwdHash = Dart.HashString(passwd);
                spieler.Add(name, new Spieler(name, eMail, firstName, lastName, geburtstag, passwdHash));
            }
        }

        /// <summary>	
        /// rechnet Alter aufgrund eines übergebenen Geburtstags aus	
        /// </summary>	
        /// <param name="birthday">ein Geburtsdatum</param>	
        /// <returns>aktuelles Alter</returns>
        public static int GetAgeFromDate(DateTime birthday)
        {
            int years = DateTime.Now.Year - birthday.Year;
            birthday = birthday.AddYears(years);
            if (DateTime.Now.CompareTo(birthday) < 0) { years--; }
            return years;
        }

        /// <summary>
        /// erstellt einen neuen Spieler
        /// </summary>
        /// <param name="name">kann als preLoad angegeben werden</param>
        /// <returns>gibt den erstellten Spieler zurück</returns>
        public static Spieler AddSpieler(String name = "")
        {
            String eMail = "";
            String firstName = "";
            String lastName = "";
            DateTime geburtstag = new DateTime(1900, 1, 1);
            String passwd = "";

            String passwdHash = Dart.HashString(passwd);
            Spieler s = new Spieler(name, eMail, firstName, lastName, geburtstag, passwdHash);
            spieler.Add(name, s);
            // Speichern();
            DBConnect.InsertUser(s);
            return s;
        }

        /// <summary>
        /// Möglichkeit mehrere Spieler nacheinander zu erstellen
        /// </summary>
        //public static void AddSpielerConsoleMehrere()
        //{
        public static void AddSpielerMehrere()
        {
            do
            {
                //AddSpielerConsole();
                AddSpieler();
            } while (YN_Dialog("Weitere Spieler hizufügen"));
        }

        /// <summary>	
        /// erstellt neues Spiel, fügt es in die Spielliste ein und speichert es in der Datenbank	
        /// </summary>
        public static void AddSpiel()
        {
            Spiel s = new Spiel();
            spiele.Add(s);
            SaveSpielToDB(s);
        }

        /// <summary>	
        /// sucht alle Spiele raus, in welchen ein gegebener Spieler gespielt hat	
        /// </summary>	
        /// <param name="spieler">Spieler für welchen die entsprechenden Spiele gesucht werden</param>	
        /// <returns>Spiele als Liste in denen Spieler vorhanden ist</returns>
        public static List<Spiel> SearchSpielePlayedBy(Spieler spieler)
        {
            return spiele.FindAll((Spiel x) => x.HasPlayed(spieler));
        }

        /// <summary>	
        /// sucht alle Spiele raus, in welchen ein gegebener Spieler gespielt hat über username	
        /// </summary>	
        /// <param name="name">Username für Spieler für welchen die entsprechenden Spiele gesucht werden</param>	
        /// <returns>Spiele als Liste in denen Spieler vorhanden ist</returns>
        public static List<Spiel> SearchSpielePlayedBy(String name)
        {
            return spiele.FindAll((Spiel x) => x.HasPlayed(GetSpieler(name.ToLower())));
        }

        /// <summary>	
        /// gibt Spieler zu entsprechendem Username zurück	
        /// </summary>	
        /// <param name="name">username für welchen Spieler zurückgegeben werden soll</param>	
        /// <returns>Spieler mit entsprechendem Username</returns>
        public static Spieler GetSpieler(String name)
        {
            return spieler[name.ToLower()];
        }

        /// <summary>	
        /// gibt Spieler zu entsprechender ID zurück	
        /// </summary>	
        /// <param name="id">id für Spieler</param>	
        /// <returns>Spieler mit entsprechender ID</returns>
        public static Spieler GetSpielerID(int id)
        {
            for (int i = 0; i < spieler.Count; i++)
            {
                if (spieler.ElementAt(i).Value.GetId() == id)
                {
                    return spieler.ElementAt(i).Value;
                }
            }
            return null;
        }

        /// <summary>	
        /// prüft über username, ob Spieler bereits vorhanden ist	
        /// </summary>	
        /// <param name="name">username, welcher überprüft werden soll</param>	
        /// <returns>true wenn Spieler bereits vorhanden</returns>
        public static bool IsSpielerVorhanden(String name)
        {
            return spieler.ContainsKey(name);
        }

        /// <summary>	
        /// erstellt Checkout Tabelle als Dictionary aus Datei "checkout.txt"	
        /// </summary>
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

        /// <summary>	
        /// zeigt alle vorhanden Spieler in der Console an mit allen Daten	
        /// </summary>
        public static void ShowSpielerConsole()
        {
            Console.WriteLine("Spieler:");
            for (int i = 0; i < spieler.Count; i++)
            {
                Console.Write(spieler.ElementAt(i).Value.GetUsername() + ", " + spieler.ElementAt(i).Value.GetEMail() + ", ");
                if (spieler.ElementAt(i).Value.GetGeburtstag().Year != 1900)
                {
                    Console.Write(spieler.ElementAt(i).Value.GetGeburtstag().ToShortDateString() + " (" + spieler.ElementAt(i).Value.GetAlter() + ")");
                }
                Console.WriteLine();
            }
            Confirm_Dialog();
        }

        /// <summary>	
        /// Ja/Nein Dialog mit übergebener Frage	
        /// </summary>	
        /// <param name="s">Frage</param>	
        /// <returns>Antwort der Frage</returns>
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

        /// <summary>	
        /// Bestätigungs Dialog mit Möglichkeit Text zu übergeben	
        /// </summary>	
        /// <param name="s">Text zum Übergeben</param>
        public static void Confirm_Dialog(String s = "Zum fortfahren beliebige Taste drücken")
        {
            Console.WriteLine(s);
            Console.ReadKey();
        }

        /// <summary>
        /// String eingabe Dialog in der Console mit der Möglichkeit alles auf lowercase zu wandeln	
        /// </summary>	
        /// <param name="s">Dialogtext</param>	
        /// <param name="lower"></param>	
        /// <returns>Eingabe als String als ggf lowercase</returns>
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

        /// <summary>
        /// Int eingabe Dialog in der Console mit der Möglichkeit den Eingabe Bereich zu beschränken
        /// </summary>
        /// <param name="s">EingabeText/Frage</param>
        /// <param name="min">Minimaler möglicher Eingabe Wert</param>
        /// <param name="max">Maximaler möglicher Eingabe Wert</param>
        /// <param name="einzeln">möglicher einzelner Wert außerhalb des Min/Max Bereiches</param>
        /// <returns></returns>
        public static int Int_Dialog(String s, int min = int.MinValue, int max = int.MaxValue, int einzeln = int.MaxValue)
        {
            int integer = 0;
            bool invalid = true;
            while (invalid)
            {
                invalid = false;
                try
                {
                    Console.WriteLine(s + ":");
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
                        case 0:
                            Test();
                            break;
                        case 1:
                            ShowSpielerConsole();
                            break;
                        case 2:
                            AddSpielerMehrere();
                            break;
                        case 3:
                            AddSpiel();
                            break;
                        case 4:
                            Statistik.Starting();
                            break;
                        case 5:
                            //running = false;
                            //Speichern();
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

        /// <summary>
        /// schreibt den Char c j-mal mit Zeilenumbruch, wenn line = true
        /// </summary>
        /// <param name="c">Char der geschrieben werden soll</param>
        /// <param name="j">Anzahl, wie oft c geschreiben werden soll</param>
        /// <param name="line">boolean, ob am Ende ein Zeilenumbruch gemacht werden soll</param>
        public static void WriteChar(char c, int j, bool line = true)
        {
            for (int i = 0; i < j; i++)
            {
                Console.Write(c);
            }
            if (line) Console.WriteLine();
        }

        /// <summary>
        /// gibt die maximale/höchste länge aller Spieler Usernames zurück 
        /// </summary>
        /// <returns>maximale/höchste länge aller Spieler Usernames</returns>
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

        /// <summary>
        /// gibt die länge des Usernames des übergebenen Spielers zurück
        /// </summary>
        /// <param name="s">Spieler dessen Länge des Usernames überprüft werden soll</param>
        /// <returns>länge des Usernames des übergebenen Spielers</returns>
        public static int LengthSpieler(Spieler s)
        {
            return s.GetUsername().Count();
        }

        /// <summary>
        /// speichert alle Würfe eines übergebenen Durchgangs in der DB
        /// </summary>
        /// <param name="d">Durchgang dessen Würfe gespeichert werden sollen</param>
        public static void SaveWürfeToDB(Durchgang d)
        {
            for (int y = 0; y < d.GetWürfe().Count(); y++)
            {
                DBConnect.InsertWurf(d.GetWürfe().ElementAt(y), d
                    );
            }
        }
        
        /// <summary>
        /// speichert alle Durchgänge des übergebenen Legs in der DB
        /// </summary>
        /// <param name="l">Leg dessen Durchgänge gespeichert werden sollen</param>
        public static void SaveDurchgängeToDB(Leg l)
        {
            for (int y = 0; y < l.GetDurchgänge().Count; y++)
            {
                DBConnect.InsertDurchgang(l.GetDurchgänge().ElementAt(y), l);
                SaveWürfeToDB(l.GetDurchgänge().ElementAt(y));
            }
        }

        /// <summary>
        /// speichert alle Legs des übergeben Sets in der DB
        /// </summary>
        /// <param name="s">Set dessen Legs gespeichert werden sollen</param>
        public static void SaveLegsToDB(Set s)
        {
            for (int y = 0; y < s.GetLegs().Count; y++)
            {
                DBConnect.InsertLeg(s.GetLegs().ElementAt(y), s);
                SaveDurchgängeToDB(s.GetLegs().ElementAt(y));
            }
        }

        /// <summary>
        /// speichert alle Sets des übergebenen Spiels in der DB
        /// </summary>
        /// <param name="s">Spiel dessen Sets gespeichert werden sollen</param>
        public static void SaveSetsToDB(Spiel s)
        {
            for (int y = 0; y < s.GetSetsAll().Count; y++)
            {
                DBConnect.InsertSet(s.GetSetsAll().ElementAt(y), s);
                SaveLegsToDB(s.GetSetsAll().ElementAt(y));
            }
        }

        /// <summary>
        /// speichert alle Sets in der DB
        /// </summary>
        public static void SaveSetsToDB()
        {
            for (int y = 0; y < spiele.Count; y++)
            {
                for (int z = 0; z < spiele.ElementAt(y).GetSetsAll().Count; z++)
                {
                    DBConnect.InsertSet(spiele.ElementAt(y).GetSetsAll().ElementAt(z), spiele.ElementAt(y));
                    SaveLegsToDB(spiele.ElementAt(y).GetSetsAll().ElementAt(z));

                }
            }
        }

        /// <summary>
        /// speichert übergebenes Spiel in der DB
        /// </summary>
        /// <param name="s">Spiel das gespeichert werden soll</param>
        public static void SaveSpielToDB(Spiel s)
        {
            try
            {
                DBConnect.InsertSpiel(s);
                for (int z = 0; z < s.GetSpieler().Count; z++)
                {
                    DBConnect.InsertSpieltMit(s, s.GetSpieler().ElementAt(z).Value, s.GetSetsGewonnen()[z]);
                }
                SaveSetsToDB(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

        }

        /// <summary>
        /// speichert alle Spiele in der DB
        /// </summary>
        public static void SaveSpieleToDB()
        {
            for (int y = 0; y < spiele.Count; y++)
            {
                SaveSpielToDB(spiele.ElementAt(y));
            }
        }

        /// <summary>
        /// speichert alle Spieler in der DB
        /// </summary>
        public static void SaveSpielerToDB()
        {
            for (int y = 0; y < spieler.Count; y++)
            {
                DBConnect.InsertUser(spieler.ElementAt(y).Value);
            }
        }

        /// <summary>
        /// holt alle Spieler aus der DB, erstellt diese als Objekte und fügt sie einem Dictionary hinzu dass dann übergeben wird
        /// </summary>
        /// <returns>Dictionary mit allen erstellten SpielerObjekten aus der DB</returns>
        public static Dictionary<String, Spieler> GetSpielerFromDB()
        {
            Dictionary<String, Spieler> spieler = new Dictionary<string, Spieler>();
            List<string>[] list = DBConnect.SelectUser();
            for (int y = 0; y < list[0].Count(); y++)
            {
                int id = int.Parse(list[0].ElementAt(y));
                String username = list[1].ElementAt(y);
                String firstName = list[2].ElementAt(y);
                String lastName = list[3].ElementAt(y);
                String eMail = list[5].ElementAt(y);
                String passwd = list[6].ElementAt(y);
                DateTime geburtstag = new DateTime(1900, 1, 1);
                if (!list[4].ElementAt(y).Equals("NULL") && (list[4].ElementAt(y).Count() > 0))
                {
                    //string jahrString = "" + list[4].ElementAt(y).ElementAt(6) + list[4].ElementAt(y).ElementAt(7) + list[4].ElementAt(y).ElementAt(8) + list[4].ElementAt(y).ElementAt(9);
                    //int jahr = int.Parse(jahrString);
                    //string monatString = "" + list[4].ElementAt(y).ElementAt(3) + list[4].ElementAt(y).ElementAt(4);
                    //int monat = int.Parse(monatString);
                    //string tagString = "" + list[4].ElementAt(y).ElementAt(0) + list[4].ElementAt(y).ElementAt(1);
                    //int tag = int.Parse(tagString);
                    geburtstag = TimeOfString(list[4].ElementAt(y));
                }
                spieler.Add(username, new Spieler(id, username, eMail, firstName, lastName, geburtstag, passwd));
            }
            return spieler;
        }

        /// <summary>
        /// holt alle Spiele aus der DB, erstellt diese als Objekte, inkl. aller Verküpfungen und Attributen und fügt diese zu einer List hinzu, welche dann übergeben wird
        /// </summary>
        /// <returns>List mit allen komplett erstellten SpielObjekten aus der DB</returns>
        public static List<Spiel> GetSpieleFromDB()
        {
            List<Spiel> spiele = new List<Spiel>();
            List<string>[] list = DBConnect.SelectSpiele();
            for (int y = 0; y < list[0].Count; y++)
            {
                Spiel s = new Spiel(int.Parse(list[0].ElementAt(y)), TimeOfStringTime(list[1].ElementAt(y)), int.Parse(list[2].ElementAt(y)), int.Parse(list[3].ElementAt(y)), int.Parse(list[4].ElementAt(y)));
                s.SetSpieler(GetSpielerInSpielFromDB(s.GetId()));
                s.SetSetsGewonnen(GetSetsGewonnenFromDB(s.GetId()));
                s.SetSets(GetSetsOfSpiel(s.GetId()));

                spiele.Add(s);
            }
            return spiele;
        }

        /// <summary>
        /// holt das Array der gewonnenen Sets für das Spiel mit der übergeben id aus der DB und gibt dies zurück
        /// </summary>
        /// <param name="id">id des Spiels für welches das Array geholt werden soll</param>
        /// <returns>SetsGewonnen Array aus Spiel mit id</returns>
        public static int[] GetSetsGewonnenFromDB(int id)
        {
            int[] array = new int[DBConnect.CountSpielerInSpiel(id)];
            for (int y = 0; y < array.Count(); y++)
            {
                array[y] = int.Parse(DBConnect.SelectSpieltMit(id)[2].ElementAt(y));
            }
            return array;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Dictionary<String, Spieler> GetSpielerInSpielFromDB(int id)
        {
            Dictionary<String, Spieler> spieler = new Dictionary<string, Spieler>();
            List<string>[] list = DBConnect.SelectSpieltMit(id);
            for (int y = 0; y < list[0].Count; y++)
            {
                string username = GetSpielerID(int.Parse(list[0].ElementAt(y))).GetUsername();
                spieler.Add(username, GetSpieler(username));
            }
            return spieler;
        }

        /// <summary>
        /// holt alle Sets des Spiels mit der übergebenen id aus der Datenbank, erstellt die Objekte und fügt sie zu einer List hinzu, welche dann übergeben wird
        /// </summary>
        /// <param name="id">id des Spiels aus welchem alle Sets geholt werden sollen</param>
        /// <returns>List mit allen geholten Sets</returns>
        public static List<Set> GetSetsOfSpiel(int id)
        {
            List<Set> sets = new List<Set>();
            List<string>[] list = DBConnect.SelectSetSpielID(id);
            for (int y = 0; y < list[0].Count; y++)
            {
                Set s = new Set(int.Parse(list[0].ElementAt(y)), GetSpielerID(int.Parse(list[4].ElementAt(y))), int.Parse(list[2].ElementAt(y)), int.Parse(list[3].ElementAt(y)));
                s.SetLegs(GetLegsOfSet(s.GetId()));
                sets.Add(s);
            }
            return sets;
        }

        /// <summary>
        /// holt alle Legs des Sets mit der übergebenen id aus der Datenbank, erstellt die Objekte und fügt sie zu einer List hinzu, welche dann übergeben wird
        /// </summary>
        /// <param name="id">id des Sets aus welchem alle Legs geholt werden sollen</param>
        /// <returns>List mit allen geholten Legs</returns>
        public static List<Leg> GetLegsOfSet(int id)
        {
            List<Leg> legs = new List<Leg>();
            List<string>[] list = DBConnect.SelectLegSetID(id);
            for (int y = 0; y < list[0].Count; y++)
            {
                Leg l = new Leg(int.Parse(list[0].ElementAt(y)), int.Parse(list[2].ElementAt(y)), int.Parse(list[3].ElementAt(y)), int.Parse(list[4].ElementAt(y)));
                l.SetDurchgänge(GetDurchgängeOfLeg(l.GetId()));
                legs.Add(l);
            }
            return legs;
        }

        /// <summary>
        /// holt alle Durchgänge des Legs mit der übergebenen id aus der Datenbank, erstellt die Objekte und fügt sie zu einer List hinzu, welche dann übergeben wird
        /// </summary>
        /// <param name="id">id des Legs aus welchem alle Durchgänge geholt werden sollen</param>
        /// <returns>List mit allen geholten Durchgängen</returns>
        public static List<Durchgang> GetDurchgängeOfLeg(int id)
        {
            List<Durchgang> durchgänge = new List<Durchgang>();
            List<string>[] list = DBConnect.SelectDurchgangLegID(id);
            for (int y = 0; y < list[0].Count && y < list[2].Count && y < list[3].Count && y < list[4].Count; y++)
            {
                Durchgang d = new Durchgang(int.Parse(list[0].ElementAt(y)), int.Parse(list[2].ElementAt(y)), int.Parse(list[3].ElementAt(y)), int.Parse(list[4].ElementAt(y)));
                d.SetWürfe(GetWürfeOfDurchgang(d.GetId()));
                durchgänge.Add(d);
            }
            return durchgänge;
        }

        /// <summary>
        /// holt alle Würfe des Durchgangs mit der übergebenen id aus der Datenbank, erstellt die Objekte und fügt sie zu einem Array hinzu, welches dann übergeben wird
        /// </summary>
        /// <param name="id">id des Durchgangs aus welchem alle Würfe geholt werden sollen</param>
        /// <returns>Array mit allen geholten Würfen</returns>
        public static Wurf[] GetWürfeOfDurchgang(int id)
        {
            Wurf[] würfe = new Wurf[3];
            würfe[0] = new Wurf(0, 0);
            würfe[1] = new Wurf(0, 0);
            würfe[2] = new Wurf(0, 0);
            List<string>[] list = DBConnect.SelectWurfDurchgangID(id);
            for (int y = 0; y < list[0].Count; y++)
            {
                Wurf w = new Wurf(int.Parse(list[0].ElementAt(y)), int.Parse(list[2].ElementAt(y)), int.Parse(list[3].ElementAt(y)), int.Parse(list[4].ElementAt(y)));
                würfe[y] = w;
            }
            return würfe;
        }

        /// <summary>
        /// konvertiert den eingegebenen String in eine DateTime ohne Uhrzeit (zur verarbeitung der DB Ausgaben)
        /// </summary>
        /// <param name="s">String (aus DB Ausgabe) welcher in DateTime konvertiert werden soll</param>
        /// <returns>DateTime aus String</returns>
        public static DateTime TimeOfString(String s)
        {
            string jahrString = "" + s.ElementAt(6) + s.ElementAt(7) + s.ElementAt(8) + s.ElementAt(9);
            int jahr = int.Parse(jahrString);
            string monatString = "" + s.ElementAt(3) + s.ElementAt(4);
            int monat = int.Parse(monatString);
            string tagString = "" + s.ElementAt(0) + s.ElementAt(1);
            int tag = int.Parse(tagString);
            return new DateTime(jahr, monat, tag);
        }

        /// <summary>
        /// konvertiert den eingegebenen String in eine DateTime mit Uhrzeit (zur verarbeitung der DB Ausgaben)
        /// </summary>
        ///<param name="s">String (aus DB Ausgabe) welcher in DateTime konvertiert werden soll</param>
        /// <returns>DateTime aus String</returns>
        public static DateTime TimeOfStringTime(String s)
        {
            string jahrString = "" + s.ElementAt(6) + s.ElementAt(7) + s.ElementAt(8) + s.ElementAt(9);
            int jahr = int.Parse(jahrString);
            string monatString = "" + s.ElementAt(3) + s.ElementAt(4);
            int monat = int.Parse(monatString);
            string tagString = "" + s.ElementAt(0) + s.ElementAt(1);
            int tag = int.Parse(tagString);
            string stundeString = "" + s.ElementAt(11) + s.ElementAt(12);
            int stunde = int.Parse(stundeString);
            string minuteString = "" + s.ElementAt(14) + s.ElementAt(15);
            int minute = int.Parse(minuteString);
            string sekundeString = "" + s.ElementAt(17) + s.ElementAt(18);
            int sekunde = int.Parse(sekundeString);
            return new DateTime(jahr, monat, tag, stunde, minute, sekunde);
        }
    }
}
