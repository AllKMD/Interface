using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Interface.webapi;

namespace Interface.Modules.Komentarze
{
    public partial class sellRatingReasonControl : UserControl
    {
        private int groupID;
        private SellRatingInfoStruct reasonInfo;
        
        public sellRatingReasonControl(SellRatingInfoStruct reason)
        {
            InitializeComponent();
            groupID = reason.sellratinggroupid;
            reasonInfo = reason;

            //dodawanie labela oceny,powodów niezadowolenia
            reasonTitleLabel.Text = reason.sellratinggrouptitle;
            for (int i = 0; i < reason.sellratingreasons.Length;i++ )
            {
                reasonComboBox.Items.Add(reason.sellratingreasons[i].sellratingreasontitle);
            }
            reasonComboBox.Visible = false;
            reasonOfDisssatLabel.Visible = false;
        }



        public int GROUPID
        {
            get { return groupID; }
            set { }
        }
        public int CHOSENREASONID
        {
            get 
            {
                if(reasonComboBox.Text!="")
                {
                    for (int i = 0; i < reasonInfo.sellratingreasons.Length; i++)
                    {
                        if (reasonComboBox.Text == reasonInfo.sellratingreasons[i].sellratingreasontitle)
                        {
                            return reasonInfo.sellratingreasons[i].sellratingreasonid;
                        }
                    }

                    //"Nie znaleziono kategorii powodu niezadowolenia
                    return -1;
                }
                else
                {
                    //Wybierz powód niezadowolenia
                    return -1;
                }
            }
            set { }
        }
        public int ESTIMATIONVALUE
        {
            get
            {
                return reasonValueTrackBar.Value;
            }
            set { }
        }

        private void reasonValueTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (reasonValueTrackBar.Value == 5)
            {
                reasonComboBox.Visible = false;
                reasonOfDisssatLabel.Visible = false;
            }
            else
            {
                reasonComboBox.Visible = true;
                reasonOfDisssatLabel.Visible = true;
            }
        }
    }
}
