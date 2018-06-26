namespace DartConsole
{
    partial class MainMenu
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lbl_Begruessung = new System.Windows.Forms.Label();
            this.btn_Beenden = new System.Windows.Forms.Button();
            this.btn_statistik = new System.Windows.Forms.Button();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPg_start = new System.Windows.Forms.TabPage();
            this.tbPg_Konto = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Uebernehmen = new System.Windows.Forms.Button();
            this.tBx_geburtstag = new System.Windows.Forms.TextBox();
            this.tBx_newPasswdWdh = new System.Windows.Forms.TextBox();
            this.tBx_newPasswd = new System.Windows.Forms.TextBox();
            this.tBx_nachname = new System.Windows.Forms.TextBox();
            this.tBx_eMail = new System.Windows.Forms.TextBox();
            this.tBx_vorname = new System.Windows.Forms.TextBox();
            this.tBx_username = new System.Windows.Forms.TextBox();
            this.lbl_Geburtstag = new System.Windows.Forms.Label();
            this.lbl_NewPasswortWdh = new System.Windows.Forms.Label();
            this.lbl_newPasswort = new System.Windows.Forms.Label();
            this.lbl_eMail = new System.Windows.Forms.Label();
            this.lbl_Nachname = new System.Windows.Forms.Label();
            this.lbl_Vorname = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPg_start.SuspendLayout();
            this.tbPg_Konto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lbl_Begruessung);
            this.groupBox.Controls.Add(this.btn_Beenden);
            this.groupBox.Controls.Add(this.btn_statistik);
            this.groupBox.Controls.Add(this.btn_newGame);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox.Location = new System.Drawing.Point(2, 4);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox.Size = new System.Drawing.Size(497, 242);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_Begruessung
            // 
            this.lbl_Begruessung.AutoSize = true;
            this.lbl_Begruessung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Begruessung.Location = new System.Drawing.Point(61, 17);
            this.lbl_Begruessung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Begruessung.Name = "lbl_Begruessung";
            this.lbl_Begruessung.Size = new System.Drawing.Size(122, 25);
            this.lbl_Begruessung.TabIndex = 3;
            this.lbl_Begruessung.Text = "Hallo Spieler";
            // 
            // btn_Beenden
            // 
            this.btn_Beenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Beenden.Location = new System.Drawing.Point(61, 183);
            this.btn_Beenden.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Beenden.Name = "btn_Beenden";
            this.btn_Beenden.Size = new System.Drawing.Size(379, 55);
            this.btn_Beenden.TabIndex = 2;
            this.btn_Beenden.Text = "Logout";
            this.btn_Beenden.UseVisualStyleBackColor = true;
            this.btn_Beenden.Click += new System.EventHandler(this.btn_Beenden_Click);
            // 
            // btn_statistik
            // 
            this.btn_statistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistik.Location = new System.Drawing.Point(61, 112);
            this.btn_statistik.Margin = new System.Windows.Forms.Padding(2);
            this.btn_statistik.Name = "btn_statistik";
            this.btn_statistik.Size = new System.Drawing.Size(379, 55);
            this.btn_statistik.TabIndex = 1;
            this.btn_statistik.Text = "Statistik";
            this.btn_statistik.UseVisualStyleBackColor = true;
            // 
            // btn_newGame
            // 
            this.btn_newGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newGame.Location = new System.Drawing.Point(61, 42);
            this.btn_newGame.Margin = new System.Windows.Forms.Padding(2);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(379, 55);
            this.btn_newGame.TabIndex = 0;
            this.btn_newGame.Text = "Neues Spiel";
            this.btn_newGame.UseVisualStyleBackColor = true;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPg_start);
            this.tabControl1.Controls.Add(this.tbPg_Konto);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 277);
            this.tabControl1.TabIndex = 1;
            // 
            // tbPg_start
            // 
            this.tbPg_start.Controls.Add(this.groupBox);
            this.tbPg_start.Location = new System.Drawing.Point(4, 22);
            this.tbPg_start.Margin = new System.Windows.Forms.Padding(2);
            this.tbPg_start.Name = "tbPg_start";
            this.tbPg_start.Padding = new System.Windows.Forms.Padding(2);
            this.tbPg_start.Size = new System.Drawing.Size(509, 251);
            this.tbPg_start.TabIndex = 0;
            this.tbPg_start.Text = "Start";
            this.tbPg_start.UseVisualStyleBackColor = true;
            // 
            // tbPg_Konto
            // 
            this.tbPg_Konto.Controls.Add(this.groupBox1);
            this.tbPg_Konto.Location = new System.Drawing.Point(4, 22);
            this.tbPg_Konto.Name = "tbPg_Konto";
            this.tbPg_Konto.Padding = new System.Windows.Forms.Padding(3);
            this.tbPg_Konto.Size = new System.Drawing.Size(509, 251);
            this.tbPg_Konto.TabIndex = 1;
            this.tbPg_Konto.Text = "Konto";
            this.tbPg_Konto.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Uebernehmen);
            this.groupBox1.Controls.Add(this.tBx_geburtstag);
            this.groupBox1.Controls.Add(this.tBx_newPasswdWdh);
            this.groupBox1.Controls.Add(this.tBx_newPasswd);
            this.groupBox1.Controls.Add(this.tBx_nachname);
            this.groupBox1.Controls.Add(this.tBx_eMail);
            this.groupBox1.Controls.Add(this.tBx_vorname);
            this.groupBox1.Controls.Add(this.tBx_username);
            this.groupBox1.Controls.Add(this.lbl_Geburtstag);
            this.groupBox1.Controls.Add(this.lbl_NewPasswortWdh);
            this.groupBox1.Controls.Add(this.lbl_newPasswort);
            this.groupBox1.Controls.Add(this.lbl_eMail);
            this.groupBox1.Controls.Add(this.lbl_Nachname);
            this.groupBox1.Controls.Add(this.lbl_Vorname);
            this.groupBox1.Controls.Add(this.lbl_username);
            this.groupBox1.Location = new System.Drawing.Point(-12, -31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_Uebernehmen
            // 
            this.btn_Uebernehmen.Location = new System.Drawing.Point(286, 224);
            this.btn_Uebernehmen.Name = "btn_Uebernehmen";
            this.btn_Uebernehmen.Size = new System.Drawing.Size(216, 45);
            this.btn_Uebernehmen.TabIndex = 14;
            this.btn_Uebernehmen.Text = "Übernehmen";
            this.btn_Uebernehmen.UseVisualStyleBackColor = true;
            this.btn_Uebernehmen.Click += new System.EventHandler(this.btn_Uebernehmen_Click);
            // 
            // tBx_geburtstag
            // 
            this.tBx_geburtstag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_geburtstag.Location = new System.Drawing.Point(288, 188);
            this.tBx_geburtstag.Name = "tBx_geburtstag";
            this.tBx_geburtstag.ReadOnly = true;
            this.tBx_geburtstag.Size = new System.Drawing.Size(215, 23);
            this.tBx_geburtstag.TabIndex = 13;
            // 
            // tBx_newPasswdWdh
            // 
            this.tBx_newPasswdWdh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_newPasswdWdh.Location = new System.Drawing.Point(34, 247);
            this.tBx_newPasswdWdh.Name = "tBx_newPasswdWdh";
            this.tBx_newPasswdWdh.Size = new System.Drawing.Size(215, 23);
            this.tBx_newPasswdWdh.TabIndex = 12;
            this.tBx_newPasswdWdh.UseSystemPasswordChar = true;
            // 
            // tBx_newPasswd
            // 
            this.tBx_newPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_newPasswd.Location = new System.Drawing.Point(34, 188);
            this.tBx_newPasswd.Name = "tBx_newPasswd";
            this.tBx_newPasswd.Size = new System.Drawing.Size(215, 23);
            this.tBx_newPasswd.TabIndex = 11;
            this.tBx_newPasswd.UseSystemPasswordChar = true;
            // 
            // tBx_nachname
            // 
            this.tBx_nachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_nachname.Location = new System.Drawing.Point(288, 130);
            this.tBx_nachname.Name = "tBx_nachname";
            this.tBx_nachname.ReadOnly = true;
            this.tBx_nachname.Size = new System.Drawing.Size(215, 23);
            this.tBx_nachname.TabIndex = 10;
            // 
            // tBx_eMail
            // 
            this.tBx_eMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_eMail.Location = new System.Drawing.Point(34, 130);
            this.tBx_eMail.Name = "tBx_eMail";
            this.tBx_eMail.Size = new System.Drawing.Size(215, 23);
            this.tBx_eMail.TabIndex = 9;
            // 
            // tBx_vorname
            // 
            this.tBx_vorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_vorname.Location = new System.Drawing.Point(288, 71);
            this.tBx_vorname.Name = "tBx_vorname";
            this.tBx_vorname.ReadOnly = true;
            this.tBx_vorname.Size = new System.Drawing.Size(215, 23);
            this.tBx_vorname.TabIndex = 8;
            // 
            // tBx_username
            // 
            this.tBx_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_username.Location = new System.Drawing.Point(34, 71);
            this.tBx_username.Name = "tBx_username";
            this.tBx_username.Size = new System.Drawing.Size(215, 23);
            this.tBx_username.TabIndex = 7;
            // 
            // lbl_Geburtstag
            // 
            this.lbl_Geburtstag.AutoSize = true;
            this.lbl_Geburtstag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Geburtstag.Location = new System.Drawing.Point(284, 165);
            this.lbl_Geburtstag.Name = "lbl_Geburtstag";
            this.lbl_Geburtstag.Size = new System.Drawing.Size(90, 20);
            this.lbl_Geburtstag.TabIndex = 6;
            this.lbl_Geburtstag.Text = "Geburtstag";
            this.lbl_Geburtstag.Click += new System.EventHandler(this.lbl_Geburtstag_Click);
            // 
            // lbl_NewPasswortWdh
            // 
            this.lbl_NewPasswortWdh.AutoSize = true;
            this.lbl_NewPasswortWdh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewPasswortWdh.Location = new System.Drawing.Point(30, 224);
            this.lbl_NewPasswortWdh.Name = "lbl_NewPasswortWdh";
            this.lbl_NewPasswortWdh.Size = new System.Drawing.Size(167, 20);
            this.lbl_NewPasswortWdh.TabIndex = 5;
            this.lbl_NewPasswortWdh.Text = "Passwort Wiederholen";
            this.lbl_NewPasswortWdh.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_newPasswort
            // 
            this.lbl_newPasswort.AutoSize = true;
            this.lbl_newPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newPasswort.Location = new System.Drawing.Point(30, 165);
            this.lbl_newPasswort.Name = "lbl_newPasswort";
            this.lbl_newPasswort.Size = new System.Drawing.Size(124, 20);
            this.lbl_newPasswort.TabIndex = 4;
            this.lbl_newPasswort.Text = "Neues Passwort";
            // 
            // lbl_eMail
            // 
            this.lbl_eMail.AutoSize = true;
            this.lbl_eMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eMail.Location = new System.Drawing.Point(30, 107);
            this.lbl_eMail.Name = "lbl_eMail";
            this.lbl_eMail.Size = new System.Drawing.Size(46, 20);
            this.lbl_eMail.TabIndex = 3;
            this.lbl_eMail.Text = "eMail";
            // 
            // lbl_Nachname
            // 
            this.lbl_Nachname.AutoSize = true;
            this.lbl_Nachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nachname.Location = new System.Drawing.Point(284, 107);
            this.lbl_Nachname.Name = "lbl_Nachname";
            this.lbl_Nachname.Size = new System.Drawing.Size(86, 20);
            this.lbl_Nachname.TabIndex = 2;
            this.lbl_Nachname.Text = "Nachname";
            // 
            // lbl_Vorname
            // 
            this.lbl_Vorname.AutoSize = true;
            this.lbl_Vorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vorname.Location = new System.Drawing.Point(284, 48);
            this.lbl_Vorname.Name = "lbl_Vorname";
            this.lbl_Vorname.Size = new System.Drawing.Size(74, 20);
            this.lbl_Vorname.TabIndex = 1;
            this.lbl_Vorname.Text = "Vorname";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(30, 48);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(83, 20);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username";
            // 
            // MainMenu
            // 
            this.AcceptButton = this.btn_Uebernehmen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "DartConsole";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbPg_start.ResumeLayout(false);
            this.tbPg_Konto.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btn_Beenden;
        private System.Windows.Forms.Button btn_statistik;
        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPg_start;
        private System.Windows.Forms.TabPage tbPg_Konto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_NewPasswortWdh;
        private System.Windows.Forms.Label lbl_newPasswort;
        private System.Windows.Forms.Label lbl_eMail;
        private System.Windows.Forms.Label lbl_Nachname;
        private System.Windows.Forms.Label lbl_Vorname;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_Geburtstag;
        private System.Windows.Forms.TextBox tBx_geburtstag;
        private System.Windows.Forms.TextBox tBx_newPasswdWdh;
        private System.Windows.Forms.TextBox tBx_newPasswd;
        private System.Windows.Forms.TextBox tBx_nachname;
        private System.Windows.Forms.TextBox tBx_eMail;
        private System.Windows.Forms.TextBox tBx_vorname;
        private System.Windows.Forms.TextBox tBx_username;
        private System.Windows.Forms.Button btn_Uebernehmen;
        public System.Windows.Forms.Label lbl_Begruessung;
    }
}