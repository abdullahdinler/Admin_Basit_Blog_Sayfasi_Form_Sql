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
    public partial class Hakkimda : Form
    {
        public Hakkimda()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Form_Cv;Integrated Security=True");

        private void Hakkimda_Load(object sender, EventArgs e)
        {

            // Hakkimda kisa ve uzun yazi sql kodu.
            baglanti.Open();
            SqlCommand command = new SqlCommand("Select * from Admin_Hakkinda",baglanti);
            command.ExecuteNonQuery();
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                kisaozet_txt.Text = dataReader["Kisa_Ozet"].ToString();
                uzunozet_txt.Text = dataReader["Uzun_Ozet"].ToString();
            }
            baglanti.Close();


            // Hakkimda kisisel bilgi kisi sql kodu.
            baglanti.Open();
            SqlCommand uzunyazi = new SqlCommand("Select * from admin_bilgi",baglanti);
            uzunyazi.ExecuteNonQuery();
            SqlDataReader admindDataReader = uzunyazi.ExecuteReader();
            while (admindDataReader.Read())
            {
                dogumgunu_txt.Text = admindDataReader["Dogum_Gunu"].ToString();
                yas_txt.Text = admindDataReader["Yas"].ToString();
                website_txt.Text = admindDataReader["Website"].ToString();
                derece_txt.Text = admindDataReader["Derece"].ToString();
                telefon_txt.Text = admindDataReader["Telefon"].ToString();
                eposta_txt.Text = admindDataReader["Eposta"].ToString();
                sehir_txt.Text = admindDataReader["Sehir"].ToString();
                freelance_txt.Text = admindDataReader["Freelance"].ToString();
            }
            baglanti.Close();


            // Yetenekler
            baglanti.Open();
            SqlCommand yetenek = new SqlCommand("Select tablo.* From (select row_number() over(order by Id) indexer, * from Yetenekler) tablo where tablo.indexer = 1 ",baglanti);
            yetenek.ExecuteNonQuery();
            SqlDataReader yetenekDataReader = yetenek.ExecuteReader();
            while (yetenekDataReader.Read())
            {
                yetenekadi1.Text = yetenekDataReader[2].ToString();
                yetenek1.Value = Convert.ToInt32(yetenekDataReader[3]);
            }
            baglanti.Close();


            // Yetenekler 2
            baglanti.Open();
            SqlCommand yetenekk2 = new SqlCommand("Select tablo.* From (select row_number() over(order by Id) indexer, *from Yetenekler) tablo where tablo.indexer = 2", baglanti);
            yetenekk2.ExecuteNonQuery();
            SqlDataReader yetenekDataReader2 = yetenekk2.ExecuteReader();
            while (yetenekDataReader2.Read())
            {
                yetenekadi2.Text = yetenekDataReader2[2].ToString();
                yetenek2.Value = Convert.ToInt32(yetenekDataReader2[3]);
            }
            baglanti.Close();


            // Yetenekler 3
            baglanti.Open();
            SqlCommand yetenekk3 = new SqlCommand("Select tablo.* From (select row_number() over(order by Id) indexer, *from Yetenekler) tablo where tablo.indexer = 3", baglanti);
            yetenekk3.ExecuteNonQuery();
            SqlDataReader yetenekDataReader3 = yetenekk3.ExecuteReader();
            while (yetenekDataReader3.Read())
            {
                yetenekadi3.Text = yetenekDataReader3[2].ToString();
                yetenek3.Value = Convert.ToInt32(yetenekDataReader3[3]);
            }
            baglanti.Close();

            // Yetenekler 4
            baglanti.Open();
            SqlCommand yetenekk4 = new SqlCommand("Select tablo.* From (select row_number() over(order by Id) indexer, *from Yetenekler) tablo where tablo.indexer = 4", baglanti);
            yetenekk4.ExecuteNonQuery();
            SqlDataReader yetenekDataReader4 = yetenekk4.ExecuteReader();
            while (yetenekDataReader4.Read())
            {
                yetenekadi4.Text = yetenekDataReader4[2].ToString();
                yetenek4.Value = Convert.ToInt32(yetenekDataReader4[3]);
            }
            baglanti.Close();


            // Yetenekler 5
            baglanti.Open();
            SqlCommand yetenekk5 = new SqlCommand("Select tablo.* From (select row_number() over(order by Id) indexer, *from Yetenekler) tablo where tablo.indexer = 5", baglanti);
            yetenekk5.ExecuteNonQuery();
            SqlDataReader yetenekDataReader5 = yetenekk5.ExecuteReader();
            while (yetenekDataReader5.Read())
            {
                yetenekadi5.Text = yetenekDataReader5[2].ToString();
                yetenek5.Value = Convert.ToInt32(yetenekDataReader5[3]);
            }
            baglanti.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Iletisim iletisim = new Iletisim();
            iletisim.Show();
            this.Hide();
        }
    }
}
