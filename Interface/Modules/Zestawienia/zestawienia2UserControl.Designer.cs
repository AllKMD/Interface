namespace Interface
{
    partial class zestawienia2UserControl
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
            this.toolTipPanel = new System.Windows.Forms.Panel();
            this.typeContainer = new System.Windows.Forms.SplitContainer();
            this.kupioneData = new System.Windows.Forms.DataGridView();
            this.kupioneTopPanel = new System.Windows.Forms.Panel();
            this.kupioneTopLabel = new System.Windows.Forms.Label();
            this.sprzedaneData = new System.Windows.Forms.DataGridView();
            this.sprzedaneTopPanel = new System.Windows.Forms.Panel();
            this.sprzedaneTopLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftMidsplit = new System.Windows.Forms.Splitter();
            this.midRightSplit = new System.Windows.Forms.Splitter();
            this.soldTotalLb = new System.Windows.Forms.Label();
            this.totalLb = new System.Windows.Forms.Label();
            this.boughtTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kupioneNazwaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupioneKategoriaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupioneCenaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZakupu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprzedaneNazwaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprzedaneKategoriaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprzedaneCenaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSprzedazy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeContainer)).BeginInit();
            this.typeContainer.Panel1.SuspendLayout();
            this.typeContainer.Panel2.SuspendLayout();
            this.typeContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kupioneData)).BeginInit();
            this.kupioneTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprzedaneData)).BeginInit();
            this.sprzedaneTopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTipPanel
            // 
            this.toolTipPanel.Controls.Add(this.label1);
            this.toolTipPanel.Controls.Add(this.panel1);
            this.toolTipPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolTipPanel.Location = new System.Drawing.Point(0, 663);
            this.toolTipPanel.Name = "toolTipPanel";
            this.toolTipPanel.Size = new System.Drawing.Size(1120, 83);
            this.toolTipPanel.TabIndex = 0;
            // 
            // typeContainer
            // 
            this.typeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeContainer.Location = new System.Drawing.Point(0, 0);
            this.typeContainer.Name = "typeContainer";
            // 
            // typeContainer.Panel1
            // 
            this.typeContainer.Panel1.Controls.Add(this.kupioneData);
            this.typeContainer.Panel1.Controls.Add(this.kupioneTopPanel);
            // 
            // typeContainer.Panel2
            // 
            this.typeContainer.Panel2.Controls.Add(this.sprzedaneData);
            this.typeContainer.Panel2.Controls.Add(this.sprzedaneTopPanel);
            this.typeContainer.Size = new System.Drawing.Size(1120, 663);
            this.typeContainer.SplitterDistance = 556;
            this.typeContainer.TabIndex = 1;
            // 
            // kupioneData
            // 
            this.kupioneData.AllowUserToDeleteRows = false;
            this.kupioneData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.kupioneData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kupioneData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kupioneNazwaColumn,
            this.kupioneKategoriaColumn,
            this.kupioneCenaColumn,
            this.dataZakupu});
            this.kupioneData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kupioneData.Location = new System.Drawing.Point(0, 100);
            this.kupioneData.Name = "kupioneData";
            this.kupioneData.ReadOnly = true;
            this.kupioneData.Size = new System.Drawing.Size(556, 563);
            this.kupioneData.TabIndex = 1;
            // 
            // kupioneTopPanel
            // 
            this.kupioneTopPanel.Controls.Add(this.kupioneTopLabel);
            this.kupioneTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kupioneTopPanel.Location = new System.Drawing.Point(0, 0);
            this.kupioneTopPanel.Name = "kupioneTopPanel";
            this.kupioneTopPanel.Size = new System.Drawing.Size(556, 100);
            this.kupioneTopPanel.TabIndex = 0;
            // 
            // kupioneTopLabel
            // 
            this.kupioneTopLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kupioneTopLabel.AutoSize = true;
            this.kupioneTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kupioneTopLabel.Location = new System.Drawing.Point(234, 44);
            this.kupioneTopLabel.Name = "kupioneTopLabel";
            this.kupioneTopLabel.Size = new System.Drawing.Size(98, 25);
            this.kupioneTopLabel.TabIndex = 0;
            this.kupioneTopLabel.Text = "Kupione";
            this.kupioneTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sprzedaneData
            // 
            this.sprzedaneData.AllowUserToDeleteRows = false;
            this.sprzedaneData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.sprzedaneData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sprzedaneData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sprzedaneNazwaColumn,
            this.sprzedaneKategoriaColumn,
            this.sprzedaneCenaColumn,
            this.dataSprzedazy});
            this.sprzedaneData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sprzedaneData.Location = new System.Drawing.Point(0, 100);
            this.sprzedaneData.Name = "sprzedaneData";
            this.sprzedaneData.ReadOnly = true;
            this.sprzedaneData.Size = new System.Drawing.Size(560, 563);
            this.sprzedaneData.TabIndex = 1;
            // 
            // sprzedaneTopPanel
            // 
            this.sprzedaneTopPanel.Controls.Add(this.sprzedaneTopLabel);
            this.sprzedaneTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sprzedaneTopPanel.Location = new System.Drawing.Point(0, 0);
            this.sprzedaneTopPanel.Name = "sprzedaneTopPanel";
            this.sprzedaneTopPanel.Size = new System.Drawing.Size(560, 100);
            this.sprzedaneTopPanel.TabIndex = 0;
            // 
            // sprzedaneTopLabel
            // 
            this.sprzedaneTopLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sprzedaneTopLabel.AutoSize = true;
            this.sprzedaneTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sprzedaneTopLabel.Location = new System.Drawing.Point(225, 44);
            this.sprzedaneTopLabel.Name = "sprzedaneTopLabel";
            this.sprzedaneTopLabel.Size = new System.Drawing.Size(125, 25);
            this.sprzedaneTopLabel.TabIndex = 0;
            this.sprzedaneTopLabel.Text = "Sprzedane";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boughtTotal);
            this.panel1.Controls.Add(this.totalLb);
            this.panel1.Controls.Add(this.soldTotalLb);
            this.panel1.Controls.Add(this.midRightSplit);
            this.panel1.Controls.Add(this.leftMidsplit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 56);
            this.panel1.TabIndex = 0;
            // 
            // leftMidsplit
            // 
            this.leftMidsplit.Location = new System.Drawing.Point(0, 0);
            this.leftMidsplit.Name = "leftMidsplit";
            this.leftMidsplit.Size = new System.Drawing.Size(370, 56);
            this.leftMidsplit.TabIndex = 0;
            this.leftMidsplit.TabStop = false;
            // 
            // midRightSplit
            // 
            this.midRightSplit.Location = new System.Drawing.Point(370, 0);
            this.midRightSplit.Name = "midRightSplit";
            this.midRightSplit.Size = new System.Drawing.Size(368, 56);
            this.midRightSplit.TabIndex = 1;
            this.midRightSplit.TabStop = false;
            // 
            // soldTotalLb
            // 
            this.soldTotalLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.soldTotalLb.AutoSize = true;
            this.soldTotalLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.soldTotalLb.Location = new System.Drawing.Point(875, 12);
            this.soldTotalLb.Name = "soldTotalLb";
            this.soldTotalLb.Size = new System.Drawing.Size(71, 25);
            this.soldTotalLb.TabIndex = 2;
            this.soldTotalLb.Text = "+ 400";
            // 
            // totalLb
            // 
            this.totalLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalLb.AutoSize = true;
            this.totalLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalLb.Location = new System.Drawing.Point(496, 12);
            this.totalLb.Name = "totalLb";
            this.totalLb.Size = new System.Drawing.Size(124, 25);
            this.totalLb.TabIndex = 3;
            this.totalLb.Text = "Suma: 200";
            // 
            // boughtTotal
            // 
            this.boughtTotal.AutoSize = true;
            this.boughtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boughtTotal.Location = new System.Drawing.Point(173, 12);
            this.boughtTotal.Name = "boughtTotal";
            this.boughtTotal.Size = new System.Drawing.Size(59, 25);
            this.boughtTotal.TabIndex = 4;
            this.boughtTotal.Text = "-200";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz interesujące Cię przedmioty z jednej/obu kategorii";
            // 
            // kupioneNazwaColumn
            // 
            this.kupioneNazwaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kupioneNazwaColumn.HeaderText = "Nazwa";
            this.kupioneNazwaColumn.Name = "kupioneNazwaColumn";
            this.kupioneNazwaColumn.ReadOnly = true;
            // 
            // kupioneKategoriaColumn
            // 
            this.kupioneKategoriaColumn.HeaderText = "Kategoria";
            this.kupioneKategoriaColumn.Name = "kupioneKategoriaColumn";
            this.kupioneKategoriaColumn.ReadOnly = true;
            // 
            // kupioneCenaColumn
            // 
            this.kupioneCenaColumn.HeaderText = "Cena";
            this.kupioneCenaColumn.Name = "kupioneCenaColumn";
            this.kupioneCenaColumn.ReadOnly = true;
            // 
            // dataZakupu
            // 
            this.dataZakupu.HeaderText = "Data zakupu";
            this.dataZakupu.Name = "dataZakupu";
            this.dataZakupu.ReadOnly = true;
            // 
            // sprzedaneNazwaColumn
            // 
            this.sprzedaneNazwaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sprzedaneNazwaColumn.HeaderText = "Nazwa";
            this.sprzedaneNazwaColumn.Name = "sprzedaneNazwaColumn";
            this.sprzedaneNazwaColumn.ReadOnly = true;
            // 
            // sprzedaneKategoriaColumn
            // 
            this.sprzedaneKategoriaColumn.HeaderText = "Kategoria";
            this.sprzedaneKategoriaColumn.Name = "sprzedaneKategoriaColumn";
            this.sprzedaneKategoriaColumn.ReadOnly = true;
            // 
            // sprzedaneCenaColumn
            // 
            this.sprzedaneCenaColumn.HeaderText = "Cena";
            this.sprzedaneCenaColumn.Name = "sprzedaneCenaColumn";
            this.sprzedaneCenaColumn.ReadOnly = true;
            // 
            // dataSprzedazy
            // 
            this.dataSprzedazy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataSprzedazy.HeaderText = "Data sprzedazy";
            this.dataSprzedazy.Name = "dataSprzedazy";
            this.dataSprzedazy.ReadOnly = true;
            // 
            // zestawienia2UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.typeContainer);
            this.Controls.Add(this.toolTipPanel);
            this.Name = "zestawienia2UserControl";
            this.Size = new System.Drawing.Size(1120, 746);
            this.toolTipPanel.ResumeLayout(false);
            this.toolTipPanel.PerformLayout();
            this.typeContainer.Panel1.ResumeLayout(false);
            this.typeContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typeContainer)).EndInit();
            this.typeContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kupioneData)).EndInit();
            this.kupioneTopPanel.ResumeLayout(false);
            this.kupioneTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprzedaneData)).EndInit();
            this.sprzedaneTopPanel.ResumeLayout(false);
            this.sprzedaneTopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolTipPanel;
        private System.Windows.Forms.SplitContainer typeContainer;
        private System.Windows.Forms.Panel kupioneTopPanel;
        private System.Windows.Forms.Label kupioneTopLabel;
        private System.Windows.Forms.Panel sprzedaneTopPanel;
        private System.Windows.Forms.Label sprzedaneTopLabel;
        private System.Windows.Forms.DataGridView kupioneData;
        private System.Windows.Forms.DataGridView sprzedaneData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label boughtTotal;
        private System.Windows.Forms.Label totalLb;
        private System.Windows.Forms.Label soldTotalLb;
        private System.Windows.Forms.Splitter midRightSplit;
        private System.Windows.Forms.Splitter leftMidsplit;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupioneNazwaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupioneKategoriaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupioneCenaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZakupu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprzedaneNazwaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprzedaneKategoriaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprzedaneCenaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSprzedazy;




    }
}
