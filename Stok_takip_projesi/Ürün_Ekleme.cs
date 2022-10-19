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
    public partial class Ürün_Ekleme : Form
    {
        public Ürün_Ekleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MJQAGJ8\\SQLEXPRESS; Initial Catalog =Stok_Takip;Integrated Security=true;");
        bool durum;

        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text == read["barkodno"].ToString() || textBox1.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into urun (barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values (@barkodno,@kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", textBox1.Text);
                komut.Parameters.AddWithValue("@kategori", comboBox1.Text);
                komut.Parameters.AddWithValue("@marka", comboBox2.Text);
                komut.Parameters.AddWithValue("@urunadi", textBox2.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(textBox3.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(textBox4.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(textBox5.Text));
                komut.Parameters.AddWithValue("@tarih", textBox6.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("ürün eklendi");
            }
            else
            {
                MessageBox.Show("barkod no mevcut");
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
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
        private void Ürün_Ekleme_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from markabilgileri where kategori='"+comboBox1.Text+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox2.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text=="")
            {
                textBox3.Text = "";
                foreach  (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodno like'" + textBox6.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textBox7.Text = read["kategori"].ToString();
                textBox8.Text = read["marka"].ToString();
                textBox9.Text = read["urunadi"].ToString();
                lblmiktar.Text = read["miktari"].ToString();
                textBox11.Text = read["alisfiyati"].ToString();
                textBox12.Text = read["satisfiyati"].ToString();

            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update urun set miktari=miktari+'"+int.Parse(textBox10.Text)+"' where barkodno='"+textBox6.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("ÜRÜN GÜNCELLENDİ");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
