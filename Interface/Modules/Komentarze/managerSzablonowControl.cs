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
using Interface.webapi;

namespace Interface.Komentarze
{
    public partial class managerSzablonowControl : UserControl
    {
        public Control parentControl;

        private int dbUserid;
        private SQLQueries queries;
        private List<feedbackTemplateStruct> list;
        private List<WaitFeedbackStruct> fbsToGive;
        private Session Sess;

        public managerSzablonowControl(int dbUserid,List<WaitFeedbackStruct> fbsToGive,Session s)//pobiera feedbaki do wystawienia i przesle je dalej do wystaw komentarz
        {
            InitializeComponent();

            this.dbUserid = dbUserid;
            queries = new SQLQueries();

            list = queries.getFeedbackTemplates(dbUserid);
            if(list!=null)
            {
                foreach(feedbackTemplateStruct temp in list)
                {
                    this.komentarzContentLB.Items.Add(temp.header);
                }
            }
            this.fbsToGive = fbsToGive;
            Sess = s;
        }
        private void anulujBT_Click(object sender, EventArgs e)
        {
            parentControl.Enabled = true;
            (Parent as Form).Close();
        }

        private void uzyjBT_Click(object sender, EventArgs e)
        {
            //KOD DO UZYWANIA KOMENTARZA///
            //tworzy wystaw komentarz i przesyla do niego fbstogive i wybrany szablon
            if (komentarzContentLB.SelectedItem != null)
            {
                wystawKomentarzControl c = new wystawKomentarzControl(fbsToGive, Sess, ParentForm, findSelectedTemplateInList());
                this.ParentForm.Controls.Add(c);
                this.Visible = false;
                c.Visible = true;
            }
            ///////////////////////////////
        }

        private void dodajBT_Click(object sender, EventArgs e)
        {
            blankContainerForm f = new blankContainerForm();
            allFeatureFeedbackTemplateControl c= new allFeatureFeedbackTemplateControl(queries,Sess);
            f.Controls.Add(c);
            c.parentControl = this;
            f.Show();

        }

        private void pokazBT_Click(object sender, EventArgs e)
        {
            if (komentarzContentLB.SelectedItem != null && list != null)
            {
                feedbackTemplateStruct template = findSelectedTemplateInList();

                blankContainerForm f = new blankContainerForm();
                allFeatureFeedbackTemplateControl c = new allFeatureFeedbackTemplateControl(queries, template, actionENUM.show,Sess);
                f.Controls.Add(c);
                f.Show();
            }
        }

        private void edytujBT_Click(object sender, EventArgs e)
        {
            if (komentarzContentLB.SelectedItem != null && list != null)
            {
                feedbackTemplateStruct template = findSelectedTemplateInList();

                blankContainerForm f = new blankContainerForm();
                allFeatureFeedbackTemplateControl c= new allFeatureFeedbackTemplateControl(queries, template, actionENUM.modify,Sess);
                f.Controls.Add(c);
                c.parentControl = this;
                f.Show();

            }
            else
            {
                MessageBox.Show("Wybierz szablon.");
            }
        }

        private void usunBT_Click(object sender, EventArgs e)
        {
            if (komentarzContentLB.SelectedItem != null && list!=null)
            {
                int id=-1;
                string selectedHeader;

                foreach(feedbackTemplateStruct temp in list)
                {
                    selectedHeader =Convert.ToString( komentarzContentLB.SelectedItem);
                    if(temp.header==selectedHeader)
                    {
                        id = temp.templateid;
                        break;   
                    }
                }
                if (id != -1)
                {
                    queries.deleteFeedbackTemplate(id);
                    MessageBox.Show("Usunięto szablon.");

                    //pobieranie+odwswiezanie listy
                    downloadTemplateList();
                    refreshTemplateHeaderList();
                }
            }
            else
            {
                MessageBox.Show("Wybierz szablon.");
            }

        }

        //METODY::
        public void downloadTemplateList()
        {
            list = queries.getFeedbackTemplates(dbUserid);
        }
        public void refreshTemplateHeaderList()
        {
            komentarzContentLB.Items.Clear();
            if (list != null)
            {
                foreach (feedbackTemplateStruct temp in list)
                {
                    this.komentarzContentLB.Items.Add(temp.header);
                }
            }
        }
        private feedbackTemplateStruct findSelectedTemplateInList()
        {
            string selectedHeader;

            selectedHeader = Convert.ToString(komentarzContentLB.SelectedItem);

            foreach (feedbackTemplateStruct temp in list)
            {
                if (temp.header == selectedHeader)
                {
                    return temp;
                }
            }
            throw new Exception("Nie znaleziono wybranego szablonu na liscie.");
        }
    }
}
