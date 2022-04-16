using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Diagnostics;

namespace Admin_Basit_Blog_Sayfasi_Form_Sql
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void instagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/abdullahdinlerx/");
        }

        private void linkedn_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/abdullahdinler/");
        }

        private void github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/abdullahdinler");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hakkimda hakim = new Hakkimda();
            hakim.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Iletisim iletisim = new Iletisim();
            iletisim.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminGiris adminGiris = new AdminGiris();
            adminGiris.Show();
            this.Hide();
        }
    }
}
