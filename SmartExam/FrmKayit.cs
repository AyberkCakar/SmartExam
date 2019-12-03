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
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbOgrenci.Checked == true)
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
                        ogr.Cinsiyet = true;
                    ogr.DogumTarihi = dtDogumTarihi.DateTime;
                    ogr.KullanıcıID = txtKullaniciID.Text;
                    ogr.Sifre = txtSifre.Text;
                    ogr.KisiEkle();
                    MessageBox.Show("Yeni Öğrenci Kaydı Eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (rdbOgretmen.Checked == true)
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
                        ogrt.Cinsiyet = true;
                    ogrt.DogumTarihi = dtDogumTarihi.DateTime;
                    ogrt.KullanıcıID = txtKullaniciID.Text;
                    ogrt.Sifre = txtSifre.Text;
                    ogrt.Telefon = mskTelefon.Text;
                    ogrt.KisiEkle();
                    MessageBox.Show("Yeni Öğretmen Kaydı Eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kayıt Türü Seçiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;

            }

        }
    }
}
