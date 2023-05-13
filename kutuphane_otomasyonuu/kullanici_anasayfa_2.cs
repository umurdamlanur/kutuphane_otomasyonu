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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kutuphane_otomasyonuu
{
    public partial class kullanici_anasayfa_2 : Form
    {
        public kullanici_anasayfa_2()
        {
            InitializeComponent();
        }
        SqlCommand komut;
        SqlDataReader dr;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4VOD4RV\SQLEXPRESS01;Initial Catalog=kutuphane_otomasyonu;Integrated Security=True");
        private string connectionString;

        private void btnekle_Click(object sender, EventArgs e)
        {
            //listboxa ekleme kısmı
            string kitapBilgisi = combokod.Text + " - " + txtkad.Text + " - " + txtteslimalan.Text + " - " + dtalinantarih.Text + " - " + dtteslimtarih.Text;
            listBox1.Items.Add(kitapBilgisi);

            txtkad.Clear();
            txtyazarad.Clear();
            txtsayfa.Clear();
            txtteslimalan.Clear();
        }

        private void combokod_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_kitapp", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // DataTable tablosundaki verileri combokod'a eklemek için 
            foreach (DataRow row in dt.Rows)
            {
                combokod.Items.Add(row["kod"].ToString());
            }
            string selectedValue = combokod.SelectedItem.ToString();
            {
                baglanti.Open();
            }

            string query = "SELECT * FROM tbl_kitapp WHERE kod = @p1";
            SqlCommand command = new SqlCommand(query, baglanti);
            command.Parameters.AddWithValue("@p1", selectedValue);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtkad.Text = reader["k_ad"].ToString();
                txtyazarad.Text = reader["yazar_ad"].ToString();
                txtsayfa.Text = reader["sayfa_sayisi"].ToString();
            }
            baglanti.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
