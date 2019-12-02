using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace SmartExam
{
    public partial class OgrenciScreen : Form
    {
        public OgrenciScreen()
        {
            InitializeComponent();
        }

        //
        //  Genel Tanımlar
        //


        Sinav sinav = new Sinav();
        Ogrenci ogr = new Ogrenci();
        public string kullanici;


        //
        //  Ana Menü İşlemleri
        //
        private void OgrenciScreen_Load(object sender, EventArgs e)
        {
            OgrenciBilgiGetir();
            gridSinavDoldur();
            comboBoxDersGetir();
            
        }

        private void btnSinavlarim_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
            gridSinavDoldur();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 2;
        }

        private void btnBilgilerim_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 3;
        }

        private void btnCikis_Click(object sender, EventArgs e)  // Eğer ki Sınav Ekranı Açıksa Programı Kapatma
        {
            FrmSinav frmSınav = new FrmSinav();
            if (Application.OpenForms[frmSınav.Name] == null)
            {
                this.Close();
            }
        }


        //
        //  Sınav İşlemleri
        //


        // Öğrencinin Çözdüğü Sınav Bilgilerini Getir

        void gridSinavDoldur()
        {
            ogr.SinavBilgileriniGetir(sinav, Convert.ToInt32(txtogrID.Text));
            DataTable tablo = new DataTable();
            tablo.Columns.Add("SinavID", typeof(int));
            tablo.Columns.Add("Ders", typeof(string));
            tablo.Columns.Add("Sınıf", typeof(int));
            tablo.Columns.Add("Doğru", typeof(int));
            tablo.Columns.Add("Yanlış", typeof(int));
            tablo.Columns.Add("Boş", typeof(int));
            tablo.Columns.Add("Tarih", typeof(DateTime));
            foreach (Sinav sin in sinav.Sinavlar)
            {
                tablo.Rows.Add(sin.SinavID, sin.DersAD, sin.Sinif, sin.sinavDet.Dogru, sin.sinavDet.Yanliş, sin.sinavDet.Bos, sin.sinavDet.Tarih);
                gridControl1.DataSource = tablo;
            }
            sinav.Sinavlar.Clear();
            gridView1.OptionsBehavior.Editable = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtSinavNo.Text = Convert.ToInt32(dataRow[0]).ToString();
            txtDers.Text = dataRow[1].ToString();
            txtSinavSinif.Text = Convert.ToInt32(dataRow[2]).ToString();
            txtSinavDogru.Text = Convert.ToInt32(dataRow[3]).ToString();
            txtSinavYanlis.Text = Convert.ToInt32(dataRow[4]).ToString();
            txtBos.Text = Convert.ToInt32(dataRow[5]).ToString();
            txtTarih.Text = Convert.ToDateTime(dataRow[6]).ToString();
        }

        // Öğrenci için Kayıtlı Tüm Dersleri Sınavın Dersi İçin Getir

        void comboBoxDersGetir()
        {
            Ders ders = new Ders();
            ders.TumDersler();
            foreach (Ders dr in ders.Dersler)
            {
                cmbDers.Properties.Items.Add(dr.DersAD);
                cmbIstatistikDers.Properties.Items.Add(dr.DersAD);
            }
            ders.Dersler.Clear();
        }

        // Ders ve Sınıf Seçtikten Sonra Sınavı Başlat

        private void btnSinaviBaslat_Click(object sender, EventArgs e)
        {

            if (cmbDers.SelectedIndex != -1 && cmbSınıf.SelectedIndex != -1)
            {
                FrmSinav frmSınav = new FrmSinav();
                frmSınav.dersAd = cmbDers.Text;
                frmSınav.ders = cmbDers.SelectedIndex + 1;
                frmSınav.sinif = Convert.ToInt32(cmbSınıf.Text);
                frmSınav.ogrenciID = Convert.ToInt32(txtogrID.Text);
                frmSınav.Show();
            }
            else
            {
                MessageBox.Show("Ders , Soru Sayisi ve Sınıf Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //
        //  İstatistik İşlemleri
        //

        private void btnGrafikOlustur_Click(object sender, EventArgs e)
        {
            Istatistik istatistik = new Istatistik();
            ogr.IstatistikGetir(istatistik, Convert.ToInt32(cmbIstatistikDers.SelectedIndex + 1), Convert.ToInt32(txtogrID.Text));
            foreach (Istatistik istatistiks in istatistik.IstatistiklerDogru)
            {
                chartControl1.Series["Doğru"].Points.AddPoint(istatistiks.Konu, istatistiks.Adet);
            }
            foreach (Istatistik istatistiks in istatistik.IstatistiklerYanlis)
            {
                chartControl1.Series["Yanlış"].Points.AddPoint(istatistiks.Konu, istatistiks.Adet);
            }

        }



        //
        //  Öğrenci Bilgi İşlemleri
        //


        // Öğrenci Bilgilerini Getir

        void OgrenciBilgiGetir()
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.KisiBilgiGetir(kullanici);
            txtAd.Text = lblAd.Text = ogrenci.Ad;
            txtogrID.Text = ogrenci.ID.ToString();
            txtSoyad.Text = lblSoyad.Text = ogrenci.Soyad;
            txtDogumTarihi.Text = ogrenci.DogumTarihi.ToString();
            picOgrAnaMenuResim.ImageLocation = picOgrUpdateResim.ImageLocation = txtResim.Text = ogrenci.Resim;
            if (ogrenci.Cinsiyet == Convert.ToBoolean(1))
            {
                txtCinsiyet.Text = "Erkek";
            }
            else
            {
                txtCinsiyet.Text = "Kadın";
            }
            txtSifre.Text = ogrenci.Sifre;
            mskTC.Text = ogrenci.TC;
            txtKullaniciAdi.Text = ogrenci.KullanıcıID;
        }

        // Öğrenci Bilgileri Güncelle

        void OgrenciBilgiGuncelle()
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ID = Convert.ToInt32(txtogrID.Text);
            ogrenci.Sifre = txtSifre.Text;
            ogrenci.Resim = txtResim.Text;
            ogrenci.KisiBilgiGuncelle(0);
            MessageBox.Show("Öğrenci Bilgileri Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSifreGoster_Click(object sender, EventArgs e)
        {
            if (txtSifre.UseSystemPasswordChar == false)
                txtSifre.UseSystemPasswordChar = true;
            else if (txtSifre.UseSystemPasswordChar == true)
                txtSifre.UseSystemPasswordChar = false;
        }

        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            OgrenciBilgiGuncelle();
            OgrenciBilgiGetir();
        }

        private void btnOgrResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();  
            picOgrUpdateResim.ImageLocation = openFileDialog1.FileName;  
            txtResim.Text = openFileDialog1.FileName;  
        }
    }
}
