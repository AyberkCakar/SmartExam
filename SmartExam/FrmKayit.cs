using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace SmartExam
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        TFuncKontrol FuncKontrol = new TFuncKontrol();
        Sifrele sifre = new Sifrele();

        //
        // Yasak Karakter Girişi Kontrolü
        //

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKullaniciID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void rdbOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            lblTelefon.Visible = false;
            mskTelefon.Visible = false;
        }

        private void rdbOgretmen_CheckedChanged(object sender, EventArgs e)
        {

            lblTelefon.Visible = true;
            mskTelefon.Visible = true; ;
            mskTelefon.Text = "";
        }

        private void FrmKayit_Load(object sender, EventArgs e)
        {       
        }

        // Öğrenci Kaydı 

        void ogrenciKaydi()
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Ad = txtAd.Text;
            ogr.Soyad = txtSoyad.Text;
            ogr.TC = mskTC.Text;
            if (Convert.ToInt16(cmbCinsiyet.SelectedIndex) == 0)
            {
                ogr.Cinsiyet = false;
            }
            else
            {
                ogr.Cinsiyet = true;
            }
            ogr.DogumTarihi = dtDogumTarihi.DateTime;
            ogr.KullanıcıID = txtKullaniciID.Text;
            ogr.Sifre = sifre.SifreOlustur(txtSifre.Text);
            string formKontrol = FuncKontrol.formKontrol(txtAd.Text, txtSoyad.Text, mskTC.Text, txtKullaniciID.Text, txtSifre.Text, dtDogumTarihi.Text);
            if (formKontrol == "Başarılı")
            {
                if (ogr.KisiEkle() == false)
                {
                    MessageBox.Show("Yeni Öğrenci Kaydı Eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Bu Kullanıcı Adi Veya TC Kimlik Kullanılmaktadır...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
            else
            {
                MessageBox.Show(formKontrol, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Öğretmen Kaydı

        void ogretmenKaydi()
        {
            Ogretmen ogrt = new Ogretmen();
            ogrt.Ad = txtAd.Text;
            ogrt.Soyad = txtSoyad.Text;
            ogrt.TC = mskTC.Text;
            if (Convert.ToInt16(cmbCinsiyet.SelectedIndex) == 0)
            {
                ogrt.Cinsiyet = false;
            }
            else
            {
                ogrt.Cinsiyet = true;
            }
            ogrt.DogumTarihi = dtDogumTarihi.DateTime;
            ogrt.KullanıcıID = txtKullaniciID.Text;
            ogrt.Sifre = sifre.SifreOlustur(txtSifre.Text);
            ogrt.Telefon = mskTelefon.Text;
            string formKontrol = FuncKontrol.formKontrol(txtAd.Text, txtSoyad.Text, mskTC.Text, txtKullaniciID.Text, txtSifre.Text, dtDogumTarihi.Text);
            if (formKontrol == "Başarılı")
            {
                if(ogrt.KisiEkle() == false)
                {
                    MessageBox.Show("Yeni Öğretmen Kaydı Eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Bu Kullanıcı Adi Veya TC Kimlik Kullanılmaktadır...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(formKontrol, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (rdbOgrenci.Checked == true)
            {
                ogrenciKaydi();
            }
            else if (rdbOgretmen.Checked == true)
            {
                ogretmenKaydi();
            }
            else
            {
                MessageBox.Show("Kayıt Türü Seçiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtDogumTarihi_EditValueChanged(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Today;
            dtDogumTarihi.EditValue = tarih;
        }
    }
}
