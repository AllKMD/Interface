using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Interface.webapi;  // będziemy używać biblioteki webapi
using Interface;
using System.Security.Cryptography;
using Interface._Classes;


namespace Interface
{

    public partial class loginForm : Form
    {
        AllegroWebApiService allegroService = new AllegroWebApiService();
        private long verKey;
        private string verString;
        const string webAPIKey = "7dda4ce4";
        private Graphics g;
        private Categories cat;
        private Session s;

        public loginForm()
        {
            InitializeComponent();
            imglogo.Image = new Bitmap(400, 400);
            g = Graphics.FromImage(imglogo.Image);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            s = new Session("7dda4ce4", 1);
            s.login(loginTextB.Text, hasloTextB.Text);

            if (s.SESSIONHANDLE != "")
            {
                cat = new Categories(allegroService, webAPIKey, out verKey, out verString);
                //cat.CATSDATA = allegroService.doGetCatsData(228, 0, webAPIKey, out verKey, out verString);
                ladowanieForm loadform = new ladowanieForm(s, this.cat);
                loadform.Show();
                this.Hide();
            }

            hasloTextB.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginForm_Enter(object sender, EventArgs e)
        {
            
        }

        private void hasloTextB_Enter(object sender, EventArgs e)
        {
            
        }

        private void hasloTextB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//ENTER
            {
                s = new Session("7dda4ce4", 1);
                s.login(loginTextB.Text, hasloTextB.Text);

                if (s.SESSIONHANDLE != "")
                {
                    cat = new Categories(allegroService, webAPIKey, out verKey, out verString);
                    //cat.CATSDATA = allegroService.doGetCatsData(1, 0, webAPIKey, out verKey, out verString);
                    ladowanieForm loadform = new ladowanieForm(s,this.cat);
                    loadform.Show();
                    this.Hide();
                }

                hasloTextB.Text = "";
            }
        }
    }
}
