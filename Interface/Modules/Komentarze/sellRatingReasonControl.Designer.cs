namespace Interface.Modules.Komentarze
{
    partial class sellRatingReasonControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reasonValueTrackBar = new System.Windows.Forms.TrackBar();
            this.reasonTitleLabel = new System.Windows.Forms.Label();
            this.markLabel = new System.Windows.Forms.Label();
            this.reasonComboBox = new System.Windows.Forms.ComboBox();
            this.reasonOfDisssatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reasonValueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // reasonValueTrackBar
            // 
            this.reasonValueTrackBar.Location = new System.Drawing.Point(19, 30);
            this.reasonValueTrackBar.Maximum = 5;
            this.reasonValueTrackBar.Minimum = 1;
            this.reasonValueTrackBar.Name = "reasonValueTrackBar";
            this.reasonValueTrackBar.Size = new System.Drawing.Size(116, 45);
            this.reasonValueTrackBar.TabIndex = 9;
            this.reasonValueTrackBar.Value = 5;
            this.reasonValueTrackBar.ValueChanged += new System.EventHandler(this.reasonValueTrackBar_ValueChanged);
            // 
            // reasonTitleLabel
            // 
            this.reasonTitleLabel.AutoSize = true;
            this.reasonTitleLabel.Location = new System.Drawing.Point(16, 14);
            this.reasonTitleLabel.Name = "reasonTitleLabel";
            this.reasonTitleLabel.Size = new System.Drawing.Size(52, 13);
            this.reasonTitleLabel.TabIndex = 10;
            this.reasonTitleLabel.Text = "Przesylka";
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Location = new System.Drawing.Point(139, 33);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(24, 13);
            this.markLabel.TabIndex = 11;
            this.markLabel.Text = "5/5";
            // 
            // reasonComboBox
            // 
            this.reasonComboBox.FormattingEnabled = true;
            this.reasonComboBox.Location = new System.Drawing.Point(330, 33);
            this.reasonComboBox.Name = "reasonComboBox";
            this.reasonComboBox.Size = new System.Drawing.Size(216, 21);
            this.reasonComboBox.TabIndex = 13;
            // 
            // reasonOfDisssatLabel
            // 
            this.reasonOfDisssatLabel.AutoSize = true;
            this.reasonOfDisssatLabel.Location = new System.Drawing.Point(208, 36);
            this.reasonOfDisssatLabel.Name = "reasonOfDisssatLabel";
            this.reasonOfDisssatLabel.Size = new System.Drawing.Size(116, 13);
            this.reasonOfDisssatLabel.TabIndex = 14;
            this.reasonOfDisssatLabel.Text = "Powód niezadowolenia";
            // 
            // sellRatingReasonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.reasonOfDisssatLabel);
            this.Controls.Add(this.reasonComboBox);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.reasonTitleLabel);
            this.Controls.Add(this.reasonValueTrackBar);
            this.Name = "sellRatingReasonControl";
            this.Size = new System.Drawing.Size(561, 65);
            ((System.ComponentModel.ISupportInitialize)(this.reasonValueTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar reasonValueTrackBar;
        private System.Windows.Forms.Label reasonTitleLabel;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.ComboBox reasonComboBox;
        private System.Windows.Forms.Label reasonOfDisssatLabel;
    }
}
