﻿using System;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Beenden_Click(object sender, EventArgs e)
        {
            Program.spieler = null;
            Program.frmMainMenu.Hide();
            Program.frmStartingScreen.Show();
        }
    }
}