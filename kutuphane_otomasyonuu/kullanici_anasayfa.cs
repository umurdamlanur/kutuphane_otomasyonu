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

namespace kutuphane_otomasyonuu //bu sayfa kullanılmıyor
{
    public partial class kullanici_anasayfa : Form
    {
        public kullanici_anasayfa()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4VOD4RV\SQLEXPRESS01;Initial Catalog=kutuphane_otomasyonu;Integrated Security=True");

        private void btnekle_Click(object sender, EventArgs e)
        {
            /* baglanti.Open(); //tbl_alınan_kitap

            // Veritabanından hesabın var olup olmadığını kontrol etmek için sorgu
            SqlCommand kontrolKomutu = new SqlCommand("SELECT COUNT(*) FROM tbl_kitapp WHERE kod=@p1 AND k_ad=@p2 AND yazar_ad=@p3 AND sayfa_sayisi=@p4 AND alinan_tarih=@p5 AND teslim_tarihi=@p6 AND teslim_alan=@p7", baglanti);
             kontrolKomutu.Parameters.AddWithValue("@p1", txtkod.Text);
             kontrolKomutu.Parameters.AddWithValue("@p2", txtkad.Text);
             kontrolKomutu.Parameters.AddWithValue("@p3", txtyazarad.Text);
             kontrolKomutu.Parameters.AddWithValue("@p4", txtsayfa.Text);
             kontrolKomutu.Parameters.AddWithValue("@p5", DateTime.Parse(dtalinantarih.Text));
             kontrolKomutu.Parameters.AddWithValue("@p6", DateTime.Parse(dtteslimtarih.Text));
             kontrolKomutu.Parameters.AddWithValue("@p7", txtteslimalan.Text);
             int count = (int)kontrolKomutu.ExecuteScalar();

             if (count > 0)
             {
                 // hesap varsa
                 MessageBox.Show("girdiğiniz kitap bilgileri yanlış lütfen kontrol edip tekrar giriniz!");
             }
             else
             {
                 // hesap yoksa, kaydı ekle bölümü
                 SqlCommand komut = new SqlCommand("INSERT INTO tbl_kitapp (kod, k_ad, yazar_ad, sayfa_sayisi, alinan_tarih, teslim_tarihi, teslim_alan) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", baglanti);
                 komut.Parameters.AddWithValue("@p1", txtkod.Text);
                 komut.Parameters.AddWithValue("@p2", txtkad.Text);
                 komut.Parameters.AddWithValue("@p3", txtyazarad.Text);
                 komut.Parameters.AddWithValue("@p4", txtsayfa.Text);
                 komut.Parameters.AddWithValue("@p5", DateTime.Parse(dtalinantarih.Text));
                 komut.Parameters.AddWithValue("@p6", DateTime.Parse(dtteslimtarih.Text));
                 komut.Parameters.AddWithValue("@p7", txtteslimalan.Text);
                 komut.ExecuteNonQuery();
                 MessageBox.Show("kitap bilgileri eklendi. keyifli okumalar:)");
                // txtkod.Clear(); //kod deneme

             }

            string kitapBilgisi = txtkod.Text + " - " + txtkad.Text + " - " + txtyazarad.Text;
            listBox1.Items.Add(kitapBilgisi);
            txtkod.Clear(); 
            txtkad.Clear();
            txtyazarad.Clear();
            txtsayfa.Clear();
            txtteslimalan.Clear();

            baglanti.Close();
            */
        }
    }
}
