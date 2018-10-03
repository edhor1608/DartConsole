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

        public bool GetVisibleWurf1()
        {
            return Program.frmWurfView.cB_zielWurf1.Visible & Program.frmWurfView.lbl_wurf1.Visible & Program.frmWurfView.tB_wurf1.Visible;
        }

        public bool GetVisibleWurf2()
        {
            return Program.frmWurfView.cB_zielWurf2.Visible & Program.frmWurfView.lbl_wurf2.Visible & Program.frmWurfView.tB_wurf2.Visible;
        }

        public bool GetVisibleWurf3()
        {
            return Program.frmWurfView.cB_zielWurf3.Visible & Program.frmWurfView.lbl_wurf3.Visible & Program.frmWurfView.tB_wurf3.Visible;
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
            if (cB_zielWurf1.Visible)
            {
                Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[0].SetMultiZiel(GetWurfOfCB(cB_zielWurf1.SelectedIndex)[0]);
                Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[0].SetWertZiel(GetWurfOfCB(cB_zielWurf1.SelectedIndex)[1]);
            }
            if (cB_zielWurf2.Visible)
            {
                Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[1].SetMultiZiel(GetWurfOfCB(cB_zielWurf2.SelectedIndex)[0]);
                Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[1].SetWertZiel(GetWurfOfCB(cB_zielWurf2.SelectedIndex)[1]);
            }
            if (cB_zielWurf3.Visible)
            {
                Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[2].SetMultiZiel(GetWurfOfCB(cB_zielWurf3.SelectedIndex)[0]);
                Program.spielAktuell.GetSetAktuell(Program.spielAktuell.GetSpielerAktuell()).GetAktuellLeg().GetDurchgangAktuell().GetWürfe()[2].SetWertZiel(GetWurfOfCB(cB_zielWurf3.SelectedIndex)[1]);
            }
            Program.frmSpielView.Show();
            this.Hide();
            Program.frmSpielView.Uebernehmen();
        }

        private int[] GetWurfOfCB(int i)
        {
            int[] wurf = new int[2];
            wurf[1] = 20 - (i % 20);
            if (i >= 0 && i <= 19)
            {
                wurf[0] = 3;
                return wurf;
            }
            else if (i >= 20 && i <= 39)
            {
                wurf[0] = 2;
                return wurf;
            }
            else if (i >= 40 && i <= 59)
            {
                wurf[0] = 1;
                return wurf;
            }
            else if (i == 60)
            {
                wurf[0] = 2;
                wurf[1] = 50;
                return wurf;
            }
            else
            {
                wurf[0] = 1;
                wurf[1] = 50;
                return wurf;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.frmSpielView.Show();
            this.Hide();
            Program.frmSpielView.Loeschen();
        }

        public void SetLocation(int x, int y)
        {
            Location = new Point(x, y);
        }
    }
}
