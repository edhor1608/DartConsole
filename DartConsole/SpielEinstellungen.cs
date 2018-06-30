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
    public partial class SpielEinstellungen : Form
    {
        public SpielEinstellungen()
        {
            InitializeComponent();
            FormsInArray();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SpielEinstellungen_Load(object sender, EventArgs e)
        {
            tBx_spieler1.Text = Program.spieler.GetUsername();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllTB();
            tBx_spieler2.Text = Program.spieler.GetUsername();
            tBx_spieler2.ReadOnly = true;
            tBx_spieler2.BackColor = Color.Gray;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            IsUserValid((System.Windows.Forms.TextBox)sender);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            IsUserValid((System.Windows.Forms.TextBox)sender);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllTB();
            tBx_spieler4.Text = Program.spieler.GetUsername();
            tBx_spieler4.ReadOnly = true;
            tBx_spieler4.BackColor = Color.Gray;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            IsUserValid((System.Windows.Forms.TextBox)sender);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            IsUserValid((System.Windows.Forms.TextBox)sender);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            IsUserValid((System.Windows.Forms.TextBox)sender);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllTB();
            tBx_spieler5.Text = Program.spieler.GetUsername();
            tBx_spieler5.ReadOnly = true;
            tBx_spieler5.BackColor = Color.Gray;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            IsUserValid((System.Windows.Forms.TextBox)sender);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllTB();
            tBx_spieler6.Text = Program.spieler.GetUsername();
            tBx_spieler6.ReadOnly = true;
            tBx_spieler6.BackColor = Color.Gray;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllTB();
            tBx_spieler7.Text = Program.spieler.GetUsername();
            tBx_spieler7.ReadOnly = true;
            tBx_spieler7.BackColor = Color.Gray;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllTB();
            tBx_spieler8.Text = Program.spieler.GetUsername();
            tBx_spieler8.ReadOnly = true;
            tBx_spieler8.BackColor = Color.Gray;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            IsUserValid((System.Windows.Forms.TextBox)sender);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllTB();
            tBx_spieler3.Text = Program.spieler.GetUsername();
            tBx_spieler3.ReadOnly = true;
            tBx_spieler3.BackColor = Color.Gray;
        }

        private void rB_spieler1_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllTB();
            tBx_spieler1.Text = Program.spieler.GetUsername();
            tBx_spieler1.ReadOnly = true;
            tBx_spieler1.BackColor = Color.Gray;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numUpDown_anzahlSpieler_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < numUpDown_anzahlSpieler.Value; i++)
            {
                lblArraySpieler[i].Visible = true;
                tBArraySpieler[i].Visible = true;
                rBArraySpieler[i].Visible = true;
            }
            for (int i = (int)(numUpDown_anzahlSpieler.Value); i < 8; i++)
            {
                lblArraySpieler[i].Visible = false;
                tBArraySpieler[i].Visible = false;
                rBArraySpieler[i].Visible = false;
            }
            if (WhereChecked() >= numUpDown_anzahlSpieler.Value)
            {
                rB_spieler1.Checked = true;
            }
        }

        private void btn_newSpieler_Click(object sender, EventArgs e)
        {
            new AddSpielerView().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.frmGameOptions.Hide();
            Program.frmMainMenu.Show();
        }

        private void btn_starten_Click(object sender, EventArgs e)
        {
            if (IsUserValid())
            {
                Program.frmGameOptions.Hide();
                Program.spielAktuell = new Spiel(CreateSpielerDic(), (int)numUpDown_saetze.Value, (int)numUpDown_legs.Value, int.Parse(comB_rest.Text));
                //Dart.AddSpiel(Program.spielAktuell);
                Program.spielAktuell.AddSet();
                Program.spielAktuell.AddLeg();
                Program.spielAktuell.AddDurchgangSpielerAktuell();
                Program.frmSpielView = new SpielView();
                Program.frmSpielView.Show();
            }
            else
            {
                MessageBox.Show("Ungültiger Username.");
            }
               
        }

        private bool IsUserValid()
        {
            for (int i = 0; i < (int)(numUpDown_anzahlSpieler.Value); i++)
            {
                if (!Dart.IsSpielerVorhanden(tBArraySpieler[i].Text))
                {
                    tBArraySpieler[i].BackColor = Color.Red;
                    return false;
                }
            }
            return true;
        }

        private bool IsUserValid(System.Windows.Forms.TextBox tBx)
        {
            if (!Dart.IsSpielerVorhanden(tBx.Text))
            {
                tBx.BackColor = Color.Red;
                return false;
            }
            else
            {
                tBx.BackColor = Color.Green;
            }
            return true;
        }

        private Dictionary<String, Spieler> CreateSpielerDic()
        {
            Dictionary<String, Spieler> spieler = new Dictionary<string, Spieler>();
            for (int i = 0; i < (int)(numUpDown_anzahlSpieler.Value); i++)
            {
                Spieler s = Dart.GetSpieler(tBArraySpieler[i].Text);
                spieler.Add(s.GetUsername(), s);
            }
            return spieler;
        }

        private void tBx_spieler1_TextChanged(object sender, EventArgs e)
        {
            IsUserValid((System.Windows.Forms.TextBox)sender);
        }
    }
}
