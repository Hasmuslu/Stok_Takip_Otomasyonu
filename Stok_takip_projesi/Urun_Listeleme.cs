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
    public partial class Urun_Listeleme : Form
    {
        public Urun_Listeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MJQAGJ8\\SQLEXPRESS; Initial Catalog =Stok_Takip;Integrated Security=true;");
        DataSet daset = new DataSet();
        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read[0].ToString());
            }
            baglanti.Close();
        }
        private void Urun_Listeleme_Load(object sender, EventArgs e)
        {
            getir();
            kategorigetir();
        }

        private void getir()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set  urunadi=@urunadi,miktari=@miktari,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", textBox6.Text);
            komut.Parameters.AddWithValue("@urunadi", textBox9.Text);
            komut.Parameters.AddWithValue("@miktari",int.Parse(textBox10.Text));
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(textBox11.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(textBox12.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            getir();
            MessageBox.Show("ÜRÜNLER GÜNCELLENDİ");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set  kategori=@kategori,marka=@marka where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", textBox6.Text);
                komut.Parameters.AddWithValue("@kategori", comboBox1.Text);
                komut.Parameters.AddWithValue("@marka", comboBox2.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("ÜRÜNLER GÜNCELLENDİ");
            }
            else
            {
                MessageBox.Show("Barkod no yazılı değil");
            }

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            daset.Tables["urun"].Clear();
            getir();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from markabilgileri where kategori='" + comboBox1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox2.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Eminmisiniz", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete  from  urun where barkodno=@barkodno",baglanti);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["urun"].Clear();
                getir();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from urun where barkodno like '%" + textBox1.Text + "%'", baglanti);
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}

