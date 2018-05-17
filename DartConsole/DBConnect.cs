using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DartConsole
{
    class DBConnect
    {
        private static MySqlConnection connection;
        private static string server;
        private static string database;
        private static string username;
        private static string password;
        private static int port;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private static void Initialize()
        {
            server = "jonas-rohde.de";
            database = "dart";
            port = 3306;
            username = "edhor";
            password = "Tierchen2467";
            string connectionString;
            connectionString = "Server=" + server + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password + ";SslMode=" + "none";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private static bool OpenConnection()
        {
            Initialize();
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Insert statement
        public static void Insert()
        {
            string query = "INSERT INTO user (username) VALUES('jonas')";

            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE user SET name='edhor'WHERE name='jonas' AND id_user=1";

            //Open connection
            if (OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

        //Delete statement
        public static void Delete()
        {
            string query = "DELETE FROM user WHERE name='jonas' AND id_user>3";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Select statement
        public static List<string>[] Select()
        {
            string query = "SELECT * FROM user";

            //Create a list to store the result
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id_user"] + "");
                    list[1].Add(dataReader["username"] + "");
                    list[2].Add(dataReader["firstName"] + "");
                    list[2].Add(dataReader["lastName"] + "");
                    list[2].Add(dataReader["geburtstag"] + "");
                    list[2].Add(dataReader["eMail"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public static int Count()
        {
            string query = "SELECT Count(*) FROM user";
            int Count = -1;

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public static int CountSpieler()
        {
            string query = "SELECT Count(*) FROM user";
            int Count = -1;

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public static int CountSpielerInSpiel(int id)
        {
            string query = "SELECT Count(*) FROM spieltMit WHERE id_spiel="+id;
            int Count = -1;

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public static int GetMaxIDSpiel()
        {
            string query = "SELECT Max(id_spiel) FROM spiel";
            int Count = -1;

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                try
                {
                    Count = int.Parse(cmd.ExecuteScalar() + "");
                }
                catch
                {

                }

                //close Connection
                CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public static int GetMaxIDSpieler()
        {
            string query = "SELECT Max(id_user) FROM user";
            int Count = -1;

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                try
                {
                    Count = int.Parse(cmd.ExecuteScalar() + "");
                }
                catch
                {

                }

                //close Connection
                CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public static int GetMaxIDSet()
        {
            string query = "SELECT Max(id_set) FROM set";
            int Count = -1;

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                try
                {
                    Count = int.Parse(cmd.ExecuteScalar() + "");
                }
                catch
                {

                }

                //close Connection
                CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public static int GetMaxIDLeg()
        {
            string query = "SELECT Max(id_leg) FROM leg";
            int Count = -1;

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                try
                {
                    Count = int.Parse(cmd.ExecuteScalar() + "");
                }
                catch
                {

                }

                //close Connection
                CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public static int GetMaxIDDurchgang()
        {
            string query = "SELECT Max(id_durchgang) FROM durchgang";
            int Count = -1;

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                try
                {
                    Count = int.Parse(cmd.ExecuteScalar() + "");
                }
                catch
                {

                }

                //close Connection
                CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public static int GetMaxIDWurf()
        {
            string query = "SELECT Max(id_wurf) FROM wurf";
            int Count = -1;

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                try
                {
                    Count = int.Parse(cmd.ExecuteScalar() + "");
                }
                catch
                {

                }

                //close Connection
                CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public static bool CheckSpieler(Spieler s)
        {
            return CheckID(s.GetId());
        }

        public static bool CheckID(int id)
        {
            string query = "SELECT Count(*) FROM user WHERE id_user=" + id;
            int Count = -1;

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                CloseConnection();
            }
            if (Count <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void InsertWurf(Wurf w, Durchgang durchgang)
        {
            string query = "INSERT INTO wurf (`id_wurf`, `id_durchgang`, `wurfNummer`, `multiplikator`, `wert`) VALUES ('"+w.GetId()+"', '"+durchgang.GetId()+"', '"+w.GetWurfNummer()+"', '"+w.GetMulti()+"', '"+w.GetWert()+"')";

            //open connection
            if (OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                    //Console.ReadLine();
                }
                //close connection
                CloseConnection();
            }
        }

        public static void InsertDurchgang(Durchgang durchgang, Leg leg)
        {
            int finishBereich = 0;
            if (durchgang.IsFinishBereich()) finishBereich = 1;

            string query = "INSERT INTO durchgang (`id_durchgang`, `id_leg`, `durchgangNummer`, `anzahlWurfe`, `finishBereich`) VALUES ('" + durchgang.GetId() + "', '" + leg.GetId() + "', '" + durchgang.GetDurchgangNummer() + "', '" + durchgang.GetAnzahlWürfe() + "', '" + finishBereich + "')";

            //open connection
            if (OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                    //Console.ReadLine();
                }
                //close connection
                CloseConnection();
            }
        }

        public static void InsertLeg(Leg leg, Set set)
        {
            string query = "INSERT INTO leg (`id_leg`, `id_set`, `legNummer`, `rest`, `finish`) VALUES ('" + leg.GetId() + "', '" + set.GetId() + "', '" + leg.GetLegNummer() + "', '" + leg.GetRest() + "', '" + leg.GetFinish() + "')";

            //open connection
            if (OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                    //Console.ReadLine();
                }
                //close connection
                CloseConnection();
            }
        }

        public static void InsertSet(Set set, Spiel spiel)
        {
            string query = "INSERT INTO `set` (`id_set`, `id_spiel`, `setNummer`, `legsGewonnen`, `id_spieler`) VALUES ('" + set.GetId() + "', '" + spiel.GetId() + "', '" + set.GetSetNummer() + "', '" + set.GetLegsGewonnen() + "', '" + set.GetSpieler().GetId() + "');";

            //open connection
            if (OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                    //Console.ReadLine();
                }
                //close connection
                CloseConnection();
            }
        }

        public static void InsertSpiel(Spiel s)
        {
            string query = "INSERT INTO spiel (`id_spiel`, `datum`, `start`, `setsToWin`, `legsToWin`) VALUES ('" + s.GetId() + "', '" + s.GetDatum().Year + "-" + s.GetDatum().Month + "-" + s.GetDatum().Day + "', '501', '" + s.GetSetsToWin() + "', '" + s.GetLegsToWin() + "')";

            //open connection
            if (OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                    //Console.ReadLine();
                }
                //close connection
                CloseConnection();
            }

        }

        public static void InsertSpieltMit(Spiel s, Spieler sp, int setsGewonnen)
        {
            string query = "INSERT INTO spieltMit (`id_user`, `id_spiel`, `setsGewonnen`) VALUES ('" + sp.GetId() + "', '" + s.GetId() + "', '" + setsGewonnen + "')";

            //open connection
            if (OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                    //Console.ReadLine();
                }
                //close connection
                CloseConnection();
            }
        }

        public static void InsertUser(Spieler s)
        {
            if (!CheckSpieler(s))
            {
                String firstNameData = "'" + s.GetFirstName() + "'";
                String lastNameData = "'" + s.GetLastName() + "'";
                String geburtstagData = "'" + s.GetGeburtstag().Year + "-" + s.GetGeburtstag().Month + "-" + s.GetGeburtstag().Day + "'";
                String eMailData = "'" + s.GetEMail() + "'";
                if (s.GetFirstName() == "")
                {
                    firstNameData = "NULL";
                }
                if (s.GetLastName() == "")
                {
                    lastNameData = "NULL";
                }
                if (s.GetEMail() == "")
                {
                    eMailData = "NULL";
                }
                if (s.GetGeburtstag().Equals(new DateTime(1900, 1, 1)))
                {
                    geburtstagData = "NULL";
                }
                string query = "INSERT INTO user (`id_user`, `username`, `firstName`, `lastName`, `geburtstag`, `eMail`) VALUES('" + s.GetId() + "', '" + s.GetUsername() + "', " + firstNameData + ", " + lastNameData + ", " + geburtstagData + ", " + eMailData + ")";
                //Console.WriteLine(query);
                //Console.ReadKey();
                //open connection
                if (OpenConnection() == true)
                {
                    try
                    {
                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        //Execute command
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                    //close connection
                    CloseConnection();
                }
                else
                {
                    Console.WriteLine("HALLOI");
                    Console.ReadLine();
                }
            }

        }

        public static List<string>[] SelectUser()
        {
            string query = "SELECT * FROM user";

            //Create a list to store the result
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id_user"] + "");
                    list[1].Add(dataReader["username"] + "");
                    list[2].Add(dataReader["firstName"] + "");
                    list[3].Add(dataReader["lastName"] + "");
                    list[4].Add(dataReader["geburtstag"] + "");
                    list[5].Add(dataReader["eMail"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public static List<string>[] SelectUserID(int id)
        {
            string query = "SELECT * FROM user WHERE id_user="+id;

            //Create a list to store the result
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id_user"] + "");
                    list[1].Add(dataReader["username"] + "");
                    list[2].Add(dataReader["firstName"] + "");
                    list[3].Add(dataReader["lastName"] + "");
                    list[4].Add(dataReader["geburtstag"] + "");
                    list[5].Add(dataReader["eMail"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public static List<string>[] SelectSpieltMit(int id)
        {
            string query = "SELECT * FROM `spieltMit` WHERE id_spiel="+id;

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id_user"] + "");
                    list[1].Add(dataReader["id_spiel"] + "");
                    list[2].Add(dataReader["setsGewonnen"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public static List<string>[] SelectWurfDurchgangID(int id)
        {
            string query = "SELECT * FROM `wurf` WHERE id_durchgang=" + id;

            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id_wurf"] + "");
                    list[1].Add(dataReader["id_durchgang"] + "");
                    list[2].Add(dataReader["wurfNummer"] + "");
                    list[3].Add(dataReader["multiplikator"] + "");
                    list[4].Add(dataReader["wert"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public static List<string>[] SelectDurchgangLegID(int id)
        {
            string query = "SELECT * FROM `durchgang` WHERE id_leg=" + id;

            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id_durchgang"] + "");
                    list[1].Add(dataReader["id_leg"] + "");
                    list[2].Add(dataReader["durchgangNummer"] + "");
                    list[3].Add(dataReader["anzahlWurfe"] + "");
                    list[4].Add(dataReader["finishBereich"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public static List<string>[] SelectLegSetID(int id)
        {
            string query = "SELECT * FROM `leg` WHERE id_set=" + id;

            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id_leg"] + "");
                    list[1].Add(dataReader["id_set"] + "");
                    list[2].Add(dataReader["legNummer"] + "");
                    list[3].Add(dataReader["rest"] + "");
                    list[4].Add(dataReader["finish"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public static List<string>[] SelectSetSpielID(int id)
        {
            string query = "SELECT * FROM `set` WHERE id_spiel="+id;

            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id_set"] + "");
                    list[1].Add(dataReader["id_spiel"] + "");
                    list[2].Add(dataReader["setNummer"] + "");
                    list[3].Add(dataReader["legsGewonnen"] + "");
                    list[4].Add(dataReader["id_spieler"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public static List<string>[] SelectSpiele()
        {
            string query = "SELECT * FROM `spiel`";

            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id_spiel"] + "");
                    list[1].Add(dataReader["datum"] + "");
                    list[2].Add(dataReader["start"] + "");
                    list[3].Add(dataReader["setsToWin"] + "");
                    list[4].Add(dataReader["legsToWin"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
