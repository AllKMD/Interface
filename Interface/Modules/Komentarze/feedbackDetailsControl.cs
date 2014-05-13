using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Interface._Classes;

namespace Interface.Modules.Komentarze
{
    public partial class feedbackDetailsControl : UserControl
    {
        UserControl parentControl;

        public feedbackDetailsControl(filtr f, long auctId)
        {
            InitializeComponent();

            this.parentControl = parentControl;

        }


    }
}
