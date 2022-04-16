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
    public partial class AdminGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Form_Cv;Integrated Security=True");
        public AdminGiris()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand admingiris = new SqlCommand("Select * from Admin_Liste where KullaniciAdi = @adi and Sifre = @sifre", baglanti);
            admingiris.Parameters.AddWithValue("@adi", textkullaniciadi.Text);
            admingiris.Parameters.AddWithValue("@sifre", textsifre.Text);
            SqlDataReader onay = admingiris.ExecuteReader();
            if (onay.Read())
            {
                AdminPanelHakkimda adminPanel = new AdminPanelHakkimda();
                adminPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ve şifre.", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            baglanti.Close();
        }
    }
}
