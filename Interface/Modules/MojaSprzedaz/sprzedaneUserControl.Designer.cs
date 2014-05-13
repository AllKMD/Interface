namespace Interface.MojaSprzedaz
{
    partial class sprzedaneUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.aSellHeaderGroupB = new System.Windows.Forms.GroupBox();
            this.aSellOptionViewSplitC = new System.Windows.Forms.SplitContainer();
            this.aSellWWCComboB = new System.Windows.Forms.ComboBox();
            this.aSellKSWCComboB = new System.Windows.Forms.ComboBox();
            this.aSellOKComboB = new System.Windows.Forms.ComboBox();
            this.aSellWystawioneWCiagu = new System.Windows.Forms.Label();
            this.aSellKończąceSięWCiągu = new System.Windows.Forms.Label();
            this.aSoldofertyKupna = new System.Windows.Forms.Label();
            this.aSellPokazOfertyButton = new System.Windows.Forms.Button();
            this.aSellNLTOTextB = new System.Windows.Forms.TextBox();
            this.aSellCDTextB = new System.Windows.Forms.TextBox();
            this.aSellCOTextB = new System.Windows.Forms.TextBox();
            this.aSellDoo = new System.Windows.Forms.Label();
            this.aSellNumerLubTytułOferty = new System.Windows.Forms.Label();
            this.aSoldCenaOd = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sprzedaneDanePanel = new System.Windows.Forms.Panel();
            this.nieSprzedaneDataGV = new System.Windows.Forms.DataGridView();
            this.NazwaAukcji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilość = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.aSellHeaderGroupB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSellOptionViewSplitC)).BeginInit();
            this.aSellOptionViewSplitC.Panel1.SuspendLayout();
            this.aSellOptionViewSplitC.Panel2.SuspendLayout();
            this.aSellOptionViewSplitC.SuspendLayout();
            this.sprzedaneDanePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nieSprzedaneDataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.aSellHeaderGroupB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 129);
            this.panel1.TabIndex = 1;
            // 
            // aSellHeaderGroupB
            // 
            this.aSellHeaderGroupB.Controls.Add(this.aSellOptionViewSplitC);
            this.aSellHeaderGroupB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aSellHeaderGroupB.Location = new System.Drawing.Point(0, 0);
            this.aSellHeaderGroupB.MaximumSize = new System.Drawing.Size(0, 130);
            this.aSellHeaderGroupB.Name = "aSellHeaderGroupB";
            this.aSellHeaderGroupB.Size = new System.Drawing.Size(751, 129);
            this.aSellHeaderGroupB.TabIndex = 2;
            this.aSellHeaderGroupB.TabStop = false;
            this.aSellHeaderGroupB.Text = "Opcje Przeglądania Sprzedanych Przedmiotów";
            // 
            // aSellOptionViewSplitC
            // 
            this.aSellOptionViewSplitC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aSellOptionViewSplitC.IsSplitterFixed = true;
            this.aSellOptionViewSplitC.Location = new System.Drawing.Point(3, 16);
            this.aSellOptionViewSplitC.MaximumSize = new System.Drawing.Size(0, 130);
            this.aSellOptionViewSplitC.Name = "aSellOptionViewSplitC";
            // 
            // aSellOptionViewSplitC.Panel1
            // 
            this.aSellOptionViewSplitC.Panel1.Controls.Add(this.aSellWWCComboB);
            this.aSellOptionViewSplitC.Panel1.Controls.Add(this.aSellKSWCComboB);
            this.aSellOptionViewSplitC.Panel1.Controls.Add(this.aSellOKComboB);
            this.aSellOptionViewSplitC.Panel1.Controls.Add(this.aSellWystawioneWCiagu);
            this.aSellOptionViewSplitC.Panel1.Controls.Add(this.aSellKończąceSięWCiągu);
            this.aSellOptionViewSplitC.Panel1.Controls.Add(this.aSoldofertyKupna);
            // 
            // aSellOptionViewSplitC.Panel2
            // 
            this.aSellOptionViewSplitC.Panel2.Controls.Add(this.aSellPokazOfertyButton);
            this.aSellOptionViewSplitC.Panel2.Controls.Add(this.aSellNLTOTextB);
            this.aSellOptionViewSplitC.Panel2.Controls.Add(this.aSellCDTextB);
            this.aSellOptionViewSplitC.Panel2.Controls.Add(this.aSellCOTextB);
            this.aSellOptionViewSplitC.Panel2.Controls.Add(this.aSellDoo);
            this.aSellOptionViewSplitC.Panel2.Controls.Add(this.aSellNumerLubTytułOferty);
            this.aSellOptionViewSplitC.Panel2.Controls.Add(this.aSoldCenaOd);
            this.aSellOptionViewSplitC.Size = new System.Drawing.Size(745, 110);
            this.aSellOptionViewSplitC.SplitterDistance = 339;
            this.aSellOptionViewSplitC.TabIndex = 0;
            // 
            // aSellWWCComboB
            // 
            this.aSellWWCComboB.FormattingEnabled = true;
            this.aSellWWCComboB.Items.AddRange(new object[] {
            "-nie wybrana-",
            "1 godziny",
            "3 godzin",
            "6 godzin",
            "12 godzin",
            "24 godzin",
            "2 dni",
            "4 dni ",
            "7 dni"});
            this.aSellWWCComboB.Location = new System.Drawing.Point(124, 75);
            this.aSellWWCComboB.Name = "aSellWWCComboB";
            this.aSellWWCComboB.Size = new System.Drawing.Size(121, 21);
            this.aSellWWCComboB.TabIndex = 5;
            this.aSellWWCComboB.Text = "-nie wybrana-";
            // 
            // aSellKSWCComboB
            // 
            this.aSellKSWCComboB.FormattingEnabled = true;
            this.aSellKSWCComboB.Items.AddRange(new object[] {
            "-nie wybrana-",
            "1 godziny",
            "3 godzin",
            "6 godzin",
            "12 godzin",
            "24 godzin",
            "2 dni",
            "4 dni ",
            "7 dni"});
            this.aSellKSWCComboB.Location = new System.Drawing.Point(124, 51);
            this.aSellKSWCComboB.Name = "aSellKSWCComboB";
            this.aSellKSWCComboB.Size = new System.Drawing.Size(121, 21);
            this.aSellKSWCComboB.TabIndex = 4;
            this.aSellKSWCComboB.Text = "-nie wybrana-";
            // 
            // aSellOKComboB
            // 
            this.aSellOKComboB.FormattingEnabled = true;
            this.aSellOKComboB.Items.AddRange(new object[] {
            "-nie wybrana-",
            "z ofertami",
            "bez ofert"});
            this.aSellOKComboB.Location = new System.Drawing.Point(124, 16);
            this.aSellOKComboB.Name = "aSellOKComboB";
            this.aSellOKComboB.Size = new System.Drawing.Size(121, 21);
            this.aSellOKComboB.TabIndex = 3;
            this.aSellOKComboB.Text = "-nie wybrana-";
            // 
            // aSellWystawioneWCiagu
            // 
            this.aSellWystawioneWCiagu.AutoSize = true;
            this.aSellWystawioneWCiagu.Location = new System.Drawing.Point(10, 78);
            this.aSellWystawioneWCiagu.Name = "aSellWystawioneWCiagu";
            this.aSellWystawioneWCiagu.Size = new System.Drawing.Size(108, 13);
            this.aSellWystawioneWCiagu.TabIndex = 2;
            this.aSellWystawioneWCiagu.Text = "Wystawione w ciągu:";
            // 
            // aSellKończąceSięWCiągu
            // 
            this.aSellKończąceSięWCiągu.AutoSize = true;
            this.aSellKończąceSięWCiągu.Location = new System.Drawing.Point(4, 54);
            this.aSellKończąceSięWCiągu.Name = "aSellKończąceSięWCiągu";
            this.aSellKończąceSięWCiągu.Size = new System.Drawing.Size(114, 13);
            this.aSellKończąceSięWCiągu.TabIndex = 1;
            this.aSellKończąceSięWCiągu.Text = "Kończące się w ciągu:";
            // 
            // aSoldofertyKupna
            // 
            this.aSoldofertyKupna.AutoSize = true;
            this.aSoldofertyKupna.Location = new System.Drawing.Point(46, 19);
            this.aSoldofertyKupna.Name = "aSoldofertyKupna";
            this.aSoldofertyKupna.Size = new System.Drawing.Size(72, 13);
            this.aSoldofertyKupna.TabIndex = 0;
            this.aSoldofertyKupna.Text = "Oferty Kupna:";
            // 
            // aSellPokazOfertyButton
            // 
            this.aSellPokazOfertyButton.Location = new System.Drawing.Point(220, 78);
            this.aSellPokazOfertyButton.Name = "aSellPokazOfertyButton";
            this.aSellPokazOfertyButton.Size = new System.Drawing.Size(135, 23);
            this.aSellPokazOfertyButton.TabIndex = 8;
            this.aSellPokazOfertyButton.Text = "Pokaż Oferty";
            this.aSellPokazOfertyButton.UseVisualStyleBackColor = true;
            // 
            // aSellNLTOTextB
            // 
            this.aSellNLTOTextB.Location = new System.Drawing.Point(121, 51);
            this.aSellNLTOTextB.Name = "aSellNLTOTextB";
            this.aSellNLTOTextB.Size = new System.Drawing.Size(234, 20);
            this.aSellNLTOTextB.TabIndex = 7;
            // 
            // aSellCDTextB
            // 
            this.aSellCDTextB.Location = new System.Drawing.Point(255, 17);
            this.aSellCDTextB.Name = "aSellCDTextB";
            this.aSellCDTextB.Size = new System.Drawing.Size(100, 20);
            this.aSellCDTextB.TabIndex = 6;
            // 
            // aSellCOTextB
            // 
            this.aSellCOTextB.Location = new System.Drawing.Point(121, 16);
            this.aSellCOTextB.Name = "aSellCOTextB";
            this.aSellCOTextB.Size = new System.Drawing.Size(100, 20);
            this.aSellCOTextB.TabIndex = 5;
            // 
            // aSellDoo
            // 
            this.aSellDoo.AutoSize = true;
            this.aSellDoo.Location = new System.Drawing.Point(227, 19);
            this.aSellDoo.Name = "aSellDoo";
            this.aSellDoo.Size = new System.Drawing.Size(22, 13);
            this.aSellDoo.TabIndex = 4;
            this.aSellDoo.Text = "do:";
            // 
            // aSellNumerLubTytułOferty
            // 
            this.aSellNumerLubTytułOferty.AutoSize = true;
            this.aSellNumerLubTytułOferty.Location = new System.Drawing.Point(3, 54);
            this.aSellNumerLubTytułOferty.Name = "aSellNumerLubTytułOferty";
            this.aSellNumerLubTytułOferty.Size = new System.Drawing.Size(111, 13);
            this.aSellNumerLubTytułOferty.TabIndex = 2;
            this.aSellNumerLubTytułOferty.Text = "Numer lub tytuł oferty:";
            // 
            // aSoldCenaOd
            // 
            this.aSoldCenaOd.AutoSize = true;
            this.aSoldCenaOd.Location = new System.Drawing.Point(64, 19);
            this.aSoldCenaOd.Name = "aSoldCenaOd";
            this.aSoldCenaOd.Size = new System.Drawing.Size(50, 13);
            this.aSoldCenaOd.TabIndex = 1;
            this.aSoldCenaOd.Text = "Cena od:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 27);
            this.panel2.TabIndex = 2;
            // 
            // sprzedaneDanePanel
            // 
            this.sprzedaneDanePanel.Controls.Add(this.nieSprzedaneDataGV);
            this.sprzedaneDanePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sprzedaneDanePanel.Location = new System.Drawing.Point(0, 129);
            this.sprzedaneDanePanel.Name = "sprzedaneDanePanel";
            this.sprzedaneDanePanel.Size = new System.Drawing.Size(751, 219);
            this.sprzedaneDanePanel.TabIndex = 4;
            // 
            // nieSprzedaneDataGV
            // 
            this.nieSprzedaneDataGV.AllowUserToAddRows = false;
            this.nieSprzedaneDataGV.AllowUserToDeleteRows = false;
            this.nieSprzedaneDataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nieSprzedaneDataGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nieSprzedaneDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nieSprzedaneDataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazwaAukcji,
            this.Cena,
            this.Ilość,
            this.Data_W});
            this.nieSprzedaneDataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nieSprzedaneDataGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.nieSprzedaneDataGV.Location = new System.Drawing.Point(0, 0);
            this.nieSprzedaneDataGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nieSprzedaneDataGV.Name = "nieSprzedaneDataGV";
            this.nieSprzedaneDataGV.ReadOnly = true;
            this.nieSprzedaneDataGV.Size = new System.Drawing.Size(751, 219);
            this.nieSprzedaneDataGV.TabIndex = 30;
            // 
            // NazwaAukcji
            // 
            this.NazwaAukcji.FillWeight = 227.9202F;
            this.NazwaAukcji.HeaderText = "Nazwa";
            this.NazwaAukcji.Name = "NazwaAukcji";
            this.NazwaAukcji.ReadOnly = true;
            // 
            // Cena
            // 
            this.Cena.FillWeight = 44.42284F;
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            this.Cena.ReadOnly = true;
            // 
            // Ilość
            // 
            this.Ilość.FillWeight = 58.00484F;
            this.Ilość.HeaderText = "Ilość";
            this.Ilość.Name = "Ilość";
            this.Ilość.ReadOnly = true;
            // 
            // Data_W
            // 
            this.Data_W.FillWeight = 69.65209F;
            this.Data_W.HeaderText = "Data wystawienia";
            this.Data_W.Name = "Data_W";
            this.Data_W.ReadOnly = true;
            // 
            // sprzedaneUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sprzedaneDanePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "sprzedaneUserControl";
            this.Size = new System.Drawing.Size(751, 375);
            this.panel1.ResumeLayout(false);
            this.aSellHeaderGroupB.ResumeLayout(false);
            this.aSellOptionViewSplitC.Panel1.ResumeLayout(false);
            this.aSellOptionViewSplitC.Panel1.PerformLayout();
            this.aSellOptionViewSplitC.Panel2.ResumeLayout(false);
            this.aSellOptionViewSplitC.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSellOptionViewSplitC)).EndInit();
            this.aSellOptionViewSplitC.ResumeLayout(false);
            this.sprzedaneDanePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nieSprzedaneDataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox aSellHeaderGroupB;
        private System.Windows.Forms.SplitContainer aSellOptionViewSplitC;
        private System.Windows.Forms.ComboBox aSellWWCComboB;
        private System.Windows.Forms.ComboBox aSellKSWCComboB;
        private System.Windows.Forms.ComboBox aSellOKComboB;
        private System.Windows.Forms.Label aSellWystawioneWCiagu;
        private System.Windows.Forms.Label aSellKończąceSięWCiągu;
        private System.Windows.Forms.Label aSoldofertyKupna;
        private System.Windows.Forms.Button aSellPokazOfertyButton;
        private System.Windows.Forms.TextBox aSellNLTOTextB;
        private System.Windows.Forms.TextBox aSellCDTextB;
        private System.Windows.Forms.TextBox aSellCOTextB;
        private System.Windows.Forms.Label aSellDoo;
        private System.Windows.Forms.Label aSellNumerLubTytułOferty;
        private System.Windows.Forms.Label aSoldCenaOd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sprzedaneDanePanel;
        private System.Windows.Forms.DataGridView nieSprzedaneDataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaAukcji;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilość;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_W;

    }
}
