using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Admin_Basit_Blog_Sayfasi_Form_Sql
{
    public partial class Iletisim : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Form_Cv;Integrated Security=True");
        public Iletisim()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Iletisim iletisim = new Iletisim();
            iletisim.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hakkimda hakim = new Hakkimda();
            hakim.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // girilen verileri sql gonderdik
            baglanti.Open();
            SqlCommand gonder = new SqlCommand("insert into Iletisim (Ad_Soyad,Eposta,Konu,Mesaj) values (@adsoyad,@eposta,@konu,@mesaj)", baglanti);
            gonder.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            gonder.Parameters.AddWithValue("@eposta", txteposta.Text);
            gonder.Parameters.AddWithValue("@konu", boxkonu.Text);
            gonder.Parameters.AddWithValue("@mesaj", txtmesaj.Text);
            gonder.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız başarılı bir şekilde gönderilmiştir. En kısa sürede sizlerle iletişime geçilecektir.", "Bilgilendirme",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtadsoyad.Text = "";
            txteposta.Text = "";
            txtmesaj.Text = "";
            boxkonu.Text = "";
        }

        
    }
}
