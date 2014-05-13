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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wystawKomentarzControl));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.anulujBT = new System.Windows.Forms.Button();
            this.wystawBT = new System.Windows.Forms.Button();
            this.liczbaZnakowLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // anulujBT
            // 
            resources.ApplyResources(this.anulujBT, "anulujBT");
            this.anulujBT.Name = "anulujBT";
            this.anulujBT.UseVisualStyleBackColor = true;
            this.anulujBT.Click += new System.EventHandler(this.anulujBT_Click);
            // 
            // wystawBT
            // 
            resources.ApplyResources(this.wystawBT, "wystawBT");
            this.wystawBT.Name = "wystawBT";
            this.wystawBT.UseVisualStyleBackColor = true;
            this.wystawBT.Click += new System.EventHandler(this.wystawBT_Click);
            // 
            // liczbaZnakowLB
            // 
            resources.ApplyResources(this.liczbaZnakowLB, "liczbaZnakowLB");
            this.liczbaZnakowLB.Name = "liczbaZnakowLB";
            // 
            // wystawKomentarzControl
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.Controls.Add(this.liczbaZnakowLB);
            this.Controls.Add(this.wystawBT);
            this.Controls.Add(this.anulujBT);
            this.Controls.Add(this.richTextBox1);
            this.Name = "wystawKomentarzControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button anulujBT;
        private System.Windows.Forms.Button wystawBT;
        private System.Windows.Forms.Label liczbaZnakowLB;
    }
}
