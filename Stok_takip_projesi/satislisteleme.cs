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
    public partial class satislisteleme : Form
    {
        public satislisteleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MJQAGJ8\\SQLEXPRESS; Initial Catalog =Stok_Takip;Integrated Security=true;");
        DataSet daset = new DataSet();
        private void satislisteleme_Load(object sender, EventArgs e)
        {
            satislistele();
        }

        private void satislistele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from satis", baglanti);
            da.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];
            baglanti.Close();
        }
    }
}
