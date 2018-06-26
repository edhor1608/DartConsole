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
    public partial class StartingScreen : Form
    {
        public StartingScreen()
        {
            InitializeComponent();
        }

        private void lbl_passwort_Click(object sender, EventArgs e)
        {

        }

        private void btn_usrAuflistung_Click(object sender, EventArgs e)
        {
            Program.frmStartingScreen.Hide();
            Program.frmMainView.Show();

        }

        private void btn_Beenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_newUser_Click(object sender, EventArgs e)
        {
            new AddSpielerView().ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (CheckLogin())
            {
                Program.spieler = Dart.GetSpieler(tBx_username.Text.ToLower());
                Program.frmStartingScreen.Hide();
                Program.frmMainMenu.Show();
            }
            else
            {
                lbl_falseUser.Visible = true;
                tBx_username.Clear();
                tBx_passwort.Clear();
            }
        }

        private bool CheckLogin()
        {
            String username = tBx_username.Text.ToLower();
            String passwort = Dart.HashString(tBx_passwort.Text);
            if (Dart.IsSpielerVorhanden(username))
            {
                if(Dart.GetSpieler(username).GetPasswd().ToLower().Equals(passwort.ToLower()))
                {
                    Program.frmMainMenu.lbl_Begruessung.Text = "Hallo "+ username;
                    return true;
                }
                else
                {
                    lbl_falsePaswd.Visible = true;
                    //tBx_passwort.Text = Dart.GetSpieler(username).GetPasswd();
                    return false;
                }
            }
            else
            {
                lbl_falseUser.Visible = true;
                return false;
            }
        }
    }
}
