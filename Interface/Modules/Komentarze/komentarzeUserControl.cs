using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Interface.Komentarze;
using Interface._Classes;
using Interface.webapi;

using System.Threading;

namespace Interface
{
    public partial class komentarzeUserControl : UserControl
    {
        Session sess;
        MyFeedbackListStruct2[] myReceivedFeedbacks,myPostedFeedbackList;
        WaitFeedbackStruct[] myWaitingFeedbacks;
        Users users=new Users();

        public komentarzeUserControl(Session s)
        {
            InitializeComponent();
            this.sess = s;

            //===================================INICJALIZACJA KOLUMN DLA DGV=====================================
            daneDGV.Columns.Add("Komu", "Komu");
            daneDGV.Columns.Add("Nr aukcji", "Nr aukcji");
            daneDGV.Columns.Add("Pokaż zwrotny", "Pokaż zwrotny");
            daneDGV.Columns.Add("Data", "Data");
            daneDGV.Columns.Add("Od kogo", "Od kogo");
            daneDGV.Columns.Add("Typ", "Typ");
            daneDGV.Columns.Add("Treść", "Treść");
            daneDGV.Columns.Add("filtr","filtr");

            for (int i = 0; i < 8; i++)
            {
                daneDGV.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                daneDGV.Columns[i].Visible = false;
                daneDGV.Columns[i].ReadOnly=true;
            }
            //=====================================================================================================

            //===========================POBIERANIE KOMENTARZY + WYPELNIANIE DGV DANYMI============================
            FeedbackContainer feedbacks = new FeedbackContainer();
            feedbacks.getMyFeedbacks(sess);
            feedbacks.getMyWaitingFeedbacks(sess);
            myReceivedFeedbacks=feedbacks.MYRECIVEDFEEDBACKLIST;
            myWaitingFeedbacks=feedbacks.MYWAITINGFEEDBACKS;
            myPostedFeedbackList=feedbacks.MYPOSTEDFEEDBACKLIST;

            //OTRZYMANE=============================================================================================
            foreach (MyFeedbackListStruct2 stru in myReceivedFeedbacks)
            {
                int index = daneDGV.Rows.Add();

                daneDGV.Rows[index].Cells["Nr aukcji"].Value = stru.feedbackarray[5];
                //daneDGV.Rows[index].Cells["Pokaż zwrotny"].Value =
                daneDGV.Rows[index].Cells["Od kogo"].Value = users.getUserName(Convert.ToInt32(stru.feedbackarray[0]), sess);
                switch (stru.feedbackarray[3])
                {
                    case "1":
                        daneDGV.Rows[index].Cells["Typ"].Value = "Pozytywny";
                        break;
                    case "2":
                        daneDGV.Rows[index].Cells["Typ"].Value = "Negatywny";
                        break;
                    case "3":
                        daneDGV.Rows[index].Cells["Typ"].Value = "Neutralny";
                        break;
                    default:
                        break;
                }
                daneDGV.Rows[index].Cells["Data"].Value = stru.feedbackarray[2];
                daneDGV.Rows[index].Cells["Treść"].Value = stru.feedbackarray[4];
                daneDGV.Rows[index].Cells["filtr"].Value = filtr.otrzymany;
                daneDGV.Rows[index].Visible = false;
            }
            //DO WYSTAWIENIA===================================================================================================
            foreach(WaitFeedbackStruct stru in myWaitingFeedbacks)
            {
                int index = daneDGV.Rows.Add();

                daneDGV.Rows[index].Cells["Nr aukcji"].Value = stru.feitemid;
                //daneDGV.Rows[index].Cells["Pokaż zwrotny"].Value =
                daneDGV.Rows[index].Cells["Komu"].Value = users.getUserName(stru.fetouserid, sess);
                daneDGV.Rows[index].Cells["filtr"].Value = filtr.do_wystawienia;
            }
            //WYSTAWIONE=======================================================================================================
            foreach(MyFeedbackListStruct2 stru in myPostedFeedbackList)
            {
                int index = daneDGV.Rows.Add();

                daneDGV.Rows[index].Cells["Nr aukcji"].Value = stru.feedbackarray[5];
                //daneDGV.Rows[index].Cells["Pokaż zwrotny"].Value =
                daneDGV.Rows[index].Cells["Komu"].Value = users.getUserName(Convert.ToInt32(stru.feedbackarray[1]), sess);
                switch (stru.feedbackarray[3])
                {
                    case "1":
                        daneDGV.Rows[index].Cells["Typ"].Value = "Pozytywny";
                        break;
                    case "2":
                        daneDGV.Rows[index].Cells["Typ"].Value = "Negatywny";
                        break;
                    case "3":
                        daneDGV.Rows[index].Cells["Typ"].Value = "Neutralny";
                        break;
                    default:
                        break;
                }
                daneDGV.Rows[index].Cells["Data"].Value = stru.feedbackarray[2];
                daneDGV.Rows[index].Cells["Treść"].Value = stru.feedbackarray[4];
                daneDGV.Rows[index].Cells["filtr"].Value = filtr.wystawiony;
                daneDGV.Rows[index].Visible = false;

            }
            //NIEOTRZYMANE====================================================================================================

            //================================================================================================================

            statusKomentarzaCB_SelectedIndexChanged(this, new EventArgs());
            daneDGV.Focus();
        }

