using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class zestawieniaUserControl : UserControl
    {
        public zestawieniaUserControl()
        {
            InitializeComponent();
            zestawieniaGrid.Columns[0].HeaderText = showByCBox.Text;
        }

        private void showByCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            zestawieniaGrid.Columns[0].HeaderText = showByCBox.Text;
        }


    }
}
