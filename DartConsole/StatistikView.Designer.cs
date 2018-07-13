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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatistikView));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tP_Start = new System.Windows.Forms.TabPage();
            this.btn_zurueck = new System.Windows.Forms.Button();
            this.tP_Allgemein = new System.Windows.Forms.TabPage();
            this.tP_Spiel = new System.Windows.Forms.TabPage();
            this.cB_legAuswahl = new System.Windows.Forms.ComboBox();
            this.cB_setAuswahl = new System.Windows.Forms.ComboBox();
            this.cB_spielAuswahl = new System.Windows.Forms.ComboBox();
            this.rtbInfos = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.tP_Start.SuspendLayout();
            this.tP_Spiel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tP_Start);
            this.tabControl.Controls.Add(this.tP_Allgemein);
            this.tabControl.Controls.Add(this.tP_Spiel);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(536, 461);
            this.tabControl.TabIndex = 0;
            // 
            // tP_Start
            // 
            this.tP_Start.Controls.Add(this.btn_zurueck);
            this.tP_Start.Location = new System.Drawing.Point(4, 22);
            this.tP_Start.Margin = new System.Windows.Forms.Padding(2);
            this.tP_Start.Name = "tP_Start";
            this.tP_Start.Padding = new System.Windows.Forms.Padding(2);
            this.tP_Start.Size = new System.Drawing.Size(528, 435);
            this.tP_Start.TabIndex = 0;
            this.tP_Start.Text = "Start";
            this.tP_Start.UseVisualStyleBackColor = true;
            // 
            // btn_zurueck
            // 
            this.btn_zurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zurueck.Location = new System.Drawing.Point(372, 376);
            this.btn_zurueck.Name = "btn_zurueck";
            this.btn_zurueck.Size = new System.Drawing.Size(153, 56);
            this.btn_zurueck.TabIndex = 0;
            this.btn_zurueck.Text = "Zurück";
            this.btn_zurueck.UseVisualStyleBackColor = true;
            this.btn_zurueck.Click += new System.EventHandler(this.btn_zurueck_Click);
            // 
            // tP_Allgemein
            // 
            this.tP_Allgemein.Location = new System.Drawing.Point(4, 22);
            this.tP_Allgemein.Margin = new System.Windows.Forms.Padding(2);
            this.tP_Allgemein.Name = "tP_Allgemein";
            this.tP_Allgemein.Padding = new System.Windows.Forms.Padding(2);
            this.tP_Allgemein.Size = new System.Drawing.Size(528, 435);
            this.tP_Allgemein.TabIndex = 1;
            this.tP_Allgemein.Text = "Allgemein";
            this.tP_Allgemein.UseVisualStyleBackColor = true;
            // 
            // tP_Spiel
            // 
            this.tP_Spiel.Controls.Add(this.rtbInfos);
            this.tP_Spiel.Controls.Add(this.cB_legAuswahl);
            this.tP_Spiel.Controls.Add(this.cB_setAuswahl);
            this.tP_Spiel.Controls.Add(this.cB_spielAuswahl);
            this.tP_Spiel.Location = new System.Drawing.Point(4, 22);
            this.tP_Spiel.Margin = new System.Windows.Forms.Padding(2);
            this.tP_Spiel.Name = "tP_Spiel";
            this.tP_Spiel.Padding = new System.Windows.Forms.Padding(2);
            this.tP_Spiel.Size = new System.Drawing.Size(528, 435);
            this.tP_Spiel.TabIndex = 2;
            this.tP_Spiel.Text = "Spiel";
            this.tP_Spiel.UseVisualStyleBackColor = true;
            // 
            // cB_legAuswahl
            // 
            this.cB_legAuswahl.FormattingEnabled = true;
            this.cB_legAuswahl.Location = new System.Drawing.Point(15, 86);
            this.cB_legAuswahl.Margin = new System.Windows.Forms.Padding(2);
            this.cB_legAuswahl.Name = "cB_legAuswahl";
            this.cB_legAuswahl.Size = new System.Drawing.Size(117, 21);
            this.cB_legAuswahl.TabIndex = 2;
            this.cB_legAuswahl.Text = "Leg auswählen";
            this.cB_legAuswahl.SelectedIndexChanged += new System.EventHandler(this.cB_legAuswahl_SelectedIndexChanged);
            // 
            // cB_setAuswahl
            // 
            this.cB_setAuswahl.FormattingEnabled = true;
            this.cB_setAuswahl.Location = new System.Drawing.Point(15, 49);
            this.cB_setAuswahl.Margin = new System.Windows.Forms.Padding(2);
            this.cB_setAuswahl.Name = "cB_setAuswahl";
            this.cB_setAuswahl.Size = new System.Drawing.Size(117, 21);
            this.cB_setAuswahl.TabIndex = 1;
            this.cB_setAuswahl.Text = "Set auswählen";
            this.cB_setAuswahl.SelectedIndexChanged += new System.EventHandler(this.cB_setAuswahl_SelectedIndexChanged);
            // 
            // cB_spielAuswahl
            // 
            this.cB_spielAuswahl.FormattingEnabled = true;
            this.cB_spielAuswahl.Location = new System.Drawing.Point(15, 14);
            this.cB_spielAuswahl.Margin = new System.Windows.Forms.Padding(2);
            this.cB_spielAuswahl.Name = "cB_spielAuswahl";
            this.cB_spielAuswahl.Size = new System.Drawing.Size(117, 21);
            this.cB_spielAuswahl.TabIndex = 0;
            this.cB_spielAuswahl.Text = "Spiel auswählen";
            this.cB_spielAuswahl.SelectedIndexChanged += new System.EventHandler(this.cB_spielAuswahl_SelectedIndexChanged);
            // 
            // rtbInfos
            // 
            this.rtbInfos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfos.Location = new System.Drawing.Point(311, 0);
            this.rtbInfos.Name = "rtbInfos";
            this.rtbInfos.ReadOnly = true;
            this.rtbInfos.Size = new System.Drawing.Size(217, 435);
            this.rtbInfos.TabIndex = 4;
            this.rtbInfos.Text = "";
            // 
            // StatistikView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 461);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StatistikView";
            this.Text = "StatistikView";
            this.Load += new System.EventHandler(this.StatistikView_Load);
            this.tabControl.ResumeLayout(false);
            this.tP_Start.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_zurueck;
        private System.Windows.Forms.RichTextBox rtbInfos;
    }
}