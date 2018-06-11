namespace DartConsole
{
    partial class SpielerInformationView
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.tBx_username = new System.Windows.Forms.TextBox();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.tBx_lastName = new System.Windows.Forms.TextBox();
            this.lbl_geburtstag = new System.Windows.Forms.Label();
            this.tBx_geburtstag = new System.Windows.Forms.TextBox();
            this.tBx_firstName = new System.Windows.Forms.TextBox();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_eMail = new System.Windows.Forms.Label();
            this.tBx_eMail = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(13, 13);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username";
            // 
            // tBx_username
            // 
            this.tBx_username.Location = new System.Drawing.Point(87, 5);
            this.tBx_username.Name = "tBx_username";
            this.tBx_username.ReadOnly = true;
            this.tBx_username.Size = new System.Drawing.Size(189, 20);
            this.tBx_username.TabIndex = 1;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(13, 65);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(59, 13);
            this.lbl_lastName.TabIndex = 0;
            this.lbl_lastName.Text = "Nachname";
            // 
            // tBx_lastName
            // 
            this.tBx_lastName.Location = new System.Drawing.Point(87, 57);
            this.tBx_lastName.Name = "tBx_lastName";
            this.tBx_lastName.ReadOnly = true;
            this.tBx_lastName.Size = new System.Drawing.Size(189, 20);
            this.tBx_lastName.TabIndex = 1;
            // 
            // lbl_geburtstag
            // 
            this.lbl_geburtstag.AutoSize = true;
            this.lbl_geburtstag.Location = new System.Drawing.Point(13, 91);
            this.lbl_geburtstag.Name = "lbl_geburtstag";
            this.lbl_geburtstag.Size = new System.Drawing.Size(68, 13);
            this.lbl_geburtstag.TabIndex = 0;
            this.lbl_geburtstag.Text = "Geburtdatum";
            // 
            // tBx_geburtstag
            // 
            this.tBx_geburtstag.Location = new System.Drawing.Point(87, 83);
            this.tBx_geburtstag.Name = "tBx_geburtstag";
            this.tBx_geburtstag.ReadOnly = true;
            this.tBx_geburtstag.Size = new System.Drawing.Size(189, 20);
            this.tBx_geburtstag.TabIndex = 1;
            // 
            // tBx_firstName
            // 
            this.tBx_firstName.Location = new System.Drawing.Point(87, 31);
            this.tBx_firstName.Name = "tBx_firstName";
            this.tBx_firstName.ReadOnly = true;
            this.tBx_firstName.Size = new System.Drawing.Size(189, 20);
            this.tBx_firstName.TabIndex = 1;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(13, 38);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(49, 13);
            this.lbl_firstName.TabIndex = 2;
            this.lbl_firstName.Text = "Vorname";
            // 
            // lbl_eMail
            // 
            this.lbl_eMail.AutoSize = true;
            this.lbl_eMail.Location = new System.Drawing.Point(13, 117);
            this.lbl_eMail.Name = "lbl_eMail";
            this.lbl_eMail.Size = new System.Drawing.Size(36, 13);
            this.lbl_eMail.TabIndex = 0;
            this.lbl_eMail.Text = "E-Mail";
            // 
            // tBx_eMail
            // 
            this.tBx_eMail.Location = new System.Drawing.Point(87, 109);
            this.tBx_eMail.Name = "tBx_eMail";
            this.tBx_eMail.ReadOnly = true;
            this.tBx_eMail.Size = new System.Drawing.Size(189, 20);
            this.tBx_eMail.TabIndex = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(201, 135);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // SpielerInformationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 161);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_firstName);
            this.Controls.Add(this.tBx_eMail);
            this.Controls.Add(this.lbl_eMail);
            this.Controls.Add(this.tBx_geburtstag);
            this.Controls.Add(this.lbl_geburtstag);
            this.Controls.Add(this.tBx_firstName);
            this.Controls.Add(this.tBx_lastName);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.tBx_username);
            this.Controls.Add(this.lbl_username);
            this.MaximumSize = new System.Drawing.Size(296, 200);
            this.MinimumSize = new System.Drawing.Size(296, 200);
            this.Name = "SpielerInformationView";
            this.Text = "SpielerInformationView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tBx_username;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.TextBox tBx_lastName;
        private System.Windows.Forms.Label lbl_geburtstag;
        private System.Windows.Forms.TextBox tBx_geburtstag;
        private System.Windows.Forms.TextBox tBx_firstName;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_eMail;
        private System.Windows.Forms.TextBox tBx_eMail;
        private System.Windows.Forms.Button btn_ok;
    }
}