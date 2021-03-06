﻿namespace DartConsole
{
    partial class SpielView
    {
        System.Windows.Forms.Label[] lblArraySpieler = new System.Windows.Forms.Label[8];
        System.Windows.Forms.Label[] lblArraySets = new System.Windows.Forms.Label[8];
        System.Windows.Forms.Label[] lblArrayLegs = new System.Windows.Forms.Label[8];
        System.Windows.Forms.Label[] lblArrayRest = new System.Windows.Forms.Label[8];
        System.Windows.Forms.Label[] lblArrayPfeil = new System.Windows.Forms.Label[8];
        System.Windows.Forms.Label[] lblArrayCheck = new System.Windows.Forms.Label[8];
        System.Windows.Forms.Label[] lblArrayAVG = new System.Windows.Forms.Label[8];
        System.Windows.Forms.Label[] lblArrayDQ = new System.Windows.Forms.Label[8];

        System.Windows.Forms.Button[] btnArrayWurf1Wert = new System.Windows.Forms.Button[20];
        System.Windows.Forms.Button[] btnArrayWurf2Wert = new System.Windows.Forms.Button[20];
        System.Windows.Forms.Button[] btnArrayWurf3Wert = new System.Windows.Forms.Button[20];

        System.Windows.Forms.Button[][] btnArrayWert = new System.Windows.Forms.Button[3][];

        System.Windows.Forms.Button[] btnArrayWurf1Multi = new System.Windows.Forms.Button[6];
        System.Windows.Forms.Button[] btnArrayWurf2Multi = new System.Windows.Forms.Button[6];
        System.Windows.Forms.Button[] btnArrayWurf3Multi = new System.Windows.Forms.Button[6];

        System.Windows.Forms.Button[][] btnArrayMulti = new System.Windows.Forms.Button[3][];

        private void FillFormsInArrays()
        {
            lblArraySpieler[0] = lbl_nameSpieler1;
            lblArraySpieler[1] = lbl_nameSpieler2;
            lblArraySpieler[2] = lbl_nameSpieler3;
            lblArraySpieler[3] = lbl_nameSpieler4;
            lblArraySpieler[4] = lbl_nameSpieler5;
            lblArraySpieler[5] = lbl_nameSpieler6;
            lblArraySpieler[6] = lbl_nameSpieler7;
            lblArraySpieler[7] = lbl_nameSpieler8;

            lblArraySets[0] = lbl_setSpieler1;
            lblArraySets[1] = lbl_setSpieler2;
            lblArraySets[2] = lbl_setSpieler3;
            lblArraySets[3] = lbl_setSpieler4;
            lblArraySets[4] = lbl_setSpieler5;
            lblArraySets[5] = lbl_setSpieler6;
            lblArraySets[6] = lbl_setSpieler7;
            lblArraySets[7] = lbl_setSpieler8;

            lblArrayLegs[0] = lbl_legSpieler1;
            lblArrayLegs[1] = lbl_legSpieler2;
            lblArrayLegs[2] = lbl_legSpieler3;
            lblArrayLegs[3] = lbl_legSpieler4;
            lblArrayLegs[4] = lbl_legSpieler5;
            lblArrayLegs[5] = lbl_legSpieler6;
            lblArrayLegs[6] = lbl_legSpieler7;
            lblArrayLegs[7] = lbl_legSpieler8;

            lblArrayRest[0] = lbl_restSpieler1;
            lblArrayRest[1] = lbl_restSpieler2;
            lblArrayRest[2] = lbl_restSpieler3;
            lblArrayRest[3] = lbl_restSpieler4;
            lblArrayRest[4] = lbl_restSpieler5;
            lblArrayRest[5] = lbl_restSpieler6;
            lblArrayRest[6] = lbl_restSpieler7;
            lblArrayRest[7] = lbl_restSpieler8;

            lblArrayPfeil[0] = lbl_pfeilSpieler1;
            lblArrayPfeil[1] = lbl_pfeilSpieler2;
            lblArrayPfeil[2] = lbl_pfeilSpieler3;
            lblArrayPfeil[3] = lbl_pfeilSpieler4;
            lblArrayPfeil[4] = lbl_pfeilSpieler5;
            lblArrayPfeil[5] = lbl_pfeilSpieler6;
            lblArrayPfeil[6] = lbl_pfeilSpieler7;
            lblArrayPfeil[7] = lbl_pfeilSpieler8;

            lblArrayCheck[0] = lbl_checkSpieler1;
            lblArrayCheck[1] = lbl_checkSpieler2;
            lblArrayCheck[2] = lbl_checkSpieler3;
            lblArrayCheck[3] = lbl_checkSpieler4;
            lblArrayCheck[4] = lbl_checkSpieler5;
            lblArrayCheck[5] = lbl_checkSpieler6;
            lblArrayCheck[6] = lbl_checkSpieler7;
            lblArrayCheck[7] = lbl_checkSpieler8;

            lblArrayAVG[0] = lbl_avgSpieler1;
            lblArrayAVG[1] = lbl_avgSpieler2;
            lblArrayAVG[2] = lbl_avgSpieler3;
            lblArrayAVG[3] = lbl_avgSpieler4;
            lblArrayAVG[4] = lbl_avgSpieler5;
            lblArrayAVG[5] = lbl_avgSpieler6;
            lblArrayAVG[6] = lbl_avgSpieler7;
            lblArrayAVG[7] = lbl_avgSpieler8;

            lblArrayDQ[0] = lbl_dqSpieler1;
            lblArrayDQ[1] = lbl_dqSpieler2;
            lblArrayDQ[2] = lbl_dqSpieler3;
            lblArrayDQ[3] = lbl_dqSpieler4;
            lblArrayDQ[4] = lbl_dqSpieler5;
            lblArrayDQ[5] = lbl_dqSpieler6;
            lblArrayDQ[6] = lbl_dqSpieler7;
            lblArrayDQ[7] = lbl_dqSpieler8;

            btnArrayWurf1Wert[0] = btn_wurf1_1;
            btnArrayWurf1Wert[1] = btn_wurf1_2;
            btnArrayWurf1Wert[2] = btn_wurf1_3;
            btnArrayWurf1Wert[3] = btn_wurf1_4;
            btnArrayWurf1Wert[4] = btn_wurf1_5;
            btnArrayWurf1Wert[5] = btn_wurf1_6;
            btnArrayWurf1Wert[6] = btn_wurf1_7;
            btnArrayWurf1Wert[7] = btn_wurf1_8;
            btnArrayWurf1Wert[8] = btn_wurf1_9;
            btnArrayWurf1Wert[9] = btn_wurf1_10;
            btnArrayWurf1Wert[10] = btn_wurf1_11;
            btnArrayWurf1Wert[11] = btn_wurf1_12;
            btnArrayWurf1Wert[12] = btn_wurf1_13;
            btnArrayWurf1Wert[13] = btn_wurf1_14;
            btnArrayWurf1Wert[14] = btn_wurf1_15;
            btnArrayWurf1Wert[15] = btn_wurf1_16;
            btnArrayWurf1Wert[16] = btn_wurf1_17;
            btnArrayWurf1Wert[17] = btn_wurf1_18;
            btnArrayWurf1Wert[18] = btn_wurf1_19;
            btnArrayWurf1Wert[19] = btn_wurf1_20;

            btnArrayWurf2Wert[0] = btn_wurf2_1;
            btnArrayWurf2Wert[1] = btn_wurf2_2;
            btnArrayWurf2Wert[2] = btn_wurf2_3;
            btnArrayWurf2Wert[3] = btn_wurf2_4;
            btnArrayWurf2Wert[4] = btn_wurf2_5;
            btnArrayWurf2Wert[5] = btn_wurf2_6;
            btnArrayWurf2Wert[6] = btn_wurf2_7;
            btnArrayWurf2Wert[7] = btn_wurf2_8;
            btnArrayWurf2Wert[8] = btn_wurf2_9;
            btnArrayWurf2Wert[9] = btn_wurf2_10;
            btnArrayWurf2Wert[10] = btn_wurf2_11;
            btnArrayWurf2Wert[11] = btn_wurf2_12;
            btnArrayWurf2Wert[12] = btn_wurf2_13;
            btnArrayWurf2Wert[13] = btn_wurf2_14;
            btnArrayWurf2Wert[14] = btn_wurf2_15;
            btnArrayWurf2Wert[15] = btn_wurf2_16;
            btnArrayWurf2Wert[16] = btn_wurf2_17;
            btnArrayWurf2Wert[17] = btn_wurf2_18;
            btnArrayWurf2Wert[18] = btn_wurf2_19;
            btnArrayWurf2Wert[19] = btn_wurf2_20;

            btnArrayWurf3Wert[0] = btn_wurf3_1;
            btnArrayWurf3Wert[1] = btn_wurf3_2;
            btnArrayWurf3Wert[2] = btn_wurf3_3;
            btnArrayWurf3Wert[3] = btn_wurf3_4;
            btnArrayWurf3Wert[4] = btn_wurf3_5;
            btnArrayWurf3Wert[5] = btn_wurf3_6;
            btnArrayWurf3Wert[6] = btn_wurf3_7;
            btnArrayWurf3Wert[7] = btn_wurf3_8;
            btnArrayWurf3Wert[8] = btn_wurf3_9;
            btnArrayWurf3Wert[9] = btn_wurf3_10;
            btnArrayWurf3Wert[10] = btn_wurf3_11;
            btnArrayWurf3Wert[11] = btn_wurf3_12;
            btnArrayWurf3Wert[12] = btn_wurf3_13;
            btnArrayWurf3Wert[13] = btn_wurf3_14;
            btnArrayWurf3Wert[14] = btn_wurf3_15;
            btnArrayWurf3Wert[15] = btn_wurf3_16;
            btnArrayWurf3Wert[16] = btn_wurf3_17;
            btnArrayWurf3Wert[17] = btn_wurf3_18;
            btnArrayWurf3Wert[18] = btn_wurf3_19;
            btnArrayWurf3Wert[19] = btn_wurf3_20;

            btnArrayWurf1Multi[0] = btn_einmalWurf1;
            btnArrayWurf1Multi[1] = btn_zweimalWurf1;
            btnArrayWurf1Multi[2] = btn_dreimalWurf1;
            btnArrayWurf1Multi[3] = btn_bullWurf1;
            btnArrayWurf1Multi[4] = btn_doubleBullWurf1;
            btnArrayWurf1Multi[5] = btn_nullWurf1;

            btnArrayWurf2Multi[0] = btn_einmalWurf2;
            btnArrayWurf2Multi[1] = btn_zweimalWurf2;
            btnArrayWurf2Multi[2] = btn_dreimalWurf2;
            btnArrayWurf2Multi[3] = btn_bullWurf2;
            btnArrayWurf2Multi[4] = btn_doubleBullWurf2;
            btnArrayWurf2Multi[5] = btn_nullWurf2;

            btnArrayWurf3Multi[0] = btn_einmalWurf3;
            btnArrayWurf3Multi[1] = btn_zweimalWurf3;
            btnArrayWurf3Multi[2] = btn_dreimalWurf3;
            btnArrayWurf3Multi[3] = btn_bullWurf3;
            btnArrayWurf3Multi[4] = btn_doubleBullWurf3;
            btnArrayWurf3Multi[5] = btn_nullWurf3;

            btnArrayWert[0] = btnArrayWurf1Wert;
            btnArrayWert[1] = btnArrayWurf2Wert;
            btnArrayWert[2] = btnArrayWurf3Wert;

            btnArrayMulti[0] = btnArrayWurf1Multi;
            btnArrayMulti[1] = btnArrayWurf2Multi;
            btnArrayMulti[2] = btnArrayWurf3Multi;
        }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox groupBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpielView));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btn_weiter = new System.Windows.Forms.Button();
            this.btn_beenden = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_set = new System.Windows.Forms.Label();
            this.lbl_leg = new System.Windows.Forms.Label();
            this.lbl_rest = new System.Windows.Forms.Label();
            this.lbl_nameSpieler1 = new System.Windows.Forms.Label();
            this.lbl_nameSpieler2 = new System.Windows.Forms.Label();
            this.lbl_nameSpieler3 = new System.Windows.Forms.Label();
            this.lbl_nameSpieler4 = new System.Windows.Forms.Label();
            this.lbl_nameSpieler5 = new System.Windows.Forms.Label();
            this.lbl_nameSpieler6 = new System.Windows.Forms.Label();
            this.lbl_nameSpieler7 = new System.Windows.Forms.Label();
            this.lbl_nameSpieler8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_pfeilSpieler1 = new System.Windows.Forms.Label();
            this.lbl_pfeilSpieler2 = new System.Windows.Forms.Label();
            this.lbl_pfeilSpieler3 = new System.Windows.Forms.Label();
            this.lbl_pfeilSpieler4 = new System.Windows.Forms.Label();
            this.lbl_pfeilSpieler5 = new System.Windows.Forms.Label();
            this.lbl_pfeilSpieler6 = new System.Windows.Forms.Label();
            this.lbl_pfeilSpieler7 = new System.Windows.Forms.Label();
            this.lbl_pfeilSpieler8 = new System.Windows.Forms.Label();
            this.lbl_setSpieler1 = new System.Windows.Forms.Label();
            this.lbl_legSpieler1 = new System.Windows.Forms.Label();
            this.lbl_restSpieler1 = new System.Windows.Forms.Label();
            this.lbl_setSpieler2 = new System.Windows.Forms.Label();
            this.lbl_legSpieler2 = new System.Windows.Forms.Label();
            this.lbl_restSpieler2 = new System.Windows.Forms.Label();
            this.lbl_setSpieler3 = new System.Windows.Forms.Label();
            this.lbl_legSpieler3 = new System.Windows.Forms.Label();
            this.lbl_restSpieler3 = new System.Windows.Forms.Label();
            this.lbl_setSpieler4 = new System.Windows.Forms.Label();
            this.lbl_legSpieler4 = new System.Windows.Forms.Label();
            this.lbl_restSpieler4 = new System.Windows.Forms.Label();
            this.lbl_setSpieler5 = new System.Windows.Forms.Label();
            this.lbl_legSpieler5 = new System.Windows.Forms.Label();
            this.lbl_restSpieler5 = new System.Windows.Forms.Label();
            this.lbl_setSpieler6 = new System.Windows.Forms.Label();
            this.lbl_legSpieler6 = new System.Windows.Forms.Label();
            this.lbl_restSpieler6 = new System.Windows.Forms.Label();
            this.lbl_setSpieler7 = new System.Windows.Forms.Label();
            this.lbl_legSpieler7 = new System.Windows.Forms.Label();
            this.lbl_restSpieler7 = new System.Windows.Forms.Label();
            this.lbl_setSpieler8 = new System.Windows.Forms.Label();
            this.lbl_legSpieler8 = new System.Windows.Forms.Label();
            this.lbl_restSpieler8 = new System.Windows.Forms.Label();
            this.lbl_checkSpieler1 = new System.Windows.Forms.Label();
            this.lbl_checkSpieler2 = new System.Windows.Forms.Label();
            this.lbl_checkSpieler3 = new System.Windows.Forms.Label();
            this.lbl_checkSpieler4 = new System.Windows.Forms.Label();
            this.lbl_checkSpieler5 = new System.Windows.Forms.Label();
            this.lbl_checkSpieler6 = new System.Windows.Forms.Label();
            this.lbl_checkSpieler7 = new System.Windows.Forms.Label();
            this.lbl_checkSpieler8 = new System.Windows.Forms.Label();
            this.lbl_avgSpieler1 = new System.Windows.Forms.Label();
            this.lbl_avgSpieler2 = new System.Windows.Forms.Label();
            this.lbl_avgSpieler3 = new System.Windows.Forms.Label();
            this.lbl_avgSpieler4 = new System.Windows.Forms.Label();
            this.lbl_avgSpieler5 = new System.Windows.Forms.Label();
            this.lbl_avgSpieler6 = new System.Windows.Forms.Label();
            this.lbl_avgSpieler7 = new System.Windows.Forms.Label();
            this.lbl_avgSpieler8 = new System.Windows.Forms.Label();
            this.lbl_avg = new System.Windows.Forms.Label();
            this.lbl_dq = new System.Windows.Forms.Label();
            this.lbl_dqSpieler1 = new System.Windows.Forms.Label();
            this.lbl_dqSpieler2 = new System.Windows.Forms.Label();
            this.lbl_dqSpieler3 = new System.Windows.Forms.Label();
            this.lbl_dqSpieler4 = new System.Windows.Forms.Label();
            this.lbl_dqSpieler5 = new System.Windows.Forms.Label();
            this.lbl_dqSpieler6 = new System.Windows.Forms.Label();
            this.lbl_dqSpieler7 = new System.Windows.Forms.Label();
            this.lbl_dqSpieler8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEingabeStarten = new System.Windows.Forms.Button();
            this.lblSpracheWertW3 = new System.Windows.Forms.Label();
            this.lblSpracheMultiW1 = new System.Windows.Forms.Label();
            this.lblSpracheWertW2 = new System.Windows.Forms.Label();
            this.lblSpracheWertW1 = new System.Windows.Forms.Label();
            this.lblSpracheMultiW2 = new System.Windows.Forms.Label();
            this.lblSpracheMultiW3 = new System.Windows.Forms.Label();
            this.rbKlickEingabe = new System.Windows.Forms.RadioButton();
            this.rbSpracheingabe = new System.Windows.Forms.RadioButton();
            this.cB_zielWurf3 = new System.Windows.Forms.ComboBox();
            this.cB_zielWurf2 = new System.Windows.Forms.ComboBox();
            this.cB_zielWurf1 = new System.Windows.Forms.ComboBox();
            this.btn_loeschen = new System.Windows.Forms.Button();
            this.btn_uebernehmen = new System.Windows.Forms.Button();
            this.btn_nullWurf3 = new System.Windows.Forms.Button();
            this.btn_nullWurf2 = new System.Windows.Forms.Button();
            this.btn_nullWurf1 = new System.Windows.Forms.Button();
            this.lbl_wurf3 = new System.Windows.Forms.Label();
            this.lbl_wurf2 = new System.Windows.Forms.Label();
            this.lbl_wurf1 = new System.Windows.Forms.Label();
            this.btn_doubleBullWurf3 = new System.Windows.Forms.Button();
            this.btn_bullWurf3 = new System.Windows.Forms.Button();
            this.btn_dreimalWurf3 = new System.Windows.Forms.Button();
            this.btn_zweimalWurf3 = new System.Windows.Forms.Button();
            this.btn_einmalWurf3 = new System.Windows.Forms.Button();
            this.btn_wurf3_16 = new System.Windows.Forms.Button();
            this.btn_wurf3_20 = new System.Windows.Forms.Button();
            this.btn_wurf3_19 = new System.Windows.Forms.Button();
            this.btn_wurf3_18 = new System.Windows.Forms.Button();
            this.btn_wurf3_17 = new System.Windows.Forms.Button();
            this.btn_wurf3_11 = new System.Windows.Forms.Button();
            this.btn_wurf3_15 = new System.Windows.Forms.Button();
            this.btn_wurf3_14 = new System.Windows.Forms.Button();
            this.btn_wurf3_13 = new System.Windows.Forms.Button();
            this.btn_wurf3_12 = new System.Windows.Forms.Button();
            this.btn_wurf3_6 = new System.Windows.Forms.Button();
            this.btn_wurf3_10 = new System.Windows.Forms.Button();
            this.btn_wurf3_9 = new System.Windows.Forms.Button();
            this.btn_wurf3_8 = new System.Windows.Forms.Button();
            this.btn_wurf3_7 = new System.Windows.Forms.Button();
            this.btn_wurf3_1 = new System.Windows.Forms.Button();
            this.btn_wurf3_5 = new System.Windows.Forms.Button();
            this.btn_wurf3_4 = new System.Windows.Forms.Button();
            this.btn_wurf3_3 = new System.Windows.Forms.Button();
            this.btn_wurf3_2 = new System.Windows.Forms.Button();
            this.tBx_wurf3 = new System.Windows.Forms.TextBox();
            this.btn_doubleBullWurf2 = new System.Windows.Forms.Button();
            this.btn_bullWurf2 = new System.Windows.Forms.Button();
            this.btn_dreimalWurf2 = new System.Windows.Forms.Button();
            this.btn_zweimalWurf2 = new System.Windows.Forms.Button();
            this.btn_einmalWurf2 = new System.Windows.Forms.Button();
            this.btn_wurf2_16 = new System.Windows.Forms.Button();
            this.btn_wurf2_20 = new System.Windows.Forms.Button();
            this.btn_wurf2_19 = new System.Windows.Forms.Button();
            this.btn_wurf2_18 = new System.Windows.Forms.Button();
            this.btn_wurf2_17 = new System.Windows.Forms.Button();
            this.btn_wurf2_11 = new System.Windows.Forms.Button();
            this.btn_wurf2_15 = new System.Windows.Forms.Button();
            this.btn_wurf2_14 = new System.Windows.Forms.Button();
            this.btn_wurf2_13 = new System.Windows.Forms.Button();
            this.btn_wurf2_12 = new System.Windows.Forms.Button();
            this.btn_wurf2_6 = new System.Windows.Forms.Button();
            this.btn_wurf2_10 = new System.Windows.Forms.Button();
            this.btn_wurf2_9 = new System.Windows.Forms.Button();
            this.btn_wurf2_8 = new System.Windows.Forms.Button();
            this.btn_wurf2_7 = new System.Windows.Forms.Button();
            this.btn_wurf2_1 = new System.Windows.Forms.Button();
            this.btn_wurf2_5 = new System.Windows.Forms.Button();
            this.btn_wurf2_4 = new System.Windows.Forms.Button();
            this.btn_wurf2_3 = new System.Windows.Forms.Button();
            this.btn_wurf2_2 = new System.Windows.Forms.Button();
            this.tBx_wurf2 = new System.Windows.Forms.TextBox();
            this.btn_doubleBullWurf1 = new System.Windows.Forms.Button();
            this.btn_bullWurf1 = new System.Windows.Forms.Button();
            this.btn_dreimalWurf1 = new System.Windows.Forms.Button();
            this.btn_zweimalWurf1 = new System.Windows.Forms.Button();
            this.btn_einmalWurf1 = new System.Windows.Forms.Button();
            this.btn_wurf1_16 = new System.Windows.Forms.Button();
            this.btn_wurf1_20 = new System.Windows.Forms.Button();
            this.btn_wurf1_19 = new System.Windows.Forms.Button();
            this.btn_wurf1_18 = new System.Windows.Forms.Button();
            this.btn_wurf1_17 = new System.Windows.Forms.Button();
            this.btn_wurf1_11 = new System.Windows.Forms.Button();
            this.btn_wurf1_15 = new System.Windows.Forms.Button();
            this.btn_wurf1_14 = new System.Windows.Forms.Button();
            this.btn_wurf1_13 = new System.Windows.Forms.Button();
            this.btn_wurf1_12 = new System.Windows.Forms.Button();
            this.btn_wurf1_6 = new System.Windows.Forms.Button();
            this.btn_wurf1_10 = new System.Windows.Forms.Button();
            this.btn_wurf1_9 = new System.Windows.Forms.Button();
            this.btn_wurf1_8 = new System.Windows.Forms.Button();
            this.btn_wurf1_7 = new System.Windows.Forms.Button();
            this.btn_wurf1_1 = new System.Windows.Forms.Button();
            this.btn_wurf1_5 = new System.Windows.Forms.Button();
            this.btn_wurf1_4 = new System.Windows.Forms.Button();
            this.btn_wurf1_3 = new System.Windows.Forms.Button();
            this.btn_wurf1_2 = new System.Windows.Forms.Button();
            this.tBx_wurf1 = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.progressBar);
            groupBox2.Controls.Add(this.btn_weiter);
            groupBox2.Controls.Add(this.btn_beenden);
            groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            groupBox2.Location = new System.Drawing.Point(559, -11);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(190, 298);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 221);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(169, 64);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 99;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // btn_weiter
            // 
            this.btn_weiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_weiter.Location = new System.Drawing.Point(49, 221);
            this.btn_weiter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_weiter.Name = "btn_weiter";
            this.btn_weiter.Size = new System.Drawing.Size(163, 64);
            this.btn_weiter.TabIndex = 1;
            this.btn_weiter.Text = "Weiter";
            this.btn_weiter.UseVisualStyleBackColor = true;
            this.btn_weiter.Click += new System.EventHandler(this.btn_weiter_Click);
            // 
            // btn_beenden
            // 
            this.btn_beenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_beenden.Location = new System.Drawing.Point(0, 17);
            this.btn_beenden.Margin = new System.Windows.Forms.Padding(2);
            this.btn_beenden.Name = "btn_beenden";
            this.btn_beenden.Size = new System.Drawing.Size(169, 29);
            this.btn_beenden.TabIndex = 0;
            this.btn_beenden.Text = "Beenden";
            this.btn_beenden.UseVisualStyleBackColor = true;
            this.btn_beenden.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_set, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_leg, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_rest, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nameSpieler1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nameSpieler2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nameSpieler3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nameSpieler4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nameSpieler5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nameSpieler6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nameSpieler7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nameSpieler8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pfeilSpieler1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pfeilSpieler2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pfeilSpieler3, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pfeilSpieler4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pfeilSpieler5, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pfeilSpieler6, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pfeilSpieler7, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pfeilSpieler8, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_setSpieler1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_legSpieler1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_restSpieler1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_setSpieler2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_legSpieler2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_restSpieler2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_setSpieler3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_legSpieler3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_restSpieler3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_setSpieler4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_legSpieler4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_restSpieler4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_setSpieler5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_legSpieler5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_restSpieler5, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_setSpieler6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_legSpieler6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_restSpieler6, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_setSpieler7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_legSpieler7, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_restSpieler7, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_setSpieler8, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_legSpieler8, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_restSpieler8, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_checkSpieler1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_checkSpieler2, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_checkSpieler3, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_checkSpieler4, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_checkSpieler5, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_checkSpieler6, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_checkSpieler7, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_checkSpieler8, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_avgSpieler1, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_avgSpieler2, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_avgSpieler3, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_avgSpieler4, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_avgSpieler5, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_avgSpieler6, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_avgSpieler7, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_avgSpieler8, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_avg, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dq, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dqSpieler1, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dqSpieler2, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dqSpieler3, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dqSpieler4, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dqSpieler5, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dqSpieler6, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dqSpieler7, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dqSpieler8, 7, 8);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(561, 288);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(3, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_set
            // 
            this.lbl_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_set.AutoSize = true;
            this.lbl_set.Location = new System.Drawing.Point(76, 0);
            this.lbl_set.Name = "lbl_set";
            this.lbl_set.Size = new System.Drawing.Size(37, 20);
            this.lbl_set.TabIndex = 1;
            this.lbl_set.Text = "Set";
            this.lbl_set.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_leg
            // 
            this.lbl_leg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_leg.AutoSize = true;
            this.lbl_leg.Location = new System.Drawing.Point(119, 0);
            this.lbl_leg.Name = "lbl_leg";
            this.lbl_leg.Size = new System.Drawing.Size(37, 20);
            this.lbl_leg.TabIndex = 2;
            this.lbl_leg.Text = "Leg";
            this.lbl_leg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_rest
            // 
            this.lbl_rest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_rest.AutoSize = true;
            this.lbl_rest.Location = new System.Drawing.Point(166, 0);
            this.lbl_rest.Name = "lbl_rest";
            this.lbl_rest.Size = new System.Drawing.Size(43, 20);
            this.lbl_rest.TabIndex = 3;
            this.lbl_rest.Text = "Rest";
            this.lbl_rest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_nameSpieler1
            // 
            this.lbl_nameSpieler1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nameSpieler1.AutoSize = true;
            this.lbl_nameSpieler1.Location = new System.Drawing.Point(3, 40);
            this.lbl_nameSpieler1.Name = "lbl_nameSpieler1";
            this.lbl_nameSpieler1.Size = new System.Drawing.Size(67, 30);
            this.lbl_nameSpieler1.TabIndex = 13;
            this.lbl_nameSpieler1.Text = "Spieler1";
            this.lbl_nameSpieler1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nameSpieler2
            // 
            this.lbl_nameSpieler2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nameSpieler2.AutoSize = true;
            this.lbl_nameSpieler2.Location = new System.Drawing.Point(3, 70);
            this.lbl_nameSpieler2.Name = "lbl_nameSpieler2";
            this.lbl_nameSpieler2.Size = new System.Drawing.Size(67, 30);
            this.lbl_nameSpieler2.TabIndex = 14;
            this.lbl_nameSpieler2.Text = "Spieler2";
            this.lbl_nameSpieler2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nameSpieler3
            // 
            this.lbl_nameSpieler3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nameSpieler3.AutoSize = true;
            this.lbl_nameSpieler3.Location = new System.Drawing.Point(3, 100);
            this.lbl_nameSpieler3.Name = "lbl_nameSpieler3";
            this.lbl_nameSpieler3.Size = new System.Drawing.Size(67, 30);
            this.lbl_nameSpieler3.TabIndex = 15;
            this.lbl_nameSpieler3.Text = "Spieler3";
            this.lbl_nameSpieler3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nameSpieler4
            // 
            this.lbl_nameSpieler4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nameSpieler4.AutoSize = true;
            this.lbl_nameSpieler4.Location = new System.Drawing.Point(3, 130);
            this.lbl_nameSpieler4.Name = "lbl_nameSpieler4";
            this.lbl_nameSpieler4.Size = new System.Drawing.Size(67, 30);
            this.lbl_nameSpieler4.TabIndex = 16;
            this.lbl_nameSpieler4.Text = "Spieler4";
            this.lbl_nameSpieler4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nameSpieler5
            // 
            this.lbl_nameSpieler5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nameSpieler5.AutoSize = true;
            this.lbl_nameSpieler5.Location = new System.Drawing.Point(3, 160);
            this.lbl_nameSpieler5.Name = "lbl_nameSpieler5";
            this.lbl_nameSpieler5.Size = new System.Drawing.Size(67, 30);
            this.lbl_nameSpieler5.TabIndex = 17;
            this.lbl_nameSpieler5.Text = "Spieler5";
            this.lbl_nameSpieler5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nameSpieler6
            // 
            this.lbl_nameSpieler6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nameSpieler6.AutoSize = true;
            this.lbl_nameSpieler6.Location = new System.Drawing.Point(3, 190);
            this.lbl_nameSpieler6.Name = "lbl_nameSpieler6";
            this.lbl_nameSpieler6.Size = new System.Drawing.Size(67, 30);
            this.lbl_nameSpieler6.TabIndex = 18;
            this.lbl_nameSpieler6.Text = "Spieler6";
            this.lbl_nameSpieler6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nameSpieler7
            // 
            this.lbl_nameSpieler7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nameSpieler7.AutoSize = true;
            this.lbl_nameSpieler7.Location = new System.Drawing.Point(3, 220);
            this.lbl_nameSpieler7.Name = "lbl_nameSpieler7";
            this.lbl_nameSpieler7.Size = new System.Drawing.Size(67, 30);
            this.lbl_nameSpieler7.TabIndex = 19;
            this.lbl_nameSpieler7.Text = "Spieler7";
            this.lbl_nameSpieler7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nameSpieler8
            // 
            this.lbl_nameSpieler8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nameSpieler8.AutoSize = true;
            this.lbl_nameSpieler8.Location = new System.Drawing.Point(3, 250);
            this.lbl_nameSpieler8.Name = "lbl_nameSpieler8";
            this.lbl_nameSpieler8.Size = new System.Drawing.Size(67, 38);
            this.lbl_nameSpieler8.TabIndex = 20;
            this.lbl_nameSpieler8.Text = "Spieler8";
            this.lbl_nameSpieler8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Checkout";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_pfeilSpieler1
            // 
            this.lbl_pfeilSpieler1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pfeilSpieler1.AutoSize = true;
            this.lbl_pfeilSpieler1.Location = new System.Drawing.Point(219, 40);
            this.lbl_pfeilSpieler1.Name = "lbl_pfeilSpieler1";
            this.lbl_pfeilSpieler1.Size = new System.Drawing.Size(28, 30);
            this.lbl_pfeilSpieler1.TabIndex = 5;
            this.lbl_pfeilSpieler1.Text = "<--";
            this.lbl_pfeilSpieler1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pfeilSpieler2
            // 
            this.lbl_pfeilSpieler2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pfeilSpieler2.AutoSize = true;
            this.lbl_pfeilSpieler2.Location = new System.Drawing.Point(219, 70);
            this.lbl_pfeilSpieler2.Name = "lbl_pfeilSpieler2";
            this.lbl_pfeilSpieler2.Size = new System.Drawing.Size(28, 30);
            this.lbl_pfeilSpieler2.TabIndex = 6;
            this.lbl_pfeilSpieler2.Text = "<--";
            this.lbl_pfeilSpieler2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pfeilSpieler3
            // 
            this.lbl_pfeilSpieler3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pfeilSpieler3.AutoSize = true;
            this.lbl_pfeilSpieler3.Location = new System.Drawing.Point(219, 100);
            this.lbl_pfeilSpieler3.Name = "lbl_pfeilSpieler3";
            this.lbl_pfeilSpieler3.Size = new System.Drawing.Size(28, 30);
            this.lbl_pfeilSpieler3.TabIndex = 7;
            this.lbl_pfeilSpieler3.Text = "<--";
            this.lbl_pfeilSpieler3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pfeilSpieler4
            // 
            this.lbl_pfeilSpieler4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pfeilSpieler4.AutoSize = true;
            this.lbl_pfeilSpieler4.Location = new System.Drawing.Point(219, 130);
            this.lbl_pfeilSpieler4.Name = "lbl_pfeilSpieler4";
            this.lbl_pfeilSpieler4.Size = new System.Drawing.Size(28, 30);
            this.lbl_pfeilSpieler4.TabIndex = 8;
            this.lbl_pfeilSpieler4.Text = "<--";
            this.lbl_pfeilSpieler4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pfeilSpieler5
            // 
            this.lbl_pfeilSpieler5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pfeilSpieler5.AutoSize = true;
            this.lbl_pfeilSpieler5.Location = new System.Drawing.Point(219, 160);
            this.lbl_pfeilSpieler5.Name = "lbl_pfeilSpieler5";
            this.lbl_pfeilSpieler5.Size = new System.Drawing.Size(28, 30);
            this.lbl_pfeilSpieler5.TabIndex = 9;
            this.lbl_pfeilSpieler5.Text = "<--";
            this.lbl_pfeilSpieler5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pfeilSpieler6
            // 
            this.lbl_pfeilSpieler6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pfeilSpieler6.AutoSize = true;
            this.lbl_pfeilSpieler6.Location = new System.Drawing.Point(219, 190);
            this.lbl_pfeilSpieler6.Name = "lbl_pfeilSpieler6";
            this.lbl_pfeilSpieler6.Size = new System.Drawing.Size(28, 30);
            this.lbl_pfeilSpieler6.TabIndex = 10;
            this.lbl_pfeilSpieler6.Text = "<--";
            this.lbl_pfeilSpieler6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pfeilSpieler7
            // 
            this.lbl_pfeilSpieler7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pfeilSpieler7.AutoSize = true;
            this.lbl_pfeilSpieler7.Location = new System.Drawing.Point(219, 220);
            this.lbl_pfeilSpieler7.Name = "lbl_pfeilSpieler7";
            this.lbl_pfeilSpieler7.Size = new System.Drawing.Size(28, 30);
            this.lbl_pfeilSpieler7.TabIndex = 11;
            this.lbl_pfeilSpieler7.Text = "<--";
            this.lbl_pfeilSpieler7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pfeilSpieler8
            // 
            this.lbl_pfeilSpieler8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pfeilSpieler8.AutoSize = true;
            this.lbl_pfeilSpieler8.Location = new System.Drawing.Point(219, 250);
            this.lbl_pfeilSpieler8.Name = "lbl_pfeilSpieler8";
            this.lbl_pfeilSpieler8.Size = new System.Drawing.Size(28, 38);
            this.lbl_pfeilSpieler8.TabIndex = 12;
            this.lbl_pfeilSpieler8.Text = "<--";
            this.lbl_pfeilSpieler8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_setSpieler1
            // 
            this.lbl_setSpieler1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_setSpieler1.AutoSize = true;
            this.lbl_setSpieler1.Location = new System.Drawing.Point(76, 40);
            this.lbl_setSpieler1.Name = "lbl_setSpieler1";
            this.lbl_setSpieler1.Size = new System.Drawing.Size(37, 30);
            this.lbl_setSpieler1.TabIndex = 21;
            this.lbl_setSpieler1.Text = "10";
            this.lbl_setSpieler1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_legSpieler1
            // 
            this.lbl_legSpieler1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_legSpieler1.AutoSize = true;
            this.lbl_legSpieler1.Location = new System.Drawing.Point(119, 40);
            this.lbl_legSpieler1.Name = "lbl_legSpieler1";
            this.lbl_legSpieler1.Size = new System.Drawing.Size(37, 30);
            this.lbl_legSpieler1.TabIndex = 22;
            this.lbl_legSpieler1.Text = "10";
            this.lbl_legSpieler1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_restSpieler1
            // 
            this.lbl_restSpieler1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_restSpieler1.AutoSize = true;
            this.lbl_restSpieler1.Location = new System.Drawing.Point(162, 40);
            this.lbl_restSpieler1.Name = "lbl_restSpieler1";
            this.lbl_restSpieler1.Size = new System.Drawing.Size(51, 30);
            this.lbl_restSpieler1.TabIndex = 23;
            this.lbl_restSpieler1.Text = "501";
            this.lbl_restSpieler1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_setSpieler2
            // 
            this.lbl_setSpieler2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_setSpieler2.AutoSize = true;
            this.lbl_setSpieler2.Location = new System.Drawing.Point(76, 70);
            this.lbl_setSpieler2.Name = "lbl_setSpieler2";
            this.lbl_setSpieler2.Size = new System.Drawing.Size(37, 30);
            this.lbl_setSpieler2.TabIndex = 24;
            this.lbl_setSpieler2.Text = "10";
            this.lbl_setSpieler2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_legSpieler2
            // 
            this.lbl_legSpieler2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_legSpieler2.AutoSize = true;
            this.lbl_legSpieler2.Location = new System.Drawing.Point(119, 70);
            this.lbl_legSpieler2.Name = "lbl_legSpieler2";
            this.lbl_legSpieler2.Size = new System.Drawing.Size(37, 30);
            this.lbl_legSpieler2.TabIndex = 25;
            this.lbl_legSpieler2.Text = "10";
            this.lbl_legSpieler2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_restSpieler2
            // 
            this.lbl_restSpieler2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_restSpieler2.AutoSize = true;
            this.lbl_restSpieler2.Location = new System.Drawing.Point(162, 70);
            this.lbl_restSpieler2.Name = "lbl_restSpieler2";
            this.lbl_restSpieler2.Size = new System.Drawing.Size(51, 30);
            this.lbl_restSpieler2.TabIndex = 26;
            this.lbl_restSpieler2.Text = "501";
            this.lbl_restSpieler2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_setSpieler3
            // 
            this.lbl_setSpieler3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_setSpieler3.AutoSize = true;
            this.lbl_setSpieler3.Location = new System.Drawing.Point(76, 100);
            this.lbl_setSpieler3.Name = "lbl_setSpieler3";
            this.lbl_setSpieler3.Size = new System.Drawing.Size(37, 30);
            this.lbl_setSpieler3.TabIndex = 27;
            this.lbl_setSpieler3.Text = "10";
            this.lbl_setSpieler3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_legSpieler3
            // 
            this.lbl_legSpieler3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_legSpieler3.AutoSize = true;
            this.lbl_legSpieler3.Location = new System.Drawing.Point(119, 100);
            this.lbl_legSpieler3.Name = "lbl_legSpieler3";
            this.lbl_legSpieler3.Size = new System.Drawing.Size(37, 30);
            this.lbl_legSpieler3.TabIndex = 28;
            this.lbl_legSpieler3.Text = "10";
            this.lbl_legSpieler3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_restSpieler3
            // 
            this.lbl_restSpieler3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_restSpieler3.AutoSize = true;
            this.lbl_restSpieler3.Location = new System.Drawing.Point(162, 100);
            this.lbl_restSpieler3.Name = "lbl_restSpieler3";
            this.lbl_restSpieler3.Size = new System.Drawing.Size(51, 30);
            this.lbl_restSpieler3.TabIndex = 29;
            this.lbl_restSpieler3.Text = "501";
            this.lbl_restSpieler3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_setSpieler4
            // 
            this.lbl_setSpieler4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_setSpieler4.AutoSize = true;
            this.lbl_setSpieler4.Location = new System.Drawing.Point(76, 130);
            this.lbl_setSpieler4.Name = "lbl_setSpieler4";
            this.lbl_setSpieler4.Size = new System.Drawing.Size(37, 30);
            this.lbl_setSpieler4.TabIndex = 30;
            this.lbl_setSpieler4.Text = "10";
            this.lbl_setSpieler4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_legSpieler4
            // 
            this.lbl_legSpieler4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_legSpieler4.AutoSize = true;
            this.lbl_legSpieler4.Location = new System.Drawing.Point(119, 130);
            this.lbl_legSpieler4.Name = "lbl_legSpieler4";
            this.lbl_legSpieler4.Size = new System.Drawing.Size(37, 30);
            this.lbl_legSpieler4.TabIndex = 31;
            this.lbl_legSpieler4.Text = "10";
            this.lbl_legSpieler4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_restSpieler4
            // 
            this.lbl_restSpieler4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_restSpieler4.AutoSize = true;
            this.lbl_restSpieler4.Location = new System.Drawing.Point(162, 130);
            this.lbl_restSpieler4.Name = "lbl_restSpieler4";
            this.lbl_restSpieler4.Size = new System.Drawing.Size(51, 30);
            this.lbl_restSpieler4.TabIndex = 32;
            this.lbl_restSpieler4.Text = "501";
            this.lbl_restSpieler4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_setSpieler5
            // 
            this.lbl_setSpieler5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_setSpieler5.AutoSize = true;
            this.lbl_setSpieler5.Location = new System.Drawing.Point(76, 160);
            this.lbl_setSpieler5.Name = "lbl_setSpieler5";
            this.lbl_setSpieler5.Size = new System.Drawing.Size(37, 30);
            this.lbl_setSpieler5.TabIndex = 33;
            this.lbl_setSpieler5.Text = "10";
            this.lbl_setSpieler5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_legSpieler5
            // 
            this.lbl_legSpieler5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_legSpieler5.AutoSize = true;
            this.lbl_legSpieler5.Location = new System.Drawing.Point(119, 160);
            this.lbl_legSpieler5.Name = "lbl_legSpieler5";
            this.lbl_legSpieler5.Size = new System.Drawing.Size(37, 30);
            this.lbl_legSpieler5.TabIndex = 34;
            this.lbl_legSpieler5.Text = "10";
            this.lbl_legSpieler5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_restSpieler5
            // 
            this.lbl_restSpieler5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_restSpieler5.AutoSize = true;
            this.lbl_restSpieler5.Location = new System.Drawing.Point(162, 160);
            this.lbl_restSpieler5.Name = "lbl_restSpieler5";
            this.lbl_restSpieler5.Size = new System.Drawing.Size(51, 30);
            this.lbl_restSpieler5.TabIndex = 35;
            this.lbl_restSpieler5.Text = "501";
            this.lbl_restSpieler5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_setSpieler6
            // 
            this.lbl_setSpieler6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_setSpieler6.AutoSize = true;
            this.lbl_setSpieler6.Location = new System.Drawing.Point(76, 190);
            this.lbl_setSpieler6.Name = "lbl_setSpieler6";
            this.lbl_setSpieler6.Size = new System.Drawing.Size(37, 30);
            this.lbl_setSpieler6.TabIndex = 36;
            this.lbl_setSpieler6.Text = "10";
            this.lbl_setSpieler6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_legSpieler6
            // 
            this.lbl_legSpieler6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_legSpieler6.AutoSize = true;
            this.lbl_legSpieler6.Location = new System.Drawing.Point(119, 190);
            this.lbl_legSpieler6.Name = "lbl_legSpieler6";
            this.lbl_legSpieler6.Size = new System.Drawing.Size(37, 30);
            this.lbl_legSpieler6.TabIndex = 37;
            this.lbl_legSpieler6.Text = "10";
            this.lbl_legSpieler6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_restSpieler6
            // 
            this.lbl_restSpieler6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_restSpieler6.AutoSize = true;
            this.lbl_restSpieler6.Location = new System.Drawing.Point(162, 190);
            this.lbl_restSpieler6.Name = "lbl_restSpieler6";
            this.lbl_restSpieler6.Size = new System.Drawing.Size(51, 30);
            this.lbl_restSpieler6.TabIndex = 38;
            this.lbl_restSpieler6.Text = "501";
            this.lbl_restSpieler6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_setSpieler7
            // 
            this.lbl_setSpieler7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_setSpieler7.AutoSize = true;
            this.lbl_setSpieler7.Location = new System.Drawing.Point(76, 220);
            this.lbl_setSpieler7.Name = "lbl_setSpieler7";
            this.lbl_setSpieler7.Size = new System.Drawing.Size(37, 30);
            this.lbl_setSpieler7.TabIndex = 39;
            this.lbl_setSpieler7.Text = "10";
            this.lbl_setSpieler7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_legSpieler7
            // 
            this.lbl_legSpieler7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_legSpieler7.AutoSize = true;
            this.lbl_legSpieler7.Location = new System.Drawing.Point(119, 220);
            this.lbl_legSpieler7.Name = "lbl_legSpieler7";
            this.lbl_legSpieler7.Size = new System.Drawing.Size(37, 30);
            this.lbl_legSpieler7.TabIndex = 40;
            this.lbl_legSpieler7.Text = "10";
            this.lbl_legSpieler7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_restSpieler7
            // 
            this.lbl_restSpieler7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_restSpieler7.AutoSize = true;
            this.lbl_restSpieler7.Location = new System.Drawing.Point(162, 220);
            this.lbl_restSpieler7.Name = "lbl_restSpieler7";
            this.lbl_restSpieler7.Size = new System.Drawing.Size(51, 30);
            this.lbl_restSpieler7.TabIndex = 41;
            this.lbl_restSpieler7.Text = "501";
            this.lbl_restSpieler7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_setSpieler8
            // 
            this.lbl_setSpieler8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_setSpieler8.AutoSize = true;
            this.lbl_setSpieler8.Location = new System.Drawing.Point(76, 250);
            this.lbl_setSpieler8.Name = "lbl_setSpieler8";
            this.lbl_setSpieler8.Size = new System.Drawing.Size(37, 38);
            this.lbl_setSpieler8.TabIndex = 42;
            this.lbl_setSpieler8.Text = "10";
            this.lbl_setSpieler8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_legSpieler8
            // 
            this.lbl_legSpieler8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_legSpieler8.AutoSize = true;
            this.lbl_legSpieler8.Location = new System.Drawing.Point(119, 250);
            this.lbl_legSpieler8.Name = "lbl_legSpieler8";
            this.lbl_legSpieler8.Size = new System.Drawing.Size(37, 38);
            this.lbl_legSpieler8.TabIndex = 43;
            this.lbl_legSpieler8.Text = "10";
            this.lbl_legSpieler8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_restSpieler8
            // 
            this.lbl_restSpieler8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_restSpieler8.AutoSize = true;
            this.lbl_restSpieler8.Location = new System.Drawing.Point(162, 250);
            this.lbl_restSpieler8.Name = "lbl_restSpieler8";
            this.lbl_restSpieler8.Size = new System.Drawing.Size(51, 38);
            this.lbl_restSpieler8.TabIndex = 44;
            this.lbl_restSpieler8.Text = "501";
            this.lbl_restSpieler8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_checkSpieler1
            // 
            this.lbl_checkSpieler1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_checkSpieler1.AutoSize = true;
            this.lbl_checkSpieler1.Location = new System.Drawing.Point(253, 40);
            this.lbl_checkSpieler1.Name = "lbl_checkSpieler1";
            this.lbl_checkSpieler1.Size = new System.Drawing.Size(98, 30);
            this.lbl_checkSpieler1.TabIndex = 45;
            this.lbl_checkSpieler1.Text = "T20 T20 T20";
            this.lbl_checkSpieler1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_checkSpieler2
            // 
            this.lbl_checkSpieler2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_checkSpieler2.AutoSize = true;
            this.lbl_checkSpieler2.Location = new System.Drawing.Point(253, 70);
            this.lbl_checkSpieler2.Name = "lbl_checkSpieler2";
            this.lbl_checkSpieler2.Size = new System.Drawing.Size(98, 30);
            this.lbl_checkSpieler2.TabIndex = 46;
            this.lbl_checkSpieler2.Text = "T20 T20 T20";
            this.lbl_checkSpieler2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_checkSpieler3
            // 
            this.lbl_checkSpieler3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_checkSpieler3.AutoSize = true;
            this.lbl_checkSpieler3.Location = new System.Drawing.Point(253, 100);
            this.lbl_checkSpieler3.Name = "lbl_checkSpieler3";
            this.lbl_checkSpieler3.Size = new System.Drawing.Size(98, 30);
            this.lbl_checkSpieler3.TabIndex = 47;
            this.lbl_checkSpieler3.Text = "T20 T20 T20";
            this.lbl_checkSpieler3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_checkSpieler4
            // 
            this.lbl_checkSpieler4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_checkSpieler4.AutoSize = true;
            this.lbl_checkSpieler4.Location = new System.Drawing.Point(253, 130);
            this.lbl_checkSpieler4.Name = "lbl_checkSpieler4";
            this.lbl_checkSpieler4.Size = new System.Drawing.Size(98, 30);
            this.lbl_checkSpieler4.TabIndex = 48;
            this.lbl_checkSpieler4.Text = "T20 T20 T20";
            this.lbl_checkSpieler4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_checkSpieler5
            // 
            this.lbl_checkSpieler5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_checkSpieler5.AutoSize = true;
            this.lbl_checkSpieler5.Location = new System.Drawing.Point(253, 160);
            this.lbl_checkSpieler5.Name = "lbl_checkSpieler5";
            this.lbl_checkSpieler5.Size = new System.Drawing.Size(98, 30);
            this.lbl_checkSpieler5.TabIndex = 49;
            this.lbl_checkSpieler5.Text = "T20 T20 T20";
            this.lbl_checkSpieler5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_checkSpieler6
            // 
            this.lbl_checkSpieler6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_checkSpieler6.AutoSize = true;
            this.lbl_checkSpieler6.Location = new System.Drawing.Point(253, 190);
            this.lbl_checkSpieler6.Name = "lbl_checkSpieler6";
            this.lbl_checkSpieler6.Size = new System.Drawing.Size(98, 30);
            this.lbl_checkSpieler6.TabIndex = 50;
            this.lbl_checkSpieler6.Text = "T20 T20 T20";
            this.lbl_checkSpieler6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_checkSpieler7
            // 
            this.lbl_checkSpieler7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_checkSpieler7.AutoSize = true;
            this.lbl_checkSpieler7.Location = new System.Drawing.Point(253, 220);
            this.lbl_checkSpieler7.Name = "lbl_checkSpieler7";
            this.lbl_checkSpieler7.Size = new System.Drawing.Size(98, 30);
            this.lbl_checkSpieler7.TabIndex = 51;
            this.lbl_checkSpieler7.Text = "T20 T20 T20";
            this.lbl_checkSpieler7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_checkSpieler8
            // 
            this.lbl_checkSpieler8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_checkSpieler8.AutoSize = true;
            this.lbl_checkSpieler8.Location = new System.Drawing.Point(253, 250);
            this.lbl_checkSpieler8.Name = "lbl_checkSpieler8";
            this.lbl_checkSpieler8.Size = new System.Drawing.Size(98, 38);
            this.lbl_checkSpieler8.TabIndex = 52;
            this.lbl_checkSpieler8.Text = "T20 T20 T20";
            this.lbl_checkSpieler8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_avgSpieler1
            // 
            this.lbl_avgSpieler1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_avgSpieler1.AutoSize = true;
            this.lbl_avgSpieler1.Location = new System.Drawing.Point(356, 40);
            this.lbl_avgSpieler1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_avgSpieler1.Name = "lbl_avgSpieler1";
            this.lbl_avgSpieler1.Size = new System.Drawing.Size(51, 30);
            this.lbl_avgSpieler1.TabIndex = 53;
            this.lbl_avgSpieler1.Text = "label2";
            this.lbl_avgSpieler1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_avgSpieler2
            // 
            this.lbl_avgSpieler2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_avgSpieler2.AutoSize = true;
            this.lbl_avgSpieler2.Location = new System.Drawing.Point(356, 70);
            this.lbl_avgSpieler2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_avgSpieler2.Name = "lbl_avgSpieler2";
            this.lbl_avgSpieler2.Size = new System.Drawing.Size(51, 30);
            this.lbl_avgSpieler2.TabIndex = 54;
            this.lbl_avgSpieler2.Text = "label3";
            this.lbl_avgSpieler2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_avgSpieler3
            // 
            this.lbl_avgSpieler3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_avgSpieler3.AutoSize = true;
            this.lbl_avgSpieler3.Location = new System.Drawing.Point(356, 100);
            this.lbl_avgSpieler3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_avgSpieler3.Name = "lbl_avgSpieler3";
            this.lbl_avgSpieler3.Size = new System.Drawing.Size(51, 30);
            this.lbl_avgSpieler3.TabIndex = 55;
            this.lbl_avgSpieler3.Text = "label4";
            this.lbl_avgSpieler3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_avgSpieler4
            // 
            this.lbl_avgSpieler4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_avgSpieler4.AutoSize = true;
            this.lbl_avgSpieler4.Location = new System.Drawing.Point(356, 130);
            this.lbl_avgSpieler4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_avgSpieler4.Name = "lbl_avgSpieler4";
            this.lbl_avgSpieler4.Size = new System.Drawing.Size(51, 30);
            this.lbl_avgSpieler4.TabIndex = 56;
            this.lbl_avgSpieler4.Text = "label5";
            this.lbl_avgSpieler4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_avgSpieler5
            // 
            this.lbl_avgSpieler5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_avgSpieler5.AutoSize = true;
            this.lbl_avgSpieler5.Location = new System.Drawing.Point(356, 160);
            this.lbl_avgSpieler5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_avgSpieler5.Name = "lbl_avgSpieler5";
            this.lbl_avgSpieler5.Size = new System.Drawing.Size(51, 30);
            this.lbl_avgSpieler5.TabIndex = 57;
            this.lbl_avgSpieler5.Text = "label6";
            this.lbl_avgSpieler5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_avgSpieler6
            // 
            this.lbl_avgSpieler6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_avgSpieler6.AutoSize = true;
            this.lbl_avgSpieler6.Location = new System.Drawing.Point(356, 190);
            this.lbl_avgSpieler6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_avgSpieler6.Name = "lbl_avgSpieler6";
            this.lbl_avgSpieler6.Size = new System.Drawing.Size(51, 30);
            this.lbl_avgSpieler6.TabIndex = 58;
            this.lbl_avgSpieler6.Text = "label7";
            this.lbl_avgSpieler6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_avgSpieler7
            // 
            this.lbl_avgSpieler7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_avgSpieler7.AutoSize = true;
            this.lbl_avgSpieler7.Location = new System.Drawing.Point(356, 220);
            this.lbl_avgSpieler7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_avgSpieler7.Name = "lbl_avgSpieler7";
            this.lbl_avgSpieler7.Size = new System.Drawing.Size(51, 30);
            this.lbl_avgSpieler7.TabIndex = 59;
            this.lbl_avgSpieler7.Text = "label8";
            this.lbl_avgSpieler7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_avgSpieler8
            // 
            this.lbl_avgSpieler8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_avgSpieler8.AutoSize = true;
            this.lbl_avgSpieler8.Location = new System.Drawing.Point(356, 250);
            this.lbl_avgSpieler8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_avgSpieler8.Name = "lbl_avgSpieler8";
            this.lbl_avgSpieler8.Size = new System.Drawing.Size(51, 38);
            this.lbl_avgSpieler8.TabIndex = 60;
            this.lbl_avgSpieler8.Text = "label9";
            this.lbl_avgSpieler8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_avg
            // 
            this.lbl_avg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_avg.AutoSize = true;
            this.lbl_avg.Location = new System.Drawing.Point(359, 0);
            this.lbl_avg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_avg.Name = "lbl_avg";
            this.lbl_avg.Size = new System.Drawing.Size(44, 20);
            this.lbl_avg.TabIndex = 61;
            this.lbl_avg.Text = "AVG";
            this.lbl_avg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_dq
            // 
            this.lbl_dq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_dq.AutoSize = true;
            this.lbl_dq.Location = new System.Drawing.Point(420, 0);
            this.lbl_dq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dq.Name = "lbl_dq";
            this.lbl_dq.Size = new System.Drawing.Size(33, 20);
            this.lbl_dq.TabIndex = 62;
            this.lbl_dq.Text = "DQ";
            this.lbl_dq.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_dqSpieler1
            // 
            this.lbl_dqSpieler1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dqSpieler1.AutoSize = true;
            this.lbl_dqSpieler1.Location = new System.Drawing.Point(411, 40);
            this.lbl_dqSpieler1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dqSpieler1.Name = "lbl_dqSpieler1";
            this.lbl_dqSpieler1.Size = new System.Drawing.Size(51, 30);
            this.lbl_dqSpieler1.TabIndex = 63;
            this.lbl_dqSpieler1.Text = "label2";
            this.lbl_dqSpieler1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_dqSpieler2
            // 
            this.lbl_dqSpieler2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dqSpieler2.AutoSize = true;
            this.lbl_dqSpieler2.Location = new System.Drawing.Point(411, 70);
            this.lbl_dqSpieler2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dqSpieler2.Name = "lbl_dqSpieler2";
            this.lbl_dqSpieler2.Size = new System.Drawing.Size(51, 30);
            this.lbl_dqSpieler2.TabIndex = 64;
            this.lbl_dqSpieler2.Text = "label3";
            this.lbl_dqSpieler2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_dqSpieler3
            // 
            this.lbl_dqSpieler3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dqSpieler3.AutoSize = true;
            this.lbl_dqSpieler3.Location = new System.Drawing.Point(411, 100);
            this.lbl_dqSpieler3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dqSpieler3.Name = "lbl_dqSpieler3";
            this.lbl_dqSpieler3.Size = new System.Drawing.Size(51, 30);
            this.lbl_dqSpieler3.TabIndex = 65;
            this.lbl_dqSpieler3.Text = "label4";
            this.lbl_dqSpieler3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_dqSpieler4
            // 
            this.lbl_dqSpieler4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dqSpieler4.AutoSize = true;
            this.lbl_dqSpieler4.Location = new System.Drawing.Point(411, 130);
            this.lbl_dqSpieler4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dqSpieler4.Name = "lbl_dqSpieler4";
            this.lbl_dqSpieler4.Size = new System.Drawing.Size(51, 30);
            this.lbl_dqSpieler4.TabIndex = 66;
            this.lbl_dqSpieler4.Text = "label5";
            this.lbl_dqSpieler4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_dqSpieler5
            // 
            this.lbl_dqSpieler5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dqSpieler5.AutoSize = true;
            this.lbl_dqSpieler5.Location = new System.Drawing.Point(411, 160);
            this.lbl_dqSpieler5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dqSpieler5.Name = "lbl_dqSpieler5";
            this.lbl_dqSpieler5.Size = new System.Drawing.Size(51, 30);
            this.lbl_dqSpieler5.TabIndex = 67;
            this.lbl_dqSpieler5.Text = "label6";
            this.lbl_dqSpieler5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_dqSpieler6
            // 
            this.lbl_dqSpieler6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dqSpieler6.AutoSize = true;
            this.lbl_dqSpieler6.Location = new System.Drawing.Point(411, 190);
            this.lbl_dqSpieler6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dqSpieler6.Name = "lbl_dqSpieler6";
            this.lbl_dqSpieler6.Size = new System.Drawing.Size(51, 30);
            this.lbl_dqSpieler6.TabIndex = 68;
            this.lbl_dqSpieler6.Text = "label7";
            this.lbl_dqSpieler6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_dqSpieler7
            // 
            this.lbl_dqSpieler7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dqSpieler7.AutoSize = true;
            this.lbl_dqSpieler7.Location = new System.Drawing.Point(411, 220);
            this.lbl_dqSpieler7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dqSpieler7.Name = "lbl_dqSpieler7";
            this.lbl_dqSpieler7.Size = new System.Drawing.Size(51, 30);
            this.lbl_dqSpieler7.TabIndex = 69;
            this.lbl_dqSpieler7.Text = "label8";
            this.lbl_dqSpieler7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_dqSpieler8
            // 
            this.lbl_dqSpieler8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dqSpieler8.AutoSize = true;
            this.lbl_dqSpieler8.Location = new System.Drawing.Point(411, 250);
            this.lbl_dqSpieler8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dqSpieler8.Name = "lbl_dqSpieler8";
            this.lbl_dqSpieler8.Size = new System.Drawing.Size(51, 38);
            this.lbl_dqSpieler8.TabIndex = 70;
            this.lbl_dqSpieler8.Text = "label9";
            this.lbl_dqSpieler8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEingabeStarten);
            this.groupBox1.Controls.Add(this.lblSpracheWertW3);
            this.groupBox1.Controls.Add(this.lblSpracheMultiW1);
            this.groupBox1.Controls.Add(this.lblSpracheWertW2);
            this.groupBox1.Controls.Add(this.lblSpracheWertW1);
            this.groupBox1.Controls.Add(this.lblSpracheMultiW2);
            this.groupBox1.Controls.Add(this.lblSpracheMultiW3);
            this.groupBox1.Controls.Add(this.rbKlickEingabe);
            this.groupBox1.Controls.Add(this.rbSpracheingabe);
            this.groupBox1.Controls.Add(this.cB_zielWurf3);
            this.groupBox1.Controls.Add(this.cB_zielWurf2);
            this.groupBox1.Controls.Add(this.cB_zielWurf1);
            this.groupBox1.Controls.Add(this.btn_loeschen);
            this.groupBox1.Controls.Add(this.btn_uebernehmen);
            this.groupBox1.Controls.Add(this.btn_nullWurf3);
            this.groupBox1.Controls.Add(this.btn_nullWurf2);
            this.groupBox1.Controls.Add(this.btn_nullWurf1);
            this.groupBox1.Controls.Add(this.lbl_wurf3);
            this.groupBox1.Controls.Add(this.lbl_wurf2);
            this.groupBox1.Controls.Add(this.lbl_wurf1);
            this.groupBox1.Controls.Add(this.btn_doubleBullWurf3);
            this.groupBox1.Controls.Add(this.btn_bullWurf3);
            this.groupBox1.Controls.Add(this.btn_dreimalWurf3);
            this.groupBox1.Controls.Add(this.btn_zweimalWurf3);
            this.groupBox1.Controls.Add(this.btn_einmalWurf3);
            this.groupBox1.Controls.Add(this.btn_wurf3_16);
            this.groupBox1.Controls.Add(this.btn_wurf3_20);
            this.groupBox1.Controls.Add(this.btn_wurf3_19);
            this.groupBox1.Controls.Add(this.btn_wurf3_18);
            this.groupBox1.Controls.Add(this.btn_wurf3_17);
            this.groupBox1.Controls.Add(this.btn_wurf3_11);
            this.groupBox1.Controls.Add(this.btn_wurf3_15);
            this.groupBox1.Controls.Add(this.btn_wurf3_14);
            this.groupBox1.Controls.Add(this.btn_wurf3_13);
            this.groupBox1.Controls.Add(this.btn_wurf3_12);
            this.groupBox1.Controls.Add(this.btn_wurf3_6);
            this.groupBox1.Controls.Add(this.btn_wurf3_10);
            this.groupBox1.Controls.Add(this.btn_wurf3_9);
            this.groupBox1.Controls.Add(this.btn_wurf3_8);
            this.groupBox1.Controls.Add(this.btn_wurf3_7);
            this.groupBox1.Controls.Add(this.btn_wurf3_1);
            this.groupBox1.Controls.Add(this.btn_wurf3_5);
            this.groupBox1.Controls.Add(this.btn_wurf3_4);
            this.groupBox1.Controls.Add(this.btn_wurf3_3);
            this.groupBox1.Controls.Add(this.btn_wurf3_2);
            this.groupBox1.Controls.Add(this.tBx_wurf3);
            this.groupBox1.Controls.Add(this.btn_doubleBullWurf2);
            this.groupBox1.Controls.Add(this.btn_bullWurf2);
            this.groupBox1.Controls.Add(this.btn_dreimalWurf2);
            this.groupBox1.Controls.Add(this.btn_zweimalWurf2);
            this.groupBox1.Controls.Add(this.btn_einmalWurf2);
            this.groupBox1.Controls.Add(this.btn_wurf2_16);
            this.groupBox1.Controls.Add(this.btn_wurf2_20);
            this.groupBox1.Controls.Add(this.btn_wurf2_19);
            this.groupBox1.Controls.Add(this.btn_wurf2_18);
            this.groupBox1.Controls.Add(this.btn_wurf2_17);
            this.groupBox1.Controls.Add(this.btn_wurf2_11);
            this.groupBox1.Controls.Add(this.btn_wurf2_15);
            this.groupBox1.Controls.Add(this.btn_wurf2_14);
            this.groupBox1.Controls.Add(this.btn_wurf2_13);
            this.groupBox1.Controls.Add(this.btn_wurf2_12);
            this.groupBox1.Controls.Add(this.btn_wurf2_6);
            this.groupBox1.Controls.Add(this.btn_wurf2_10);
            this.groupBox1.Controls.Add(this.btn_wurf2_9);
            this.groupBox1.Controls.Add(this.btn_wurf2_8);
            this.groupBox1.Controls.Add(this.btn_wurf2_7);
            this.groupBox1.Controls.Add(this.btn_wurf2_1);
            this.groupBox1.Controls.Add(this.btn_wurf2_5);
            this.groupBox1.Controls.Add(this.btn_wurf2_4);
            this.groupBox1.Controls.Add(this.btn_wurf2_3);
            this.groupBox1.Controls.Add(this.btn_wurf2_2);
            this.groupBox1.Controls.Add(this.tBx_wurf2);
            this.groupBox1.Controls.Add(this.btn_doubleBullWurf1);
            this.groupBox1.Controls.Add(this.btn_bullWurf1);
            this.groupBox1.Controls.Add(this.btn_dreimalWurf1);
            this.groupBox1.Controls.Add(this.btn_zweimalWurf1);
            this.groupBox1.Controls.Add(this.btn_einmalWurf1);
            this.groupBox1.Controls.Add(this.btn_wurf1_16);
            this.groupBox1.Controls.Add(this.btn_wurf1_20);
            this.groupBox1.Controls.Add(this.btn_wurf1_19);
            this.groupBox1.Controls.Add(this.btn_wurf1_18);
            this.groupBox1.Controls.Add(this.btn_wurf1_17);
            this.groupBox1.Controls.Add(this.btn_wurf1_11);
            this.groupBox1.Controls.Add(this.btn_wurf1_15);
            this.groupBox1.Controls.Add(this.btn_wurf1_14);
            this.groupBox1.Controls.Add(this.btn_wurf1_13);
            this.groupBox1.Controls.Add(this.btn_wurf1_12);
            this.groupBox1.Controls.Add(this.btn_wurf1_6);
            this.groupBox1.Controls.Add(this.btn_wurf1_10);
            this.groupBox1.Controls.Add(this.btn_wurf1_9);
            this.groupBox1.Controls.Add(this.btn_wurf1_8);
            this.groupBox1.Controls.Add(this.btn_wurf1_7);
            this.groupBox1.Controls.Add(this.btn_wurf1_1);
            this.groupBox1.Controls.Add(this.btn_wurf1_5);
            this.groupBox1.Controls.Add(this.btn_wurf1_4);
            this.groupBox1.Controls.Add(this.btn_wurf1_3);
            this.groupBox1.Controls.Add(this.btn_wurf1_2);
            this.groupBox1.Controls.Add(this.tBx_wurf1);
            this.groupBox1.Location = new System.Drawing.Point(0, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 295);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnEingabeStarten
            // 
            this.btnEingabeStarten.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEingabeStarten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEingabeStarten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEingabeStarten.Location = new System.Drawing.Point(559, 135);
            this.btnEingabeStarten.Name = "btnEingabeStarten";
            this.btnEingabeStarten.Size = new System.Drawing.Size(169, 136);
            this.btnEingabeStarten.TabIndex = 100;
            this.btnEingabeStarten.Text = "Eingabe starten";
            this.btnEingabeStarten.UseVisualStyleBackColor = false;
            this.btnEingabeStarten.Click += new System.EventHandler(this.btnEingabeStarten_Click);
            // 
            // lblSpracheWertW3
            // 
            this.lblSpracheWertW3.AutoSize = true;
            this.lblSpracheWertW3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpracheWertW3.Location = new System.Drawing.Point(420, 137);
            this.lblSpracheWertW3.Name = "lblSpracheWertW3";
            this.lblSpracheWertW3.Size = new System.Drawing.Size(47, 100);
            this.lblSpracheWertW3.TabIndex = 105;
            this.lblSpracheWertW3.Text = "\"20\"\r\n\"19\"\r\n\"18\"\r\n\"Bull\"\r\n...";
            this.lblSpracheWertW3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpracheMultiW1
            // 
            this.lblSpracheMultiW1.AutoSize = true;
            this.lblSpracheMultiW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpracheMultiW1.Location = new System.Drawing.Point(54, 137);
            this.lblSpracheMultiW1.Name = "lblSpracheMultiW1";
            this.lblSpracheMultiW1.Size = new System.Drawing.Size(73, 100);
            this.lblSpracheMultiW1.TabIndex = 100;
            this.lblSpracheMultiW1.Text = "\"einfach\"\r\n\"doppel\"\r\n\"triple\"\r\n\"Bull\"\r\n\"0\"";
            this.lblSpracheMultiW1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpracheWertW2
            // 
            this.lblSpracheWertW2.AutoSize = true;
            this.lblSpracheWertW2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpracheWertW2.Location = new System.Drawing.Point(253, 137);
            this.lblSpracheWertW2.Name = "lblSpracheWertW2";
            this.lblSpracheWertW2.Size = new System.Drawing.Size(47, 100);
            this.lblSpracheWertW2.TabIndex = 104;
            this.lblSpracheWertW2.Text = "\"20\"\r\n\"19\"\r\n\"18\"\r\n\"Bull\"\r\n...";
            this.lblSpracheWertW2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpracheWertW1
            // 
            this.lblSpracheWertW1.AutoSize = true;
            this.lblSpracheWertW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpracheWertW1.Location = new System.Drawing.Point(75, 137);
            this.lblSpracheWertW1.Name = "lblSpracheWertW1";
            this.lblSpracheWertW1.Size = new System.Drawing.Size(47, 100);
            this.lblSpracheWertW1.TabIndex = 103;
            this.lblSpracheWertW1.Text = "\"20\"\r\n\"19\"\r\n\"18\"\r\n\"Bull\"\r\n...";
            this.lblSpracheWertW1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpracheMultiW2
            // 
            this.lblSpracheMultiW2.AutoSize = true;
            this.lblSpracheMultiW2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpracheMultiW2.Location = new System.Drawing.Point(234, 137);
            this.lblSpracheMultiW2.Name = "lblSpracheMultiW2";
            this.lblSpracheMultiW2.Size = new System.Drawing.Size(73, 100);
            this.lblSpracheMultiW2.TabIndex = 101;
            this.lblSpracheMultiW2.Text = "\"einfach\"\r\n\"doppel\"\r\n\"triple\"\r\n\"Bull\"\r\n\"0\"";
            this.lblSpracheMultiW2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpracheMultiW3
            // 
            this.lblSpracheMultiW3.AutoSize = true;
            this.lblSpracheMultiW3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpracheMultiW3.Location = new System.Drawing.Point(420, 137);
            this.lblSpracheMultiW3.Name = "lblSpracheMultiW3";
            this.lblSpracheMultiW3.Size = new System.Drawing.Size(73, 100);
            this.lblSpracheMultiW3.TabIndex = 102;
            this.lblSpracheMultiW3.Text = "\"einfach\"\r\n\"doppel\"\r\n\"triple\"\r\n\"Bull\"\r\n\"0\"";
            this.lblSpracheMultiW3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbKlickEingabe
            // 
            this.rbKlickEingabe.AutoSize = true;
            this.rbKlickEingabe.Checked = true;
            this.rbKlickEingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKlickEingabe.Location = new System.Drawing.Point(581, 6);
            this.rbKlickEingabe.Name = "rbKlickEingabe";
            this.rbKlickEingabe.Size = new System.Drawing.Size(123, 24);
            this.rbKlickEingabe.TabIndex = 100;
            this.rbKlickEingabe.TabStop = true;
            this.rbKlickEingabe.Text = "Mauseingabe";
            this.rbKlickEingabe.UseVisualStyleBackColor = true;
            this.rbKlickEingabe.CheckedChanged += new System.EventHandler(this.rbKlickEingabe_CheckedChanged);
            // 
            // rbSpracheingabe
            // 
            this.rbSpracheingabe.AutoSize = true;
            this.rbSpracheingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSpracheingabe.Location = new System.Drawing.Point(581, 36);
            this.rbSpracheingabe.Name = "rbSpracheingabe";
            this.rbSpracheingabe.Size = new System.Drawing.Size(135, 24);
            this.rbSpracheingabe.TabIndex = 101;
            this.rbSpracheingabe.Text = "Spracheingabe";
            this.rbSpracheingabe.UseVisualStyleBackColor = true;
            this.rbSpracheingabe.CheckedChanged += new System.EventHandler(this.rbSpracheingabe_CheckedChanged);
            // 
            // cB_zielWurf3
            // 
            this.cB_zielWurf3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_zielWurf3.FormattingEnabled = true;
            this.cB_zielWurf3.Items.AddRange(new object[] {
            "3\tx\t20",
            "3\tx\t19",
            "3\tx\t18",
            "3\tx\t17",
            "3\tx\t16",
            "3\tx\t15",
            "3\tx\t14",
            "3\tx\t13",
            "3\tx\t12",
            "3\tx\t11",
            "3\tx\t10",
            "3\tx\t9",
            "3\tx\t8",
            "3\tx\t7",
            "3\tx\t6",
            "3\tx\t5",
            "3\tx\t4",
            "3\tx\t3",
            "3\tx\t2",
            "3\tx\t1",
            "2\tx\t20",
            "2\tx\t19",
            "2\tx\t18",
            "2\tx\t17",
            "2\tx\t16",
            "2\tx\t15",
            "2\tx\t14",
            "2\tx\t13",
            "2\tx\t12",
            "2\tx\t11",
            "2\tx\t10",
            "2\tx\t9",
            "2\tx\t8",
            "2\tx\t7",
            "2\tx\t6",
            "2\tx\t5",
            "2\tx\t4",
            "2\tx\t3",
            "2\tx\t2",
            "2\tx\t1",
            "1\tx\t20",
            "1\tx\t19",
            "1\tx\t18",
            "1\tx\t17",
            "1\tx\t16",
            "1\tx\t15",
            "1\tx\t14",
            "1\tx\t13",
            "1\tx\t12",
            "1\tx\t11",
            "1\tx\t10",
            "1\tx\t9",
            "1\tx\t8",
            "1\tx\t7",
            "1\tx\t6",
            "1\tx\t5",
            "1\tx\t4",
            "1\tx\t3",
            "1\tx\t2",
            "1\tx\t1",
            "DBull\t\t",
            "SBull\t\t"});
            this.cB_zielWurf3.Location = new System.Drawing.Point(367, 101);
            this.cB_zielWurf3.Margin = new System.Windows.Forms.Padding(2);
            this.cB_zielWurf3.Name = "cB_zielWurf3";
            this.cB_zielWurf3.Size = new System.Drawing.Size(174, 33);
            this.cB_zielWurf3.TabIndex = 2;
            this.cB_zielWurf3.Visible = false;
            // 
            // cB_zielWurf2
            // 
            this.cB_zielWurf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_zielWurf2.FormattingEnabled = true;
            this.cB_zielWurf2.Items.AddRange(new object[] {
            "3\tx\t20",
            "3\tx\t19",
            "3\tx\t18",
            "3\tx\t17",
            "3\tx\t16",
            "3\tx\t15",
            "3\tx\t14",
            "3\tx\t13",
            "3\tx\t12",
            "3\tx\t11",
            "3\tx\t10",
            "3\tx\t9",
            "3\tx\t8",
            "3\tx\t7",
            "3\tx\t6",
            "3\tx\t5",
            "3\tx\t4",
            "3\tx\t3",
            "3\tx\t2",
            "3\tx\t1",
            "2\tx\t20",
            "2\tx\t19",
            "2\tx\t18",
            "2\tx\t17",
            "2\tx\t16",
            "2\tx\t15",
            "2\tx\t14",
            "2\tx\t13",
            "2\tx\t12",
            "2\tx\t11",
            "2\tx\t10",
            "2\tx\t9",
            "2\tx\t8",
            "2\tx\t7",
            "2\tx\t6",
            "2\tx\t5",
            "2\tx\t4",
            "2\tx\t3",
            "2\tx\t2",
            "2\tx\t1",
            "1\tx\t20",
            "1\tx\t19",
            "1\tx\t18",
            "1\tx\t17",
            "1\tx\t16",
            "1\tx\t15",
            "1\tx\t14",
            "1\tx\t13",
            "1\tx\t12",
            "1\tx\t11",
            "1\tx\t10",
            "1\tx\t9",
            "1\tx\t8",
            "1\tx\t7",
            "1\tx\t6",
            "1\tx\t5",
            "1\tx\t4",
            "1\tx\t3",
            "1\tx\t2",
            "1\tx\t1",
            "DBull\t\t",
            "SBull\t\t"});
            this.cB_zielWurf2.Location = new System.Drawing.Point(187, 101);
            this.cB_zielWurf2.Margin = new System.Windows.Forms.Padding(2);
            this.cB_zielWurf2.Name = "cB_zielWurf2";
            this.cB_zielWurf2.Size = new System.Drawing.Size(174, 33);
            this.cB_zielWurf2.TabIndex = 2;
            this.cB_zielWurf2.Visible = false;
            // 
            // cB_zielWurf1
            // 
            this.cB_zielWurf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_zielWurf1.FormattingEnabled = true;
            this.cB_zielWurf1.Items.AddRange(new object[] {
            "3\tx\t20",
            "3\tx\t19",
            "3\tx\t18",
            "3\tx\t17",
            "3\tx\t16",
            "3\tx\t15",
            "3\tx\t14",
            "3\tx\t13",
            "3\tx\t12",
            "3\tx\t11",
            "3\tx\t10",
            "3\tx\t9",
            "3\tx\t8",
            "3\tx\t7",
            "3\tx\t6",
            "3\tx\t5",
            "3\tx\t4",
            "3\tx\t3",
            "3\tx\t2",
            "3\tx\t1",
            "2\tx\t20",
            "2\tx\t19",
            "2\tx\t18",
            "2\tx\t17",
            "2\tx\t16",
            "2\tx\t15",
            "2\tx\t14",
            "2\tx\t13",
            "2\tx\t12",
            "2\tx\t11",
            "2\tx\t10",
            "2\tx\t9",
            "2\tx\t8",
            "2\tx\t7",
            "2\tx\t6",
            "2\tx\t5",
            "2\tx\t4",
            "2\tx\t3",
            "2\tx\t2",
            "2\tx\t1",
            "1\tx\t20",
            "1\tx\t19",
            "1\tx\t18",
            "1\tx\t17",
            "1\tx\t16",
            "1\tx\t15",
            "1\tx\t14",
            "1\tx\t13",
            "1\tx\t12",
            "1\tx\t11",
            "1\tx\t10",
            "1\tx\t9",
            "1\tx\t8",
            "1\tx\t7",
            "1\tx\t6",
            "1\tx\t5",
            "1\tx\t4",
            "1\tx\t3",
            "1\tx\t2",
            "1\tx\t1",
            "DBull\t\t",
            "SBull\t\t"});
            this.cB_zielWurf1.Location = new System.Drawing.Point(8, 101);
            this.cB_zielWurf1.Margin = new System.Windows.Forms.Padding(2);
            this.cB_zielWurf1.Name = "cB_zielWurf1";
            this.cB_zielWurf1.Size = new System.Drawing.Size(174, 33);
            this.cB_zielWurf1.TabIndex = 1;
            this.cB_zielWurf1.Visible = false;
            // 
            // btn_loeschen
            // 
            this.btn_loeschen.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_loeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loeschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loeschen.Location = new System.Drawing.Point(559, 65);
            this.btn_loeschen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_loeschen.Name = "btn_loeschen";
            this.btn_loeschen.Size = new System.Drawing.Size(169, 66);
            this.btn_loeschen.TabIndex = 98;
            this.btn_loeschen.Text = "Löschen";
            this.btn_loeschen.UseVisualStyleBackColor = false;
            this.btn_loeschen.Click += new System.EventHandler(this.btn_loeschen_Click);
            // 
            // btn_uebernehmen
            // 
            this.btn_uebernehmen.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_uebernehmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uebernehmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uebernehmen.Location = new System.Drawing.Point(559, 135);
            this.btn_uebernehmen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_uebernehmen.Name = "btn_uebernehmen";
            this.btn_uebernehmen.Size = new System.Drawing.Size(169, 136);
            this.btn_uebernehmen.TabIndex = 97;
            this.btn_uebernehmen.Text = "Übernehmen";
            this.btn_uebernehmen.UseVisualStyleBackColor = false;
            this.btn_uebernehmen.Click += new System.EventHandler(this.btn_uebernehmen_Click);
            // 
            // btn_nullWurf3
            // 
            this.btn_nullWurf3.Location = new System.Drawing.Point(367, 244);
            this.btn_nullWurf3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nullWurf3.Name = "btn_nullWurf3";
            this.btn_nullWurf3.Size = new System.Drawing.Size(175, 30);
            this.btn_nullWurf3.TabIndex = 96;
            this.btn_nullWurf3.Text = "Null";
            this.btn_nullWurf3.UseVisualStyleBackColor = true;
            this.btn_nullWurf3.Click += new System.EventHandler(this.btn_nullWurf3_Click);
            // 
            // btn_nullWurf2
            // 
            this.btn_nullWurf2.Location = new System.Drawing.Point(187, 244);
            this.btn_nullWurf2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nullWurf2.Name = "btn_nullWurf2";
            this.btn_nullWurf2.Size = new System.Drawing.Size(175, 30);
            this.btn_nullWurf2.TabIndex = 95;
            this.btn_nullWurf2.Text = "Null";
            this.btn_nullWurf2.UseVisualStyleBackColor = true;
            this.btn_nullWurf2.Click += new System.EventHandler(this.btn_nullWurf2_Click);
            // 
            // btn_nullWurf1
            // 
            this.btn_nullWurf1.Location = new System.Drawing.Point(7, 244);
            this.btn_nullWurf1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nullWurf1.Name = "btn_nullWurf1";
            this.btn_nullWurf1.Size = new System.Drawing.Size(175, 30);
            this.btn_nullWurf1.TabIndex = 94;
            this.btn_nullWurf1.Text = "Null";
            this.btn_nullWurf1.UseVisualStyleBackColor = true;
            this.btn_nullWurf1.Click += new System.EventHandler(this.btn_nullWurf1_Click);
            // 
            // lbl_wurf3
            // 
            this.lbl_wurf3.AutoSize = true;
            this.lbl_wurf3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wurf3.Location = new System.Drawing.Point(412, 25);
            this.lbl_wurf3.Name = "lbl_wurf3";
            this.lbl_wurf3.Size = new System.Drawing.Size(93, 31);
            this.lbl_wurf3.TabIndex = 93;
            this.lbl_wurf3.Text = "Wurf 3";
            // 
            // lbl_wurf2
            // 
            this.lbl_wurf2.AutoSize = true;
            this.lbl_wurf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wurf2.Location = new System.Drawing.Point(232, 25);
            this.lbl_wurf2.Name = "lbl_wurf2";
            this.lbl_wurf2.Size = new System.Drawing.Size(93, 31);
            this.lbl_wurf2.TabIndex = 92;
            this.lbl_wurf2.Text = "Wurf 2";
            // 
            // lbl_wurf1
            // 
            this.lbl_wurf1.AutoSize = true;
            this.lbl_wurf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wurf1.Location = new System.Drawing.Point(52, 25);
            this.lbl_wurf1.Name = "lbl_wurf1";
            this.lbl_wurf1.Size = new System.Drawing.Size(93, 31);
            this.lbl_wurf1.TabIndex = 91;
            this.lbl_wurf1.Text = "Wurf 1";
            // 
            // btn_doubleBullWurf3
            // 
            this.btn_doubleBullWurf3.Location = new System.Drawing.Point(456, 209);
            this.btn_doubleBullWurf3.Name = "btn_doubleBullWurf3";
            this.btn_doubleBullWurf3.Size = new System.Drawing.Size(85, 30);
            this.btn_doubleBullWurf3.TabIndex = 90;
            this.btn_doubleBullWurf3.Text = "2x Bull";
            this.btn_doubleBullWurf3.UseVisualStyleBackColor = true;
            this.btn_doubleBullWurf3.Click += new System.EventHandler(this.btn_doubleBullWurf3_Click);
            // 
            // btn_bullWurf3
            // 
            this.btn_bullWurf3.Location = new System.Drawing.Point(367, 209);
            this.btn_bullWurf3.Name = "btn_bullWurf3";
            this.btn_bullWurf3.Size = new System.Drawing.Size(85, 30);
            this.btn_bullWurf3.TabIndex = 89;
            this.btn_bullWurf3.Text = "Bull";
            this.btn_bullWurf3.UseVisualStyleBackColor = true;
            this.btn_bullWurf3.Click += new System.EventHandler(this.btn_bullWurf3_Click);
            // 
            // btn_dreimalWurf3
            // 
            this.btn_dreimalWurf3.Location = new System.Drawing.Point(367, 173);
            this.btn_dreimalWurf3.Name = "btn_dreimalWurf3";
            this.btn_dreimalWurf3.Size = new System.Drawing.Size(174, 30);
            this.btn_dreimalWurf3.TabIndex = 88;
            this.btn_dreimalWurf3.Text = "3x";
            this.btn_dreimalWurf3.UseVisualStyleBackColor = true;
            this.btn_dreimalWurf3.Click += new System.EventHandler(this.btn_dreimalWurf3_Click);
            // 
            // btn_zweimalWurf3
            // 
            this.btn_zweimalWurf3.Location = new System.Drawing.Point(367, 137);
            this.btn_zweimalWurf3.Name = "btn_zweimalWurf3";
            this.btn_zweimalWurf3.Size = new System.Drawing.Size(174, 30);
            this.btn_zweimalWurf3.TabIndex = 87;
            this.btn_zweimalWurf3.Text = "2x";
            this.btn_zweimalWurf3.UseVisualStyleBackColor = true;
            this.btn_zweimalWurf3.Click += new System.EventHandler(this.btn_zweimalWurf3_Click);
            // 
            // btn_einmalWurf3
            // 
            this.btn_einmalWurf3.Location = new System.Drawing.Point(367, 101);
            this.btn_einmalWurf3.Name = "btn_einmalWurf3";
            this.btn_einmalWurf3.Size = new System.Drawing.Size(174, 30);
            this.btn_einmalWurf3.TabIndex = 86;
            this.btn_einmalWurf3.Text = "1x";
            this.btn_einmalWurf3.UseVisualStyleBackColor = true;
            this.btn_einmalWurf3.Click += new System.EventHandler(this.btn_einmalWurf3_Click);
            // 
            // btn_wurf3_16
            // 
            this.btn_wurf3_16.Location = new System.Drawing.Point(367, 209);
            this.btn_wurf3_16.Name = "btn_wurf3_16";
            this.btn_wurf3_16.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_16.TabIndex = 85;
            this.btn_wurf3_16.Text = "16";
            this.btn_wurf3_16.UseVisualStyleBackColor = true;
            this.btn_wurf3_16.Click += new System.EventHandler(this.btn_wurf3_16_Click);
            // 
            // btn_wurf3_20
            // 
            this.btn_wurf3_20.Location = new System.Drawing.Point(511, 209);
            this.btn_wurf3_20.Name = "btn_wurf3_20";
            this.btn_wurf3_20.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_20.TabIndex = 84;
            this.btn_wurf3_20.Text = "20";
            this.btn_wurf3_20.UseVisualStyleBackColor = true;
            this.btn_wurf3_20.Click += new System.EventHandler(this.btn_wurf3_20_Click);
            // 
            // btn_wurf3_19
            // 
            this.btn_wurf3_19.Location = new System.Drawing.Point(475, 209);
            this.btn_wurf3_19.Name = "btn_wurf3_19";
            this.btn_wurf3_19.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_19.TabIndex = 83;
            this.btn_wurf3_19.Text = "19";
            this.btn_wurf3_19.UseVisualStyleBackColor = true;
            this.btn_wurf3_19.Click += new System.EventHandler(this.btn_wurf3_19_Click);
            // 
            // btn_wurf3_18
            // 
            this.btn_wurf3_18.Location = new System.Drawing.Point(439, 209);
            this.btn_wurf3_18.Name = "btn_wurf3_18";
            this.btn_wurf3_18.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_18.TabIndex = 82;
            this.btn_wurf3_18.Text = "18";
            this.btn_wurf3_18.UseVisualStyleBackColor = true;
            this.btn_wurf3_18.Click += new System.EventHandler(this.btn_wurf3_18_Click);
            // 
            // btn_wurf3_17
            // 
            this.btn_wurf3_17.Location = new System.Drawing.Point(403, 209);
            this.btn_wurf3_17.Name = "btn_wurf3_17";
            this.btn_wurf3_17.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_17.TabIndex = 81;
            this.btn_wurf3_17.Text = "17";
            this.btn_wurf3_17.UseVisualStyleBackColor = true;
            this.btn_wurf3_17.Click += new System.EventHandler(this.btn_wurf3_17_Click);
            // 
            // btn_wurf3_11
            // 
            this.btn_wurf3_11.Location = new System.Drawing.Point(367, 173);
            this.btn_wurf3_11.Name = "btn_wurf3_11";
            this.btn_wurf3_11.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_11.TabIndex = 80;
            this.btn_wurf3_11.Text = "11";
            this.btn_wurf3_11.UseVisualStyleBackColor = true;
            this.btn_wurf3_11.Click += new System.EventHandler(this.btn_wurf3_11_Click);
            // 
            // btn_wurf3_15
            // 
            this.btn_wurf3_15.Location = new System.Drawing.Point(511, 173);
            this.btn_wurf3_15.Name = "btn_wurf3_15";
            this.btn_wurf3_15.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_15.TabIndex = 79;
            this.btn_wurf3_15.Text = "15";
            this.btn_wurf3_15.UseVisualStyleBackColor = true;
            this.btn_wurf3_15.Click += new System.EventHandler(this.btn_wurf3_15_Click);
            // 
            // btn_wurf3_14
            // 
            this.btn_wurf3_14.Location = new System.Drawing.Point(475, 173);
            this.btn_wurf3_14.Name = "btn_wurf3_14";
            this.btn_wurf3_14.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_14.TabIndex = 78;
            this.btn_wurf3_14.Text = "14";
            this.btn_wurf3_14.UseVisualStyleBackColor = true;
            this.btn_wurf3_14.Click += new System.EventHandler(this.btn_wurf3_14_Click);
            // 
            // btn_wurf3_13
            // 
            this.btn_wurf3_13.Location = new System.Drawing.Point(439, 173);
            this.btn_wurf3_13.Name = "btn_wurf3_13";
            this.btn_wurf3_13.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_13.TabIndex = 77;
            this.btn_wurf3_13.Text = "13";
            this.btn_wurf3_13.UseVisualStyleBackColor = true;
            this.btn_wurf3_13.Click += new System.EventHandler(this.btn_wurf3_13_Click);
            // 
            // btn_wurf3_12
            // 
            this.btn_wurf3_12.Location = new System.Drawing.Point(403, 173);
            this.btn_wurf3_12.Name = "btn_wurf3_12";
            this.btn_wurf3_12.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_12.TabIndex = 76;
            this.btn_wurf3_12.Text = "12";
            this.btn_wurf3_12.UseVisualStyleBackColor = true;
            this.btn_wurf3_12.Click += new System.EventHandler(this.btn_wurf3_12_Click);
            // 
            // btn_wurf3_6
            // 
            this.btn_wurf3_6.Location = new System.Drawing.Point(367, 137);
            this.btn_wurf3_6.Name = "btn_wurf3_6";
            this.btn_wurf3_6.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_6.TabIndex = 75;
            this.btn_wurf3_6.Text = "6";
            this.btn_wurf3_6.UseVisualStyleBackColor = true;
            this.btn_wurf3_6.Click += new System.EventHandler(this.btn_wurf3_6_Click);
            // 
            // btn_wurf3_10
            // 
            this.btn_wurf3_10.Location = new System.Drawing.Point(511, 137);
            this.btn_wurf3_10.Name = "btn_wurf3_10";
            this.btn_wurf3_10.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_10.TabIndex = 74;
            this.btn_wurf3_10.Text = "10";
            this.btn_wurf3_10.UseVisualStyleBackColor = true;
            this.btn_wurf3_10.Click += new System.EventHandler(this.btn_wurf3_10_Click);
            // 
            // btn_wurf3_9
            // 
            this.btn_wurf3_9.Location = new System.Drawing.Point(475, 137);
            this.btn_wurf3_9.Name = "btn_wurf3_9";
            this.btn_wurf3_9.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_9.TabIndex = 73;
            this.btn_wurf3_9.Text = "9";
            this.btn_wurf3_9.UseVisualStyleBackColor = true;
            this.btn_wurf3_9.Click += new System.EventHandler(this.btn_wurf3_9_Click);
            // 
            // btn_wurf3_8
            // 
            this.btn_wurf3_8.Location = new System.Drawing.Point(439, 137);
            this.btn_wurf3_8.Name = "btn_wurf3_8";
            this.btn_wurf3_8.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_8.TabIndex = 72;
            this.btn_wurf3_8.Text = "8";
            this.btn_wurf3_8.UseVisualStyleBackColor = true;
            this.btn_wurf3_8.Click += new System.EventHandler(this.btn_wurf3_8_Click);
            // 
            // btn_wurf3_7
            // 
            this.btn_wurf3_7.Location = new System.Drawing.Point(403, 137);
            this.btn_wurf3_7.Name = "btn_wurf3_7";
            this.btn_wurf3_7.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_7.TabIndex = 71;
            this.btn_wurf3_7.Text = "7";
            this.btn_wurf3_7.UseVisualStyleBackColor = true;
            this.btn_wurf3_7.Click += new System.EventHandler(this.btn_wurf3_7_Click);
            // 
            // btn_wurf3_1
            // 
            this.btn_wurf3_1.Location = new System.Drawing.Point(367, 101);
            this.btn_wurf3_1.Name = "btn_wurf3_1";
            this.btn_wurf3_1.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_1.TabIndex = 70;
            this.btn_wurf3_1.Text = "1";
            this.btn_wurf3_1.UseVisualStyleBackColor = true;
            this.btn_wurf3_1.Click += new System.EventHandler(this.btn_wurf3_1_Click);
            // 
            // btn_wurf3_5
            // 
            this.btn_wurf3_5.Location = new System.Drawing.Point(511, 101);
            this.btn_wurf3_5.Name = "btn_wurf3_5";
            this.btn_wurf3_5.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_5.TabIndex = 69;
            this.btn_wurf3_5.Text = "5";
            this.btn_wurf3_5.UseVisualStyleBackColor = true;
            this.btn_wurf3_5.Click += new System.EventHandler(this.btn_wurf3_5_Click);
            // 
            // btn_wurf3_4
            // 
            this.btn_wurf3_4.Location = new System.Drawing.Point(475, 101);
            this.btn_wurf3_4.Name = "btn_wurf3_4";
            this.btn_wurf3_4.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_4.TabIndex = 68;
            this.btn_wurf3_4.Text = "4";
            this.btn_wurf3_4.UseVisualStyleBackColor = true;
            this.btn_wurf3_4.Click += new System.EventHandler(this.btn_wurf3_4_Click);
            // 
            // btn_wurf3_3
            // 
            this.btn_wurf3_3.Location = new System.Drawing.Point(439, 101);
            this.btn_wurf3_3.Name = "btn_wurf3_3";
            this.btn_wurf3_3.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_3.TabIndex = 67;
            this.btn_wurf3_3.Text = "3";
            this.btn_wurf3_3.UseVisualStyleBackColor = true;
            this.btn_wurf3_3.Click += new System.EventHandler(this.btn_wurf3_3_Click);
            // 
            // btn_wurf3_2
            // 
            this.btn_wurf3_2.Location = new System.Drawing.Point(403, 101);
            this.btn_wurf3_2.Name = "btn_wurf3_2";
            this.btn_wurf3_2.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf3_2.TabIndex = 66;
            this.btn_wurf3_2.Text = "2";
            this.btn_wurf3_2.UseVisualStyleBackColor = true;
            this.btn_wurf3_2.Click += new System.EventHandler(this.btn_wurf3_2_Click);
            // 
            // tBx_wurf3
            // 
            this.tBx_wurf3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_wurf3.Location = new System.Drawing.Point(367, 65);
            this.tBx_wurf3.Name = "tBx_wurf3";
            this.tBx_wurf3.ReadOnly = true;
            this.tBx_wurf3.Size = new System.Drawing.Size(174, 30);
            this.tBx_wurf3.TabIndex = 65;
            this.tBx_wurf3.Text = "3x20";
            this.tBx_wurf3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_doubleBullWurf2
            // 
            this.btn_doubleBullWurf2.Location = new System.Drawing.Point(277, 209);
            this.btn_doubleBullWurf2.Name = "btn_doubleBullWurf2";
            this.btn_doubleBullWurf2.Size = new System.Drawing.Size(85, 30);
            this.btn_doubleBullWurf2.TabIndex = 64;
            this.btn_doubleBullWurf2.Text = "2x Bull";
            this.btn_doubleBullWurf2.UseVisualStyleBackColor = true;
            this.btn_doubleBullWurf2.Click += new System.EventHandler(this.btn_doubleBullWurf2_Click);
            // 
            // btn_bullWurf2
            // 
            this.btn_bullWurf2.Location = new System.Drawing.Point(187, 209);
            this.btn_bullWurf2.Name = "btn_bullWurf2";
            this.btn_bullWurf2.Size = new System.Drawing.Size(85, 30);
            this.btn_bullWurf2.TabIndex = 63;
            this.btn_bullWurf2.Text = "Bull";
            this.btn_bullWurf2.UseVisualStyleBackColor = true;
            this.btn_bullWurf2.Click += new System.EventHandler(this.btn_bullWurf2_Click);
            // 
            // btn_dreimalWurf2
            // 
            this.btn_dreimalWurf2.Location = new System.Drawing.Point(187, 173);
            this.btn_dreimalWurf2.Name = "btn_dreimalWurf2";
            this.btn_dreimalWurf2.Size = new System.Drawing.Size(174, 30);
            this.btn_dreimalWurf2.TabIndex = 62;
            this.btn_dreimalWurf2.Text = "3x";
            this.btn_dreimalWurf2.UseVisualStyleBackColor = true;
            this.btn_dreimalWurf2.Click += new System.EventHandler(this.btn_dreimalWurf2_Click);
            // 
            // btn_zweimalWurf2
            // 
            this.btn_zweimalWurf2.Location = new System.Drawing.Point(187, 137);
            this.btn_zweimalWurf2.Name = "btn_zweimalWurf2";
            this.btn_zweimalWurf2.Size = new System.Drawing.Size(174, 30);
            this.btn_zweimalWurf2.TabIndex = 61;
            this.btn_zweimalWurf2.Text = "2x";
            this.btn_zweimalWurf2.UseVisualStyleBackColor = true;
            this.btn_zweimalWurf2.Click += new System.EventHandler(this.btn_zweimalWurf2_Click);
            // 
            // btn_einmalWurf2
            // 
            this.btn_einmalWurf2.Location = new System.Drawing.Point(187, 101);
            this.btn_einmalWurf2.Name = "btn_einmalWurf2";
            this.btn_einmalWurf2.Size = new System.Drawing.Size(174, 30);
            this.btn_einmalWurf2.TabIndex = 60;
            this.btn_einmalWurf2.Text = "1x";
            this.btn_einmalWurf2.UseVisualStyleBackColor = true;
            this.btn_einmalWurf2.Click += new System.EventHandler(this.btn_einmalWurf2_Click);
            // 
            // btn_wurf2_16
            // 
            this.btn_wurf2_16.Location = new System.Drawing.Point(187, 209);
            this.btn_wurf2_16.Name = "btn_wurf2_16";
            this.btn_wurf2_16.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_16.TabIndex = 59;
            this.btn_wurf2_16.Text = "16";
            this.btn_wurf2_16.UseVisualStyleBackColor = true;
            this.btn_wurf2_16.Click += new System.EventHandler(this.btn_wurf2_16_Click);
            // 
            // btn_wurf2_20
            // 
            this.btn_wurf2_20.Location = new System.Drawing.Point(331, 209);
            this.btn_wurf2_20.Name = "btn_wurf2_20";
            this.btn_wurf2_20.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_20.TabIndex = 58;
            this.btn_wurf2_20.Text = "20";
            this.btn_wurf2_20.UseVisualStyleBackColor = true;
            this.btn_wurf2_20.Click += new System.EventHandler(this.btn_wurf2_20_Click);
            // 
            // btn_wurf2_19
            // 
            this.btn_wurf2_19.Location = new System.Drawing.Point(295, 209);
            this.btn_wurf2_19.Name = "btn_wurf2_19";
            this.btn_wurf2_19.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_19.TabIndex = 57;
            this.btn_wurf2_19.Text = "19";
            this.btn_wurf2_19.UseVisualStyleBackColor = true;
            this.btn_wurf2_19.Click += new System.EventHandler(this.btn_wurf2_19_Click);
            // 
            // btn_wurf2_18
            // 
            this.btn_wurf2_18.Location = new System.Drawing.Point(259, 209);
            this.btn_wurf2_18.Name = "btn_wurf2_18";
            this.btn_wurf2_18.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_18.TabIndex = 56;
            this.btn_wurf2_18.Text = "18";
            this.btn_wurf2_18.UseVisualStyleBackColor = true;
            this.btn_wurf2_18.Click += new System.EventHandler(this.btn_wurf2_18_Click);
            // 
            // btn_wurf2_17
            // 
            this.btn_wurf2_17.Location = new System.Drawing.Point(223, 209);
            this.btn_wurf2_17.Name = "btn_wurf2_17";
            this.btn_wurf2_17.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_17.TabIndex = 55;
            this.btn_wurf2_17.Text = "17";
            this.btn_wurf2_17.UseVisualStyleBackColor = true;
            this.btn_wurf2_17.Click += new System.EventHandler(this.btn_wurf2_17_Click);
            // 
            // btn_wurf2_11
            // 
            this.btn_wurf2_11.Location = new System.Drawing.Point(187, 173);
            this.btn_wurf2_11.Name = "btn_wurf2_11";
            this.btn_wurf2_11.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_11.TabIndex = 54;
            this.btn_wurf2_11.Text = "11";
            this.btn_wurf2_11.UseVisualStyleBackColor = true;
            this.btn_wurf2_11.Click += new System.EventHandler(this.btn_wurf2_11_Click);
            // 
            // btn_wurf2_15
            // 
            this.btn_wurf2_15.Location = new System.Drawing.Point(331, 173);
            this.btn_wurf2_15.Name = "btn_wurf2_15";
            this.btn_wurf2_15.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_15.TabIndex = 53;
            this.btn_wurf2_15.Text = "15";
            this.btn_wurf2_15.UseVisualStyleBackColor = true;
            this.btn_wurf2_15.Click += new System.EventHandler(this.btn_wurf2_15_Click);
            // 
            // btn_wurf2_14
            // 
            this.btn_wurf2_14.Location = new System.Drawing.Point(295, 173);
            this.btn_wurf2_14.Name = "btn_wurf2_14";
            this.btn_wurf2_14.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_14.TabIndex = 52;
            this.btn_wurf2_14.Text = "14";
            this.btn_wurf2_14.UseVisualStyleBackColor = true;
            this.btn_wurf2_14.Click += new System.EventHandler(this.btn_wurf2_14_Click);
            // 
            // btn_wurf2_13
            // 
            this.btn_wurf2_13.Location = new System.Drawing.Point(259, 173);
            this.btn_wurf2_13.Name = "btn_wurf2_13";
            this.btn_wurf2_13.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_13.TabIndex = 51;
            this.btn_wurf2_13.Text = "13";
            this.btn_wurf2_13.UseVisualStyleBackColor = true;
            this.btn_wurf2_13.Click += new System.EventHandler(this.btn_wurf2_13_Click);
            // 
            // btn_wurf2_12
            // 
            this.btn_wurf2_12.Location = new System.Drawing.Point(223, 173);
            this.btn_wurf2_12.Name = "btn_wurf2_12";
            this.btn_wurf2_12.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_12.TabIndex = 50;
            this.btn_wurf2_12.Text = "12";
            this.btn_wurf2_12.UseVisualStyleBackColor = true;
            this.btn_wurf2_12.Click += new System.EventHandler(this.btn_wurf2_12_Click);
            // 
            // btn_wurf2_6
            // 
            this.btn_wurf2_6.Location = new System.Drawing.Point(187, 137);
            this.btn_wurf2_6.Name = "btn_wurf2_6";
            this.btn_wurf2_6.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_6.TabIndex = 49;
            this.btn_wurf2_6.Text = "6";
            this.btn_wurf2_6.UseVisualStyleBackColor = true;
            this.btn_wurf2_6.Click += new System.EventHandler(this.btn_wurf2_6_Click);
            // 
            // btn_wurf2_10
            // 
            this.btn_wurf2_10.Location = new System.Drawing.Point(331, 137);
            this.btn_wurf2_10.Name = "btn_wurf2_10";
            this.btn_wurf2_10.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_10.TabIndex = 48;
            this.btn_wurf2_10.Text = "10";
            this.btn_wurf2_10.UseVisualStyleBackColor = true;
            this.btn_wurf2_10.Click += new System.EventHandler(this.btn_wurf2_10_Click);
            // 
            // btn_wurf2_9
            // 
            this.btn_wurf2_9.Location = new System.Drawing.Point(295, 137);
            this.btn_wurf2_9.Name = "btn_wurf2_9";
            this.btn_wurf2_9.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_9.TabIndex = 47;
            this.btn_wurf2_9.Text = "9";
            this.btn_wurf2_9.UseVisualStyleBackColor = true;
            this.btn_wurf2_9.Click += new System.EventHandler(this.btn_wurf2_9_Click);
            // 
            // btn_wurf2_8
            // 
            this.btn_wurf2_8.Location = new System.Drawing.Point(259, 137);
            this.btn_wurf2_8.Name = "btn_wurf2_8";
            this.btn_wurf2_8.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_8.TabIndex = 46;
            this.btn_wurf2_8.Text = "8";
            this.btn_wurf2_8.UseVisualStyleBackColor = true;
            this.btn_wurf2_8.Click += new System.EventHandler(this.btn_wurf2_8_Click);
            // 
            // btn_wurf2_7
            // 
            this.btn_wurf2_7.Location = new System.Drawing.Point(223, 137);
            this.btn_wurf2_7.Name = "btn_wurf2_7";
            this.btn_wurf2_7.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_7.TabIndex = 45;
            this.btn_wurf2_7.Text = "7";
            this.btn_wurf2_7.UseVisualStyleBackColor = true;
            this.btn_wurf2_7.Click += new System.EventHandler(this.btn_wurf2_7_Click);
            // 
            // btn_wurf2_1
            // 
            this.btn_wurf2_1.Location = new System.Drawing.Point(187, 101);
            this.btn_wurf2_1.Name = "btn_wurf2_1";
            this.btn_wurf2_1.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_1.TabIndex = 44;
            this.btn_wurf2_1.Text = "1";
            this.btn_wurf2_1.UseVisualStyleBackColor = true;
            this.btn_wurf2_1.Click += new System.EventHandler(this.btn_wurf2_1_Click);
            // 
            // btn_wurf2_5
            // 
            this.btn_wurf2_5.Location = new System.Drawing.Point(331, 101);
            this.btn_wurf2_5.Name = "btn_wurf2_5";
            this.btn_wurf2_5.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_5.TabIndex = 43;
            this.btn_wurf2_5.Text = "5";
            this.btn_wurf2_5.UseVisualStyleBackColor = true;
            this.btn_wurf2_5.Click += new System.EventHandler(this.btn_wurf2_5_Click);
            // 
            // btn_wurf2_4
            // 
            this.btn_wurf2_4.Location = new System.Drawing.Point(295, 101);
            this.btn_wurf2_4.Name = "btn_wurf2_4";
            this.btn_wurf2_4.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_4.TabIndex = 42;
            this.btn_wurf2_4.Text = "4";
            this.btn_wurf2_4.UseVisualStyleBackColor = true;
            this.btn_wurf2_4.Click += new System.EventHandler(this.btn_wurf2_4_Click);
            // 
            // btn_wurf2_3
            // 
            this.btn_wurf2_3.Location = new System.Drawing.Point(259, 101);
            this.btn_wurf2_3.Name = "btn_wurf2_3";
            this.btn_wurf2_3.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_3.TabIndex = 41;
            this.btn_wurf2_3.Text = "3";
            this.btn_wurf2_3.UseVisualStyleBackColor = true;
            this.btn_wurf2_3.Click += new System.EventHandler(this.btn_wurf2_3_Click);
            // 
            // btn_wurf2_2
            // 
            this.btn_wurf2_2.Location = new System.Drawing.Point(223, 101);
            this.btn_wurf2_2.Name = "btn_wurf2_2";
            this.btn_wurf2_2.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf2_2.TabIndex = 40;
            this.btn_wurf2_2.Text = "2";
            this.btn_wurf2_2.UseVisualStyleBackColor = true;
            this.btn_wurf2_2.Click += new System.EventHandler(this.btn_wurf2_2_Click);
            // 
            // tBx_wurf2
            // 
            this.tBx_wurf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_wurf2.Location = new System.Drawing.Point(187, 65);
            this.tBx_wurf2.Name = "tBx_wurf2";
            this.tBx_wurf2.ReadOnly = true;
            this.tBx_wurf2.Size = new System.Drawing.Size(174, 30);
            this.tBx_wurf2.TabIndex = 39;
            this.tBx_wurf2.Text = "3x20";
            this.tBx_wurf2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_doubleBullWurf1
            // 
            this.btn_doubleBullWurf1.Location = new System.Drawing.Point(97, 209);
            this.btn_doubleBullWurf1.Name = "btn_doubleBullWurf1";
            this.btn_doubleBullWurf1.Size = new System.Drawing.Size(85, 30);
            this.btn_doubleBullWurf1.TabIndex = 38;
            this.btn_doubleBullWurf1.Text = "2x Bull";
            this.btn_doubleBullWurf1.UseVisualStyleBackColor = true;
            this.btn_doubleBullWurf1.Click += new System.EventHandler(this.btn_doubleBullWurf1_Click);
            // 
            // btn_bullWurf1
            // 
            this.btn_bullWurf1.Location = new System.Drawing.Point(7, 209);
            this.btn_bullWurf1.Name = "btn_bullWurf1";
            this.btn_bullWurf1.Size = new System.Drawing.Size(85, 30);
            this.btn_bullWurf1.TabIndex = 37;
            this.btn_bullWurf1.Text = "Bull";
            this.btn_bullWurf1.UseVisualStyleBackColor = true;
            this.btn_bullWurf1.Click += new System.EventHandler(this.btn_bullWurf1_Click);
            // 
            // btn_dreimalWurf1
            // 
            this.btn_dreimalWurf1.Location = new System.Drawing.Point(7, 173);
            this.btn_dreimalWurf1.Name = "btn_dreimalWurf1";
            this.btn_dreimalWurf1.Size = new System.Drawing.Size(174, 30);
            this.btn_dreimalWurf1.TabIndex = 36;
            this.btn_dreimalWurf1.Text = "3x";
            this.btn_dreimalWurf1.UseVisualStyleBackColor = true;
            this.btn_dreimalWurf1.Click += new System.EventHandler(this.btn_dreimalWurf1_Click);
            // 
            // btn_zweimalWurf1
            // 
            this.btn_zweimalWurf1.Location = new System.Drawing.Point(7, 137);
            this.btn_zweimalWurf1.Name = "btn_zweimalWurf1";
            this.btn_zweimalWurf1.Size = new System.Drawing.Size(174, 30);
            this.btn_zweimalWurf1.TabIndex = 35;
            this.btn_zweimalWurf1.Text = "2x";
            this.btn_zweimalWurf1.UseVisualStyleBackColor = true;
            this.btn_zweimalWurf1.Click += new System.EventHandler(this.btn_zweimalWurf1_Click);
            // 
            // btn_einmalWurf1
            // 
            this.btn_einmalWurf1.Location = new System.Drawing.Point(7, 101);
            this.btn_einmalWurf1.Name = "btn_einmalWurf1";
            this.btn_einmalWurf1.Size = new System.Drawing.Size(174, 30);
            this.btn_einmalWurf1.TabIndex = 34;
            this.btn_einmalWurf1.Text = "1x";
            this.btn_einmalWurf1.UseVisualStyleBackColor = true;
            this.btn_einmalWurf1.Click += new System.EventHandler(this.btn_einmalWurf1_Click);
            // 
            // btn_wurf1_16
            // 
            this.btn_wurf1_16.Location = new System.Drawing.Point(7, 209);
            this.btn_wurf1_16.Name = "btn_wurf1_16";
            this.btn_wurf1_16.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_16.TabIndex = 33;
            this.btn_wurf1_16.Text = "16";
            this.btn_wurf1_16.UseVisualStyleBackColor = true;
            this.btn_wurf1_16.Click += new System.EventHandler(this.btn_wurf1_16_Click);
            // 
            // btn_wurf1_20
            // 
            this.btn_wurf1_20.Location = new System.Drawing.Point(151, 209);
            this.btn_wurf1_20.Name = "btn_wurf1_20";
            this.btn_wurf1_20.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_20.TabIndex = 32;
            this.btn_wurf1_20.Text = "20";
            this.btn_wurf1_20.UseVisualStyleBackColor = true;
            this.btn_wurf1_20.Click += new System.EventHandler(this.btn_wurf1_20_Click);
            // 
            // btn_wurf1_19
            // 
            this.btn_wurf1_19.Location = new System.Drawing.Point(115, 209);
            this.btn_wurf1_19.Name = "btn_wurf1_19";
            this.btn_wurf1_19.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_19.TabIndex = 31;
            this.btn_wurf1_19.Text = "19";
            this.btn_wurf1_19.UseVisualStyleBackColor = true;
            this.btn_wurf1_19.Click += new System.EventHandler(this.btn_wurf1_19_Click);
            // 
            // btn_wurf1_18
            // 
            this.btn_wurf1_18.Location = new System.Drawing.Point(79, 209);
            this.btn_wurf1_18.Name = "btn_wurf1_18";
            this.btn_wurf1_18.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_18.TabIndex = 30;
            this.btn_wurf1_18.Text = "18";
            this.btn_wurf1_18.UseVisualStyleBackColor = true;
            this.btn_wurf1_18.Click += new System.EventHandler(this.btn_wurf1_18_Click);
            // 
            // btn_wurf1_17
            // 
            this.btn_wurf1_17.Location = new System.Drawing.Point(43, 209);
            this.btn_wurf1_17.Name = "btn_wurf1_17";
            this.btn_wurf1_17.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_17.TabIndex = 29;
            this.btn_wurf1_17.Text = "17";
            this.btn_wurf1_17.UseVisualStyleBackColor = true;
            this.btn_wurf1_17.Click += new System.EventHandler(this.btn_wurf1_17_Click);
            // 
            // btn_wurf1_11
            // 
            this.btn_wurf1_11.Location = new System.Drawing.Point(7, 173);
            this.btn_wurf1_11.Name = "btn_wurf1_11";
            this.btn_wurf1_11.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_11.TabIndex = 28;
            this.btn_wurf1_11.Text = "11";
            this.btn_wurf1_11.UseVisualStyleBackColor = true;
            this.btn_wurf1_11.Click += new System.EventHandler(this.btn_wurf1_11_Click);
            // 
            // btn_wurf1_15
            // 
            this.btn_wurf1_15.Location = new System.Drawing.Point(151, 173);
            this.btn_wurf1_15.Name = "btn_wurf1_15";
            this.btn_wurf1_15.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_15.TabIndex = 27;
            this.btn_wurf1_15.Text = "15";
            this.btn_wurf1_15.UseVisualStyleBackColor = true;
            this.btn_wurf1_15.Click += new System.EventHandler(this.btn_wurf1_15_Click);
            // 
            // btn_wurf1_14
            // 
            this.btn_wurf1_14.Location = new System.Drawing.Point(115, 173);
            this.btn_wurf1_14.Name = "btn_wurf1_14";
            this.btn_wurf1_14.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_14.TabIndex = 26;
            this.btn_wurf1_14.Text = "14";
            this.btn_wurf1_14.UseVisualStyleBackColor = true;
            this.btn_wurf1_14.Click += new System.EventHandler(this.btn_wurf1_14_Click);
            // 
            // btn_wurf1_13
            // 
            this.btn_wurf1_13.Location = new System.Drawing.Point(79, 173);
            this.btn_wurf1_13.Name = "btn_wurf1_13";
            this.btn_wurf1_13.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_13.TabIndex = 25;
            this.btn_wurf1_13.Text = "13";
            this.btn_wurf1_13.UseVisualStyleBackColor = true;
            this.btn_wurf1_13.Click += new System.EventHandler(this.btn_wurf1_13_Click);
            // 
            // btn_wurf1_12
            // 
            this.btn_wurf1_12.Location = new System.Drawing.Point(43, 173);
            this.btn_wurf1_12.Name = "btn_wurf1_12";
            this.btn_wurf1_12.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_12.TabIndex = 24;
            this.btn_wurf1_12.Text = "12";
            this.btn_wurf1_12.UseVisualStyleBackColor = true;
            this.btn_wurf1_12.Click += new System.EventHandler(this.btn_wurf1_12_Click);
            // 
            // btn_wurf1_6
            // 
            this.btn_wurf1_6.Location = new System.Drawing.Point(7, 137);
            this.btn_wurf1_6.Name = "btn_wurf1_6";
            this.btn_wurf1_6.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_6.TabIndex = 23;
            this.btn_wurf1_6.Text = "6";
            this.btn_wurf1_6.UseVisualStyleBackColor = true;
            this.btn_wurf1_6.Click += new System.EventHandler(this.btn_wurf1_6_Click);
            // 
            // btn_wurf1_10
            // 
            this.btn_wurf1_10.Location = new System.Drawing.Point(151, 137);
            this.btn_wurf1_10.Name = "btn_wurf1_10";
            this.btn_wurf1_10.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_10.TabIndex = 22;
            this.btn_wurf1_10.Text = "10";
            this.btn_wurf1_10.UseVisualStyleBackColor = true;
            this.btn_wurf1_10.Click += new System.EventHandler(this.btn_wurf1_10_Click);
            // 
            // btn_wurf1_9
            // 
            this.btn_wurf1_9.Location = new System.Drawing.Point(115, 137);
            this.btn_wurf1_9.Name = "btn_wurf1_9";
            this.btn_wurf1_9.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_9.TabIndex = 21;
            this.btn_wurf1_9.Text = "9";
            this.btn_wurf1_9.UseVisualStyleBackColor = true;
            this.btn_wurf1_9.Click += new System.EventHandler(this.btn_wurf1_9_Click);
            // 
            // btn_wurf1_8
            // 
            this.btn_wurf1_8.Location = new System.Drawing.Point(79, 137);
            this.btn_wurf1_8.Name = "btn_wurf1_8";
            this.btn_wurf1_8.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_8.TabIndex = 20;
            this.btn_wurf1_8.Text = "8";
            this.btn_wurf1_8.UseVisualStyleBackColor = true;
            this.btn_wurf1_8.Click += new System.EventHandler(this.btn_wurf1_8_Click);
            // 
            // btn_wurf1_7
            // 
            this.btn_wurf1_7.Location = new System.Drawing.Point(43, 137);
            this.btn_wurf1_7.Name = "btn_wurf1_7";
            this.btn_wurf1_7.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_7.TabIndex = 19;
            this.btn_wurf1_7.Text = "7";
            this.btn_wurf1_7.UseVisualStyleBackColor = true;
            this.btn_wurf1_7.Click += new System.EventHandler(this.btn_wurf1_7_Click);
            // 
            // btn_wurf1_1
            // 
            this.btn_wurf1_1.Location = new System.Drawing.Point(7, 101);
            this.btn_wurf1_1.Name = "btn_wurf1_1";
            this.btn_wurf1_1.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_1.TabIndex = 18;
            this.btn_wurf1_1.Text = "1";
            this.btn_wurf1_1.UseVisualStyleBackColor = true;
            this.btn_wurf1_1.Click += new System.EventHandler(this.btn_wurf1_1_Click);
            // 
            // btn_wurf1_5
            // 
            this.btn_wurf1_5.Location = new System.Drawing.Point(151, 101);
            this.btn_wurf1_5.Name = "btn_wurf1_5";
            this.btn_wurf1_5.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_5.TabIndex = 17;
            this.btn_wurf1_5.Text = "5";
            this.btn_wurf1_5.UseVisualStyleBackColor = true;
            this.btn_wurf1_5.Click += new System.EventHandler(this.btn_wurf1_5_Click);
            // 
            // btn_wurf1_4
            // 
            this.btn_wurf1_4.Location = new System.Drawing.Point(115, 101);
            this.btn_wurf1_4.Name = "btn_wurf1_4";
            this.btn_wurf1_4.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_4.TabIndex = 16;
            this.btn_wurf1_4.Text = "4";
            this.btn_wurf1_4.UseVisualStyleBackColor = true;
            this.btn_wurf1_4.Click += new System.EventHandler(this.btn_wurf1_4_Click);
            // 
            // btn_wurf1_3
            // 
            this.btn_wurf1_3.Location = new System.Drawing.Point(79, 101);
            this.btn_wurf1_3.Name = "btn_wurf1_3";
            this.btn_wurf1_3.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_3.TabIndex = 15;
            this.btn_wurf1_3.Text = "3";
            this.btn_wurf1_3.UseVisualStyleBackColor = true;
            this.btn_wurf1_3.Click += new System.EventHandler(this.btn_wurf1_3_Click);
            // 
            // btn_wurf1_2
            // 
            this.btn_wurf1_2.Location = new System.Drawing.Point(43, 101);
            this.btn_wurf1_2.Name = "btn_wurf1_2";
            this.btn_wurf1_2.Size = new System.Drawing.Size(30, 30);
            this.btn_wurf1_2.TabIndex = 14;
            this.btn_wurf1_2.Text = "2";
            this.btn_wurf1_2.UseVisualStyleBackColor = true;
            this.btn_wurf1_2.Click += new System.EventHandler(this.btn_wurf1_2_Click);
            // 
            // tBx_wurf1
            // 
            this.tBx_wurf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_wurf1.Location = new System.Drawing.Point(7, 65);
            this.tBx_wurf1.Name = "tBx_wurf1";
            this.tBx_wurf1.ReadOnly = true;
            this.tBx_wurf1.Size = new System.Drawing.Size(174, 30);
            this.tBx_wurf1.TabIndex = 0;
            this.tBx_wurf1.Text = "3x20";
            this.tBx_wurf1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SpielView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 561);
            this.ControlBox = false;
            this.Controls.Add(groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpielView";
            this.Text = "SpielView";
            this.Load += new System.EventHandler(this.SpielView_Load);
            groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_set;
        private System.Windows.Forms.Label lbl_leg;
        private System.Windows.Forms.Label lbl_rest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pfeilSpieler1;
        private System.Windows.Forms.Label lbl_pfeilSpieler2;
        private System.Windows.Forms.Label lbl_pfeilSpieler3;
        private System.Windows.Forms.Label lbl_pfeilSpieler4;
        private System.Windows.Forms.Label lbl_pfeilSpieler5;
        private System.Windows.Forms.Label lbl_pfeilSpieler6;
        private System.Windows.Forms.Label lbl_pfeilSpieler7;
        private System.Windows.Forms.Label lbl_pfeilSpieler8;
        private System.Windows.Forms.Label lbl_nameSpieler1;
        private System.Windows.Forms.Label lbl_nameSpieler2;
        private System.Windows.Forms.Label lbl_nameSpieler3;
        private System.Windows.Forms.Label lbl_nameSpieler4;
        private System.Windows.Forms.Label lbl_nameSpieler5;
        private System.Windows.Forms.Label lbl_nameSpieler6;
        private System.Windows.Forms.Label lbl_nameSpieler7;
        private System.Windows.Forms.Label lbl_nameSpieler8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_wurf3;
        private System.Windows.Forms.Label lbl_wurf2;
        private System.Windows.Forms.Label lbl_wurf1;
        private System.Windows.Forms.Button btn_doubleBullWurf3;
        private System.Windows.Forms.Button btn_bullWurf3;
        private System.Windows.Forms.Button btn_dreimalWurf3;
        private System.Windows.Forms.Button btn_zweimalWurf3;
        private System.Windows.Forms.Button btn_einmalWurf3;
        private System.Windows.Forms.Button btn_wurf3_16;
        private System.Windows.Forms.Button btn_wurf3_20;
        private System.Windows.Forms.Button btn_wurf3_19;
        private System.Windows.Forms.Button btn_wurf3_18;
        private System.Windows.Forms.Button btn_wurf3_17;
        private System.Windows.Forms.Button btn_wurf3_11;
        private System.Windows.Forms.Button btn_wurf3_15;
        private System.Windows.Forms.Button btn_wurf3_14;
        private System.Windows.Forms.Button btn_wurf3_13;
        private System.Windows.Forms.Button btn_wurf3_12;
        private System.Windows.Forms.Button btn_wurf3_6;
        private System.Windows.Forms.Button btn_wurf3_10;
        private System.Windows.Forms.Button btn_wurf3_9;
        private System.Windows.Forms.Button btn_wurf3_8;
        private System.Windows.Forms.Button btn_wurf3_7;
        private System.Windows.Forms.Button btn_wurf3_1;
        private System.Windows.Forms.Button btn_wurf3_5;
        private System.Windows.Forms.Button btn_wurf3_4;
        private System.Windows.Forms.Button btn_wurf3_3;
        private System.Windows.Forms.Button btn_wurf3_2;
        private System.Windows.Forms.TextBox tBx_wurf3;
        private System.Windows.Forms.Button btn_doubleBullWurf2;
        private System.Windows.Forms.Button btn_bullWurf2;
        private System.Windows.Forms.Button btn_dreimalWurf2;
        private System.Windows.Forms.Button btn_zweimalWurf2;
        private System.Windows.Forms.Button btn_einmalWurf2;
        private System.Windows.Forms.Button btn_wurf2_16;
        private System.Windows.Forms.Button btn_wurf2_20;
        private System.Windows.Forms.Button btn_wurf2_19;
        private System.Windows.Forms.Button btn_wurf2_18;
        private System.Windows.Forms.Button btn_wurf2_17;
        private System.Windows.Forms.Button btn_wurf2_11;
        private System.Windows.Forms.Button btn_wurf2_15;
        private System.Windows.Forms.Button btn_wurf2_14;
        private System.Windows.Forms.Button btn_wurf2_13;
        private System.Windows.Forms.Button btn_wurf2_12;
        private System.Windows.Forms.Button btn_wurf2_6;
        private System.Windows.Forms.Button btn_wurf2_10;
        private System.Windows.Forms.Button btn_wurf2_9;
        private System.Windows.Forms.Button btn_wurf2_8;
        private System.Windows.Forms.Button btn_wurf2_7;
        private System.Windows.Forms.Button btn_wurf2_1;
        private System.Windows.Forms.Button btn_wurf2_5;
        private System.Windows.Forms.Button btn_wurf2_4;
        private System.Windows.Forms.Button btn_wurf2_3;
        private System.Windows.Forms.Button btn_wurf2_2;
        private System.Windows.Forms.TextBox tBx_wurf2;
        private System.Windows.Forms.Button btn_doubleBullWurf1;
        private System.Windows.Forms.Button btn_bullWurf1;
        private System.Windows.Forms.Button btn_dreimalWurf1;
        private System.Windows.Forms.Button btn_zweimalWurf1;
        private System.Windows.Forms.Button btn_einmalWurf1;
        private System.Windows.Forms.Button btn_wurf1_16;
        private System.Windows.Forms.Button btn_wurf1_20;
        private System.Windows.Forms.Button btn_wurf1_19;
        private System.Windows.Forms.Button btn_wurf1_18;
        private System.Windows.Forms.Button btn_wurf1_17;
        private System.Windows.Forms.Button btn_wurf1_11;
        private System.Windows.Forms.Button btn_wurf1_15;
        private System.Windows.Forms.Button btn_wurf1_14;
        private System.Windows.Forms.Button btn_wurf1_13;
        private System.Windows.Forms.Button btn_wurf1_12;
        private System.Windows.Forms.Button btn_wurf1_6;
        private System.Windows.Forms.Button btn_wurf1_10;
        private System.Windows.Forms.Button btn_wurf1_9;
        private System.Windows.Forms.Button btn_wurf1_8;
        private System.Windows.Forms.Button btn_wurf1_7;
        private System.Windows.Forms.Button btn_wurf1_1;
        private System.Windows.Forms.Button btn_wurf1_5;
        private System.Windows.Forms.Button btn_wurf1_4;
        private System.Windows.Forms.Button btn_wurf1_3;
        private System.Windows.Forms.Button btn_wurf1_2;
        private System.Windows.Forms.TextBox tBx_wurf1;
        private System.Windows.Forms.Label lbl_setSpieler1;
        private System.Windows.Forms.Label lbl_legSpieler1;
        private System.Windows.Forms.Label lbl_restSpieler1;
        private System.Windows.Forms.Label lbl_setSpieler2;
        private System.Windows.Forms.Label lbl_legSpieler2;
        private System.Windows.Forms.Label lbl_restSpieler2;
        private System.Windows.Forms.Label lbl_setSpieler3;
        private System.Windows.Forms.Label lbl_legSpieler3;
        private System.Windows.Forms.Label lbl_restSpieler3;
        private System.Windows.Forms.Label lbl_setSpieler4;
        private System.Windows.Forms.Label lbl_legSpieler4;
        private System.Windows.Forms.Label lbl_restSpieler4;
        private System.Windows.Forms.Label lbl_setSpieler5;
        private System.Windows.Forms.Label lbl_legSpieler5;
        private System.Windows.Forms.Label lbl_restSpieler5;
        private System.Windows.Forms.Label lbl_setSpieler6;
        private System.Windows.Forms.Label lbl_legSpieler6;
        private System.Windows.Forms.Label lbl_restSpieler6;
        private System.Windows.Forms.Label lbl_setSpieler7;
        private System.Windows.Forms.Label lbl_legSpieler7;
        private System.Windows.Forms.Label lbl_restSpieler7;
        private System.Windows.Forms.Label lbl_setSpieler8;
        private System.Windows.Forms.Label lbl_legSpieler8;
        private System.Windows.Forms.Label lbl_restSpieler8;
        private System.Windows.Forms.Label lbl_checkSpieler1;
        private System.Windows.Forms.Label lbl_checkSpieler2;
        private System.Windows.Forms.Label lbl_checkSpieler3;
        private System.Windows.Forms.Label lbl_checkSpieler4;
        private System.Windows.Forms.Label lbl_checkSpieler5;
        private System.Windows.Forms.Label lbl_checkSpieler6;
        private System.Windows.Forms.Label lbl_checkSpieler7;
        private System.Windows.Forms.Label lbl_checkSpieler8;
        private System.Windows.Forms.Button btn_nullWurf3;
        private System.Windows.Forms.Button btn_nullWurf2;
        private System.Windows.Forms.Button btn_nullWurf1;
        private System.Windows.Forms.Button btn_loeschen;
        private System.Windows.Forms.Button btn_uebernehmen;
        private System.Windows.Forms.Button btn_beenden;
        private System.Windows.Forms.Label lbl_avgSpieler1;
        private System.Windows.Forms.Label lbl_avgSpieler2;
        private System.Windows.Forms.Label lbl_avgSpieler3;
        private System.Windows.Forms.Label lbl_avgSpieler4;
        private System.Windows.Forms.Label lbl_avgSpieler5;
        private System.Windows.Forms.Label lbl_avgSpieler6;
        private System.Windows.Forms.Label lbl_avgSpieler7;
        private System.Windows.Forms.Label lbl_avgSpieler8;
        private System.Windows.Forms.Label lbl_avg;
        private System.Windows.Forms.Label lbl_dq;
        private System.Windows.Forms.Label lbl_dqSpieler1;
        private System.Windows.Forms.Label lbl_dqSpieler2;
        private System.Windows.Forms.Label lbl_dqSpieler3;
        private System.Windows.Forms.Label lbl_dqSpieler4;
        private System.Windows.Forms.Label lbl_dqSpieler5;
        private System.Windows.Forms.Label lbl_dqSpieler6;
        private System.Windows.Forms.Label lbl_dqSpieler7;
        private System.Windows.Forms.Label lbl_dqSpieler8;
        private System.Windows.Forms.ComboBox cB_zielWurf1;
        private System.Windows.Forms.ComboBox cB_zielWurf3;
        private System.Windows.Forms.ComboBox cB_zielWurf2;
        private System.Windows.Forms.Button btn_weiter;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RadioButton rbKlickEingabe;
        private System.Windows.Forms.RadioButton rbSpracheingabe;
        private System.Windows.Forms.Label lblSpracheWertW3;
        private System.Windows.Forms.Label lblSpracheMultiW1;
        private System.Windows.Forms.Label lblSpracheWertW2;
        private System.Windows.Forms.Label lblSpracheWertW1;
        private System.Windows.Forms.Label lblSpracheMultiW2;
        private System.Windows.Forms.Label lblSpracheMultiW3;
        private System.Windows.Forms.Button btnEingabeStarten;
    }
}