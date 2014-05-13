using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Interface._Classes;

namespace Interface
{
    public partial class ladowanieForm : Form
    {
        Session s;

        public ladowanieForm(Session s)
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 3;

            this.s = s;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                mainForm mf = new mainForm(this.s);
                mf.Show();
                this.Hide();
            }

        }

    }
}
