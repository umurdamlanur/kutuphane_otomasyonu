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

namespace kutuphane_otomasyonuu
{
    public partial class kayit_ol_sayfasi : Form
    {
        public kayit_ol_sayfasi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4VOD4RV\SQLEXPRESS01;Initial Catalog=kutuphane_otomasyonu;Integrated Security=True");


        private void btnkullanicigirisi_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            // Veritabanından hesabın var olup olmadığını kontrol etmek için sorgu
            SqlCommand kontrolKomutu = new SqlCommand("SELECT COUNT(*) FROM tbl_kitap_bilgileri WHERE ad=@p1 AND soyad=@p2 AND eposta=@p3 AND sıfre=@p4", baglanti);
            kontrolKomutu.Parameters.AddWithValue("@p1", txtad.Text);
            kontrolKomutu.Parameters.AddWithValue("@p2", txtsoyad.Text);
            kontrolKomutu.Parameters.AddWithValue("@p3", txteposta.Text);
            kontrolKomutu.Parameters.AddWithValue("@p4", txtsifre.Text);
            int count = (int)kontrolKomutu.ExecuteScalar();

            if (count > 0)
            {
                // hesap varsa
                MessageBox.Show("daha önce hesap oluşturdunuz lütfen hesabım kısmından giriş yapın!");
            }
            else
            {
                // hesap yoksa, kaydı ekle bölümü
                SqlCommand komut = new SqlCommand("INSERT INTO tbl_kayıt_ol (ad, soyad, eposta, sıfre) VALUES (@p1, @p2, @p3, @p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p3", txteposta.Text);
                komut.Parameters.AddWithValue("@p4", txtsifre.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("kaydınız başarıyla eklendi. giriş sayfasına yönlendiriliyorsunuz.");
            }

            giris_sayfasi_1 g1 = new giris_sayfasi_1();
            g1.Show();

            baglanti.Close();
        }
    }
}
