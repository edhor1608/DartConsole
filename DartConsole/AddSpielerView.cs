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
            if (!IsValidEmail(tBx_eMail.Text))
            {
                MessageBox.Show("Bitte überprüfe deine eingegebene E-Mail-Adresse.");
                tBx_eMail.BackColor = Color.Red;
                
            }
            else
            {
                tBx_eMail.BackColor = Color.White;

                Dart.AddSpieler(tBx_FirstName.Text + "-" + tBx_LastName.Text, Dart.GetAgeFromDate(DateTime.Parse(tBx_Geburtsdatum.Text)), tBx_eMail.Text, tBx_FirstName.Text, tBx_LastName.Text, DateTime.Parse(tBx_Geburtsdatum.Text));

                Dart.SaveSpielerToDB();
            }

            this.Close();

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
    }
}