        private void wystawBT_Click(object sender, EventArgs e)
        {
            blankContainerForm f = new blankContainerForm();
            wystawKomentarzControl c = new wystawKomentarzControl();
            c.parentControl = this;
            f.parentControl = this;

            this.Enabled = false;

            f.Controls.Add(c);
            f.Show();
        }

        private void uzyjSzablonuBT_Click(object sender, EventArgs e)
        {
            blankContainerForm f = new blankContainerForm();
            managerSzablonowControl c = new managerSzablonowControl();

            c.parentControl = this;
            f.parentControl = this;
            this.Enabled = false;

            f.Controls.Add(c);
            f.Show();
        }

        private void statusKomentarzaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                daneDGV.Columns[i].Visible = false;
            }
            foreach (DataGridViewRow r in daneDGV.Rows)
            {
                r.Visible = false;
            }

            daneDGV.Columns["Nr aukcji"].Visible = true;
            daneDGV.Columns["Pokaż zwrotny"].Visible = true;
            switch (filtrCB.Text)
            {
                case "Do wystawienia":
                    daneDGV.Columns["Komu"].Visible = true;
                    foreach (DataGridViewRow r in daneDGV.Rows)
                    {
                        if ((filtr)(r.Cells["filtr"].Value) == filtr.do_wystawienia)
                        {
                            r.Visible = true;
                        }
                    }
                    break;
                case "Wystawione":
                    daneDGV.Columns["Komu"].Visible = true;
                    daneDGV.Columns["Typ"].Visible = true;
                    daneDGV.Columns["Data"].Visible = true;
                    daneDGV.Columns["Treść"].Visible = true;
                    foreach (DataGridViewRow r in daneDGV.Rows)
                    {
                        if ((filtr)(r.Cells["filtr"].Value) == filtr.wystawiony)
                        {
                            r.Visible = true;
                        }
                    }
                    break;
                case "Otrzymane":
                    daneDGV.Columns["Od kogo"].Visible = true;
                    daneDGV.Columns["Typ"].Visible = true;
                    daneDGV.Columns["Data"].Visible = true;
                    daneDGV.Columns["Treść"].Visible = true;
                    foreach (DataGridViewRow r in daneDGV.Rows)
                    {
                        if((filtr)(r.Cells["filtr"].Value)==filtr.otrzymany)
                        {
                            r.Visible = true;
                        }
                    }
                    break;
                case "Nieotrzymane":
                    daneDGV.Columns["Od kogo"].Visible = true;
                    foreach (DataGridViewRow r in daneDGV.Rows)
                    {
                        if ((filtr)(r.Cells["filtr"].Value) == filtr.nieotrzymany)
                        {
                            r.Visible = true;
                        }
                    }
                    break;
                default:
                    break;
            }
            daneDGV.Focus();
        }
    }
}