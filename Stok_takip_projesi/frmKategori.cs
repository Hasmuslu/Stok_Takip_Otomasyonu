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

namespace Stok_takip_projesi
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MJQAGJ8\\SQLEXPRESS; Initial Catalog =Stok_Takip;Integrated Security=true;");
        bool durum;
        private void kategoriengelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text == read["kategori"].ToString()  ||  textBox1.Text=="")
                {
                    durum =false;
                }
            }
            baglanti.Close();

        }
        private void frmKategori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            kategoriengelle();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values ('" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                MessageBox.Show("Kategori Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir kategoriy var");
            }
            textBox1.Text = "";
        }
    }
}
