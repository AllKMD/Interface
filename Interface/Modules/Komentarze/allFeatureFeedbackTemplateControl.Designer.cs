namespace Interface.Modules.Komentarze
{
    partial class allFeatureFeedbackTemplateControl
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
            this.contentTextBox = new System.Windows.Forms.RichTextBox();
            this.saveBT = new System.Windows.Forms.Button();
            this.headerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.feedbackTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(70, 44);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(409, 248);
            this.contentTextBox.TabIndex = 0;
            this.contentTextBox.Text = "";
            // 
            // saveBT
            // 
            this.saveBT.Location = new System.Drawing.Point(353, 311);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(126, 23);
            this.saveBT.TabIndex = 1;
            this.saveBT.Text = "Zapisz";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // headerTextBox
            // 
            this.headerTextBox.Location = new System.Drawing.Point(70, 18);
            this.headerTextBox.Name = "headerTextBox";
            this.headerTextBox.Size = new System.Drawing.Size(409, 20);
            this.headerTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tytuł";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Treść";
            // 
            // feedbackTypeComboBox
            // 
            this.feedbackTypeComboBox.FormattingEnabled = true;
            this.feedbackTypeComboBox.Items.AddRange(new object[] {
            "POZYTYWNY",
            "NEGATYWNY",
            "NEUTRALNY"});
            this.feedbackTypeComboBox.Location = new System.Drawing.Point(70, 313);
            this.feedbackTypeComboBox.Name = "feedbackTypeComboBox";
            this.feedbackTypeComboBox.Size = new System.Drawing.Size(176, 21);
            this.feedbackTypeComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Typ";
            // 
            // allFeatureFeedbackTemplateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feedbackTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerTextBox);
            this.Controls.Add(this.saveBT);
            this.Controls.Add(this.contentTextBox);
            this.Name = "allFeatureFeedbackTemplateControl";
            this.Size = new System.Drawing.Size(506, 372);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox contentTextBox;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.TextBox headerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox feedbackTypeComboBox;
        private System.Windows.Forms.Label label3;
    }
}
