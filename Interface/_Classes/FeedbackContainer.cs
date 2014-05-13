using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.webapi;

namespace Interface._Classes
{
    public enum filtr {otrzymany,do_wystawienia,nieotrzymany,wystawiony};
    public enum FeedbackType{pozytywny,negatywny,neutralny};

    public struct feedbackTemplateStruct
    {
        public int templateid;
        public int userid;
        public string content;
        public string header;
        public int type;

    }


    public class myNotReceivedFeedback
    {
        public long auctionId;
        public int userId;

    }
    class FeedbackContainer
    {
        public static string typeToString(int t)
        {
            switch (t)
            {
                case 3:
                    return "NEUTRALNY";
                case 2:
                    return "NEGATYWNY";
                case 1:
                    return "POZYTYWNY";
                default:
                    break;
            }
            return "";
        }
        public static int typeToInt(string s)
        {
            switch (s.ToUpper())
            {
                case "NEUTRALNY":
                    return 3;
                case "NEGATYWNY":
                    return 2;
                case "POZYTYWNY":
                    return 1;
                default:
                    break;
            }
            return -1;
        }


        private MyFeedbackListStruct2[] myReceivedFeedbackList,myPostedFeedbackList;
        private WaitFeedbackStruct[] myWaitingFeedbacks;
        private myNotReceivedFeedback[] myNotReceivedFeedbackList;
        private SellRatingInfoStruct[] sellRatingInfo;

        public void getMyFeedbacks(Session s)   // pobiera OTRZYMANE i WYSTAWIONE komentarze zalogowanego uzytkownika
        {
            long []tab=new long[0];
            myReceivedFeedbackList = s.allegroService.doMyFeedback2Limit(s.SESSIONHANDLE,"fb_recvd",0,0,tab,0);
            myPostedFeedbackList = s.allegroService.doMyFeedback2Limit(s.SESSIONHANDLE, "fb_gave", 0, 0, tab, 0);
        }
        public void getMyWaitingFeedbacks(Session s)    //pobiera komentarze OCZEKUJACE na wystawienie
        {
            WaitFeedbackStruct[] tempTable;
            int count = s.allegroService.doGetWaitingFeedbacksCount(s.SESSIONHANDLE);

            myWaitingFeedbacks = s.allegroService.doGetWaitingFeedbacks(s.SESSIONHANDLE, 0, 200);
            count -= 200;

            if (count > 0)
            {
                tempTable=s.allegroService.doGetWaitingFeedbacks(s.SESSIONHANDLE, 0, 200);
                for (int i = 0; i < tempTable.Length; i++)
                {
                    myWaitingFeedbacks.Concat(tempTable);
                }
                count -= 200;
            }
        }
        public void getMyNotReceivedFeedbackList()  //laduje komentarze NIEOTRZYMANE
        {
            List<myNotReceivedFeedback> lista = new List<myNotReceivedFeedback>();
            myNotReceivedFeedback temp;

            //nie wystawilem i nie ma zwrotnego
            for (int i = 0; i < myWaitingFeedbacks.Length; i++)
            {
                if (myWaitingFeedbacks[i].feanscommenttype == "NULL" || myWaitingFeedbacks[i].feanscommenttype == "null")
                {
                    temp = new myNotReceivedFeedback();
                    temp.auctionId = myWaitingFeedbacks[i].feitemid;
                    temp.userId = myWaitingFeedbacks[i].fetouserid;
                    lista.Add(temp);
                }
            }

            //wystawilem ale nie ma zwrotnego
            for (int i = 0; i < myPostedFeedbackList.Length;i++ )
            {
                if (myPostedFeedbackList[i].feedbackarray[8] == "" || myPostedFeedbackList[i].feedbackarray[7] == "")
                {
                    temp = new myNotReceivedFeedback();
                    temp.auctionId=Convert.ToInt64(myPostedFeedbackList[i].feedbackarray[5]);
                    temp.userId=Convert.ToInt32(myPostedFeedbackList[i].feedbackarray[1]);
                    lista.Add(temp);
                }
            }

            myNotReceivedFeedbackList= lista.ToArray();

        }
        public void getSellRatingReasons(Session s)//pobiera struktury dla oceny sprzedazy
        {
            SellRatingInfoStruct[] reasons = s.allegroService.doGetSellRatingReasons(s.WEBAPIKEY, s.COUNTRYID);
            this.sellRatingInfo=reasons;
        }


        public void giveFeedbackToBuyer(Session s,WaitFeedbackStruct wfs,string content,FeedbackType type)//wystawia komentarz KUPUJACEMU
        {
            string commentType;
            switch(type)
            {
                case FeedbackType.pozytywny:
                    commentType="POS";
                    break;
                case FeedbackType.negatywny:
                    commentType="NEG";
                    break;
                default:
                    commentType="NEU";
                    break;
            }
            int a=s.allegroService.doFeedback(s.SESSIONHANDLE, wfs.feitemid, 0, wfs.fetouserid, content, commentType, wfs.feop, null);
        }
        public void giveFeedbackToSeller(Session s, WaitFeedbackStruct wfs, string content, FeedbackType type,SellRatingEstimationStruct[] rating)//wystawia komentarz SPRZEDAJACEMU
        {
            string commentType;
            switch(type)
            {
                case FeedbackType.pozytywny:
                    commentType="POS";
                    break;
                case FeedbackType.negatywny:
                    commentType="NEG";
                    break;
                default:
                    commentType="NEU";
                    break;
            }
            s.allegroService.doFeedback(s.SESSIONHANDLE, wfs.feitemid, 0, wfs.fetouserid, content, commentType, wfs.feop,rating);
        }
        

        //AKCESORY
        public List<MyFeedbackListStruct2> MYRECIVEDFEEDBACKLIST
        {
            get { return this.myReceivedFeedbackList.ToList(); }
            set { }
        }
        public List<WaitFeedbackStruct> MYWAITINGFEEDBACKS
        {
            get {
                return this.myWaitingFeedbacks.ToList(); }
            set { }
        }
        public List<MyFeedbackListStruct2> MYPOSTEDFEEDBACKLIST
        {
            get { return this.myPostedFeedbackList.ToList(); }
            set { }
        }
        public List<myNotReceivedFeedback> MYNOTRECEIVEDFEEDBACKLIST
        {
            get { return this.myNotReceivedFeedbackList.ToList(); }
            set { }
        }
        public SellRatingInfoStruct[] SELLRATINGINFO
        {
            get {
                if (this.sellRatingInfo == null)
                {
                    throw new Exception("a");
                }
                return this.sellRatingInfo;
            }
            set { }
        }

    }
}
