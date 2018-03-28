using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartConsole
{
    [Serializable]
    class Spieler
    {
        private String name;
        private int alter;
        private String eMail;

        public Spieler(String name, int alter=0, String eMail="")
        {
            this.name = name;
            this.alter = alter;
            this.eMail = eMail;
        }

        public String getName()
        {
            return name;
        }

        public int getAlter()
        {
            return alter;
        }

        public String getEMail()
        {
            return eMail;
        }

        public void setEMail(String eMail)
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
