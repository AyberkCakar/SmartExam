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
        Ogrenci ogrenci = new Ogrenci();
        public string kullanici;
        bool _sinavOldumu;

        //
        //  Ana Menü İşlemleri
        //

        private void OgrenciScreen_Load(object sender, EventArgs e)
        {
            OgrenciBilgiGetir();
            gridSinavDoldur();
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
            ogrenci.SinavBilgileriniGetir(sinav, Convert.ToInt32(txtogrID.Text));
            DataTable tablo = new DataTable();
            tablo.Columns.Add("SinavID", typeof(int));
            tablo.Columns.Add("Ders", typeof(string));
            tablo.Columns.Add("Doğru", typeof(int));
            tablo.Columns.Add("Yanlış", typeof(int));
            tablo.Columns.Add("Boş", typeof(int));
            tablo.Columns.Add("Tarih", typeof(DateTime));
            foreach (Sinav sin in sinav.Sinavlar)
            {
                tablo.Rows.Add(sin.SinavID, sin.DersAD, sin.sinavDet.Dogru, sin.sinavDet.Yanliş, sin.sinavDet.Bos, sin.sinavDet.Tarih);
                gridSınav.DataSource = tablo;
                if(sin.sinavDet.Tarih == DateTime.Today)
                {
                    _sinavOldumu = true;
                }
                else
                {
                    _sinavOldumu = false;
                }
            }
            sinav.Sinavlar.Clear();
            gridSınavView.OptionsBehavior.Editable = false;
        }

        private void gridSınavView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridSınavView.GetDataRow(gridSınavView.FocusedRowHandle);
            txtSinavNo.Text = Convert.ToInt32(dataRow[0]).ToString();
            txtDers.Text = dataRow[1].ToString();
            txtSinavDogru.Text = Convert.ToInt32(dataRow[2]).ToString();
            txtSinavYanlis.Text = Convert.ToInt32(dataRow[3]).ToString();
            txtBos.Text = Convert.ToInt32(dataRow[4]).ToString();
            txtTarih.Text = Convert.ToDateTime(dataRow[5]).ToString();
        }

        private void btnSinaviBaslat_Click(object sender, EventArgs e)
        {
            FrmSinav frmSınav = new FrmSinav();
            frmSınav.dersAd = cmbDers.Text;
            frmSınav.ders = cmbDers.SelectedIndex + 1;
            frmSınav.ogrenciID = Convert.ToInt32(txtogrID.Text);    
            if(_sinavOldumu == false)
            {
                if (gridSınav.DataSource == null)
                {
                    // Bütün Konular
                    frmSınav.ogrenciDurum = false;
                    frmSınav.Show();
                }
                else
                {
                    // Algoritmalı Konular
                    frmSınav.ogrenciDurum = true;
                    frmSınav.Show();
                }
            }
            else
                MessageBox.Show("Bugün Sınav Oldunuz Yarın Tekrar Deneyiniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //
        //  İstatistik İşlemleri
        //

        // Toplam Doğru Yanlış İstatistiği

        private void btnDerslikGrafikOlustur_Click(object sender, EventArgs e)
        {
            Istatistik istatistik = new Istatistik();
            ogrenci.IstatistikGetir(istatistik, Convert.ToInt32(cmbDerslikIstatistik.SelectedIndex + 1), Convert.ToInt32(txtogrID.Text));
            foreach (Istatistik istatistiks in istatistik.IstatistiklerDogru)
            {
                chartControl1.Series["Doğru"].Points.AddPoint(istatistiks.Konu, istatistiks.Adet);
            }
            foreach (Istatistik istatistiks in istatistik.IstatistiklerYanlis)
            {
                chartControl1.Series["Yanlış"].Points.AddPoint(istatistiks.Konu, istatistiks.Adet);
            }
        }

        // Sınavlık İstatistik

        private void gridSınav_DoubleClick(object sender, EventArgs e)
        {
            FrmIstatistik frmIstatistik = new FrmIstatistik();
            frmIstatistik.skor = Convert.ToInt32(txtSinavDogru.Text) * 5;
            frmIstatistik.SinavID = Convert.ToInt32(txtSinavNo.Text);
            frmIstatistik.ogrenciID = Convert.ToInt32(txtogrID.Text);
            frmIstatistik.Show();
        }

        // Tarihsel Puanlı İstatistik

        void TarihselIstatistik()
        {
            for (int i = 0; i <= gridSınavView.RowCount - 1; i++)
            {
                gridSınavView.FocusedRowHandle = i;
                DataRow dataRow = gridSınavView.GetDataRow(gridSınavView.FocusedRowHandle);
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToDateTime(dataRow[5]), Convert.ToInt32(dataRow[2]) * 5);
            }
        }
        
        private void btnPuanlıkGrafikOlustur_Click(object sender, EventArgs e)
        {
            TarihselIstatistik();
        }


        //
        //  Öğrenci Bilgi İşlemleri
        //


        // Öğrenci Bilgilerini Getir

        void OgrenciBilgiGetir()
        {
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
            Sifrele sifre = new Sifrele();
            ogrenci.ID = Convert.ToInt32(txtogrID.Text);
            ogrenci.Sifre = sifre.SifreOlustur(txtSifre.Text);
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
