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
    public partial class AdminEkle : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Form_Cv;Integrated Security=True");
        public AdminEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Admin_Liste (KullaniciAdi,Sifre) values(@kullaniciadi,@sifre)", connection);
            command.Parameters.AddWithValue("@kullaniciadi", textBox1.Text);
            command.Parameters.AddWithValue("@sifre", textBox2.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kullanıcı başarılı bir şekilde eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
