using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DartConsole
{
    public partial class StatistikView : Form
    {
        Spiel spiel;
        List<Set> sets;
        List<Leg> legs;
        Set set;
        Leg leg;

        public StatistikView()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            cB_setAuswahl.Visible = false;
            cB_legAuswahl.Visible = false;
            cB_spielAuswahl.Items.Clear();
            cB_spielAuswahl.SelectedIndex = -1;
            cB_spielAuswahl.Text = "Spiel auswählen";
            List<Spiel> spiele = Dart.SearchSpielePlayedBy(Program.spieler);

            for (int i = spiele.Count - 1; i >= 0; i--)
            {
                cB_spielAuswahl.Items.Add(spiele.ElementAt(i).GetDatum());
            }
            rtbInfos.Text = "";
        }

        private void StatistikView_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void cB_spielAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_spielAuswahl.SelectedIndex == -1)
            {
                return;
            }
            spiel = Dart.SearchSpielePlayedBy(Program.spieler).ElementAt((Dart.SearchSpielePlayedBy(Program.spieler).Count - 1) - cB_spielAuswahl.SelectedIndex);
            cB_setAuswahl.Visible = true;
            cB_setAuswahl.SelectedIndex = -1;
            cB_setAuswahl.Text = "Set auswählen";
            cB_setAuswahl.Items.Clear();
            sets = spiel.GetSetsPlayer(Program.spieler);
            cB_setAuswahl.Items.Add("Alle");

            for (int i = 1; i <= sets.Count; i++)
            {
                cB_setAuswahl.Items.Add("Set " + i);
            }
            cB_legAuswahl.Visible = false;
        }

        private void cB_setAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_setAuswahl.SelectedIndex == -1)
            {
                return;
            }
            cB_legAuswahl.Visible = true;
            cB_legAuswahl.SelectedIndex = -1;
            cB_legAuswahl.Text = "Leg auswählen";
            cB_legAuswahl.Items.Clear();
            cB_legAuswahl.Items.Add("Alle");

            if (cB_setAuswahl.SelectedIndex == 0)
            {
                cB_legAuswahl.SelectedIndex = 0;
                rtbInfos.Text += Show_Spiel();
            }
            else
            {
                set = spiel.GetSetsPlayer(Program.spieler).ElementAt(cB_setAuswahl.SelectedIndex - 1);
                legs = set.GetLegs();
                for (int i = 1; i <= legs.Count; i++)
                {
                    cB_legAuswahl.Items.Add("Leg " + i);
                }
            }
        }

        private void cB_legAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbInfos.Text = "";
            if (cB_legAuswahl.SelectedIndex == -1)
            {
                return;
            }
            if(cB_legAuswahl.SelectedIndex == 0 && cB_setAuswahl.SelectedIndex > 0)
            {
                rtbInfos.Text += Show_Set(set);
            }
            if (cB_legAuswahl.SelectedIndex > 0)
            {
                leg = set.GetLegs().ElementAt(cB_legAuswahl.SelectedIndex - 1);
                rtbInfos.Text += Show_Leg(leg);
            }
        }

        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            Program.frmMainMenu.Show();
            Program.frmStatistikView.Hide();
        }

        private String Show_Leg(Leg l)
        {
            String s = "";
            List<Durchgang> durchgaenge = l.GetDurchgänge();
            for (int i = 0; i < durchgaenge.Count; i++)
            {
                s += "\n\t\tDurchgang "+(i+1);
                Wurf[] wuerfe = durchgaenge.ElementAt(i).GetWürfe();
                for (int j = 0; j < durchgaenge.ElementAt(i).GetAnzahlWürfe(); j++)
                {
                    s += "\n\t\t\t"+wuerfe[j].GetMulti() + "x" + wuerfe[j].GetWert();
                }
            }
            return s;
        }

        private String Show_Set(Set s)
        {
            String st = "";
            List<Leg> legs = s.GetLegs();
            for (int i = 0;i<legs.Count;i++)
            {
                st += "\n\tLeg " + (i + 1);
                st +=Show_Leg(legs.ElementAt(i));
            }
            return st;
        }

        private string Show_Spiel()
        {
            String s = "";
            List<Set> sets = spiel.GetSetsPlayer(Program.spieler);
            for (int i = 0;i<sets.Count;i++)
            {
                s += "\nSet " + (i + 1);
                s += Show_Set(sets.ElementAt(i));
            }
            return s;
        }
    }
}
