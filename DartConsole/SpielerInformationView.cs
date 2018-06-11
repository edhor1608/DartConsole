using DartConsole;
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
    public partial class SpielerInformationView : Form
    {
        public SpielerInformationView(string spielerName)
        {
            InitializeComponent();

            Spieler sp = Dart.GetSpieler(spielerName);

            tBx_eMail.Text = sp.GetEMail();
            tBx_firstName.Text = sp.GetFirstName();
            tBx_geburtstag.Text = sp.GetGeburtstag().ToString();
            tBx_lastName.Text = sp.GetLastName();
            tBx_username.Text = sp.GetUsername();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
