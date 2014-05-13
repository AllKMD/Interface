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
using Interface.webapi;
using Interface._Interfaces;

namespace Interface
{
    public partial class ladowanieForm : Form
    {
        Categories cat;
        Session s;

        public ladowanieForm(Session s, Categories cat)
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 3;

            this.cat = cat;
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
                mainForm mf = new mainForm(this.s, this.cat);
                mf.Show();
                this.Hide();
            }

        }

    }
}
