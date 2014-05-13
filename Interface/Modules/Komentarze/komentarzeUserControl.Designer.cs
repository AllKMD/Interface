namespace Interface
{
    partial class komentarzeUserControl
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
            this.topContainerPanel = new System.Windows.Forms.Panel();
            this.innerMidPanel = new System.Windows.Forms.Panel();
            this.infoBoxTB = new System.Windows.Forms.RichTextBox();
            this.innerTopRightPanel = new System.Windows.Forms.Panel();
            this.logoPB = new System.Windows.Forms.PictureBox();
            this.filtrCB = new System.Windows.Forms.ComboBox();
            this.statusKomentarzaLB = new System.Windows.Forms.Label();
            this.wystawBT = new System.Windows.Forms.Button();
            this.uzyjSzablonuBT = new System.Windows.Forms.Button();
            this.innerTopLeftPanel = new System.Windows.Forms.Panel();
            this.komentarzeGB = new System.Windows.Forms.GroupBox();
            this.pozytywneLB = new System.Windows.Forms.Label();
            this.neutralneValueLB = new System.Windows.Forms.Label();
            this.doWystawieniaLB = new System.Windows.Forms.Label();
            this.negatywneValueLB = new System.Windows.Forms.Label();
            this.doWystawieniaValueLB = new System.Windows.Forms.Label();
            this.pozytywneValueLB = new System.Windows.Forms.Label();
            this.negatywneLB = new System.Windows.Forms.Label();
            this.neutralneLB = new System.Windows.Forms.Label();
            this.daneContainerPanel = new System.Windows.Forms.Panel();
            this.daneDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.topContainerPanel.SuspendLayout();
            this.innerMidPanel.SuspendLayout();
            this.innerTopRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.innerTopLeftPanel.SuspendLayout();
            this.komentarzeGB.SuspendLayout();
            this.daneContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daneDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // topContainerPanel
            // 
            this.topContainerPanel.Controls.Add(this.innerMidPanel);
            this.topContainerPanel.Controls.Add(this.innerTopRightPanel);
            this.topContainerPanel.Controls.Add(this.innerTopLeftPanel);
            this.topContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.topContainerPanel.Name = "topContainerPanel";
            this.topContainerPanel.Size = new System.Drawing.Size(1279, 228);
            this.topContainerPanel.TabIndex = 0;
            // 
            // innerMidPanel
            // 
            this.innerMidPanel.Controls.Add(this.infoBoxTB);
            this.innerMidPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.innerMidPanel.Location = new System.Drawing.Point(290, 75);
            this.innerMidPanel.Name = "innerMidPanel";
            this.innerMidPanel.Size = new System.Drawing.Size(511, 153);
            this.innerMidPanel.TabIndex = 62;
            // 
            // infoBoxTB
            // 
            this.infoBoxTB.BackColor = System.Drawing.SystemColors.MenuBar;
            this.infoBoxTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoBoxTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoBoxTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoBoxTB.Enabled = false;
            this.infoBoxTB.Location = new System.Drawing.Point(0, 0);
            this.infoBoxTB.Name = "infoBoxTB";
            this.infoBoxTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.infoBoxTB.Size = new System.Drawing.Size(511, 81);
            this.infoBoxTB.TabIndex = 55;
            this.infoBoxTB.Text = "Zaznacz aukcje a następnie wciśnij Wystaw by wtstawić komentarz lub Użyj szablonu" +
    " by użyć wcześniej zdefiniowanej treści komentarza ";
            // 
            // innerTopRightPanel
            // 
            this.innerTopRightPanel.Controls.Add(this.button1);
            this.innerTopRightPanel.Controls.Add(this.logoPB);
            this.innerTopRightPanel.Controls.Add(this.filtrCB);
            this.innerTopRightPanel.Controls.Add(this.statusKomentarzaLB);
            this.innerTopRightPanel.Controls.Add(this.wystawBT);
            this.innerTopRightPanel.Controls.Add(this.uzyjSzablonuBT);
            this.innerTopRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.innerTopRightPanel.Location = new System.Drawing.Point(801, 0);
            this.innerTopRightPanel.Name = "innerTopRightPanel";
            this.innerTopRightPanel.Size = new System.Drawing.Size(478, 228);
            this.innerTopRightPanel.TabIndex = 61;
            // 
            // logoPB
            // 
            this.logoPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPB.Location = new System.Drawing.Point(12, 29);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(450, 132);
            this.logoPB.TabIndex = 60;
            this.logoPB.TabStop = false;
            // 
            // filtrCB
            // 
            this.filtrCB.CausesValidation = false;
            this.filtrCB.FormattingEnabled = true;
            this.filtrCB.Items.AddRange(new object[] {
            "Otrzymane",
            "Wystawione",
            "Do wystawienia",
            "Nieotrzymane"});
            this.filtrCB.Location = new System.Drawing.Point(294, 194);
            this.filtrCB.Name = "filtrCB";
            this.filtrCB.Size = new System.Drawing.Size(176, 21);
            this.filtrCB.TabIndex = 53;
            this.filtrCB.Text = "Do wystawienia";
            this.filtrCB.SelectedIndexChanged += new System.EventHandler(this.statusKomentarzaCB_SelectedIndexChanged);
            // 
            // statusKomentarzaLB
            // 
            this.statusKomentarzaLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusKomentarzaLB.AutoSize = true;
            this.statusKomentarzaLB.Location = new System.Drawing.Point(248, 198);
            this.statusKomentarzaLB.Name = "statusKomentarzaLB";
            this.statusKomentarzaLB.Size = new System.Drawing.Size(40, 13);
            this.statusKomentarzaLB.TabIndex = 59;
            this.statusKomentarzaLB.Text = "Pokaż:";
            // 
            // wystawBT
            // 
            this.wystawBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wystawBT.Enabled = false;
            this.wystawBT.Location = new System.Drawing.Point(12, 194);
            this.wystawBT.Name = "wystawBT";
            this.wystawBT.Size = new System.Drawing.Size(97, 21);
            this.wystawBT.TabIndex = 56;
            this.wystawBT.Text = "Wystaw";
            this.wystawBT.UseVisualStyleBackColor = true;
            this.wystawBT.Click += new System.EventHandler(this.wystawBT_Click);
            // 
            // uzyjSzablonuBT
            // 
            this.uzyjSzablonuBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uzyjSzablonuBT.Enabled = false;
            this.uzyjSzablonuBT.Location = new System.Drawing.Point(115, 194);
            this.uzyjSzablonuBT.Name = "uzyjSzablonuBT";
            this.uzyjSzablonuBT.Size = new System.Drawing.Size(97, 21);
            this.uzyjSzablonuBT.TabIndex = 57;
            this.uzyjSzablonuBT.Text = "Użyj szablonu";
            this.uzyjSzablonuBT.UseVisualStyleBackColor = true;
            this.uzyjSzablonuBT.Click += new System.EventHandler(this.uzyjSzablonuBT_Click);
            // 
            // innerTopLeftPanel
            // 
            this.innerTopLeftPanel.Controls.Add(this.komentarzeGB);
            this.innerTopLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.innerTopLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.innerTopLeftPanel.Name = "innerTopLeftPanel";
            this.innerTopLeftPanel.Size = new System.Drawing.Size(290, 228);
            this.innerTopLeftPanel.TabIndex = 60;
            // 
            // komentarzeGB
            // 
            this.komentarzeGB.Controls.Add(this.pozytywneLB);
            this.komentarzeGB.Controls.Add(this.neutralneValueLB);
            this.komentarzeGB.Controls.Add(this.doWystawieniaLB);
            this.komentarzeGB.Controls.Add(this.negatywneValueLB);
            this.komentarzeGB.Controls.Add(this.doWystawieniaValueLB);
            this.komentarzeGB.Controls.Add(this.pozytywneValueLB);
            this.komentarzeGB.Controls.Add(this.negatywneLB);
            this.komentarzeGB.Controls.Add(this.neutralneLB);
            this.komentarzeGB.Location = new System.Drawing.Point(30, 36);
            this.komentarzeGB.Name = "komentarzeGB";
            this.komentarzeGB.Size = new System.Drawing.Size(228, 153);
            this.komentarzeGB.TabIndex = 52;
            this.komentarzeGB.TabStop = false;
            this.komentarzeGB.Text = "Komentarze";
            // 
            // pozytywneLB
            // 
            this.pozytywneLB.AutoSize = true;
            this.pozytywneLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pozytywneLB.ForeColor = System.Drawing.Color.ForestGreen;
            this.pozytywneLB.Location = new System.Drawing.Point(21, 28);
            this.pozytywneLB.Name = "pozytywneLB";
            this.pozytywneLB.Size = new System.Drawing.Size(71, 13);
            this.pozytywneLB.TabIndex = 44;
            this.pozytywneLB.Text = "Pozytywne:";
            // 
            // neutralneValueLB
            // 
            this.neutralneValueLB.AutoSize = true;
            this.neutralneValueLB.Location = new System.Drawing.Point(83, 50);
            this.neutralneValueLB.Name = "neutralneValueLB";
            this.neutralneValueLB.Size = new System.Drawing.Size(19, 13);
            this.neutralneValueLB.TabIndex = 50;
            this.neutralneValueLB.Text = "16";
            // 
            // doWystawieniaLB
            // 
            this.doWystawieniaLB.AutoSize = true;
            this.doWystawieniaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.doWystawieniaLB.Location = new System.Drawing.Point(21, 115);
            this.doWystawieniaLB.Name = "doWystawieniaLB";
            this.doWystawieniaLB.Size = new System.Drawing.Size(99, 13);
            this.doWystawieniaLB.TabIndex = 43;
            this.doWystawieniaLB.Text = "Do wystawienia:";
            // 
            // negatywneValueLB
            // 
            this.negatywneValueLB.AutoSize = true;
            this.negatywneValueLB.Location = new System.Drawing.Point(91, 75);
            this.negatywneValueLB.Name = "negatywneValueLB";
            this.negatywneValueLB.Size = new System.Drawing.Size(19, 13);
            this.negatywneValueLB.TabIndex = 49;
            this.negatywneValueLB.Text = "16";
            // 
            // doWystawieniaValueLB
            // 
            this.doWystawieniaValueLB.AutoSize = true;
            this.doWystawieniaValueLB.Location = new System.Drawing.Point(111, 115);
            this.doWystawieniaValueLB.Name = "doWystawieniaValueLB";
            this.doWystawieniaValueLB.Size = new System.Drawing.Size(19, 13);
            this.doWystawieniaValueLB.TabIndex = 45;
            this.doWystawieniaValueLB.Text = "16";
            // 
            // pozytywneValueLB
            // 
            this.pozytywneValueLB.AutoSize = true;
            this.pozytywneValueLB.Location = new System.Drawing.Point(88, 28);
            this.pozytywneValueLB.Name = "pozytywneValueLB";
            this.pozytywneValueLB.Size = new System.Drawing.Size(19, 13);
            this.pozytywneValueLB.TabIndex = 48;
            this.pozytywneValueLB.Text = "16";
            // 
            // negatywneLB
            // 
            this.negatywneLB.AutoSize = true;
            this.negatywneLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.negatywneLB.ForeColor = System.Drawing.Color.Red;
            this.negatywneLB.Location = new System.Drawing.Point(21, 75);
            this.negatywneLB.Name = "negatywneLB";
            this.negatywneLB.Size = new System.Drawing.Size(74, 13);
            this.negatywneLB.TabIndex = 46;
            this.negatywneLB.Text = "Negatywne:";
            // 
            // neutralneLB
            // 
            this.neutralneLB.AutoSize = true;
            this.neutralneLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.neutralneLB.Location = new System.Drawing.Point(21, 50);
            this.neutralneLB.Name = "neutralneLB";
            this.neutralneLB.Size = new System.Drawing.Size(66, 13);
            this.neutralneLB.TabIndex = 47;
            this.neutralneLB.Text = "Neutralne:";
            // 
            // daneContainerPanel
            // 
            this.daneContainerPanel.Controls.Add(this.daneDGV);
            this.daneContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daneContainerPanel.Location = new System.Drawing.Point(0, 228);
            this.daneContainerPanel.Name = "daneContainerPanel";
            this.daneContainerPanel.Size = new System.Drawing.Size(1279, 386);
            this.daneContainerPanel.TabIndex = 1;
            // 
            // daneDGV
            // 
            this.daneDGV.AllowUserToAddRows = false;
            this.daneDGV.AllowUserToDeleteRows = false;
            this.daneDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.daneDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daneDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daneDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.daneDGV.Location = new System.Drawing.Point(0, 0);
            this.daneDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.daneDGV.Name = "daneDGV";
            this.daneDGV.ReadOnly = true;
            this.daneDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.daneDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.daneDGV.Size = new System.Drawing.Size(1279, 386);
            this.daneDGV.StandardTab = true;
            this.daneDGV.TabIndex = 31;
            this.daneDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.daneDGV_CellClick);
            this.daneDGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.daneDGV_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // komentarzeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.daneContainerPanel);
            this.Controls.Add(this.topContainerPanel);
            this.Name = "komentarzeUserControl";
            this.Size = new System.Drawing.Size(1279, 614);
            this.topContainerPanel.ResumeLayout(false);
            this.innerMidPanel.ResumeLayout(false);
            this.innerTopRightPanel.ResumeLayout(false);
            this.innerTopRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.innerTopLeftPanel.ResumeLayout(false);
            this.komentarzeGB.ResumeLayout(false);
            this.komentarzeGB.PerformLayout();
            this.daneContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.daneDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topContainerPanel;
        private System.Windows.Forms.Panel daneContainerPanel;
        private System.Windows.Forms.DataGridView daneDGV;
        private System.Windows.Forms.GroupBox komentarzeGB;
        private System.Windows.Forms.Label pozytywneLB;
        private System.Windows.Forms.Label neutralneValueLB;
        private System.Windows.Forms.Label doWystawieniaLB;
        private System.Windows.Forms.Label negatywneValueLB;
        private System.Windows.Forms.Label doWystawieniaValueLB;
        private System.Windows.Forms.Label pozytywneValueLB;
        private System.Windows.Forms.Label negatywneLB;
        private System.Windows.Forms.Label neutralneLB;
        private System.Windows.Forms.RichTextBox infoBoxTB;
        private System.Windows.Forms.Panel innerMidPanel;
        private System.Windows.Forms.Panel innerTopLeftPanel;
        private System.Windows.Forms.Panel innerTopRightPanel;
        private System.Windows.Forms.ComboBox filtrCB;
        private System.Windows.Forms.Label statusKomentarzaLB;
        private System.Windows.Forms.Button wystawBT;
        private System.Windows.Forms.Button uzyjSzablonuBT;
        private System.Windows.Forms.PictureBox logoPB;
        private System.Windows.Forms.Button button1;
    }
}
