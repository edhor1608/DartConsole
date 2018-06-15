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
    public partial class SelectDateDialog : Form
    {
        //Property Geburtsdatum
        public DateTime _Geburtsdatum;
        public DateTime Geburtsdatum
        {
            get { return _Geburtsdatum; }

            set { _Geburtsdatum = value; }
        }


        public SelectDateDialog(string title = "Geburtsdatum")
        {
            InitializeComponent();

            //Auswahl des DateTimePickers auf das aktuelle Datum setzen
            dTimeP_Geburtsdatum_Waehlen.Value = DateTime.Now;

            this.Text = title;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Geburtsdatum = dTimeP_Geburtsdatum_Waehlen.Value;

            this.Close();
        }

        
    }
}
