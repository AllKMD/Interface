using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.webapi;

namespace Interface._Classes
{
    enum filtr {otrzymany,do_wystawienia,nieotrzymany,wystawiony};
    public struct myNotReceivedFeedback
    {
        long auctionId;
        int userId;

    }
    class FeedbackContainer
    {
        private MyFeedbackListStruct2[] myReceivedFeedbackList,myPostedFeedbackList;
        private WaitFeedbackStruct[] myWaitingFeedbacks;
        private myNotReceivedFeedback[] myNotReceivedFeedbackList;

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
            if (myPostedFeedbackList != null && myReceivedFeedbackList != null)
            {
                //NIEOTRZYMANE(myWaitingFeedbacks)

                //NIEOTRZYMANE(myReceivedFeedbackList)

            }
            else
            {
                //wyjatek//
            }
        }

        //AKCESORY
        public MyFeedbackListStruct2[] MYRECIVEDFEEDBACKLIST
        {
            get { return this.myReceivedFeedbackList; }
            set { }
        }
        public WaitFeedbackStruct[] MYWAITINGFEEDBACKS
        {
            get { return this.myWaitingFeedbacks; }
            set { }
        }
        public MyFeedbackListStruct2[] MYPOSTEDFEEDBACKLIST
        {
            get { return this.myPostedFeedbackList; }
            set { }
        }


    }
}
