using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_takip_projesi
{
    public partial class Müşteri_Listeleme : Form
    {
        public Müşteri_Listeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MJQAGJ8\\SQLEXPRESS; Initial Catalog =Stok_Takip;Integrated Security=true;");
        DataSet daset = new DataSet();
        private void Müşteri_Listeleme_Load(object sender, EventArgs e)
        {
            verileri_getir();
        }

        private void verileri_getir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from muşteri", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            texttc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            textadsoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            texttel.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            textadres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            textemail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Eminmisiniz", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "delete  from  muşteri where tc=@tc";
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                verileri_getir();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update muşteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc",baglanti);
            komut.Parameters.AddWithValue("@tc", texttc.Text);
            komut.Parameters.AddWithValue("@adsoyad", textadsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", texttel.Text);
            komut.Parameters.AddWithValue("@adres", textadres.Text);
            komut.Parameters.AddWithValue("@email", textemail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            texttc.Clear();
            textadsoyad.Clear();
            texttel.Clear();
            textadres.Clear();
            textemail.Clear();
            MessageBox.Show("Müşteri Güncellendi");
            verileri_getir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from muşteri where tc like '%"+ textBox1.Text+"%'" ,baglanti);
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}

