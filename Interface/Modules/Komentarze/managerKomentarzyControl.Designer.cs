namespace Interface.Komentarze
{
    partial class managerKomentarzyControl
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
            this.uzyjBT = new System.Windows.Forms.Button();
            this.edytujBT = new System.Windows.Forms.Button();
            this.dodajBT = new System.Windows.Forms.Button();
            this.usunBT = new System.Windows.Forms.Button();
            this.anulujBT = new System.Windows.Forms.Button();
            this.pokazBT = new System.Windows.Forms.Button();
            this.komentarzContentLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uzyjBT
            // 
            this.uzyjBT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uzyjBT.Location = new System.Drawing.Point(299, 208);
            this.uzyjBT.Name = "uzyjBT";
            this.uzyjBT.Size = new System.Drawing.Size(110, 26);
            this.uzyjBT.TabIndex = 3;
            this.uzyjBT.Text = "Użyj";
            this.uzyjBT.UseVisualStyleBackColor = true;
            this.uzyjBT.Click += new System.EventHandler(this.uzyjBT_Click);
            // 
            // edytujBT
            // 
            this.edytujBT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.edytujBT.Location = new System.Drawing.Point(415, 92);
            this.edytujBT.Name = "edytujBT";
            this.edytujBT.Size = new System.Drawing.Size(110, 26);
            this.edytujBT.TabIndex = 4;
            this.edytujBT.Text = "Edytuj";
            this.edytujBT.UseVisualStyleBackColor = true;
            this.edytujBT.Click += new System.EventHandler(this.edytujBT_Click);
            // 
            // dodajBT
            // 
            this.dodajBT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dodajBT.Location = new System.Drawing.Point(415, 60);
            this.dodajBT.Name = "dodajBT";
            this.dodajBT.Size = new System.Drawing.Size(110, 26);
            this.dodajBT.TabIndex = 5;
            this.dodajBT.Text = "Dodaj";
            this.dodajBT.UseVisualStyleBackColor = true;
            this.dodajBT.Click += new System.EventHandler(this.dodajBT_Click);
            // 
            // usunBT
            // 
            this.usunBT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usunBT.Location = new System.Drawing.Point(415, 124);
            this.usunBT.Name = "usunBT";
            this.usunBT.Size = new System.Drawing.Size(110, 26);
            this.usunBT.TabIndex = 6;
            this.usunBT.Text = "Usuń";
            this.usunBT.UseVisualStyleBackColor = true;
            this.usunBT.Click += new System.EventHandler(this.usunBT_Click);
            // 
            // anulujBT
            // 
            this.anulujBT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.anulujBT.Location = new System.Drawing.Point(415, 208);
            this.anulujBT.Name = "anulujBT";
            this.anulujBT.Size = new System.Drawing.Size(110, 26);
            this.anulujBT.TabIndex = 7;
            this.anulujBT.Text = "Anuluj";
            this.anulujBT.UseVisualStyleBackColor = true;
            this.anulujBT.Click += new System.EventHandler(this.anulujBT_Click);
            // 
            // pokazBT
            // 
            this.pokazBT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pokazBT.Location = new System.Drawing.Point(415, 15);
            this.pokazBT.Name = "pokazBT";
            this.pokazBT.Size = new System.Drawing.Size(110, 26);
            this.pokazBT.TabIndex = 8;
            this.pokazBT.Text = "Pokaż";
            this.pokazBT.UseVisualStyleBackColor = true;
            this.pokazBT.Click += new System.EventHandler(this.pokazBT_Click);
            // 
            // komentarzContentLB
            // 
            this.komentarzContentLB.FormattingEnabled = true;
            this.komentarzContentLB.Location = new System.Drawing.Point(20, 15);
            this.komentarzContentLB.Name = "komentarzContentLB";
            this.komentarzContentLB.Size = new System.Drawing.Size(376, 173);
            this.komentarzContentLB.TabIndex = 9;
            this.komentarzContentLB.SelectedIndexChanged += new System.EventHandler(this.komentarzContentLB_SelectedIndexChanged);
            // 
            // managerKomentarzyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.komentarzContentLB);
            this.Controls.Add(this.pokazBT);
            this.Controls.Add(this.anulujBT);
            this.Controls.Add(this.usunBT);
            this.Controls.Add(this.dodajBT);
            this.Controls.Add(this.edytujBT);
            this.Controls.Add(this.uzyjBT);
            this.Name = "managerKomentarzyControl";
            this.Size = new System.Drawing.Size(547, 253);
            this.Load += new System.EventHandler(this.managerSzablonowControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uzyjBT;
        private System.Windows.Forms.Button edytujBT;
        private System.Windows.Forms.Button dodajBT;
        private System.Windows.Forms.Button usunBT;
        private System.Windows.Forms.Button anulujBT;
        private System.Windows.Forms.Button pokazBT;
        private System.Windows.Forms.ListBox komentarzContentLB;

    }
}
