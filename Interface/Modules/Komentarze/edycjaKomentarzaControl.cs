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
    public partial class edycjaKomentarzaControl : UserControl
    {
        public edycjaKomentarzaControl()
        {
            InitializeComponent();
            this.trescKomentarzaTB.ReadOnly = true;
        }
        public edycjaKomentarzaControl(string edycja)
        {
            InitializeComponent();

            this.zapiszBT.Visible = true;
            this.trescKomentarzaTB.ReadOnly = false;
        }

        private void anulujButton_Click(object sender, EventArgs e)
        {
            (Parent as Form).Close();
        }
        private void zapiszBT_Click(object sender, EventArgs e)
        {
            //KOD DO ZAPISU/nadpisania danych w sql//
            //////////////////////////////////////////
            (Parent as Form).Close();
        }
    }
}
