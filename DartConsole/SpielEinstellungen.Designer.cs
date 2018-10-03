namespace DartConsole
{
    partial class SpielEinstellungen
    {
        System.Windows.Forms.Label[] lblArraySpieler = new System.Windows.Forms.Label[8];
        System.Windows.Forms.TextBox[] tBArraySpieler = new System.Windows.Forms.TextBox[8];
        System.Windows.Forms.RadioButton[] rBArraySpieler = new System.Windows.Forms.RadioButton[8];

        private void FormsInArray()
        {
            lblArraySpieler[0] = lbl_spieler1;
            lblArraySpieler[1] = lbl_spieler2;
            lblArraySpieler[2] = lbl_spieler3;
            lblArraySpieler[3] = lbl_spieler4;
            lblArraySpieler[4] = lbl_spieler5;
            lblArraySpieler[5] = lbl_spieler6;
            lblArraySpieler[6] = lbl_spieler7;
            lblArraySpieler[7] = lbl_spieler8;

            tBArraySpieler[0] = tBx_spieler1;
            tBArraySpieler[1] = tBx_spieler2;
            tBArraySpieler[2] = tBx_spieler3;
            tBArraySpieler[3] = tBx_spieler4;
            tBArraySpieler[4] = tBx_spieler5;
            tBArraySpieler[5] = tBx_spieler6;
            tBArraySpieler[6] = tBx_spieler7;
            tBArraySpieler[7] = tBx_spieler8;

            rBArraySpieler[0] = rB_spieler1;
            rBArraySpieler[1] = rB_spieler2;
            rBArraySpieler[2] = rB_spieler3;
            rBArraySpieler[3] = rB_spieler4;
            rBArraySpieler[4] = rB_spieler5;
            rBArraySpieler[5] = rB_spieler6;
            rBArraySpieler[6] = rB_spieler7;
            rBArraySpieler[7] = rB_spieler8;
        }

        private void ClearAllTB()
        {
            for (int i = 0; i < 8; i++)
            {
                tBArraySpieler[i].Clear();
                tBArraySpieler[i].ReadOnly = false;
            }
        }

        private void CheckSpielleiterOutOfBouce()
        {

        }

        private int WhereChecked()
        {
            for (int i = 0; i < 8; i++)
            {
                if (rBArraySpieler[i].Checked)
                {
                    return i;
                }
            }
            return 0;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpielEinstellungen));
            this.comB_spielvariante = new System.Windows.Forms.ComboBox();
            this.comB_rest = new System.Windows.Forms.ComboBox();
            this.lbl_spielvariante = new System.Windows.Forms.Label();
            this.lbl_rest = new System.Windows.Forms.Label();
            this.lbl_saetze = new System.Windows.Forms.Label();
            this.lbl_legs = new System.Windows.Forms.Label();
            this.numUpDown_saetze = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_legs = new System.Windows.Forms.NumericUpDown();
            this.lbl_anzahlSpieler = new System.Windows.Forms.Label();
            this.numUpDown_anzahlSpieler = new System.Windows.Forms.NumericUpDown();
            this.lbl_spieler1 = new System.Windows.Forms.Label();
            this.tBx_spieler1 = new System.Windows.Forms.TextBox();
            this.tBx_spieler2 = new System.Windows.Forms.TextBox();
            this.lbl_spieler2 = new System.Windows.Forms.Label();
            this.tBx_spieler3 = new System.Windows.Forms.TextBox();
            this.lbl_spieler3 = new System.Windows.Forms.Label();
            this.tBx_spieler5 = new System.Windows.Forms.TextBox();
            this.lbl_spieler5 = new System.Windows.Forms.Label();
            this.tBx_spieler6 = new System.Windows.Forms.TextBox();
            this.lbl_spieler6 = new System.Windows.Forms.Label();
            this.tBx_spieler7 = new System.Windows.Forms.TextBox();
            this.lbl_spieler7 = new System.Windows.Forms.Label();
            this.tBx_spieler4 = new System.Windows.Forms.TextBox();
            this.lbl_spieler4 = new System.Windows.Forms.Label();
            this.tBx_spieler8 = new System.Windows.Forms.TextBox();
            this.lbl_spieler8 = new System.Windows.Forms.Label();
            this.lbl_ueberschriftMitspieler = new System.Windows.Forms.Label();
            this.rB_spieler1 = new System.Windows.Forms.RadioButton();
            this.rB_spieler2 = new System.Windows.Forms.RadioButton();
            this.rB_spieler3 = new System.Windows.Forms.RadioButton();
            this.rB_spieler4 = new System.Windows.Forms.RadioButton();
            this.rB_spieler5 = new System.Windows.Forms.RadioButton();
            this.rB_spieler6 = new System.Windows.Forms.RadioButton();
            this.rB_spieler7 = new System.Windows.Forms.RadioButton();
            this.rB_spieler8 = new System.Windows.Forms.RadioButton();
            this.btn_newSpieler = new System.Windows.Forms.Button();
            this.btn_starten = new System.Windows.Forms.Button();
            this.btn_zurueck = new System.Windows.Forms.Button();
            this.cbSpeech = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_saetze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_legs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_anzahlSpieler)).BeginInit();
            this.SuspendLayout();
            // 
            // comB_spielvariante
            // 
            this.comB_spielvariante.Enabled = false;
            this.comB_spielvariante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comB_spielvariante.FormattingEnabled = true;
            this.comB_spielvariante.Location = new System.Drawing.Point(379, 53);
            this.comB_spielvariante.Name = "comB_spielvariante";
            this.comB_spielvariante.Size = new System.Drawing.Size(188, 28);
            this.comB_spielvariante.TabIndex = 0;
            this.comB_spielvariante.Text = "Standart - Double Out";
            // 
            // comB_rest
            // 
            this.comB_rest.Enabled = false;
            this.comB_rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comB_rest.FormattingEnabled = true;
            this.comB_rest.Location = new System.Drawing.Point(379, 94);
            this.comB_rest.Name = "comB_rest";
            this.comB_rest.Size = new System.Drawing.Size(188, 28);
            this.comB_rest.TabIndex = 1;
            this.comB_rest.Text = "501";
            // 
            // lbl_spielvariante
            // 
            this.lbl_spielvariante.AutoSize = true;
            this.lbl_spielvariante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spielvariante.Location = new System.Drawing.Point(273, 53);
            this.lbl_spielvariante.Name = "lbl_spielvariante";
            this.lbl_spielvariante.Size = new System.Drawing.Size(100, 20);
            this.lbl_spielvariante.TabIndex = 2;
            this.lbl_spielvariante.Text = "Spielvariante";
            this.lbl_spielvariante.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_rest
            // 
            this.lbl_rest.AutoSize = true;
            this.lbl_rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rest.Location = new System.Drawing.Point(273, 97);
            this.lbl_rest.Name = "lbl_rest";
            this.lbl_rest.Size = new System.Drawing.Size(43, 20);
            this.lbl_rest.TabIndex = 3;
            this.lbl_rest.Text = "Rest";
            // 
            // lbl_saetze
            // 
            this.lbl_saetze.AutoSize = true;
            this.lbl_saetze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saetze.Location = new System.Drawing.Point(14, 53);
            this.lbl_saetze.Name = "lbl_saetze";
            this.lbl_saetze.Size = new System.Drawing.Size(51, 20);
            this.lbl_saetze.TabIndex = 4;
            this.lbl_saetze.Text = "Sätze";
            // 
            // lbl_legs
            // 
            this.lbl_legs.AutoSize = true;
            this.lbl_legs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_legs.Location = new System.Drawing.Point(14, 94);
            this.lbl_legs.Name = "lbl_legs";
            this.lbl_legs.Size = new System.Drawing.Size(108, 20);
            this.lbl_legs.TabIndex = 6;
            this.lbl_legs.Text = "Legs pro Satz";
            // 
            // numUpDown_saetze
            // 
            this.numUpDown_saetze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_saetze.Location = new System.Drawing.Point(128, 51);
            this.numUpDown_saetze.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_saetze.Name = "numUpDown_saetze";
            this.numUpDown_saetze.Size = new System.Drawing.Size(120, 26);
            this.numUpDown_saetze.TabIndex = 7;
            this.numUpDown_saetze.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_saetze.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numUpDown_legs
            // 
            this.numUpDown_legs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_legs.Location = new System.Drawing.Point(128, 92);
            this.numUpDown_legs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_legs.Name = "numUpDown_legs";
            this.numUpDown_legs.Size = new System.Drawing.Size(120, 26);
            this.numUpDown_legs.TabIndex = 8;
            this.numUpDown_legs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_anzahlSpieler
            // 
            this.lbl_anzahlSpieler.AutoSize = true;
            this.lbl_anzahlSpieler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anzahlSpieler.Location = new System.Drawing.Point(12, 9);
            this.lbl_anzahlSpieler.Name = "lbl_anzahlSpieler";
            this.lbl_anzahlSpieler.Size = new System.Drawing.Size(111, 20);
            this.lbl_anzahlSpieler.TabIndex = 9;
            this.lbl_anzahlSpieler.Text = "Anzahl Spieler";
            // 
            // numUpDown_anzahlSpieler
            // 
            this.numUpDown_anzahlSpieler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_anzahlSpieler.Location = new System.Drawing.Point(129, 7);
            this.numUpDown_anzahlSpieler.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUpDown_anzahlSpieler.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_anzahlSpieler.Name = "numUpDown_anzahlSpieler";
            this.numUpDown_anzahlSpieler.Size = new System.Drawing.Size(120, 26);
            this.numUpDown_anzahlSpieler.TabIndex = 10;
            this.numUpDown_anzahlSpieler.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_anzahlSpieler.ValueChanged += new System.EventHandler(this.numUpDown_anzahlSpieler_ValueChanged);
            // 
            // lbl_spieler1
            // 
            this.lbl_spieler1.AutoSize = true;
            this.lbl_spieler1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spieler1.Location = new System.Drawing.Point(8, 182);
            this.lbl_spieler1.Name = "lbl_spieler1";
            this.lbl_spieler1.Size = new System.Drawing.Size(71, 20);
            this.lbl_spieler1.TabIndex = 11;
            this.lbl_spieler1.Text = "Spieler 1";
            this.lbl_spieler1.Click += new System.EventHandler(this.label3_Click);
            // 
            // tBx_spieler1
            // 
            this.tBx_spieler1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_spieler1.Location = new System.Drawing.Point(12, 205);
            this.tBx_spieler1.Name = "tBx_spieler1";
            this.tBx_spieler1.ReadOnly = true;
            this.tBx_spieler1.Size = new System.Drawing.Size(175, 26);
            this.tBx_spieler1.TabIndex = 19;
            this.tBx_spieler1.Text = "UsernameSpielleiter";
            this.tBx_spieler1.TextChanged += new System.EventHandler(this.tBx_spieler1_TextChanged);
            // 
            // tBx_spieler2
            // 
            this.tBx_spieler2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_spieler2.Location = new System.Drawing.Point(12, 268);
            this.tBx_spieler2.Name = "tBx_spieler2";
            this.tBx_spieler2.Size = new System.Drawing.Size(175, 26);
            this.tBx_spieler2.TabIndex = 21;
            this.tBx_spieler2.Visible = false;
            this.tBx_spieler2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_spieler2
            // 
            this.lbl_spieler2.AutoSize = true;
            this.lbl_spieler2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spieler2.Location = new System.Drawing.Point(8, 245);
            this.lbl_spieler2.Name = "lbl_spieler2";
            this.lbl_spieler2.Size = new System.Drawing.Size(71, 20);
            this.lbl_spieler2.TabIndex = 20;
            this.lbl_spieler2.Text = "Spieler 2";
            this.lbl_spieler2.Visible = false;
            this.lbl_spieler2.Click += new System.EventHandler(this.label4_Click);
            // 
            // tBx_spieler3
            // 
            this.tBx_spieler3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_spieler3.Location = new System.Drawing.Point(14, 329);
            this.tBx_spieler3.Name = "tBx_spieler3";
            this.tBx_spieler3.Size = new System.Drawing.Size(175, 26);
            this.tBx_spieler3.TabIndex = 23;
            this.tBx_spieler3.Visible = false;
            this.tBx_spieler3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbl_spieler3
            // 
            this.lbl_spieler3.AutoSize = true;
            this.lbl_spieler3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spieler3.Location = new System.Drawing.Point(10, 306);
            this.lbl_spieler3.Name = "lbl_spieler3";
            this.lbl_spieler3.Size = new System.Drawing.Size(71, 20);
            this.lbl_spieler3.TabIndex = 22;
            this.lbl_spieler3.Text = "Spieler 3";
            this.lbl_spieler3.Visible = false;
            this.lbl_spieler3.Click += new System.EventHandler(this.label5_Click);
            // 
            // tBx_spieler5
            // 
            this.tBx_spieler5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_spieler5.Location = new System.Drawing.Point(330, 205);
            this.tBx_spieler5.Name = "tBx_spieler5";
            this.tBx_spieler5.Size = new System.Drawing.Size(175, 26);
            this.tBx_spieler5.TabIndex = 25;
            this.tBx_spieler5.Visible = false;
            this.tBx_spieler5.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lbl_spieler5
            // 
            this.lbl_spieler5.AutoSize = true;
            this.lbl_spieler5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spieler5.Location = new System.Drawing.Point(326, 182);
            this.lbl_spieler5.Name = "lbl_spieler5";
            this.lbl_spieler5.Size = new System.Drawing.Size(71, 20);
            this.lbl_spieler5.TabIndex = 24;
            this.lbl_spieler5.Text = "Spieler 5";
            this.lbl_spieler5.Visible = false;
            this.lbl_spieler5.Click += new System.EventHandler(this.label6_Click);
            // 
            // tBx_spieler6
            // 
            this.tBx_spieler6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_spieler6.Location = new System.Drawing.Point(330, 268);
            this.tBx_spieler6.Name = "tBx_spieler6";
            this.tBx_spieler6.Size = new System.Drawing.Size(175, 26);
            this.tBx_spieler6.TabIndex = 27;
            this.tBx_spieler6.Visible = false;
            this.tBx_spieler6.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lbl_spieler6
            // 
            this.lbl_spieler6.AutoSize = true;
            this.lbl_spieler6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spieler6.Location = new System.Drawing.Point(326, 245);
            this.lbl_spieler6.Name = "lbl_spieler6";
            this.lbl_spieler6.Size = new System.Drawing.Size(71, 20);
            this.lbl_spieler6.TabIndex = 26;
            this.lbl_spieler6.Text = "Spieler 6";
            this.lbl_spieler6.Visible = false;
            this.lbl_spieler6.Click += new System.EventHandler(this.label7_Click);
            // 
            // tBx_spieler7
            // 
            this.tBx_spieler7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_spieler7.Location = new System.Drawing.Point(330, 329);
            this.tBx_spieler7.Name = "tBx_spieler7";
            this.tBx_spieler7.Size = new System.Drawing.Size(175, 26);
            this.tBx_spieler7.TabIndex = 29;
            this.tBx_spieler7.Visible = false;
            this.tBx_spieler7.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lbl_spieler7
            // 
            this.lbl_spieler7.AutoSize = true;
            this.lbl_spieler7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spieler7.Location = new System.Drawing.Point(326, 306);
            this.lbl_spieler7.Name = "lbl_spieler7";
            this.lbl_spieler7.Size = new System.Drawing.Size(71, 20);
            this.lbl_spieler7.TabIndex = 28;
            this.lbl_spieler7.Text = "Spieler 7";
            this.lbl_spieler7.Visible = false;
            this.lbl_spieler7.Click += new System.EventHandler(this.label8_Click);
            // 
            // tBx_spieler4
            // 
            this.tBx_spieler4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_spieler4.Location = new System.Drawing.Point(14, 392);
            this.tBx_spieler4.Name = "tBx_spieler4";
            this.tBx_spieler4.Size = new System.Drawing.Size(175, 26);
            this.tBx_spieler4.TabIndex = 31;
            this.tBx_spieler4.Visible = false;
            this.tBx_spieler4.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lbl_spieler4
            // 
            this.lbl_spieler4.AutoSize = true;
            this.lbl_spieler4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spieler4.Location = new System.Drawing.Point(10, 369);
            this.lbl_spieler4.Name = "lbl_spieler4";
            this.lbl_spieler4.Size = new System.Drawing.Size(71, 20);
            this.lbl_spieler4.TabIndex = 30;
            this.lbl_spieler4.Text = "Spieler 4";
            this.lbl_spieler4.Visible = false;
            this.lbl_spieler4.Click += new System.EventHandler(this.label9_Click);
            // 
            // tBx_spieler8
            // 
            this.tBx_spieler8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_spieler8.Location = new System.Drawing.Point(330, 392);
            this.tBx_spieler8.Name = "tBx_spieler8";
            this.tBx_spieler8.Size = new System.Drawing.Size(175, 26);
            this.tBx_spieler8.TabIndex = 33;
            this.tBx_spieler8.Visible = false;
            this.tBx_spieler8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // lbl_spieler8
            // 
            this.lbl_spieler8.AutoSize = true;
            this.lbl_spieler8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spieler8.Location = new System.Drawing.Point(326, 369);
            this.lbl_spieler8.Name = "lbl_spieler8";
            this.lbl_spieler8.Size = new System.Drawing.Size(71, 20);
            this.lbl_spieler8.TabIndex = 32;
            this.lbl_spieler8.Text = "Spieler 8";
            this.lbl_spieler8.Visible = false;
            this.lbl_spieler8.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbl_ueberschriftMitspieler
            // 
            this.lbl_ueberschriftMitspieler.AutoSize = true;
            this.lbl_ueberschriftMitspieler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ueberschriftMitspieler.Location = new System.Drawing.Point(7, 147);
            this.lbl_ueberschriftMitspieler.Name = "lbl_ueberschriftMitspieler";
            this.lbl_ueberschriftMitspieler.Size = new System.Drawing.Size(202, 25);
            this.lbl_ueberschriftMitspieler.TabIndex = 34;
            this.lbl_ueberschriftMitspieler.Text = "Mitspieler - Username";
            // 
            // rB_spieler1
            // 
            this.rB_spieler1.AutoSize = true;
            this.rB_spieler1.Checked = true;
            this.rB_spieler1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_spieler1.Location = new System.Drawing.Point(193, 205);
            this.rB_spieler1.Name = "rB_spieler1";
            this.rB_spieler1.Size = new System.Drawing.Size(110, 24);
            this.rB_spieler1.TabIndex = 35;
            this.rB_spieler1.TabStop = true;
            this.rB_spieler1.Text = "Spielerleiter";
            this.rB_spieler1.UseVisualStyleBackColor = true;
            this.rB_spieler1.CheckedChanged += new System.EventHandler(this.rB_spieler1_CheckedChanged);
            // 
            // rB_spieler2
            // 
            this.rB_spieler2.AutoSize = true;
            this.rB_spieler2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_spieler2.Location = new System.Drawing.Point(193, 269);
            this.rB_spieler2.Name = "rB_spieler2";
            this.rB_spieler2.Size = new System.Drawing.Size(110, 24);
            this.rB_spieler2.TabIndex = 36;
            this.rB_spieler2.Text = "Spielerleiter";
            this.rB_spieler2.UseVisualStyleBackColor = true;
            this.rB_spieler2.Visible = false;
            this.rB_spieler2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rB_spieler3
            // 
            this.rB_spieler3.AutoSize = true;
            this.rB_spieler3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_spieler3.Location = new System.Drawing.Point(195, 330);
            this.rB_spieler3.Name = "rB_spieler3";
            this.rB_spieler3.Size = new System.Drawing.Size(110, 24);
            this.rB_spieler3.TabIndex = 37;
            this.rB_spieler3.Text = "Spielerleiter";
            this.rB_spieler3.UseVisualStyleBackColor = true;
            this.rB_spieler3.Visible = false;
            this.rB_spieler3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rB_spieler4
            // 
            this.rB_spieler4.AutoSize = true;
            this.rB_spieler4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_spieler4.Location = new System.Drawing.Point(195, 393);
            this.rB_spieler4.Name = "rB_spieler4";
            this.rB_spieler4.Size = new System.Drawing.Size(110, 24);
            this.rB_spieler4.TabIndex = 38;
            this.rB_spieler4.Text = "Spielerleiter";
            this.rB_spieler4.UseVisualStyleBackColor = true;
            this.rB_spieler4.Visible = false;
            this.rB_spieler4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rB_spieler5
            // 
            this.rB_spieler5.AutoSize = true;
            this.rB_spieler5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_spieler5.Location = new System.Drawing.Point(511, 206);
            this.rB_spieler5.Name = "rB_spieler5";
            this.rB_spieler5.Size = new System.Drawing.Size(110, 24);
            this.rB_spieler5.TabIndex = 39;
            this.rB_spieler5.Text = "Spielerleiter";
            this.rB_spieler5.UseVisualStyleBackColor = true;
            this.rB_spieler5.Visible = false;
            this.rB_spieler5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rB_spieler6
            // 
            this.rB_spieler6.AutoSize = true;
            this.rB_spieler6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_spieler6.Location = new System.Drawing.Point(511, 269);
            this.rB_spieler6.Name = "rB_spieler6";
            this.rB_spieler6.Size = new System.Drawing.Size(110, 24);
            this.rB_spieler6.TabIndex = 40;
            this.rB_spieler6.Text = "Spielerleiter";
            this.rB_spieler6.UseVisualStyleBackColor = true;
            this.rB_spieler6.Visible = false;
            this.rB_spieler6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // rB_spieler7
            // 
            this.rB_spieler7.AutoSize = true;
            this.rB_spieler7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_spieler7.Location = new System.Drawing.Point(511, 330);
            this.rB_spieler7.Name = "rB_spieler7";
            this.rB_spieler7.Size = new System.Drawing.Size(110, 24);
            this.rB_spieler7.TabIndex = 41;
            this.rB_spieler7.Text = "Spielerleiter";
            this.rB_spieler7.UseVisualStyleBackColor = true;
            this.rB_spieler7.Visible = false;
            this.rB_spieler7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // rB_spieler8
            // 
            this.rB_spieler8.AutoSize = true;
            this.rB_spieler8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_spieler8.Location = new System.Drawing.Point(511, 393);
            this.rB_spieler8.Name = "rB_spieler8";
            this.rB_spieler8.Size = new System.Drawing.Size(110, 24);
            this.rB_spieler8.TabIndex = 42;
            this.rB_spieler8.Text = "Spielerleiter";
            this.rB_spieler8.UseVisualStyleBackColor = true;
            this.rB_spieler8.Visible = false;
            this.rB_spieler8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // btn_newSpieler
            // 
            this.btn_newSpieler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newSpieler.Location = new System.Drawing.Point(215, 147);
            this.btn_newSpieler.Name = "btn_newSpieler";
            this.btn_newSpieler.Size = new System.Drawing.Size(352, 25);
            this.btn_newSpieler.TabIndex = 43;
            this.btn_newSpieler.Text = "neuer Spieler";
            this.btn_newSpieler.UseVisualStyleBackColor = true;
            this.btn_newSpieler.Click += new System.EventHandler(this.btn_newSpieler_Click);
            // 
            // btn_starten
            // 
            this.btn_starten.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_starten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_starten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_starten.Location = new System.Drawing.Point(628, 147);
            this.btn_starten.Name = "btn_starten";
            this.btn_starten.Size = new System.Drawing.Size(151, 271);
            this.btn_starten.TabIndex = 44;
            this.btn_starten.Text = "Starten";
            this.btn_starten.UseVisualStyleBackColor = false;
            this.btn_starten.Click += new System.EventHandler(this.btn_starten_Click);
            // 
            // btn_zurueck
            // 
            this.btn_zurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zurueck.Location = new System.Drawing.Point(628, 7);
            this.btn_zurueck.Name = "btn_zurueck";
            this.btn_zurueck.Size = new System.Drawing.Size(151, 74);
            this.btn_zurueck.TabIndex = 45;
            this.btn_zurueck.Text = "Zurück";
            this.btn_zurueck.UseVisualStyleBackColor = true;
            this.btn_zurueck.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSpeech
            // 
            this.cbSpeech.AutoSize = true;
            this.cbSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpeech.Location = new System.Drawing.Point(628, 98);
            this.cbSpeech.Name = "cbSpeech";
            this.cbSpeech.Size = new System.Drawing.Size(151, 24);
            this.cbSpeech.TabIndex = 46;
            this.cbSpeech.Text = "Sprachsteuerung";
            this.cbSpeech.UseVisualStyleBackColor = true;
            // 
            // SpielEinstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 432);
            this.ControlBox = false;
            this.Controls.Add(this.cbSpeech);
            this.Controls.Add(this.btn_zurueck);
            this.Controls.Add(this.btn_starten);
            this.Controls.Add(this.btn_newSpieler);
            this.Controls.Add(this.rB_spieler8);
            this.Controls.Add(this.rB_spieler7);
            this.Controls.Add(this.rB_spieler6);
            this.Controls.Add(this.rB_spieler5);
            this.Controls.Add(this.rB_spieler4);
            this.Controls.Add(this.rB_spieler3);
            this.Controls.Add(this.rB_spieler2);
            this.Controls.Add(this.rB_spieler1);
            this.Controls.Add(this.lbl_ueberschriftMitspieler);
            this.Controls.Add(this.tBx_spieler8);
            this.Controls.Add(this.lbl_spieler8);
            this.Controls.Add(this.tBx_spieler4);
            this.Controls.Add(this.lbl_spieler4);
            this.Controls.Add(this.tBx_spieler7);
            this.Controls.Add(this.lbl_spieler7);
            this.Controls.Add(this.tBx_spieler6);
            this.Controls.Add(this.lbl_spieler6);
            this.Controls.Add(this.tBx_spieler5);
            this.Controls.Add(this.lbl_spieler5);
            this.Controls.Add(this.tBx_spieler3);
            this.Controls.Add(this.lbl_spieler3);
            this.Controls.Add(this.tBx_spieler2);
            this.Controls.Add(this.lbl_spieler2);
            this.Controls.Add(this.tBx_spieler1);
            this.Controls.Add(this.lbl_spieler1);
            this.Controls.Add(this.numUpDown_anzahlSpieler);
            this.Controls.Add(this.lbl_anzahlSpieler);
            this.Controls.Add(this.numUpDown_legs);
            this.Controls.Add(this.numUpDown_saetze);
            this.Controls.Add(this.lbl_legs);
            this.Controls.Add(this.lbl_saetze);
            this.Controls.Add(this.lbl_rest);
            this.Controls.Add(this.lbl_spielvariante);
            this.Controls.Add(this.comB_rest);
            this.Controls.Add(this.comB_spielvariante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpielEinstellungen";
            this.Text = "DartConsole - SpielEinstellungen";
            this.Load += new System.EventHandler(this.SpielEinstellungen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_saetze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_legs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_anzahlSpieler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comB_spielvariante;
        private System.Windows.Forms.ComboBox comB_rest;
        private System.Windows.Forms.Label lbl_spielvariante;
        private System.Windows.Forms.Label lbl_rest;
        private System.Windows.Forms.Label lbl_saetze;
        private System.Windows.Forms.Label lbl_legs;
        private System.Windows.Forms.NumericUpDown numUpDown_saetze;
        private System.Windows.Forms.NumericUpDown numUpDown_legs;
        private System.Windows.Forms.Label lbl_anzahlSpieler;
        private System.Windows.Forms.NumericUpDown numUpDown_anzahlSpieler;
        private System.Windows.Forms.Label lbl_spieler1;
        private System.Windows.Forms.TextBox tBx_spieler1;
        private System.Windows.Forms.TextBox tBx_spieler2;
        private System.Windows.Forms.Label lbl_spieler2;
        private System.Windows.Forms.TextBox tBx_spieler3;
        private System.Windows.Forms.Label lbl_spieler3;
        private System.Windows.Forms.TextBox tBx_spieler5;
        private System.Windows.Forms.Label lbl_spieler5;
        private System.Windows.Forms.TextBox tBx_spieler6;
        private System.Windows.Forms.Label lbl_spieler6;
        private System.Windows.Forms.TextBox tBx_spieler7;
        private System.Windows.Forms.Label lbl_spieler7;
        private System.Windows.Forms.TextBox tBx_spieler4;
        private System.Windows.Forms.Label lbl_spieler4;
        private System.Windows.Forms.TextBox tBx_spieler8;
        private System.Windows.Forms.Label lbl_spieler8;
        private System.Windows.Forms.Label lbl_ueberschriftMitspieler;
        private System.Windows.Forms.RadioButton rB_spieler1;
        private System.Windows.Forms.RadioButton rB_spieler2;
        private System.Windows.Forms.RadioButton rB_spieler3;
        private System.Windows.Forms.RadioButton rB_spieler4;
        private System.Windows.Forms.RadioButton rB_spieler5;
        private System.Windows.Forms.RadioButton rB_spieler6;
        private System.Windows.Forms.RadioButton rB_spieler7;
        private System.Windows.Forms.RadioButton rB_spieler8;
        private System.Windows.Forms.Button btn_newSpieler;
        private System.Windows.Forms.Button btn_starten;
        private System.Windows.Forms.Button btn_zurueck;
        private System.Windows.Forms.CheckBox cbSpeech;
    }
}