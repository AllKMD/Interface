namespace Interface
{
    partial class zestawieniaUserControl
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
            this.interfacePanel = new System.Windows.Forms.Panel();
            this.typZesLb = new System.Windows.Forms.Label();
            this.zestawienieLb = new System.Windows.Forms.Label();
            this.profitTypeBox = new System.Windows.Forms.ComboBox();
            this.showByCBox = new System.Windows.Forms.ComboBox();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.zestawieniaGrid = new System.Windows.Forms.DataGridView();
            this.showByClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyskClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolSPanel = new System.Windows.Forms.Panel();
            this.toolTipLb = new System.Windows.Forms.Label();
            this.datePanel = new System.Windows.Forms.Panel();
            this.doLb = new System.Windows.Forms.Label();
            this.odLb = new System.Windows.Forms.Label();
            this.doDatePicker = new System.Windows.Forms.DateTimePicker();
            this.odDatePicker = new System.Windows.Forms.DateTimePicker();
            this.interfacePanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zestawieniaGrid)).BeginInit();
            this.toolSPanel.SuspendLayout();
            this.datePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // interfacePanel
            // 
            this.interfacePanel.Controls.Add(this.typZesLb);
            this.interfacePanel.Controls.Add(this.zestawienieLb);
            this.interfacePanel.Controls.Add(this.profitTypeBox);
            this.interfacePanel.Controls.Add(this.showByCBox);
            this.interfacePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.interfacePanel.Location = new System.Drawing.Point(0, 48);
            this.interfacePanel.Name = "interfacePanel";
            this.interfacePanel.Size = new System.Drawing.Size(210, 427);
            this.interfacePanel.TabIndex = 0;
            // 
            // typZesLb
            // 
            this.typZesLb.AutoSize = true;
            this.typZesLb.Location = new System.Drawing.Point(16, 73);
            this.typZesLb.Name = "typZesLb";
            this.typZesLb.Size = new System.Drawing.Size(86, 13);
            this.typZesLb.TabIndex = 3;
            this.typZesLb.Text = "Typ zestawienia:";
            // 
            // zestawienieLb
            // 
            this.zestawienieLb.AutoSize = true;
            this.zestawienieLb.Location = new System.Drawing.Point(13, 13);
            this.zestawienieLb.Name = "zestawienieLb";
            this.zestawienieLb.Size = new System.Drawing.Size(67, 13);
            this.zestawienieLb.TabIndex = 2;
            this.zestawienieLb.Text = "Zestawienie:";
            // 
            // profitTypeBox
            // 
            this.profitTypeBox.FormattingEnabled = true;
            this.profitTypeBox.Items.AddRange(new object[] {
            "Netto",
            "Brutto"});
            this.profitTypeBox.Location = new System.Drawing.Point(16, 98);
            this.profitTypeBox.Name = "profitTypeBox";
            this.profitTypeBox.Size = new System.Drawing.Size(155, 21);
            this.profitTypeBox.TabIndex = 1;
            this.profitTypeBox.Text = "Brutto";
            // 
            // showByCBox
            // 
            this.showByCBox.FormattingEnabled = true;
            this.showByCBox.Items.AddRange(new object[] {
            "Zestawienie według dni",
            "Zestawienie według miesięcy",
            "Zestawienie według lat"});
            this.showByCBox.Location = new System.Drawing.Point(16, 39);
            this.showByCBox.Name = "showByCBox";
            this.showByCBox.Size = new System.Drawing.Size(155, 21);
            this.showByCBox.TabIndex = 0;
            this.showByCBox.Text = "Zestawienie według dni";
            this.showByCBox.SelectedIndexChanged += new System.EventHandler(this.showByCBox_SelectedIndexChanged);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.zestawieniaGrid);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(210, 48);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(700, 427);
            this.dataPanel.TabIndex = 1;
            // 
            // zestawieniaGrid
            // 
            this.zestawieniaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zestawieniaGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.zestawieniaGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zestawieniaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zestawieniaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.showByClm,
            this.zyskClm});
            this.zestawieniaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zestawieniaGrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.zestawieniaGrid.Location = new System.Drawing.Point(0, 0);
            this.zestawieniaGrid.Name = "zestawieniaGrid";
            this.zestawieniaGrid.Size = new System.Drawing.Size(700, 427);
            this.zestawieniaGrid.TabIndex = 0;
            // 
            // showByClm
            // 
            this.showByClm.HeaderText = "Miesiąc";
            this.showByClm.Name = "showByClm";
            // 
            // zyskClm
            // 
            this.zyskClm.HeaderText = "Zysk";
            this.zyskClm.Name = "zyskClm";
            // 
            // toolSPanel
            // 
            this.toolSPanel.Controls.Add(this.toolTipLb);
            this.toolSPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolSPanel.Location = new System.Drawing.Point(0, 475);
            this.toolSPanel.Name = "toolSPanel";
            this.toolSPanel.Size = new System.Drawing.Size(910, 29);
            this.toolSPanel.TabIndex = 2;
            // 
            // toolTipLb
            // 
            this.toolTipLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolTipLb.AutoSize = true;
            this.toolTipLb.Location = new System.Drawing.Point(308, 3);
            this.toolTipLb.Name = "toolTipLb";
            this.toolTipLb.Size = new System.Drawing.Size(319, 13);
            this.toolTipLb.TabIndex = 0;
            this.toolTipLb.Text = "Wybierz przedział czasowy i/lub kryteria wyświetlania zestawienia.";
            // 
            // datePanel
            // 
            this.datePanel.Controls.Add(this.odDatePicker);
            this.datePanel.Controls.Add(this.doDatePicker);
            this.datePanel.Controls.Add(this.doLb);
            this.datePanel.Controls.Add(this.odLb);
            this.datePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.datePanel.Location = new System.Drawing.Point(0, 0);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(910, 48);
            this.datePanel.TabIndex = 3;
            // 
            // doLb
            // 
            this.doLb.AutoSize = true;
            this.doLb.Location = new System.Drawing.Point(601, 26);
            this.doLb.Name = "doLb";
            this.doLb.Size = new System.Drawing.Size(24, 13);
            this.doLb.TabIndex = 5;
            this.doLb.Text = "Do:";
            // 
            // odLb
            // 
            this.odLb.AutoSize = true;
            this.odLb.Location = new System.Drawing.Point(328, 26);
            this.odLb.Name = "odLb";
            this.odLb.Size = new System.Drawing.Size(48, 13);
            this.odLb.TabIndex = 4;
            this.odLb.Text = "Data od:";
            // 
            // doDatePicker
            // 
            this.doDatePicker.Location = new System.Drawing.Point(628, 20);
            this.doDatePicker.Name = "doDatePicker";
            this.doDatePicker.Size = new System.Drawing.Size(143, 20);
            this.doDatePicker.TabIndex = 6;
            // 
            // odDatePicker
            // 
            this.odDatePicker.Location = new System.Drawing.Point(382, 21);
            this.odDatePicker.Name = "odDatePicker";
            this.odDatePicker.Size = new System.Drawing.Size(131, 20);
            this.odDatePicker.TabIndex = 7;
            // 
            // zestawieniaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.interfacePanel);
            this.Controls.Add(this.datePanel);
            this.Controls.Add(this.toolSPanel);
            this.Name = "zestawieniaUserControl";
            this.Size = new System.Drawing.Size(910, 504);
            this.interfacePanel.ResumeLayout(false);
            this.interfacePanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zestawieniaGrid)).EndInit();
            this.toolSPanel.ResumeLayout(false);
            this.toolSPanel.PerformLayout();
            this.datePanel.ResumeLayout(false);
            this.datePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel interfacePanel;
        private System.Windows.Forms.ComboBox showByCBox;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.ComboBox profitTypeBox;
        private System.Windows.Forms.Panel toolSPanel;
        private System.Windows.Forms.Panel datePanel;
        private System.Windows.Forms.DataGridView zestawieniaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn showByClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyskClm;
        private System.Windows.Forms.Label typZesLb;
        private System.Windows.Forms.Label zestawienieLb;
        private System.Windows.Forms.Label toolTipLb;
        private System.Windows.Forms.Label doLb;
        private System.Windows.Forms.Label odLb;
        private System.Windows.Forms.DateTimePicker odDatePicker;
        private System.Windows.Forms.DateTimePicker doDatePicker;











    }
}
