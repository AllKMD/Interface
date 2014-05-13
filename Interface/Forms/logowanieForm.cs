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
using kodMacka;
using System.Security.Cryptography;
using Interface._Classes;


namespace Interface
{
    public partial class loginForm : Form
    {
        private Graphics g;
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
            try
            {
                s.login(loginTextB.Text, hasloTextB.Text);
                //sprawdza czy jest uzytkownik, jezezeli tak to daje do session, jak nie dodaje do bazy danych
            }
            catch (Exception ex)
            {

            }

            //if (s.SESSIONHANDLE != "")
            //{
            //    ladowanieForm loadform = new ladowanieForm(s);
            //    loadform.Show();
            //    this.Close();
            //}

            //hasloTextB.Text = "";
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
                    ladowanieForm loadform = new ladowanieForm(s);
                    loadform.Show();
                    this.Hide();
                }

                hasloTextB.Text = "";
            }
        }
    }
}
