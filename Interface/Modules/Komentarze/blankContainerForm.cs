using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Komentarze
{
    public partial class blankContainerForm : Form
    {
        public Control parentControl;
        public blankContainerForm()
        {
            InitializeComponent();
            this.AutoSize = true;
        }

        private void wystawKomentarzForm_Load(object sender, EventArgs e)
        {

        }

        private void blankContainerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentControl.Enabled = true;
        }

        private void blankContainerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentControl.Enabled = true;
        }
    }
}
