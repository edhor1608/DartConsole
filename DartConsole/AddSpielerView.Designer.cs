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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_Nachname = new System.Windows.Forms.Label();
            this.lbl_Geburtsdatum = new System.Windows.Forms.Label();
            this.lbl_eMail = new System.Windows.Forms.Label();
            this.tBx_eMail = new System.Windows.Forms.TextBox();
            this.tBx_Geburtsdatum = new System.Windows.Forms.TextBox();
            this.tBx_LastName = new System.Windows.Forms.TextBox();
            this.tBx_FirstName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_FirstName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Nachname, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Geburtsdatum, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_eMail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tBx_eMail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tBx_Geburtsdatum, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tBx_LastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tBx_FirstName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(312, 169);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Controls.Add(this.btn_OK, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(159, 135);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(150, 31);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_OK
            // 
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OK.Location = new System.Drawing.Point(3, 3);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(144, 25);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_FirstName.Location = new System.Drawing.Point(3, 0);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(150, 33);
            this.lbl_FirstName.TabIndex = 1;
            this.lbl_FirstName.Text = "Vorname";
            // 
            // lbl_Nachname
            // 
            this.lbl_Nachname.AutoSize = true;
            this.lbl_Nachname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Nachname.Location = new System.Drawing.Point(3, 33);
            this.lbl_Nachname.Name = "lbl_Nachname";
            this.lbl_Nachname.Size = new System.Drawing.Size(150, 33);
            this.lbl_Nachname.TabIndex = 2;
            this.lbl_Nachname.Text = "Nachname";
            // 
            // lbl_Geburtsdatum
            // 
            this.lbl_Geburtsdatum.AutoSize = true;
            this.lbl_Geburtsdatum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Geburtsdatum.Location = new System.Drawing.Point(3, 66);
            this.lbl_Geburtsdatum.Name = "lbl_Geburtsdatum";
            this.lbl_Geburtsdatum.Size = new System.Drawing.Size(150, 33);
            this.lbl_Geburtsdatum.TabIndex = 3;
            this.lbl_Geburtsdatum.Text = "Geburtsdatum";
            // 
            // lbl_eMail
            // 
            this.lbl_eMail.AutoSize = true;
            this.lbl_eMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_eMail.Location = new System.Drawing.Point(3, 99);
            this.lbl_eMail.Name = "lbl_eMail";
            this.lbl_eMail.Size = new System.Drawing.Size(150, 33);
            this.lbl_eMail.TabIndex = 4;
            this.lbl_eMail.Text = "E-Mail";
            // 
            // tBx_eMail
            // 
            this.tBx_eMail.BackColor = System.Drawing.Color.White;
            this.tBx_eMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBx_eMail.Location = new System.Drawing.Point(159, 102);
            this.tBx_eMail.Name = "tBx_eMail";
            this.tBx_eMail.Size = new System.Drawing.Size(150, 20);
            this.tBx_eMail.TabIndex = 5;
            // 
            // tBx_Geburtsdatum
            // 
            this.tBx_Geburtsdatum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBx_Geburtsdatum.Location = new System.Drawing.Point(159, 69);
            this.tBx_Geburtsdatum.Name = "tBx_Geburtsdatum";
            this.tBx_Geburtsdatum.ReadOnly = true;
            this.tBx_Geburtsdatum.Size = new System.Drawing.Size(150, 20);
            this.tBx_Geburtsdatum.TabIndex = 6;
            this.tBx_Geburtsdatum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Geburstsdatum_Aendern);
            // 
            // tBx_LastName
            // 
            this.tBx_LastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBx_LastName.Location = new System.Drawing.Point(159, 36);
            this.tBx_LastName.Name = "tBx_LastName";
            this.tBx_LastName.Size = new System.Drawing.Size(150, 20);
            this.tBx_LastName.TabIndex = 7;
            // 
            // tBx_FirstName
            // 
            this.tBx_FirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBx_FirstName.Location = new System.Drawing.Point(159, 3);
            this.tBx_FirstName.Name = "tBx_FirstName";
            this.tBx_FirstName.Size = new System.Drawing.Size(150, 20);
            this.tBx_FirstName.TabIndex = 8;
            // 
            // AddSpielerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 169);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddSpielerView";
            this.Text = "AddSpielerView";
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
    }
}