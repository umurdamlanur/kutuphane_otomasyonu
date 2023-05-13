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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4VOD4RV\SQLEXPRESS01;Initial Catalog=kutuphane_otomasyonu;Integrated Security=True");


        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //tbl_kitap_bilgileri

            // Veritabanından hesabın var olup olmadığını kontrol etmek için sorgu 
            SqlCommand kontrolKomutu = new SqlCommand("SELECT COUNT(*) FROM tbl_kitapp WHERE kod=@p1 AND k_ad=@p2 AND yazar_ad=@p3 AND sayfa_sayisi=@p4 AND yayinevi_ad=@p5 AND yayin_tarihi=@p6 AND konusu=@p7", baglanti);
            kontrolKomutu.Parameters.AddWithValue("@p1", txtkod.Text);
            kontrolKomutu.Parameters.AddWithValue("@p2", txtkad.Text);
            kontrolKomutu.Parameters.AddWithValue("@p3", txtyazarad.Text);
            kontrolKomutu.Parameters.AddWithValue("@p4", txtsayfa.Text);
            kontrolKomutu.Parameters.AddWithValue("@p5", txtyayinevi.Text);
            kontrolKomutu.Parameters.AddWithValue("@p6", DateTime.Parse(dtyayintarihi.Text));
            kontrolKomutu.Parameters.AddWithValue("@p7", txtkonu.Text);
            int count = (int)kontrolKomutu.ExecuteScalar();

            if (count > 0)
            {
                // hesap varsa
                MessageBox.Show("daha önce bu bilgilere sahip bir kitap eklediniz!");
            }
            else
            {
                // hesap yoksa, kaydı ekle bölümü
                SqlCommand komut = new SqlCommand("INSERT INTO tbl_kitapp (kod, k_ad, yazar_ad, sayfa_sayisi, yayinevi_ad, yayin_tarihi, konusu) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtkod.Text);
                komut.Parameters.AddWithValue("@p2", txtkad.Text);
                komut.Parameters.AddWithValue("@p3", txtyazarad.Text);
                komut.Parameters.AddWithValue("@p4", txtsayfa.Text);
                komut.Parameters.AddWithValue("@p5", txtyayinevi.Text);
                komut.Parameters.AddWithValue("@p6", DateTime.Parse(dtyayintarihi.Text));
                komut.Parameters.AddWithValue("@p7", txtkonu.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("kitap bilgileri eklendi.");
                txtkod.Clear(); 
                txtkad.Clear();
                txtyazarad.Clear();
                txtsayfa.Clear();
                txtyayinevi.Clear();
                txtkonu.Clear();



            }

            baglanti.Close();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kutuphane_otomasyonuDataSet1.tbl_kitapp' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_kitappTableAdapter.Fill(this.kutuphane_otomasyonuDataSet1.tbl_kitapp);
            // TODO: Bu kod satırı 'kutuphane_otomasyonuDataSet.tbl_kitap_bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_kitap_bilgileriTableAdapter.Fill(this.kutuphane_otomasyonuDataSet.tbl_kitap_bilgileri);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from tbl_kitapp WHERE kod=@p1 AND k_ad=@p2 AND yazar_ad=@p3 AND sayfa_sayisi=@p4 AND yayinevi_ad=@p5 AND yayin_tarihi=@p6 AND konusu=@p7", baglanti);
            komut.Parameters.AddWithValue("@p1", txtkod.Text);
            komut.Parameters.AddWithValue("@p2", txtkad.Text);
            komut.Parameters.AddWithValue("@p3", txtyazarad.Text);
            komut.Parameters.AddWithValue("@p4", txtsayfa.Text);
            komut.Parameters.AddWithValue("@p5", txtyayinevi.Text);
            komut.Parameters.AddWithValue("@p6", DateTime.Parse(dtyayintarihi.Text));
            komut.Parameters.AddWithValue("@p7", txtkonu.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kitap bilgileri silindi.");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_kitapp set kod=@p1, k_ad=@p2, yazar_ad=@p3, sayfa_sayisi=@p4, yayinevi_ad=@p5, yayin_tarihi=@p6, konusu=@p7", baglanti);
            komut.Parameters.AddWithValue("@p1", txtkod.Text);
            komut.Parameters.AddWithValue("@p2", txtkad.Text);
            komut.Parameters.AddWithValue("@p3", txtyazarad.Text);
            komut.Parameters.AddWithValue("@p4", txtsayfa.Text);
            komut.Parameters.AddWithValue("@p5", txtyayinevi.Text);
            komut.Parameters.AddWithValue("@p6", DateTime.Parse(dtyayintarihi.Text));
            komut.Parameters.AddWithValue("@p7", txtkonu.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kitap bilgileri güncellendi.");
            baglanti.Close();
        }
    }
}
