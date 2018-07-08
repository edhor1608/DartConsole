namespace DartConsole
{
    partial class StatistikView
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tP_Start = new System.Windows.Forms.TabPage();
            this.tP_Allgemein = new System.Windows.Forms.TabPage();
            this.tP_Spiel = new System.Windows.Forms.TabPage();
            this.cB_spielAuswahl = new System.Windows.Forms.ComboBox();
            this.cB_setAuswahl = new System.Windows.Forms.ComboBox();
            this.cB_legAuswahl = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tP_Spiel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tP_Start);
            this.tabControl.Controls.Add(this.tP_Allgemein);
            this.tabControl.Controls.Add(this.tP_Spiel);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(804, 455);
            this.tabControl.TabIndex = 0;
            // 
            // tP_Start
            // 
            this.tP_Start.Location = new System.Drawing.Point(4, 29);
            this.tP_Start.Name = "tP_Start";
            this.tP_Start.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Start.Size = new System.Drawing.Size(796, 422);
            this.tP_Start.TabIndex = 0;
            this.tP_Start.Text = "Start";
            this.tP_Start.UseVisualStyleBackColor = true;
            // 
            // tP_Allgemein
            // 
            this.tP_Allgemein.Location = new System.Drawing.Point(4, 29);
            this.tP_Allgemein.Name = "tP_Allgemein";
            this.tP_Allgemein.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Allgemein.Size = new System.Drawing.Size(796, 422);
            this.tP_Allgemein.TabIndex = 1;
            this.tP_Allgemein.Text = "Allgemein";
            this.tP_Allgemein.UseVisualStyleBackColor = true;
            // 
            // tP_Spiel
            // 
            this.tP_Spiel.Controls.Add(this.cB_legAuswahl);
            this.tP_Spiel.Controls.Add(this.cB_setAuswahl);
            this.tP_Spiel.Controls.Add(this.cB_spielAuswahl);
            this.tP_Spiel.Location = new System.Drawing.Point(4, 29);
            this.tP_Spiel.Name = "tP_Spiel";
            this.tP_Spiel.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Spiel.Size = new System.Drawing.Size(796, 422);
            this.tP_Spiel.TabIndex = 2;
            this.tP_Spiel.Text = "Spiel";
            this.tP_Spiel.UseVisualStyleBackColor = true;
            // 
            // cB_spielAuswahl
            // 
            this.cB_spielAuswahl.FormattingEnabled = true;
            this.cB_spielAuswahl.Location = new System.Drawing.Point(23, 21);
            this.cB_spielAuswahl.Name = "cB_spielAuswahl";
            this.cB_spielAuswahl.Size = new System.Drawing.Size(173, 28);
            this.cB_spielAuswahl.TabIndex = 0;
            this.cB_spielAuswahl.Text = "Spiel auswählen";
            this.cB_spielAuswahl.SelectedIndexChanged += new System.EventHandler(this.cB_spielAuswahl_SelectedIndexChanged);
            // 
            // cB_setAuswahl
            // 
            this.cB_setAuswahl.FormattingEnabled = true;
            this.cB_setAuswahl.Location = new System.Drawing.Point(23, 75);
            this.cB_setAuswahl.Name = "cB_setAuswahl";
            this.cB_setAuswahl.Size = new System.Drawing.Size(173, 28);
            this.cB_setAuswahl.TabIndex = 1;
            this.cB_setAuswahl.Text = "Set auswählen";
            this.cB_setAuswahl.SelectedIndexChanged += new System.EventHandler(this.cB_setAuswahl_SelectedIndexChanged);
            // 
            // cB_legAuswahl
            // 
            this.cB_legAuswahl.FormattingEnabled = true;
            this.cB_legAuswahl.Location = new System.Drawing.Point(23, 133);
            this.cB_legAuswahl.Name = "cB_legAuswahl";
            this.cB_legAuswahl.Size = new System.Drawing.Size(173, 28);
            this.cB_legAuswahl.TabIndex = 2;
            this.cB_legAuswahl.Text = "Leg auswählen";
            this.cB_legAuswahl.SelectedIndexChanged += new System.EventHandler(this.cB_legAuswahl_SelectedIndexChanged);
            // 
            // StatistikView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Name = "StatistikView";
            this.Text = "StatistikView";
            this.Load += new System.EventHandler(this.StatistikView_Load);
            this.tabControl.ResumeLayout(false);
            this.tP_Spiel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tP_Start;
        private System.Windows.Forms.TabPage tP_Allgemein;
        private System.Windows.Forms.TabPage tP_Spiel;
        private System.Windows.Forms.ComboBox cB_spielAuswahl;
        private System.Windows.Forms.ComboBox cB_legAuswahl;
        private System.Windows.Forms.ComboBox cB_setAuswahl;
    }
}