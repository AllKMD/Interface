using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Komentarze
{
    public partial class managerSzablonowControl : UserControl
    {
            public Control parentControl;
        public managerSzablonowControl()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                komentarzContentLB.Items.Add("Tresc komentarza"+i+"...");
            }
        }

        private void managerSzablonowControl_Load(object sender, EventArgs e)
        {

        }

        private void anulujBT_Click(object sender, EventArgs e)
        {
            parentControl.Enabled = true;
            (Parent as Form).Close();
        }

        private void uzyjBT_Click(object sender, EventArgs e)
        {
            //KOD DO UZYWANIA KOMENTARZA///

            ///////////////////////////////
            parentControl.Enabled = true;
            (Parent as Form).Close();
        }

        private void dodajBT_Click(object sender, EventArgs e)
        {

        }

        private void pokazBT_Click(object sender, EventArgs e)
        {

        }

        private void edytujBT_Click(object sender, EventArgs e)
        {

        }

        private void usunBT_Click(object sender, EventArgs e)
        {

        }
    }
}
