namespace DartConsole
{
    partial class SelectDateDialog
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
            this.dTimeP_Geburtsdatum_Waehlen = new System.Windows.Forms.DateTimePicker();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dTimeP_Geburtsdatum_Waehlen
            // 
            this.dTimeP_Geburtsdatum_Waehlen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimeP_Geburtsdatum_Waehlen.Location = new System.Drawing.Point(12, 12);
            this.dTimeP_Geburtsdatum_Waehlen.Name = "dTimeP_Geburtsdatum_Waehlen";
            this.dTimeP_Geburtsdatum_Waehlen.Size = new System.Drawing.Size(200, 20);
            this.dTimeP_Geburtsdatum_Waehlen.TabIndex = 0;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(137, 38);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // SelectDateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 67);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dTimeP_Geburtsdatum_Waehlen);
            this.Name = "SelectDateDialog";
            this.Text = "SelectDateDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTimeP_Geburtsdatum_Waehlen;
        private System.Windows.Forms.Button btn_OK;
    }
}