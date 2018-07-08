using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DartConsole
{
    public partial class StatistikView : Form
    {
        Spiel spiel;
        Set set;
        Leg leg;

        public StatistikView()
        {
            InitializeComponent();
        }

        private void StatistikView_Load(object sender, EventArgs e)
        {
            cB_setAuswahl.Visible = false;
            cB_legAuswahl.Visible = false;
            List<Spiel> spiele = Dart.SearchSpielePlayedBy(Program.spieler);
            for (int i = spiele.Count - 1; i >= 0; i--)
            {
                cB_spielAuswahl.Items.Add(spiele.ElementAt(i).GetDatum());
            }
        }

        private void cB_spielAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            spiel = Dart.SearchSpielePlayedBy(Program.spieler).ElementAt((Dart.SearchSpielePlayedBy(Program.spieler).Count - 1) - cB_spielAuswahl.SelectedIndex);
            cB_setAuswahl.Visible = true;
            cB_legAuswahl.Visible = false;
            cB_setAuswahl.Items.Clear();
            List<Set> sets = spiel.GetSetsPlayer(Program.spieler);
            for (int i = 1; i <= sets.Count; i++)
            {
                cB_setAuswahl.Items.Add("Set " + i);
            }
        }

        private void cB_setAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            set = spiel.GetSetsPlayer(Program.spieler).ElementAt(cB_setAuswahl.SelectedIndex);
            cB_legAuswahl.Visible = true;
            cB_legAuswahl.Items.Clear();
            List<Leg> legs = set.GetLegs();
            for (int i = 1; i <= legs.Count; i++)
            {
                cB_legAuswahl.Items.Add("Leg " + i);
            }
        }

        private void cB_legAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            leg = set.GetLegs().ElementAt(cB_legAuswahl.SelectedIndex);
        }
    }
}
