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
using Interface.Modules.Komentarze;

namespace Interface
{
    public partial class komentarzeUserControl : UserControl
    {
        Session sess;
        List<MyFeedbackListStruct2> myReceivedFeedbacksList,myPostedFeedbackList;
        List<WaitFeedbackStruct> myWaitingFeedbacksList;
        List<myNotReceivedFeedback> myNotReceivedFeedbacksList;

        Users users=new Users();
        FeedbackContainer feedbacks = new FeedbackContainer();

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
            downloadFeedbacks();

            //===========================WYPELNIANIE DGV DANYMI====================================================//
            //OTRZYMANE=============================================================================================//
            foreach (MyFeedbackListStruct2 stru in myReceivedFeedbacksList)
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
            foreach(WaitFeedbackStruct stru in myWaitingFeedbacksList)
            {
                int index = daneDGV.Rows.Add();

                daneDGV.Rows[index].Cells["Nr aukcji"].Value = stru.feitemid;
                //daneDGV.Rows[index].Cells["Pokaż zwrotny"].Value =
                daneDGV.Rows[index].Cells["Komu"].Value = users.getUserName(stru.fetouserid, sess);
                daneDGV.Rows[index].Cells["filtr"].Value = filtr.do_wystawienia;


                //infoBoxTB.Text += stru.feanscommenttype;
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
            foreach (myNotReceivedFeedback stru in myNotReceivedFeedbacksList)
            {
                int index = daneDGV.Rows.Add();

                daneDGV.Rows[index].Cells["Od kogo"].Value = users.getUserName(Convert.ToInt32(stru.userId), sess);
                daneDGV.Rows[index].Cells["Nr aukcji"].Value = stru.auctionId;
                daneDGV.Rows[index].Cells["filtr"].Value = filtr.nieotrzymany;
                daneDGV.Rows[index].Visible = false;
            }
            //================================================================================================================

            daneDGV.ClearSelection();
            statusKomentarzaCB_SelectedIndexChanged(this, new EventArgs());
            daneDGV.Focus();
        }

        private void wystawBT_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows;
            selectedRows = daneDGV.SelectedRows;




            //test czy wyrzuca i refreshuje=============
            WaitFeedbackStruct t = new WaitFeedbackStruct();
            t.feitemid = 1;
            t.fetouserid = 1;
            //t.feop = 2;//kupujacemu
            t.feop = 1;//sprzedajcemu
            myWaitingFeedbacksList.Add(t);
            //koniec test sprawdzic  wczesniej===========

            //if (selectedRows.Count!=0)
            //{
            blankContainerForm f = new blankContainerForm();
            wystawKomentarzControl c = new wystawKomentarzControl(myWaitingFeedbacksList, sess, f);//NIE MY WAITING TYLKO SELECTED!!!!!
            c.parentControl = this;
            f.parentControl = this;

            this.Enabled = false;

            f.Controls.Add(c);
            f.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Wybierz aukcje do których chcesz wystawić komentarz.");
            //}



        }

        private void uzyjSzablonuBT_Click(object sender, EventArgs e)
        {
            blankContainerForm f = new blankContainerForm();
            SQLQueries q=new SQLQueries();
            managerSzablonowControl c = new managerSzablonowControl(q.getUserid((sess.GETLOGIN)), myWaitingFeedbacksList,sess);//na sztywno pod testy!!!, musi przyjmowacNIE WAITING TYLKO SELECTED!!! 

            c.parentControl = this;
            f.parentControl = this;
            this.Enabled = false;

            f.Controls.Add(c);
            f.Show();
        }

        private void statusKomentarzaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            daneDGV.ClearSelection();

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
                    uzyjSzablonuBT.Enabled = true;
                    wystawBT.Enabled = true;

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
                    uzyjSzablonuBT.Enabled = false;
                    wystawBT.Enabled = false;

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
                    uzyjSzablonuBT.Enabled = false;
                    wystawBT.Enabled = false;

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
                    uzyjSzablonuBT.Enabled = false;
                    wystawBT.Enabled = false;

                    break;

                default:
                    
                    break;
            }
            daneDGV.Focus();
        }

        private void daneDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //SZCZEGOLY KOMENTARZA
            filtr filter = (filtr)(daneDGV.Rows[e.RowIndex].Cells["filtr"].Value);
            long auctionID = Convert.ToInt64(daneDGV.Rows[e.RowIndex].Cells["Nr aukcji"].Value);

            feedbackDetailsControl con = new feedbackDetailsControl(filter,auctionID);
            blankContainerForm form = new blankContainerForm();
            form.parentControl = this;
            form.Controls.Add(con);
            form.Show();

            this.Enabled = false;

        }

        private void daneDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.wystawBT.Text = "Wystaw(" + Convert.ToString(daneDGV.SelectedRows.Count) + ')';

            ////ZAZNACZANIE/ODZNACZANIE(bez ctrl)

            //if (daneDGV.Rows[e.RowIndex].Selected == true)
            //{
            //    daneDGV.Rows[e.RowIndex].Selected = false;
            //}
            //else
            //{
            //    daneDGV.Rows[e.RowIndex].Selected = true;
            //}
        }




        void downloadFeedbacks()//pobiera komentarze i zapuje do zmiennych
        {
            //POBIERANIE DANYCH
            feedbacks.getMyFeedbacks(sess);
            feedbacks.getMyWaitingFeedbacks(sess);
            feedbacks.getMyNotReceivedFeedbackList();

            //ZAPISYWANIE DO ZMIENNYCH
            myReceivedFeedbacksList = feedbacks.MYRECIVEDFEEDBACKLIST;
            myWaitingFeedbacksList = feedbacks.MYWAITINGFEEDBACKS;
            myPostedFeedbackList = feedbacks.MYPOSTEDFEEDBACKLIST;
            myNotReceivedFeedbacksList = feedbacks.MYNOTRECEIVEDFEEDBACKLIST;
        }
        void refreshDGVdoWystawienia()//odswieza(ze zmiennej globalnej myWaitingFeedbacks) dataGridView dla pol z filtrem Do wystawienia
        {
            this.daneDGV.Rows.Clear(); //czysci wszystkie

            if (myWaitingFeedbacksList != null)
            {
                foreach (WaitFeedbackStruct stru in myWaitingFeedbacksList)
                {
                    int index = daneDGV.Rows.Add();

                    daneDGV.Rows[index].Cells["Nr aukcji"].Value = stru.feitemid;
                    //daneDGV.Rows[index].Cells["Pokaż zwrotny"].Value =
                    daneDGV.Rows[index].Cells["Komu"].Value = users.getUserName(stru.fetouserid, sess);
                    daneDGV.Rows[index].Cells["filtr"].Value = filtr.do_wystawienia;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshDGVdoWystawienia();
        }
        //dorobic METODA ZMIENIAJACA SELECTED rows na liste do wystawienia
    }
}