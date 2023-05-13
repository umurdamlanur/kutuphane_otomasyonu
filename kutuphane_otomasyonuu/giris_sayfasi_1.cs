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

namespace kutuphane_otomasyonuu
{
    public partial class giris_sayfasi_1 : Form
    {
        public giris_sayfasi_1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4VOD4RV\SQLEXPRESS01;Initial Catalog=kutuphane_otomasyonu;Integrated Security = True");
        SqlCommand komut;
        SqlDataReader dr;

        private void btnkullanicigirisi_Click(object sender, EventArgs e)
        {
            string ad = txtkullaniciad.Text;
            string sifre = txtkullanicisifre.Text;
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from tbl_kayıt_ol where ad='" + ad + "' and sıfre='" + sifre + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                kullanici_anasayfa_2 ka1 = new kullanici_anasayfa_2();
                ka1.Show();
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
            baglanti.Close();
        }

        private void btnkayıtol_Click(object sender, EventArgs e)
        {
            kayit_ol_sayfasi g1 = new kayit_ol_sayfasi();
            g1.Show();
        }

        private void btnadmingirisi_Click(object sender, EventArgs e)
        {
            string ad = txtadminad.Text;
            string sifre = txtadminsifre.Text;
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from tbl_admin_giris where ad='" + ad + "' and sıfre='" + sifre + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                anasayfa a1 = new anasayfa();
                a1.Show();
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
            baglanti.Close();
        }
    }
}
