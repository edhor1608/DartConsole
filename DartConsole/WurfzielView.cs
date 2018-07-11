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
    public partial class WurfzielView : Form
    {
        public WurfzielView()
        {
            InitializeComponent();
        }

        public void SetVisibleWurf1(bool v)
        {
            Program.frmWurfView.cB_zielWurf1.Visible = v;
            Program.frmWurfView.lbl_wurf1.Visible = v;
            Program.frmWurfView.tB_wurf1.Visible = v;
            if (!v)
            {
                Program.frmWurfView.cB_zielWurf1.SelectedIndex = 0;
            }
        }

        public void SetVisibleWurf2(bool v)
        {
            Program.frmWurfView.cB_zielWurf2.Visible = v;
            Program.frmWurfView.lbl_wurf2.Visible = v;
            Program.frmWurfView.tB_wurf2.Visible = v;
            if (!v)
            {
                Program.frmWurfView.cB_zielWurf2.SelectedIndex = 0;
            }
        }

        public void SetVisibleWurf3(bool v)
        {
            Program.frmWurfView.cB_zielWurf3.Visible = v;
            Program.frmWurfView.lbl_wurf3.Visible = v;
            Program.frmWurfView.tB_wurf3.Visible = v;
            if (!v)
            {
                Program.frmWurfView.cB_zielWurf3.SelectedIndex = 0;
            }
        }

        public void SetGeworfenWurf1(int multi, int wert)
        {
            if (wert == 50)
            {
                if (multi == 1)
                {
                    tB_wurf1.Text = "SBull";
                }
                else
                {
                    tB_wurf1.Text = "DBull";
                }
            }
            else
            {
                tB_wurf1.Text = multi + "x" + wert;
            }
        }

        public void SetGeworfenWurf2(int multi, int wert)
        {
            if (wert == 50)
            {
                if (multi == 1)
                {
                    tB_wurf2.Text = "SBull";
                }
                else
                {
                    tB_wurf2.Text = "DBull";
                }
            }
            else
            {
                tB_wurf2.Text = multi + "x" + wert;
            }
        }

        public void SetGeworfenWurf3(int multi, int wert)
        {
            if (wert == 50)
            {
                if (multi == 1)
                {
                    tB_wurf3.Text = "SBull";
                }
                else
                {
                    tB_wurf3.Text = "DBull";
                }
            }
            else
            {
                tB_wurf3.Text = multi + "x" + wert;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.frmSpielView.Show();
            this.Hide();
            Program.frmSpielView.Uebernehmen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.frmSpielView.Show();
            this.Hide();
            Program.frmSpielView.Loeschen();
        }

        public void SetLocation(int x, int y)
        {
            Location = new Point(x,y);
        }
    }
}
