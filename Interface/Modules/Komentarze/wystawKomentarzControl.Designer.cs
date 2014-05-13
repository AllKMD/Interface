namespace Interface.Komentarze
{
    partial class wystawKomentarzControl
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
            this.feedbackContentTB = new System.Windows.Forms.RichTextBox();
            this.anulujBT = new System.Windows.Forms.Button();
            this.wystawBT = new System.Windows.Forms.Button();
            this.charCountLB = new System.Windows.Forms.Label();
            this.typKomentarzaCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // feedbackContentTB
            // 
            this.feedbackContentTB.Location = new System.Drawing.Point(21, 20);
            this.feedbackContentTB.Name = "feedbackContentTB";
            this.feedbackContentTB.Size = new System.Drawing.Size(456, 139);
            this.feedbackContentTB.TabIndex = 0;
            this.feedbackContentTB.Text = "";
            // 
            // anulujBT
            // 
            this.anulujBT.Location = new System.Drawing.Point(367, 181);
            this.anulujBT.Name = "anulujBT";
            this.anulujBT.Size = new System.Drawing.Size(110, 26);
            this.anulujBT.TabIndex = 1;
            this.anulujBT.Text = "Anuluj";
            this.anulujBT.UseVisualStyleBackColor = true;
            this.anulujBT.Click += new System.EventHandler(this.anulujBT_Click);
            // 
            // wystawBT
            // 
            this.wystawBT.Location = new System.Drawing.Point(251, 181);
            this.wystawBT.Name = "wystawBT";
            this.wystawBT.Size = new System.Drawing.Size(110, 26);
            this.wystawBT.TabIndex = 2;
            this.wystawBT.Text = "Wystaw";
            this.wystawBT.UseVisualStyleBackColor = true;
            this.wystawBT.Click += new System.EventHandler(this.wystawBT_Click);
            // 
            // charCountLB
            // 
            this.charCountLB.AutoSize = true;
            this.charCountLB.Location = new System.Drawing.Point(18, 162);
            this.charCountLB.Name = "charCountLB";
            this.charCountLB.Size = new System.Drawing.Size(119, 13);
            this.charCountLB.TabIndex = 3;
            this.charCountLB.Text = "Pozostało znaków: 250";
            // 
            // typKomentarzaCB
            // 
            this.typKomentarzaCB.FormattingEnabled = true;
            this.typKomentarzaCB.Items.AddRange(new object[] {
            "POZYTYWNY",
            "NEGATYWNY",
            "NEUTRALNY"});
            this.typKomentarzaCB.Location = new System.Drawing.Point(126, 186);
            this.typKomentarzaCB.Name = "typKomentarzaCB";
            this.typKomentarzaCB.Size = new System.Drawing.Size(95, 21);
            this.typKomentarzaCB.TabIndex = 4;
            this.typKomentarzaCB.Text = "POZYTYWNY";
            // 
            // wystawKomentarzControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CausesValidation = false;
            this.Controls.Add(this.typKomentarzaCB);
            this.Controls.Add(this.charCountLB);
            this.Controls.Add(this.wystawBT);
            this.Controls.Add(this.anulujBT);
            this.Controls.Add(this.feedbackContentTB);
            this.Name = "wystawKomentarzControl";
            this.Size = new System.Drawing.Size(480, 210);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox feedbackContentTB;
        private System.Windows.Forms.Button anulujBT;
        private System.Windows.Forms.Button wystawBT;
        private System.Windows.Forms.Label charCountLB;
        private System.Windows.Forms.ComboBox typKomentarzaCB;
    }
}
