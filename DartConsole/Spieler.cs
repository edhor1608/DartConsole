﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartConsole
{
    [Serializable]
    class Spieler
    {
        private int id_spieler;
        public static int id_spieler_zähler = 0;
        private String username;
        private String firstName;
        private String lastName;
        private DateTime geburtstag;
        private String eMail;

        public Spieler(String name, String eMail, String firstName, String lastName, DateTime geburtstag)
        {
            id_spieler = id_spieler_zähler;
            id_spieler_zähler++;
            this.username = name;
            this.eMail = eMail;
            this.firstName = firstName;
            this.lastName = lastName;
            this.geburtstag = geburtstag;
        }

        public Spieler(int id_spieler, String name, String eMail, String firstName, String lastName, DateTime geburtstag)
        {
            this.id_spieler = id_spieler;
            this.username = name;
            this.eMail = eMail;
            this.firstName = firstName;
            this.lastName = lastName;
            this.geburtstag = geburtstag;
        }

        public int GetId()
        {
            return id_spieler;
        }

        public String GetFirstName()
        {
            return firstName;
        }

        public String GetLastName()
        {
            return lastName;
        }

        public DateTime GetGeburtstag()
        {
            return geburtstag;
        }

        public String GetUsername()
        {
            return username;
        }

        public int GetAlter()
        {
            return Dart.GetAgeFromDate(geburtstag);
        }

        public String GetEMail()
        {
            return eMail;
        }

        public void SetEMail(String eMail)
        {
            this.eMail = eMail;
        }

        public static bool ValidateMailAddress(String email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
