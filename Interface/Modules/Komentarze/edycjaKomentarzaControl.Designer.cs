namespace Interface.Komentarze
{
    partial class edycjaKomentarzaControl
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
            this.trescKomentarzaTB = new System.Windows.Forms.RichTextBox();
            this.anulujButton = new System.Windows.Forms.Button();
            this.zapiszBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trescKomentarzaTB
            // 
            this.trescKomentarzaTB.Location = new System.Drawing.Point(3, 3);
            this.trescKomentarzaTB.Name = "trescKomentarzaTB";
            this.trescKomentarzaTB.Size = new System.Drawing.Size(464, 167);
            this.trescKomentarzaTB.TabIndex = 0;
            this.trescKomentarzaTB.Text = "Tresc komentarza...";
            // 
            // anulujButton
            // 
            this.anulujButton.Location = new System.Drawing.Point(342, 176);
            this.anulujButton.Name = "anulujButton";
            this.anulujButton.Size = new System.Drawing.Size(125, 29);
            this.anulujButton.TabIndex = 1;
            this.anulujButton.Text = "Anuluj";
            this.anulujButton.UseVisualStyleBackColor = true;
            this.anulujButton.Click += new System.EventHandler(this.anulujButton_Click);
            // 
            // zapiszBT
            // 
            this.zapiszBT.Location = new System.Drawing.Point(211, 176);
            this.zapiszBT.Name = "zapiszBT";
            this.zapiszBT.Size = new System.Drawing.Size(125, 29);
            this.zapiszBT.TabIndex = 2;
            this.zapiszBT.Text = "Zapisz";
            this.zapiszBT.UseVisualStyleBackColor = true;
            this.zapiszBT.Visible = false;
            this.zapiszBT.Click += new System.EventHandler(this.zapiszBT_Click);
            // 
            // edycjaKomentarzaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.zapiszBT);
            this.Controls.Add(this.anulujButton);
            this.Controls.Add(this.trescKomentarzaTB);
            this.Name = "edycjaKomentarzaControl";
            this.Size = new System.Drawing.Size(471, 213);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox trescKomentarzaTB;
        private System.Windows.Forms.Button anulujButton;
        private System.Windows.Forms.Button zapiszBT;
    }
}
