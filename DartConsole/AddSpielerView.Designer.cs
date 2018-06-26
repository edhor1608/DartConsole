namespace DartConsole
{
    partial class AddSpielerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSpielerView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tBx_username = new System.Windows.Forms.TextBox();
            this.tBx_Passwort_Wdh = new System.Windows.Forms.TextBox();
            this.tBx_Passwort = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_Nachname = new System.Windows.Forms.Label();
            this.tBx_eMail = new System.Windows.Forms.TextBox();
            this.tBx_Geburtsdatum = new System.Windows.Forms.TextBox();
            this.tBx_LastName = new System.Windows.Forms.TextBox();
            this.tBx_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_eMail = new System.Windows.Forms.Label();
            this.lbl_Geburtsdatum = new System.Windows.Forms.Label();
            this.lbl_Passwort = new System.Windows.Forms.Label();
            this.lbl_Passwort_Wdh = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tBx_username, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tBx_Passwort_Wdh, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tBx_Passwort, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_FirstName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Nachname, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tBx_eMail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tBx_Geburtsdatum, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tBx_LastName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tBx_FirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_eMail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Geburtsdatum, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Passwort, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Passwort_Wdh, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_username, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tBx_username
            // 
            this.tBx_username.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.tBx_username, "tBx_username");
            this.tBx_username.Name = "tBx_username";
            this.tBx_username.TextChanged += new System.EventHandler(this.tBx_username_TextChanged);
            // 
            // tBx_Passwort_Wdh
            // 
            this.tBx_Passwort_Wdh.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tBx_Passwort_Wdh, "tBx_Passwort_Wdh");
            this.tBx_Passwort_Wdh.Name = "tBx_Passwort_Wdh";
            this.tBx_Passwort_Wdh.UseSystemPasswordChar = true;
            this.tBx_Passwort_Wdh.TextChanged += new System.EventHandler(this.tBx_Passwort_Wdh_TextChanged);
            // 
            // tBx_Passwort
            // 
            this.tBx_Passwort.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.tBx_Passwort, "tBx_Passwort");
            this.tBx_Passwort.Name = "tBx_Passwort";
            this.tBx_Passwort.UseSystemPasswordChar = true;
            this.tBx_Passwort.TextChanged += new System.EventHandler(this.tBx_Passwort_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.btn_OK, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // btn_OK
            // 
            resources.ApplyResources(this.btn_OK, "btn_OK");
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_FirstName
            // 
            resources.ApplyResources(this.lbl_FirstName, "lbl_FirstName");
            this.lbl_FirstName.Name = "lbl_FirstName";
            // 
            // lbl_Nachname
            // 
            resources.ApplyResources(this.lbl_Nachname, "lbl_Nachname");
            this.lbl_Nachname.Name = "lbl_Nachname";
            // 
            // tBx_eMail
            // 
            this.tBx_eMail.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.tBx_eMail, "tBx_eMail");
            this.tBx_eMail.Name = "tBx_eMail";
            this.tBx_eMail.TextChanged += new System.EventHandler(this.tBx_eMail_TextChanged);
            // 
            // tBx_Geburtsdatum
            // 
            this.tBx_Geburtsdatum.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.tBx_Geburtsdatum, "tBx_Geburtsdatum");
            this.tBx_Geburtsdatum.Name = "tBx_Geburtsdatum";
            this.tBx_Geburtsdatum.ReadOnly = true;
            this.tBx_Geburtsdatum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Geburstsdatum_Aendern);
            this.tBx_Geburtsdatum.TextChanged += new System.EventHandler(this.tBx_Geburtsdatum_TextChanged);
            // 
            // tBx_LastName
            // 
            resources.ApplyResources(this.tBx_LastName, "tBx_LastName");
            this.tBx_LastName.Name = "tBx_LastName";
            // 
            // tBx_FirstName
            // 
            resources.ApplyResources(this.tBx_FirstName, "tBx_FirstName");
            this.tBx_FirstName.Name = "tBx_FirstName";
            // 
            // lbl_eMail
            // 
            resources.ApplyResources(this.lbl_eMail, "lbl_eMail");
            this.lbl_eMail.Name = "lbl_eMail";
            // 
            // lbl_Geburtsdatum
            // 
            resources.ApplyResources(this.lbl_Geburtsdatum, "lbl_Geburtsdatum");
            this.lbl_Geburtsdatum.Name = "lbl_Geburtsdatum";
            // 
            // lbl_Passwort
            // 
            resources.ApplyResources(this.lbl_Passwort, "lbl_Passwort");
            this.lbl_Passwort.Name = "lbl_Passwort";
            // 
            // lbl_Passwort_Wdh
            // 
            resources.ApplyResources(this.lbl_Passwort_Wdh, "lbl_Passwort_Wdh");
            this.lbl_Passwort_Wdh.Name = "lbl_Passwort_Wdh";
            // 
            // lbl_username
            // 
            resources.ApplyResources(this.lbl_username, "lbl_username");
            this.lbl_username.Name = "lbl_username";
            // 
            // AddSpielerView
            // 
            this.AcceptButton = this.btn_OK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddSpielerView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_Nachname;
        private System.Windows.Forms.Label lbl_Geburtsdatum;
        private System.Windows.Forms.Label lbl_eMail;
        private System.Windows.Forms.TextBox tBx_eMail;
        private System.Windows.Forms.TextBox tBx_Geburtsdatum;
        private System.Windows.Forms.TextBox tBx_LastName;
        private System.Windows.Forms.TextBox tBx_FirstName;
        private System.Windows.Forms.TextBox tBx_Passwort_Wdh;
        private System.Windows.Forms.TextBox tBx_Passwort;
        private System.Windows.Forms.Label lbl_Passwort;
        private System.Windows.Forms.Label lbl_Passwort_Wdh;
        private System.Windows.Forms.TextBox tBx_username;
        private System.Windows.Forms.Label lbl_username;
    }
}