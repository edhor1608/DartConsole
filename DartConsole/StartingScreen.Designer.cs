namespace DartConsole
{
    partial class StartingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingScreen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBx_passwort = new System.Windows.Forms.TextBox();
            this.tBx_username = new System.Windows.Forms.TextBox();
            this.lbl_passwort = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.btn_usrAuflistung = new System.Windows.Forms.Button();
            this.btn_Beenden = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_newUser = new System.Windows.Forms.Button();
            this.lbl_falseUser = new System.Windows.Forms.Label();
            this.lbl_falsePaswd = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_falsePaswd);
            this.groupBox1.Controls.Add(this.lbl_falseUser);
            this.groupBox1.Controls.Add(this.btn_newUser);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.btn_Beenden);
            this.groupBox1.Controls.Add(this.tBx_passwort);
            this.groupBox1.Controls.Add(this.tBx_username);
            this.groupBox1.Controls.Add(this.lbl_passwort);
            this.groupBox1.Controls.Add(this.lbl_username);
            this.groupBox1.Controls.Add(this.lbl_Login);
            this.groupBox1.Controls.Add(this.btn_usrAuflistung);
            this.groupBox1.Location = new System.Drawing.Point(-1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tBx_passwort
            // 
            this.tBx_passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_passwort.Location = new System.Drawing.Point(258, 152);
            this.tBx_passwort.Name = "tBx_passwort";
            this.tBx_passwort.Size = new System.Drawing.Size(518, 53);
            this.tBx_passwort.TabIndex = 5;
            this.tBx_passwort.UseSystemPasswordChar = true;
            // 
            // tBx_username
            // 
            this.tBx_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_username.Location = new System.Drawing.Point(258, 78);
            this.tBx_username.Name = "tBx_username";
            this.tBx_username.Size = new System.Drawing.Size(518, 53);
            this.tBx_username.TabIndex = 4;
            // 
            // lbl_passwort
            // 
            this.lbl_passwort.AutoSize = true;
            this.lbl_passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwort.Location = new System.Drawing.Point(28, 155);
            this.lbl_passwort.Name = "lbl_passwort";
            this.lbl_passwort.Size = new System.Drawing.Size(185, 46);
            this.lbl_passwort.TabIndex = 3;
            this.lbl_passwort.Text = "Passwort";
            this.lbl_passwort.Click += new System.EventHandler(this.lbl_passwort_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(28, 81);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(203, 46);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(6, 8);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(118, 46);
            this.lbl_Login.TabIndex = 1;
            this.lbl_Login.Text = "Login";
            // 
            // btn_usrAuflistung
            // 
            this.btn_usrAuflistung.Location = new System.Drawing.Point(36, 223);
            this.btn_usrAuflistung.Name = "btn_usrAuflistung";
            this.btn_usrAuflistung.Size = new System.Drawing.Size(245, 76);
            this.btn_usrAuflistung.TabIndex = 0;
            this.btn_usrAuflistung.Text = "Spielerauflistung";
            this.btn_usrAuflistung.UseVisualStyleBackColor = true;
            this.btn_usrAuflistung.Click += new System.EventHandler(this.btn_usrAuflistung_Click);
            // 
            // btn_Beenden
            // 
            this.btn_Beenden.Location = new System.Drawing.Point(652, 22);
            this.btn_Beenden.Name = "btn_Beenden";
            this.btn_Beenden.Size = new System.Drawing.Size(123, 46);
            this.btn_Beenden.TabIndex = 6;
            this.btn_Beenden.Text = "Beenden";
            this.btn_Beenden.UseVisualStyleBackColor = true;
            this.btn_Beenden.Click += new System.EventHandler(this.btn_Beenden_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(653, 223);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(123, 76);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_newUser
            // 
            this.btn_newUser.Location = new System.Drawing.Point(370, 223);
            this.btn_newUser.Name = "btn_newUser";
            this.btn_newUser.Size = new System.Drawing.Size(184, 76);
            this.btn_newUser.TabIndex = 8;
            this.btn_newUser.Text = "neuer Spieler";
            this.btn_newUser.UseVisualStyleBackColor = true;
            this.btn_newUser.Click += new System.EventHandler(this.btn_newUser_Click);
            // 
            // lbl_falseUser
            // 
            this.lbl_falseUser.AutoSize = true;
            this.lbl_falseUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_falseUser.ForeColor = System.Drawing.Color.Red;
            this.lbl_falseUser.Location = new System.Drawing.Point(261, 42);
            this.lbl_falseUser.Name = "lbl_falseUser";
            this.lbl_falseUser.Size = new System.Drawing.Size(200, 20);
            this.lbl_falseUser.TabIndex = 9;
            this.lbl_falseUser.Text = "User nicht vorhanden !!!";
            this.lbl_falseUser.Visible = false;
            // 
            // lbl_falsePaswd
            // 
            this.lbl_falsePaswd.AutoSize = true;
            this.lbl_falsePaswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_falsePaswd.ForeColor = System.Drawing.Color.Red;
            this.lbl_falsePaswd.Location = new System.Drawing.Point(261, 42);
            this.lbl_falsePaswd.Name = "lbl_falsePaswd";
            this.lbl_falsePaswd.Size = new System.Drawing.Size(179, 20);
            this.lbl_falsePaswd.TabIndex = 10;
            this.lbl_falsePaswd.Text = "Passwort ist falsch !!!";
            this.lbl_falsePaswd.Visible = false;
            // 
            // StartingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartingScreen";
            this.Text = "DartConsole";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_passwort;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Button btn_usrAuflistung;
        private System.Windows.Forms.TextBox tBx_passwort;
        private System.Windows.Forms.TextBox tBx_username;
        private System.Windows.Forms.Button btn_Beenden;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_newUser;
        private System.Windows.Forms.Label lbl_falseUser;
        private System.Windows.Forms.Label lbl_falsePaswd;
    }
}