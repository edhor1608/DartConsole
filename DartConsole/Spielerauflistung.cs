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
    public partial class Spielerauflistung : Form
    {
        public Spielerauflistung()
        {
            InitializeComponent();

            //Dart.Init();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            GetSpielerFromDBIntoUI();
        }

        /// <summary>
        /// öffnet PhpMyAdminView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phpMyAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PhpMyAdminView().Show();
        }

        /// <summary>
        /// öffnet InfoView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InfoDartConsoleView().Show();
        }

        private void lBx_Spieler_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < lBx_Spieler.Items.Count; i++)
            {
                if (lBx_Spieler.GetSelected(i))
                {
                    new SpielerInformationView(lBx_Spieler.Items[i].ToString()).Show();
                }
            }
        }

        private void Spieler_hinzufuegen(object sender, EventArgs e)
        {
            new AddSpielerView().ShowDialog();

            lBx_Spieler.Items.Clear();

            GetSpielerFromDBIntoUI();

        }

        private void GetSpielerFromDBIntoUI()
        {
            foreach (var spieler in Dart.GetSpielerFromDB())
            {
                lBx_Spieler.Items.Add(spieler.Key);
            }
        }

        private void btn_zurück_Click(object sender, EventArgs e)
        {
            Program.frmMainView.Hide();
            Program.frmStartingScreen.Show();
        }
    }
}
