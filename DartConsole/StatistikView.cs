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
            AllgemeineStatistikAktualisieren();
        }

        private void AllgemeineStatistikAktualisieren()
        {
            lblQuoteInsgesamtWertIns.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 0, 0)[0])) / ((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 0, 0)[1]))) * 100, 2) + "%";
            lblQuoteInsgesamtWertEinzel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 1, 0)[0])) / ((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 1, 0)[1]))) * 100, 2) + "%";
            lblQuoteInsgesamtWertDoppel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 2, 0)[0])) / ((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 2, 0)[1]))) * 100, 2) + "%";
            lblQuoteInsgesamtWertTriple.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 3, 0)[0])) / ((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 3, 0)[1]))) * 100, 2) + "%";

            lblQuoteNoFinishWertIns.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 0, 1)[0])) / ((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 0, 1)[1]))) * 100, 2) + "%";
            lblQuoteNoFinishWertEinzel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 1, 1)[0])) / ((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 1, 1)[1]))) * 100, 2) + "%";
            lblQuoteNoFinishWertDoppel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 2, 1)[0])) / ((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 2, 1)[1]))) * 100, 2) + "%";
            lblQuoteNoFinishWertTriple.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 3, 1)[0])) / ((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 3, 1)[1]))) * 100, 2) + "%";

            lblQuoteFinishWertIns.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 0, 2)[0])) / ((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 0, 2)[1]))) * 100, 2) + "%";
            lblQuoteFinishWertEinzel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 1, 2)[0])) / ((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 1, 2)[1]))) * 100, 2) + "%";
            lblQuoteFinishWertDoppel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 2, 2)[0])) / ((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 2, 2)[1]))) * 100, 2) + "%";
            lblQuoteFinishWertTriple.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 3, 2)[0])) / ((double)(Statistik.GetTrefferquoteGesamt(Program.spieler, 3, 2)[1]))) * 100, 2) + "%";
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
                lblQuoteAuswahlInsWertIns.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 0, 0)[0])) / ((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 0, 0)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlInsWertEinzel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 1, 0)[0])) / ((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 1, 0)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlInsWertDoppel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 2, 0)[0])) / ((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 2, 0)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlInsWertTriple.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 3, 0)[0])) / ((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 3, 0)[1]))) * 100, 2) + "%";

                lblQuoteAuswahlNoFinishWertIns.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 0, 1)[0])) / ((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 0, 1)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlNoFinishWertEinzel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 1, 1)[0])) / ((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 1, 1)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlNoFinishWertDoppel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 2, 1)[0])) / ((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 2, 1)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlNoFinishWertTriple.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 3, 1)[0])) / ((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 3, 1)[1]))) * 100, 2) + "%";

                lblQuoteAuswahlFinishWertIns.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 0, 2)[0])) / ((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 0, 2)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlFinishWertEinzel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 1, 2)[0])) / ((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 1, 2)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlFinishWertDoppel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 2, 2)[0])) / ((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 2, 2)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlFinishWertTriple.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 3, 2)[0])) / ((double)(Statistik.GetTrefferquoteSpiel(spiel, Program.spieler, 3, 2)[1]))) * 100, 2) + "%";
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
                lblQuoteAuswahlInsWertIns.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSet(set, 0, 0)[0])) / ((double)(Statistik.GetTrefferquoteSet(set, 0, 0)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlInsWertEinzel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSet(set, 1, 0)[0])) / ((double)(Statistik.GetTrefferquoteSet(set, 1, 0)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlInsWertDoppel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSet(set, 2, 0)[0])) / ((double)(Statistik.GetTrefferquoteSet(set, 2, 0)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlInsWertTriple.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSet(set, 3, 0)[0])) / ((double)(Statistik.GetTrefferquoteSet(set, 3, 0)[1]))) * 100, 2) + "%";

                lblQuoteAuswahlNoFinishWertIns.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSet(set, 0, 1)[0])) / ((double)(Statistik.GetTrefferquoteSet(set, 0, 1)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlNoFinishWertEinzel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSet(set, 1, 1)[0])) / ((double)(Statistik.GetTrefferquoteSet(set, 1, 1)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlNoFinishWertDoppel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSet(set, 2, 1)[0])) / ((double)(Statistik.GetTrefferquoteSet(set, 2, 1)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlNoFinishWertTriple.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSet(set, 3, 1)[0])) / ((double)(Statistik.GetTrefferquoteSet(set, 3, 1)[1]))) * 100, 2) + "%";

                lblQuoteAuswahlFinishWertIns.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSet(set, 0, 2)[0])) / ((double)(Statistik.GetTrefferquoteSet(set, 0, 2)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlFinishWertEinzel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSet(set, 1, 2)[0])) / ((double)(Statistik.GetTrefferquoteSet(set, 1, 2)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlFinishWertDoppel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSet(set, 2, 2)[0])) / ((double)(Statistik.GetTrefferquoteSet(set, 2, 2)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlFinishWertTriple.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteSet(set, 3, 2)[0])) / ((double)(Statistik.GetTrefferquoteSet(set, 3, 2)[1]))) * 100, 2) + "%";
            }
            if (cB_legAuswahl.SelectedIndex > 0)
            {
                leg = set.GetLegs().ElementAt(cB_legAuswahl.SelectedIndex - 1);
                rtbInfos.Text += Show_Leg(leg);
                lblQuoteAuswahlInsWertIns.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteLeg(leg, 0, 0)[0])) / ((double)(Statistik.GetTrefferquoteLeg(leg, 0, 0)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlInsWertEinzel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteLeg(leg, 1, 0)[0])) / ((double)(Statistik.GetTrefferquoteLeg(leg, 1, 0)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlInsWertDoppel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteLeg(leg, 2, 0)[0])) / ((double)(Statistik.GetTrefferquoteLeg(leg, 2, 0)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlInsWertTriple.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteLeg(leg, 3, 0)[0])) / ((double)(Statistik.GetTrefferquoteLeg(leg, 3, 0)[1]))) * 100, 2) + "%";

                lblQuoteAuswahlNoFinishWertIns.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteLeg(leg, 0, 1)[0])) / ((double)(Statistik.GetTrefferquoteLeg(leg, 0, 1)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlNoFinishWertEinzel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteLeg(leg, 1, 1)[0])) / ((double)(Statistik.GetTrefferquoteLeg(leg, 1, 1)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlNoFinishWertDoppel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteLeg(leg, 2, 1)[0])) / ((double)(Statistik.GetTrefferquoteLeg(leg, 2, 1)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlNoFinishWertTriple.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteLeg(leg, 3, 1)[0])) / ((double)(Statistik.GetTrefferquoteLeg(leg, 3, 1)[1]))) * 100, 2) + "%";

                lblQuoteAuswahlFinishWertIns.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteLeg(leg, 0, 2)[0])) / ((double)(Statistik.GetTrefferquoteLeg(leg, 0, 2)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlFinishWertEinzel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteLeg(leg, 1, 2)[0])) / ((double)(Statistik.GetTrefferquoteLeg(leg, 1, 2)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlFinishWertDoppel.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteLeg(leg, 2, 2)[0])) / ((double)(Statistik.GetTrefferquoteLeg(leg, 2, 2)[1]))) * 100, 2) + "%";
                lblQuoteAuswahlFinishWertTriple.Text = "" + Statistik.RoundDouble((((double)(Statistik.GetTrefferquoteLeg(leg, 3, 2)[0])) / ((double)(Statistik.GetTrefferquoteLeg(leg, 3, 2)[1]))) * 100, 2) + "%";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tP_Allgemein_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllgemeineStatistikAktualisieren();
        }

        private void tP_Spiel_Click(object sender, EventArgs e)
        {

        }
    }
}
