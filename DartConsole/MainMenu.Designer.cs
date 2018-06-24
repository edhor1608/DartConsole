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
            this.btn_Beenden = new System.Windows.Forms.Button();
            this.btn_statistik = new System.Windows.Forms.Button();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPg_start = new System.Windows.Forms.TabPage();
            this.tbPg_konto = new System.Windows.Forms.TabPage();
            lbl_Begruessung = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPg_start.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(lbl_Begruessung);
            this.groupBox.Controls.Add(this.btn_Beenden);
            this.groupBox.Controls.Add(this.btn_statistik);
            this.groupBox.Controls.Add(this.btn_newGame);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox.Location = new System.Drawing.Point(3, 6);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(746, 373);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Beenden
            // 
            this.btn_Beenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Beenden.Location = new System.Drawing.Point(92, 282);
            this.btn_Beenden.Name = "btn_Beenden";
            this.btn_Beenden.Size = new System.Drawing.Size(568, 85);
            this.btn_Beenden.TabIndex = 2;
            this.btn_Beenden.Text = "Logout";
            this.btn_Beenden.UseVisualStyleBackColor = true;
            this.btn_Beenden.Click += new System.EventHandler(this.btn_Beenden_Click);
            // 
            // btn_statistik
            // 
            this.btn_statistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistik.Location = new System.Drawing.Point(92, 172);
            this.btn_statistik.Name = "btn_statistik";
            this.btn_statistik.Size = new System.Drawing.Size(568, 85);
            this.btn_statistik.TabIndex = 1;
            this.btn_statistik.Text = "Statistik";
            this.btn_statistik.UseVisualStyleBackColor = true;
            // 
            // btn_newGame
            // 
            this.btn_newGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newGame.Location = new System.Drawing.Point(92, 65);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(568, 85);
            this.btn_newGame.TabIndex = 0;
            this.btn_newGame.Text = "Neues Spiel";
            this.btn_newGame.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPg_start);
            this.tabControl1.Controls.Add(this.tbPg_konto);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tbPg_start
            // 
            this.tbPg_start.Controls.Add(this.groupBox);
            this.tbPg_start.Location = new System.Drawing.Point(4, 29);
            this.tbPg_start.Name = "tbPg_start";
            this.tbPg_start.Padding = new System.Windows.Forms.Padding(3);
            this.tbPg_start.Size = new System.Drawing.Size(768, 393);
            this.tbPg_start.TabIndex = 0;
            this.tbPg_start.Text = "Start";
            this.tbPg_start.UseVisualStyleBackColor = true;
            // 
            // tbPg_konto
            // 
            this.tbPg_konto.Location = new System.Drawing.Point(4, 29);
            this.tbPg_konto.Name = "tbPg_konto";
            this.tbPg_konto.Padding = new System.Windows.Forms.Padding(3);
            this.tbPg_konto.Size = new System.Drawing.Size(768, 393);
            this.tbPg_konto.TabIndex = 1;
            this.tbPg_konto.Text = "Konto";
            this.tbPg_konto.UseVisualStyleBackColor = true;
            // 
            // lbl_Begruessung
            // 
            lbl_Begruessung.AutoSize = true;
            lbl_Begruessung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Begruessung.Location = new System.Drawing.Point(92, 26);
            lbl_Begruessung.Name = "lbl_Begruessung";
            lbl_Begruessung.Size = new System.Drawing.Size(184, 36);
            lbl_Begruessung.TabIndex = 3;
            lbl_Begruessung.Text = "Hallo Spieler";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbPg_start.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btn_Beenden;
        private System.Windows.Forms.Button btn_statistik;
        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPg_start;
        private System.Windows.Forms.TabPage tbPg_konto;
        public static System.Windows.Forms.Label lbl_Begruessung;
    }
}