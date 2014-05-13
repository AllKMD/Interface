namespace Interface
{
    partial class mainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.komentarzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narzędziaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.komentarzeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sprzedażToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprzedajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprzedaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niesprzedaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wystawPrzedmiotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zestawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.logowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 539);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7850, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Stan konta:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.komentarzeToolStripMenuItem,
            this.narzędziaToolStripMenuItem,
            this.logowanieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(290, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // komentarzeToolStripMenuItem
            // 
            this.komentarzeToolStripMenuItem.Name = "komentarzeToolStripMenuItem";
            this.komentarzeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.komentarzeToolStripMenuItem.Text = "Program";
            // 
            // narzędziaToolStripMenuItem
            // 
            this.narzędziaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.komentarzeToolStripMenuItem1,
            this.sprzedażToolStripMenuItem,
            this.wystawPrzedmiotToolStripMenuItem,
            this.zestawieniaToolStripMenuItem});
            this.narzędziaToolStripMenuItem.Name = "narzędziaToolStripMenuItem";
            this.narzędziaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narzędziaToolStripMenuItem.Text = "Narzędzia";
            // 
            // komentarzeToolStripMenuItem1
            // 
            this.komentarzeToolStripMenuItem1.Name = "komentarzeToolStripMenuItem1";
            this.komentarzeToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.komentarzeToolStripMenuItem1.Text = "Komentarze";
            this.komentarzeToolStripMenuItem1.Click += new System.EventHandler(this.komentarzeToolStripMenuItem1_Click);
            // 
            // sprzedażToolStripMenuItem
            // 
            this.sprzedażToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sprzedajeToolStripMenuItem,
            this.sprzedaneToolStripMenuItem,
            this.niesprzedaneToolStripMenuItem});
            this.sprzedażToolStripMenuItem.Name = "sprzedażToolStripMenuItem";
            this.sprzedażToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.sprzedażToolStripMenuItem.Text = "Moja Sprzedaż";
            // 
            // sprzedajeToolStripMenuItem
            // 
            this.sprzedajeToolStripMenuItem.Name = "sprzedajeToolStripMenuItem";
            this.sprzedajeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sprzedajeToolStripMenuItem.Text = "Sprzedaje";
            this.sprzedajeToolStripMenuItem.Click += new System.EventHandler(this.sprzedajeToolStripMenuItem_Click);
            // 
            // sprzedaneToolStripMenuItem
            // 
            this.sprzedaneToolStripMenuItem.Name = "sprzedaneToolStripMenuItem";
            this.sprzedaneToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sprzedaneToolStripMenuItem.Text = "Sprzedane";
            this.sprzedaneToolStripMenuItem.Click += new System.EventHandler(this.sprzedaneToolStripMenuItem_Click);
            // 
            // niesprzedaneToolStripMenuItem
            // 
            this.niesprzedaneToolStripMenuItem.Name = "niesprzedaneToolStripMenuItem";
            this.niesprzedaneToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.niesprzedaneToolStripMenuItem.Text = "Niesprzedane";
            this.niesprzedaneToolStripMenuItem.Click += new System.EventHandler(this.niesprzedaneToolStripMenuItem_Click);
            // 
            // wystawPrzedmiotToolStripMenuItem
            // 
            this.wystawPrzedmiotToolStripMenuItem.Name = "wystawPrzedmiotToolStripMenuItem";
            this.wystawPrzedmiotToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.wystawPrzedmiotToolStripMenuItem.Text = "Wystaw Przedmiot";
            this.wystawPrzedmiotToolStripMenuItem.Click += new System.EventHandler(this.wystawPrzedmiotToolStripMenuItem_Click);
            // 
            // zestawieniaToolStripMenuItem
            // 
            this.zestawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.zestawieniaToolStripMenuItem.Name = "zestawieniaToolStripMenuItem";
            this.zestawieniaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.zestawieniaToolStripMenuItem.Text = "Zestawienia";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(164, 22);
            this.toolStripMenuItem2.Text = "Po przedmiotach";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 22);
            this.toolStripMenuItem3.Text = "Po okresie czasu";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // logowanieToolStripMenuItem
            // 
            this.logowanieToolStripMenuItem.Name = "logowanieToolStripMenuItem";
            this.logowanieToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.logowanieToolStripMenuItem.Text = "Wyloguj";
            this.logowanieToolStripMenuItem.Click += new System.EventHandler(this.logowanieToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7654, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Uzytkownik:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7918, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "-2000 zl";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7968, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Stan konta PayU:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7742, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "allegroUser";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8065, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "1500 zł";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 24);
            this.panel2.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(979, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "1500 zł";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(891, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Stan konta PayU:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(818, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "-2000 zl";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(760, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Stan konta:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(640, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "allegroUser";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(563, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Uzytkownik:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1027, 597);
            this.Name = "mainForm";
            this.Text = "Proste Allegro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem komentarzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narzędziaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem komentarzeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sprzedażToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprzedajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprzedaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niesprzedaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wystawPrzedmiotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logowanieToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem zestawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

    }
}