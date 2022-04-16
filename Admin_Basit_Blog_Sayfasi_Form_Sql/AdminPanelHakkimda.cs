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
    public partial class AdminPanelHakkimda : Form
    {
        private SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Form_Cv;Integrated Security=True");
        public AdminPanelHakkimda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxkisa.Text = "";
            TextBoxuzun.Text = "";
            textyas.Text = "";
            textcsharp.Text = "";
            textcss.Text = "";
            textderece.Text = "";
            texteposta.Text = "";
            texthtml.Text = "";
            textjavascript.Text = "";
            textsql.Text = "";
            texttelefon.Text = "";
            textwebsite.Text = "";
            combofreelance.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hakkimda ilk ve sonuncu yazilari gunceller.
            baglanti.Open();
            SqlCommand command = new SqlCommand("update Admin_Hakkinda set Kisa_Ozet = @kisa, Uzun_Ozet = @uzun", baglanti);
            command.Parameters.AddWithValue("@kisa", TextBoxkisa.Text);
            command.Parameters.AddWithValue("@uzun", TextBoxuzun.Text);
            command.ExecuteNonQuery();
            baglanti.Close();

            // Yetenek 1
            baglanti.Open();
            SqlCommand comman2 = new SqlCommand("update Yetenekler set Deger= @deger where id = 1", baglanti);
            comman2.Parameters.AddWithValue("@deger", texthtml.Text);
            comman2.ExecuteNonQuery();
            baglanti.Close();

            // Yetenek 2
            baglanti.Open();
            SqlCommand comman3 = new SqlCommand("update Yetenekler set Deger= @deger where id = 2", baglanti);
            comman3.Parameters.AddWithValue("@deger", textcss.Text);
            comman3.ExecuteNonQuery();
            baglanti.Close();

            // Yetenek 3
            baglanti.Open();
            SqlCommand comman4 = new SqlCommand("update Yetenekler set Deger= @deger where id = 3", baglanti);
            comman4.Parameters.AddWithValue("@deger", textjavascript.Text);
            comman4.ExecuteNonQuery();
            baglanti.Close();

            // Yetenek 4
            baglanti.Open();
            SqlCommand comman5 = new SqlCommand("update Yetenekler set Deger= @deger where id = 4", baglanti);
            comman5.Parameters.AddWithValue("@deger", textcsharp.Text);
            comman5.ExecuteNonQuery();
            baglanti.Close();

            // Yetenek 5
            baglanti.Open();
            SqlCommand comman6 = new SqlCommand("update Yetenekler set Deger= @deger where id = 5", baglanti);
            comman6.Parameters.AddWithValue("@deger", textsql.Text);
            comman6.ExecuteNonQuery();
            baglanti.Close();

            // Yas vb verileri gunceller.
            baglanti.Open();
            SqlCommand command7 = new SqlCommand("update admin_bilgi set Yas = @yas, Website = @website, Derece = @derece, Telefon = @telefon, Eposta = @eposta, Freelance = @freelance", baglanti);
            command7.Parameters.AddWithValue("@yas", textyas.Text);
            command7.Parameters.AddWithValue("@website", textwebsite.Text);
            command7.Parameters.AddWithValue("@derece", textderece.Text);
            command7.Parameters.AddWithValue("@telefon", texttelefon.Text);
            command7.Parameters.AddWithValue("@eposta", texteposta.Text);
            command7.Parameters.AddWithValue("@freelance", combofreelance.Text);
            command7.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler başarılı bir şekilde güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AdminEkle adminEkle = new AdminEkle();
            adminEkle.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Mesajlar mesajlar = new Mesajlar();
            mesajlar.Show();
        }
    }
}
