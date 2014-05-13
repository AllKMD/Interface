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
    public partial class wystawKomentarzControl : UserControl
    {
        public Control parentControl;

        public wystawKomentarzControl()
        {
            InitializeComponent();
        }

        private void wystawBT_Click(object sender, EventArgs e)
        {
            //*********KOD ODPOWIADAJACY ZA WYSTAWIANIE KOMENTARZA******************//

            //**********************************************************************//

            parentControl.Enabled = true;
            (Parent as Form).Close();
        }

        private void anulujBT_Click(object sender, EventArgs e)
        {
            parentControl.Enabled = true;
            (Parent as Form).Close();
        }
    }
}
