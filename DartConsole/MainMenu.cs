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
    public partial class MainMenu : Form
    {
       

        public MainMenu()
        {
            InitializeComponent();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Beenden_Click(object sender, EventArgs e)
        {
            Program.spieler = null;
            Program.frmMainMenu.Hide();
            Program.frmStartingScreen.Show();
            Program.frmStartingScreen.tBx_passwort.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Geburtstag_Click(object sender, EventArgs e)
        {

        }

        private void btn_Uebernehmen_Click(object sender, EventArgs e)
        {
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            tBx_eMail.Text = Program.spieler.GetEMail();
            tBx_geburtstag.Text = Program.spieler.GetGeburtstag().ToShortDateString();
            tBx_nachname.Text = Program.spieler.GetLastName();
            tBx_username.Text = Program.spieler.GetUsername();
            tBx_vorname.Text = Program.spieler.GetFirstName();
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            Program.frmMainMenu.Hide();
            Program.frmGameOptions.Show();
        }

        private void btn_statistik_Click(object sender, EventArgs e)
        {
            Program.frmMainMenu.Hide();
            Program.frmStatistikView.Show();
        }
    }
}
