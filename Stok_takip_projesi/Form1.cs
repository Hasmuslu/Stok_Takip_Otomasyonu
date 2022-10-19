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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MJQAGJ8\\SQLEXPRESS; Initial Catalog =Stok_Takip;Integrated Security=true;");
        DataSet daset = new DataSet();
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet",baglanti);
                lblgeneltoplam.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from sepet",baglanti);
            da.Fill(daset,"sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible=false;
            dataGridView1.Columns[1].Visible=false;
            dataGridView1.Columns[2].Visible=false;
            baglanti.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Müşteri_Ekleme me = new Müşteri_Ekleme();
            me.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Müşteri_Listeleme ml = new Müşteri_Listeleme();
            ml.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ürün_Ekleme üe = new Ürün_Ekleme();
            üe.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmKategori kate = new frmKategori();
            kate.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmMarka mark = new frmMarka();
            mark.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Urun_Listeleme ul = new Urun_Listeleme();
            ul.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void texttc_TextChanged(object sender, EventArgs e)
        {
            if (texttc.Text=="")
            {
                textadsoyad.Text = "";
                texttel.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from muşteri where tc like'"+texttc.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textadsoyad.Text = read["adsoyad"].ToString();
                texttel.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void textbarkod_TextChanged(object sender, EventArgs e)
        {
            temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodno like'" + textbarkod.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textürünadi.Text = read["urunadi"].ToString();
                textsatisfiyat.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
        }

        private void temizle()
        {
            if (textbarkod.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != textmiktar)
                        {
                            item.Text = "";
                        }
                    }
                }

            }
        }
        bool durum;
        private void barkod_kontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textbarkod.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            barkod_kontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet (tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values (@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", texttc.Text);
                komut.Parameters.AddWithValue("@adsoyad", textadsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", texttel.Text);
                komut.Parameters.AddWithValue("@barkodno", textbarkod.Text);
                komut.Parameters.AddWithValue("@urunadi", textürünadi.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(textmiktar.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(textsatisfiyat.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(texttoplamfiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["sepet"].Clear();
                sepetlistele();
                


            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update sepet set miktari=miktari+'" + int.Parse(textmiktar.Text)+ "' where barkodno='" + textbarkod.Text + "' ", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyati=miktari*satisfiyati where barkodno='" + textbarkod.Text+"'",baglanti);             
                komut3.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["sepet"].Clear();
                sepetlistele();

            }
            

            textmiktar.Text = "1";
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != textmiktar)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void textmiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                texttoplamfiyat.Text = (double.Parse(textmiktar.Text) * double.Parse(textsatisfiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void textsatisfiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                texttoplamfiyat.Text = (double.Parse(textmiktar.Text) * double.Parse(textsatisfiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Silmek İstediğinize Eminmisiniz", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete  from  sepet where barkodno=@barkodno",baglanti);               
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut.ExecuteNonQuery(); 
                baglanti.Close();
                hesapla();
                MessageBox.Show("ÜRüN SEPETTEN ÇIKTI");
                daset.Tables["sepet"].Clear();
                sepetlistele();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete  from  sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            hesapla();
            MessageBox.Show("Sepet İptal EDildi");
            daset.Tables["sepet"].Clear();
            sepetlistele();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            satislisteleme sl = new satislisteleme();
            sl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis (tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values (@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", texttc.Text);
                komut.Parameters.AddWithValue("@adsoyad", textadsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", texttel.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("Update urun set miktari=miktari+'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                

            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete  from  sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
            MessageBox.Show("SATIŞ YAPILDI");
        }
    }
}
