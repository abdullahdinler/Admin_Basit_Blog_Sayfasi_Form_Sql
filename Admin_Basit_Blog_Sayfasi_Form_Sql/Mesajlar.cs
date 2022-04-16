using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Basit_Blog_Sayfasi_Form_Sql
{
    public partial class Mesajlar : Form
    {
        public Mesajlar()
        {
            InitializeComponent();
        }

        private void Mesajlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'form_CvDataSet2.Iletisim' table. You can move, or remove it, as needed.
            this.iletisimTableAdapter.Fill(this.form_CvDataSet2.Iletisim);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adsoyad, eposta, mesaj, konu;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            adsoyad = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            eposta = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            konu = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mesaj = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            richTextBox1.Text = "Adı Soyadı:  " + adsoyad + "\n" + "Eposta:  " + eposta + "\n" + "Konu:  " + konu + "\n" + "Mesaj:  " + mesaj;
        }
    }
}
