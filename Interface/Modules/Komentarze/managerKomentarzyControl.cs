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
    public partial class managerKomentarzyControl : UserControl
    {
            public Control parentControl;
        public managerKomentarzyControl()
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
            blankContainerForm bcf = new blankContainerForm();
            bcf.Controls.Add(new edycjaKomentarzaControl("edycja"));
            bcf.Show();
        }

        private void pokazBT_Click(object sender, EventArgs e)
        {
            blankContainerForm bcf = new blankContainerForm();
            bcf.Controls.Add(new edycjaKomentarzaControl());
            bcf.Show();
        }

        private void edytujBT_Click(object sender, EventArgs e)
        {
            blankContainerForm bcf = new blankContainerForm();
            bcf.Controls.Add(new edycjaKomentarzaControl("edycja"));
            bcf.Show();
        }

        private void usunBT_Click(object sender, EventArgs e)
        {

        }

        private void komentarzContentLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
