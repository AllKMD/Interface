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
        private Point controlInBottom;

        public blankContainerForm()
        {
            InitializeComponent();
            this.AutoSize = true;
            controlInBottom = new Point(18, 186);
        }

        //metody
        public void setCords(Point p)
        {
            controlInBottom = p;
        }
        //wlasciwosci
        public Point CONTROLINBOTTOM
        {
            get { return controlInBottom; }
            set { this.controlInBottom = value; }
        }




        private void wystawKomentarzForm_Load(object sender, EventArgs e)
        {

        }

        private void blankContainerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parentControl != null)
            {
                parentControl.Enabled = true;
            }
        }

        private void blankContainerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parentControl != null)
            {
                parentControl.Enabled = true;
            }
        }


    }
}
