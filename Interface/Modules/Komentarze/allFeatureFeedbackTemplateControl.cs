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
using Interface.Modules.Komentarze;
using Interface.Komentarze;

namespace Interface.Modules.Komentarze
{
    public enum actionENUM { add, modify, show };
    public partial class allFeatureFeedbackTemplateControl : UserControl
    {
        public actionENUM chosenAction;
        public Control parentControl;

        Session sess;
        SQLQueries querries;
        feedbackTemplateStruct inputTemplate;


        public allFeatureFeedbackTemplateControl(SQLQueries q,Session s)
        {
            InitializeComponent();
            querries = q;
            chosenAction = actionENUM.add;
            sess = s;
        }
        public allFeatureFeedbackTemplateControl(SQLQueries q,feedbackTemplateStruct s,actionENUM a,Session ses)
        {
            InitializeComponent();
            sess = ses;
            querries = q;
            inputTemplate = s;

            contentTextBox.Text = s.content;
            headerTextBox.Text = s.header;
            chosenAction = a;
            if (a == actionENUM.show)
            {
                    //WYSWIETLAMY
                    saveBT.Visible = false;
                    contentTextBox.Text=inputTemplate.content ;
                    headerTextBox.Text=inputTemplate.header ;
                    feedbackTypeComboBox.Text =Convert.ToString( inputTemplate.type);//przerobic na stringi
            }
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            switch (chosenAction)
            {
                case actionENUM.add://DODAJEMY NOWY WPIS

                    int type=1;
                    feedbackTemplateStruct temp = new feedbackTemplateStruct();
                    temp.content = contentTextBox.Text;
                    temp.header = headerTextBox.Text;
                    switch(feedbackTypeComboBox.Text)//dorobic TYPY
                      {
                     case "POZYTYWNY":

                          break;
                      case "NEGATYWNY":

                          break;
                      case "NEUTRALNY":

                            break;
                        default: break;
                    }
                    temp.type = type;
                    temp.userid = querries.getUserid(sess.GETLOGIN);

                    querries.addFeedbackTemplate(temp);
                    (this.parentControl as managerSzablonowControl).downloadTemplateList();
                    (this.parentControl as managerSzablonowControl).refreshTemplateHeaderList();

                    break;

                case actionENUM.modify://EDYTUJEMY ISTNIEJACY
                    inputTemplate.header = headerTextBox.Text;
                    inputTemplate.content = contentTextBox.Text;
                    inputTemplate.type = FeedbackContainer.typeToInt(feedbackTypeComboBox.Text);
                    querries.modifyFeedbackTemplate(inputTemplate);

                    (this.parentControl as managerSzablonowControl).downloadTemplateList();
                    (this.parentControl as managerSzablonowControl).refreshTemplateHeaderList();
                    break;
                default:
                    break;
            }

            
            this.ParentForm.Close();
        }

    }
}
