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
    public partial class SpielView : Form
    {
        public SpielView()
        {
            InitializeComponent();
            FillFormsInArrays();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SpielView_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.spielAktuell.GetSpieler().Count; i++)
            {
                lblArraySpieler[i].Text = Program.spielAktuell.GetSpieler().ElementAt(i).Value.GetUsername();
            }
            for (int i = Program.spielAktuell.GetSpieler().Count; i < 8;i++)
            {
                lblArraySpieler[i].Visible = false;
                lblArraySets[i].Visible = false;
                lblArrayLegs[i].Visible = false;
                lblArrayRest[i].Visible = false;
                lblArrayPfeil[i].Visible = false;
                lblArrayCheck[i].Visible = false;
            }
        }
    }
}
