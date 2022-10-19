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
    public partial class Müşteri_Ekleme : Form
    {
        public Müşteri_Ekleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MJQAGJ8\\SQLEXPRESS; Initial Catalog =Stok_Takip;Integrated Security=true;");
        private void Müşteri_Ekleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into muşteri (tc,adsoyad,telefon,adres,email) Values (@tc,@adsoyad,@telefon,@adres,@email)", baglanti);
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
            MessageBox.Show("Müşteri EKlendi");
        }
    }
}
