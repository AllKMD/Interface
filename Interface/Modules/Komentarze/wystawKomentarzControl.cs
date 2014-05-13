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
using Interface._Classes;
using Interface.Modules.Komentarze;

namespace Interface.Komentarze
{
    public partial class wystawKomentarzControl : UserControl
    {
        private Form parentForm;
        public Control parentControl;

        private List<sellRatingReasonControl> dynamicRatingControls = new List<sellRatingReasonControl>();
        private List<WaitFeedbackStruct> feedbacksToGiveList;
        private FeedbackContainer feedbacks=new FeedbackContainer();
        private SellRatingInfoStruct[] sellRatingInfo;
        private Session sess;

        public wystawKomentarzControl(List<WaitFeedbackStruct> fbsToGive, Session s, Form parentF)
        {
            InitializeComponent();

            parentForm = parentF;
            feedbacksToGiveList = fbsToGive;
            sess = s;
            feedbacks.getSellRatingReasons(sess);
            sellRatingInfo = feedbacks.SELLRATINGINFO;

            addRatingControls();
            showRatingControls();
        }

        public wystawKomentarzControl(List<WaitFeedbackStruct> fbsToGive, Session s,Form parentF, feedbackTemplateStruct template)
        {
            InitializeComponent();

            parentForm = parentF;
            feedbacksToGiveList = fbsToGive;
            sess = s;
            feedbacks.getSellRatingReasons(sess);
            sellRatingInfo = feedbacks.SELLRATINGINFO;

            addRatingControls();
            showRatingControls();
            fillControlsWithTemplate(template);
        }



        private void wystawBT_Click(object sender, EventArgs e)
        {
            if (feedbackContentTB.Text == "")
            {
                MessageBox.Show("Wprowadź treść komentarza.");
            }
            else
            {
                FeedbackType ft;
                switch (typKomentarzaCB.Text)
                {
                    case "POZYTYWNY":
                        ft = FeedbackType.pozytywny;
                        break;
                    case "NEGATYWNY":
                        ft = FeedbackType.negatywny;
                        break;
                    case "NEUTRALNY":
                        ft = FeedbackType.neutralny;
                        break;
                    default:
                        ft = FeedbackType.pozytywny;
                        break;
                }

                for (int i = 0; i < feedbacksToGiveList.Count; i++)//idziemy po tablicy do wystawienia
                {
                    if (feedbacksToGiveList[i].feop == 2)//wystawiamy kupujacemu
                    {
                        try
                        {
                            //feedbacks.giveFeedbackToBuyer(sess, feedbacksToGiveList[i], feedbackContentTB.Text, ft);
                            feedbacksToGiveList.RemoveAt(i);
                        }
                        catch
                        {
                            //NIEWYSTAWILO
                            MessageBox.Show("Błąd podczas wystawiania komentarza.");
                            if (parentForm != null)
                            {
                                parentForm.Close();
                            }
                        }

                    }
                    if (feedbacksToGiveList[i].feop == 1)//wystawiamy sprzedajacemu
                    {//sprwdza czy wypelnione, wypelnia rating, wystawia komentarz
                        
                        //tworzenie ratingu sprzedazy=====================================================
                        List<SellRatingEstimationStruct> rating = new List<SellRatingEstimationStruct>();
                        sellRatingReasonControl[] kontrolki= dynamicRatingControls.ToArray();

                        for (int j = 0; j < kontrolki.Length; j++)
                        {
                            
                            SellRatingEstimationStruct est=new SellRatingEstimationStruct();

                            if (kontrolki[j].CHOSENREASONID==-1)//niewypelnione!!!
                            {
                                //throw new Exception("NIEWYPELNIONE!");
                            }
                            est.sellratinggroupestimation = kontrolki[j].ESTIMATIONVALUE;
                            est.sellratinggroupid = kontrolki[j].GROUPID;
                            if (est.sellratinggroupestimation < 5)//jezeli ocena mniejsza niz 5 to dlaczego=id powodu
                            {
                                est.sellratingreasonid = kontrolki[j].CHOSENREASONID;
                            }

                            rating.Add(est);
                        }

                        //wystawianie
                        try
                        {
                            //feedbacks.giveFeedbackToSeller(sess, feedbacksToGiveList[i], feedbackContentTB.Text, ft, rating.ToArray());
                            feedbacksToGiveList.RemoveAt(i);
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Błąd podczas wystawiania.");
                        }

                    }
                    
                }

                if(parentControl!=null )
                {
                parentControl.Enabled = true;
                (Parent as Form).Close();
                }
            }
            
        }

        private void anulujBT_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        void addRatingControls()
        {
            //DODAWANIE KONTROLEK
            for (int i = 0; i < sellRatingInfo.Length; i++)//dodawanie kontrolek oceny sprzedazy
            {
                sellRatingReasonControl temp = new sellRatingReasonControl(sellRatingInfo[i]);
                parentForm.Controls.Add(temp);
                Point tempPoint = new Point((parentForm as blankContainerForm).CONTROLINBOTTOM.X, (parentForm as blankContainerForm).CONTROLINBOTTOM.Y + 60);
                temp.Location = tempPoint;
                (parentForm as blankContainerForm).CONTROLINBOTTOM = temp.Location;
                dynamicRatingControls.Add(temp);
                temp.Visible = false;
            }
            //=============================
        }
        void showRatingControls()//sprawdza czy wystawiamy jakiemus sklepowi i visible=true jezeli tak
        {
            //WYSWIETLANIE KONTROLEK
            for (int i = 0; i < feedbacksToGiveList.Count; i++)//sprawdzamy czy kontrolki bd potrzebne
            {
                if (feedbacksToGiveList[i].feop == 1)//bedziemy wystawiac komentarz chociaz jednemu sprzedajacemu
                {
                    for (int j = 0; j < dynamicRatingControls.Count; j++)
                    {
                        dynamicRatingControls[j].Visible = true;
                    }
                    break;
                }
            }
            //============================
        }
        void fillControlsWithTemplate(feedbackTemplateStruct feedbackTemplate)
        {
            feedbackContentTB.Text = feedbackTemplate.content;
            typKomentarzaCB.Text=FeedbackContainer.typeToString(feedbackTemplate.type);
        }
    }
}
