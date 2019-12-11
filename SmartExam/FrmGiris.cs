using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartExam
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        // Yeni Üyelik Ana İşlemler

        private void btnKayit_Click(object sender, EventArgs e)
        {
            FrmKayit frmKayit = new FrmKayit();
            frmKayit.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Txt'lerin Tıklanma Davranışları

        private void txtKullaniciID_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Kullanıcı Adı")
            {
                txtKullaniciAdi.Text = "";
            }
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Sifre";
            }
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Sifre")
            {
                txtSifre.Text = "";
            }
            if (txtKullaniciAdi.Text == "")
            {
                txtKullaniciAdi.Text = "Kullanıcı Adı";
            }
        }

        // Karakter Girişi Yasaklama

        private void txtKullaniciID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Giriş

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Öğrenci Girişi Kontrolleri

            Sifrele sifre = new Sifrele();

            if (rdbOgrenci.Checked == true)
            {
                GirisServisi giris = new GirisServisi();
                if (giris.GirisYapOgrenci(txtKullaniciAdi.Text.ToLower(), sifre.SifreOlustur(txtSifre.Text)) != null)
                {
                    OgrenciScreen ogr = new OgrenciScreen();
                    ogr.kullanici = txtKullaniciAdi.Text.ToLower();
                    ogr.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Öğrenci Bilgisi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            // Öğretmen Girişi Kontrolleri
            else if (rdbOgretmen.Checked == true)
            {
                GirisServisi giris = new GirisServisi();
                if (giris.GirisYapOgretmen(txtKullaniciAdi.Text.ToLower(), sifre.SifreOlustur(txtSifre.Text)) != null)
                {
                    OgretmenScreen ogrt = new OgretmenScreen();
                    ogrt.kullanici = txtKullaniciAdi.Text.ToLower();
                    ogrt.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Öğretmen Bilgisi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Giriş Türü Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
