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
            if (txtKullaniciID.Text == "Kullanıcı ID")
            {
                txtKullaniciID.Text = "";
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
            if (txtKullaniciID.Text == "")
            {
                txtKullaniciID.Text = "Kullanıcı ID";
            }
        }

        // Giriş

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Öğrenci Girişi Kontrolleri

            if (rdbOgrenci.Checked == true)
            {
                GirisServisi giris = new GirisServisi();
                if (giris.GirisYapOgrenci(txtKullaniciID.Text.ToLower(), txtSifre.Text) != null)
                {
                    OgrenciScreen ogr = new OgrenciScreen();
                    ogr.kullanici = txtKullaniciID.Text.ToLower();
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
                if (giris.GirisYapOgretmen(txtKullaniciID.Text.ToLower(), txtSifre.Text) != null)
                {
                    OgretmenScreen ogrt = new OgretmenScreen();
                    ogrt.kullanici = txtKullaniciID.Text.ToLower();
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
