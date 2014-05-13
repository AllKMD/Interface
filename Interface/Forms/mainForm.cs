using Interface.MojaSprzedaz;
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
using System.Collections;
using Interface._Classes;
using System.Threading;




namespace Interface
{
    public partial class mainForm : Form
    {
        Session s;

        //////MULTITHREAD====LADOWANIE KOMENTARZY
        //static void KomentarzeLoad()
        //{
            
        //}
        //Thread t = new Thread(new ThreadStart(KomentarzeLoad));

        public mainForm(Session s)
        {
            InitializeComponent();
            panel1.Controls.Add(new sprzedajeUserControl());
            panel1.Controls[panel1.Controls.IndexOfKey("sprzedajeUserControl")].Dock = DockStyle.Fill;

            this.s = s;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void komentarzeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int temp = panel1.Controls.IndexOf(menuStrip1);
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                if (i != temp)
                {
                    panel1.Controls.RemoveAt(i);
                }
            }

            panel1.Controls.Add(new komentarzeUserControl(s));
            panel1.Controls[panel1.Controls.IndexOfKey("komentarzeUserControl")].Dock = DockStyle.Fill;

        }

        private void sprzedajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp = panel1.Controls.IndexOf(menuStrip1);
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                if (i != temp)
                {
                    panel1.Controls.RemoveAt(i);
                }
            }

            panel1.Controls.Add(new sprzedajeUserControl());
            panel1.Controls[panel1.Controls.IndexOfKey("sprzedajeUserControl")].Dock = DockStyle.Fill;
        }

        private void sprzedaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp = panel1.Controls.IndexOf(menuStrip1);
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                if (i != temp)
                {
                    panel1.Controls.RemoveAt(i);
                }
            }

            panel1.Controls.Add(new sprzedaneUserControl());
            panel1.Controls[panel1.Controls.IndexOfKey("sprzedaneUserControl")].Dock = DockStyle.Fill;
        }

        private void niesprzedaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp = panel1.Controls.IndexOf(menuStrip1);
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                if (i != temp)
                {
                    panel1.Controls.RemoveAt(i);
                }
            }

            panel1.Controls.Add(new nieSprzedaneUserControl());
            panel1.Controls[panel1.Controls.IndexOfKey("nieSprzedaneUserControl")].Dock = DockStyle.Fill;
        }

        private void logowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            loginForm logowanie = new loginForm();            
            logowanie.Show();
        }

        private void wystawPrzedmiotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp = panel1.Controls.IndexOf(menuStrip1);
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                if (i != temp)
                {
                    panel1.Controls.RemoveAt(i);
                }
            }

            panel1.Controls.Add(new wystawianieUserControl());
            panel1.Controls[panel1.Controls.IndexOfKey("wystawianieUserControl")].Dock = DockStyle.Fill;

        }

        private void wyjdzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int temp = panel1.Controls.IndexOf(menuStrip1);
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                if (i != temp)
                {
                    panel1.Controls.RemoveAt(i);
                }
            }

            panel1.Controls.Add(new zestawieniaUserControl());
            panel1.Controls[panel1.Controls.IndexOfKey("zestawieniaUserControl")].Dock = DockStyle.Fill;

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int temp = panel1.Controls.IndexOf(menuStrip1);
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                if (i != temp)
                {
                    panel1.Controls.RemoveAt(i);
                }
            }

            panel1.Controls.Add(new zestawienia2UserControl());
            panel1.Controls[panel1.Controls.IndexOfKey("zestawienia2UserControl")].Dock = DockStyle.Fill;
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
