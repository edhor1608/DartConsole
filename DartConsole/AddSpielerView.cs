using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartConsole
{
    public partial class AddSpielerView : Form
    {
        DateTime geburtsdatum;

        public AddSpielerView()
        {
            InitializeComponent();
        }

        private void Geburstsdatum_Aendern(object sender, MouseEventArgs e)
        {
            SelectDateDialog sdd = new SelectDateDialog();
            sdd.ShowDialog();

            tBx_Geburtsdatum.Text = sdd.Geburtsdatum.ToShortDateString();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                tBx_username.BackColor = Color.White;
                tBx_eMail.BackColor = Color.White;

                //Passwort Wdh Überprüfung steht noch aus
                //String passwdHash = Dart.HashString(tBx_Passwort.Text);
                Dart.AddSpieler(tBx_username.Text.ToLower(), Dart.GetAgeFromDate(DateTime.Parse(tBx_Geburtsdatum.Text)), tBx_eMail.Text, tBx_FirstName.Text, tBx_LastName.Text, DateTime.Parse(tBx_Geburtsdatum.Text), tBx_Passwort.Text);

                Dart.SaveSpielerToDB();

                MessageBox.Show("Spieler erfolgreich erstellt.");

                this.Close();
            }
        }

        /// <summary>
        /// Überprüft ob der eingegebene String eine E-Mail-Adresse ist
        /// </summary>
        /// <param name="email">Vermeindliche E-Mail-Adresse als String</param>
        /// <returns>true = IsValid und false = !IsValid</returns>
        bool IsValidEmail(string email)
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

        bool IsValid()
        {
            if (tBx_username.Text.Length == 0 || tBx_eMail.Text.Length == 0 || tBx_Passwort.Text.Length == 0 || tBx_Geburtsdatum.Text.Length == 0)
            {
                MessageBox.Show("Pflichtfelder nicht ausgefüllt.");
                return false;
            }
            if (!tBx_Passwort.Text.Equals(tBx_Passwort_Wdh.Text))
            {
                MessageBox.Show("Passwörter stimmen nicht überein");
                tBx_Passwort.BackColor = Color.Red;
                return false;
            }
            if (Dart.IsSpielerVorhanden(tBx_username.Text))
            {
                MessageBox.Show("Username bereits vorhanden.");
                tBx_username.BackColor = Color.Red;
                return false;
            }
            if (!IsValidEmail(tBx_eMail.Text))
            {
                MessageBox.Show("Bitte überprüfe deine eingegebene E-Mail-Adresse.");
                tBx_eMail.BackColor = Color.Red;
                return false;
            }
            return true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tBx_username_TextChanged(object sender, EventArgs e)
        {
            tBx_username.BackColor = Color.White;
        }

        private void tBx_eMail_TextChanged(object sender, EventArgs e)
        {
            tBx_eMail.BackColor = Color.White;
        }

        private void tBx_Passwort_TextChanged(object sender, EventArgs e)
        {
            tBx_Passwort.BackColor = Color.White;
            if (!tBx_Passwort.Text.Equals(tBx_Passwort_Wdh.Text))
            {
                tBx_Passwort_Wdh.BackColor = Color.Red;
            }
            else
            {
                tBx_Passwort_Wdh.BackColor = Color.White;
            }                
        }

        private void tBx_Geburtsdatum_TextChanged(object sender, EventArgs e)
        {
            tBx_Geburtsdatum.BackColor = Color.White;
        }

        private void tBx_Passwort_Wdh_TextChanged(object sender, EventArgs e)
        {
            tBx_Passwort_Wdh.BackColor = Color.White;
            if (!tBx_Passwort.Text.Equals(tBx_Passwort_Wdh.Text))
            {
                tBx_Passwort_Wdh.BackColor = Color.Red;
            }
            else
            {
                tBx_Passwort_Wdh.BackColor = Color.White;
            }
        }
    }
}
