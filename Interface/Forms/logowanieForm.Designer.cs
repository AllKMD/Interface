namespace Interface
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginTextB = new System.Windows.Forms.TextBox();
            this.hasloTextB = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.hasloLabel = new System.Windows.Forms.Label();
            this.logujButton = new System.Windows.Forms.Button();
            this.wyjdzButton = new System.Windows.Forms.Button();
            this.imglogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTextB
            // 
            this.loginTextB.Location = new System.Drawing.Point(89, 89);
            this.loginTextB.Name = "loginTextB";
            this.loginTextB.Size = new System.Drawing.Size(241, 20);
            this.loginTextB.TabIndex = 0;
            // 
            // hasloTextB
            // 
            this.hasloTextB.Location = new System.Drawing.Point(89, 133);
            this.hasloTextB.Name = "hasloTextB";
            this.hasloTextB.Size = new System.Drawing.Size(241, 20);
            this.hasloTextB.TabIndex = 1;
            this.hasloTextB.UseSystemPasswordChar = true;
            this.hasloTextB.Enter += new System.EventHandler(this.hasloTextB_Enter);
            this.hasloTextB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hasloTextB_KeyPress);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(45, 92);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(36, 13);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login:";
            // 
            // hasloLabel
            // 
            this.hasloLabel.AutoSize = true;
            this.hasloLabel.Location = new System.Drawing.Point(47, 136);
            this.hasloLabel.Name = "hasloLabel";
            this.hasloLabel.Size = new System.Drawing.Size(39, 13);
            this.hasloLabel.TabIndex = 3;
            this.hasloLabel.Text = "Hasło:";
            // 
            // logujButton
            // 
            this.logujButton.Location = new System.Drawing.Point(89, 173);
            this.logujButton.Name = "logujButton";
            this.logujButton.Size = new System.Drawing.Size(106, 28);
            this.logujButton.TabIndex = 4;
            this.logujButton.Text = "Loguj";
            this.logujButton.UseVisualStyleBackColor = true;
            this.logujButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // wyjdzButton
            // 
            this.wyjdzButton.Location = new System.Drawing.Point(224, 173);
            this.wyjdzButton.Name = "wyjdzButton";
            this.wyjdzButton.Size = new System.Drawing.Size(106, 28);
            this.wyjdzButton.TabIndex = 5;
            this.wyjdzButton.Text = "Wyjdź";
            this.wyjdzButton.UseVisualStyleBackColor = true;
            this.wyjdzButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // imglogo
            // 
            this.imglogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imglogo.BackgroundImage")));
            this.imglogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imglogo.ErrorImage")));
            this.imglogo.Image = ((System.Drawing.Image)(resources.GetObject("imglogo.Image")));
            this.imglogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("imglogo.InitialImage")));
            this.imglogo.Location = new System.Drawing.Point(113, 12);
            this.imglogo.MaximumSize = new System.Drawing.Size(173, 58);
            this.imglogo.MinimumSize = new System.Drawing.Size(173, 58);
            this.imglogo.Name = "imglogo";
            this.imglogo.Size = new System.Drawing.Size(173, 58);
            this.imglogo.TabIndex = 6;
            this.imglogo.TabStop = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 228);
            this.Controls.Add(this.imglogo);
            this.Controls.Add(this.wyjdzButton);
            this.Controls.Add(this.logujButton);
            this.Controls.Add(this.hasloLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.hasloTextB);
            this.Controls.Add(this.loginTextB);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(398, 266);
            this.MinimumSize = new System.Drawing.Size(398, 204);
            this.Name = "loginForm";
            this.Text = "Logowanie";
            this.Enter += new System.EventHandler(this.loginForm_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextB;
        private System.Windows.Forms.TextBox hasloTextB;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label hasloLabel;
        private System.Windows.Forms.Button logujButton;
        private System.Windows.Forms.Button wyjdzButton;
        private System.Windows.Forms.PictureBox imglogo;
    }
}

