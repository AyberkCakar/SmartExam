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
    public partial class OgretmenScreen : Form
    {
        public OgretmenScreen()
        {
            InitializeComponent();
        }

        //
        //  Genel Tanımlar
        //

        Ogretmen ogrt = new Ogretmen();
        Soru soru = new Soru();
        Ders ders = new Ders();
        Konu konu = new Konu();
        public string kullanici;

        //
        //  Ana Menü İşlemleri
        //

        private void OgretmenScreen_Load(object sender, EventArgs e)
        {
            OgretmenBilgiGetir();
            soruGridDoldur();
            dersGridDoldur();
            konuGridDoldur();
        }

        private void btnSoru_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 0;
            soruGridDoldur();
        }

        private void btnDersKonu_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
            dersGridDoldur();
            konuGridDoldur();
        }

        private void btnBilgilerim_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 2;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //  Öğretmen Bilgileri İşlemleri
        //

        void OgretmenBilgiGetir()
        {
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.KisiBilgiGetir(kullanici);
            txtAd.Text = lblAd.Text = ogretmen.Ad;
            txtSoyad.Text = lblSoyad.Text = ogretmen.Soyad;
            txtOgretmenID.Text = ogretmen.ID.ToString();
            picOgrProfil.ImageLocation = picUpdateResim.ImageLocation = txtResim.Text = ogretmen.Resim;
            if (ogretmen.Cinsiyet == Convert.ToBoolean(1))
            {
                txtCinsiyet.Text = "Erkek";
            }
            else
            {
                txtCinsiyet.Text = "Kadın";
            }
            cmbBrans.Text = lblBrans.Text = ogretmen.Brans.ToString();
            txtSifre.Text = ogretmen.Sifre;
            mskTC.Text = ogretmen.TC;
            txtKullaniciAdi.Text = ogretmen.KullanıcıID;
            mskTelefon.Text = ogretmen.Telefon;
        }

        // Öğretmen Bilgi Cüncelleme

        void OgretmenBilgiGuncelle()
        {
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.ID = Convert.ToInt32(txtOgretmenID.Text);
            ogretmen.Sifre = txtSifre.Text;
            ogretmen.Resim = txtResim.Text;
            ogretmen.Telefon = mskTelefon.Text;
            ogretmen.KisiBilgiGuncelle(Convert.ToInt32(cmbBrans.SelectedIndex + 1));
            MessageBox.Show("Öğretmen Bilgileri Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOgretmenGuncelle_Click(object sender, EventArgs e)
        {
            OgretmenBilgiGuncelle();
            OgretmenBilgiGetir();
        }

        private void btnSifreGoster_Click(object sender, EventArgs e)
        {
            if (txtSifre.UseSystemPasswordChar == false)
                txtSifre.UseSystemPasswordChar = true;
            else if (txtSifre.UseSystemPasswordChar == true)
                txtSifre.UseSystemPasswordChar = false;
        }

        private void btnOgrtResim_Click(object sender, EventArgs e)
        {
            openOgretmenResim.ShowDialog();
            txtResim.Text = openOgretmenResim.FileName;
            picUpdateResim.ImageLocation = openOgretmenResim.FileName;
        }


        //
        //  Soru İşlemleri
        //

        void soruGridDoldur()
        {
            soru.TumSorular();
            DataTable soruTable = new DataTable();
            soruTable.Columns.Add("SoruID", typeof(int));
            soruTable.Columns.Add("Soru", typeof(string));
            soruTable.Columns.Add("A Cevabı", typeof(string));
            soruTable.Columns.Add("B Cevabı", typeof(string));
            soruTable.Columns.Add("C Cevabı", typeof(string));
            soruTable.Columns.Add("D Cevabı", typeof(string));
            soruTable.Columns.Add("E Cevabı", typeof(string));
            soruTable.Columns.Add("Cevap", typeof(string));
            soruTable.Columns.Add("Resim", typeof(string));
            soruTable.Columns.Add("Sınıf", typeof(int));
            soruTable.Columns.Add("Ders", typeof(string));
            soruTable.Columns.Add("Konu", typeof(string));
            foreach (Soru question in soru.Sorular)
            {
                soruTable.Rows.Add(question.SoruID, question.SoruIcerik, question.ACevabi, question.BCevabi, question.CCevabi, question.DCevabi, question.ECevabi, question.Cevap, question.Resim, question.Sinif, question.Ders, question.Konu);
                gridSoru.DataSource = soruTable;
            }
            soru.Sorular.Clear();
        }

        private void gridSoruView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow soruDataRow = gridSoruView1.GetDataRow(gridSoruView1.FocusedRowHandle);
            txtSoruNo.Text = soruDataRow[0].ToString();
            rchSoru.Text = soruDataRow[1].ToString();
            rchA.Text = soruDataRow[2].ToString();
            rchB.Text = soruDataRow[3].ToString();
            rchC.Text = soruDataRow[4].ToString();
            rchD.Text = soruDataRow[5].ToString();
            rchE.Text = soruDataRow[6].ToString();
            cmbCevap.Text = soruDataRow[7].ToString();
            txtSoruResim.Text = soruDataRow[8].ToString();
            cmbSoruSınıf.Text = soruDataRow[9].ToString(); ;
            cmbSoruDers.Text = soruDataRow[10].ToString(); ;
            cmbSoruKonu.Text = soruDataRow[11].ToString(); ;
        }

        void SoruBilgiTemizle()
        {
            txtSoruNo.Text = "";
            txtSoruResim.Text = "";
            rchA.Text = "";
            rchB.Text = "";
            rchC.Text = "";
            rchD.Text = "";
            rchE.Text = "";
            rchSoru.Text = "";
            cmbCevap.SelectedIndex = -1;
            cmbSoruKonu.SelectedIndex = -1;
            cmbSoruSınıf.SelectedIndex = -1;
            cmbSoruDers.SelectedIndex = -1;
        }

        private void btnSoruTemizle_Click(object sender, EventArgs e)
        {
            SoruBilgiTemizle();
        }

        private void btnSoruResim_Click(object sender, EventArgs e)
        {
            openSoruResim.ShowDialog();
            txtSoruResim.Text = openSoruResim.FileName;
        }

        // Seçili Dersin Konusunu Getir

        private void cmbSoruDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ogrt.DersKonuGetir(konu, Convert.ToInt32(cmbSoruDers.SelectedIndex + 1)) != 0)
            {
                cmbSoruKonu.Properties.Items.Clear();
                foreach (Konu dersKonu in konu.DersKonusu)
                {
                    cmbSoruKonu.Properties.Items.Add(dersKonu.KonuAD);
                }
                cmbSoruKonu.SelectedIndex = 0;
                konu.DersKonusu.Clear();
            }
            else
            {
                cmbSoruKonu.Text = "Konu Yok.";
            }
        }

        // Soru Ekleme

        void soruEkle()
        {
            Soru question = new Soru();
            question.SoruIcerik = rchSoru.Text;
            question.ACevabi = rchA.Text;
            question.BCevabi = rchB.Text;
            question.CCevabi = rchC.Text;
            question.DCevabi = rchD.Text;
            question.ECevabi = rchE.Text;
            question.Cevap = cmbCevap.Text;
            question.Resim = txtSoruResim.Text;
            question.Sinif = Convert.ToInt32(cmbSoruSınıf.Text);
            ogrt.SoruEkle(question, Convert.ToInt32(cmbSoruDers.SelectedIndex + 1), Convert.ToInt32(cmbSoruKonu.SelectedIndex + 1), Convert.ToInt32(ogrt.ID));
        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            if (txtSoruNo.Text == "")
            {
                soruEkle();
                MessageBox.Show("Soru Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SoruBilgiTemizle();
                soruGridDoldur();
            }
            else
            {
                MessageBox.Show("Soru Bilgileriniz Temizleniyor. Tekrar Deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SoruBilgiTemizle();
            }
        }

        // Soru Güncelleme

        void soruGuncelle()
        {
            Soru question = new Soru();
            question.SoruID = Convert.ToInt32(txtSoruNo.Text);
            question.SoruIcerik = rchSoru.Text;
            question.ACevabi = rchA.Text;
            question.BCevabi = rchB.Text;
            question.CCevabi = rchC.Text;
            question.DCevabi = rchD.Text;
            question.ECevabi = rchE.Text;
            question.Cevap = cmbCevap.Text;
            question.Resim = txtSoruResim.Text;
            question.Sinif = Convert.ToInt32(cmbSoruSınıf.Text);
            ogrt.SoruGuncelle(question, Convert.ToInt32(cmbSoruDers.SelectedIndex + 1), Convert.ToInt32(cmbSoruKonu.SelectedIndex + 1));
        }

        private void btnSoruGuncelle_Click(object sender, EventArgs e)
        {
            if (txtSoruNo.Text != "")
            {
                if (rchA.Text != "" && rchB.Text != "" && rchC.Text != "" && rchD.Text != "" && rchE.Text != "" && rchSoru.Text != "" && cmbCevap.Text != "" && cmbSoruDers.Text != "" && cmbSoruKonu.Text != "" && cmbSoruSınıf.Text != "")
                {
                    soruGuncelle();
                    MessageBox.Show("Soru Guncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SoruBilgiTemizle();
                    soruGridDoldur();
                }
                else
                {
                    MessageBox.Show("Boş Alanları Doldurun Ve Tekrar Deneyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Soru Seçiniz. Tekrar Deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Soru Silme 

        void soruSil()
        {
            Soru question = new Soru();
            question.SoruID = Convert.ToInt32(txtSoruNo.Text);
            ogrt.SoruSil(question);
        }

        private void btnSoruSil_Click(object sender, EventArgs e)
        {
            if (txtSoruNo.Text != "")
            {
                soruSil();
                MessageBox.Show("Soru Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SoruBilgiTemizle();
                soruGridDoldur();
            }
            else
            {
                MessageBox.Show("Soru Seçiniz. Tekrar Deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //
        //  Ders İşlemleri
        //

        void dersGridDoldur()
        {
            ders.TumDersler();
            DataTable dersTable = new DataTable();
            dersTable.Columns.Add("DersID", typeof(int));
            dersTable.Columns.Add("Ders", typeof(string));
            cmbSoruDers.Properties.Items.Clear();
            cmbKonuDers.Properties.Items.Clear();
            cmbBrans.Properties.Items.Clear();
            foreach (Ders lesson in ders.Dersler)
            {
                cmbBrans.Properties.Items.Add(lesson.DersAD);
                cmbKonuDers.Properties.Items.Add(lesson.DersAD);
                cmbSoruDers.Properties.Items.Add(lesson.DersAD);
                dersTable.Rows.Add(lesson.DersID, lesson.DersAD);
                gridDers.DataSource = dersTable;
            }
            ders.Dersler.Clear();
        }

        private void gridDersView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dersDataRow = gridDersView2.GetDataRow(gridDersView2.FocusedRowHandle);
            txtDersNo.Text = dersDataRow[0].ToString();
            txtDersAd.Text = dersDataRow[1].ToString();
        }

        void DersTemizle()
        {
            txtDersAd.Text = "";
            txtDersNo.Text = "";
        }

        private void btnDersTemizle_Click(object sender, EventArgs e)
        {
            DersTemizle();
        }

        // Ders Ekleme

        void dersEkle()
        {
            Ders lesson = new Ders();
            lesson.DersAD = txtDersAd.Text;
            ogrt.DersEkle(lesson);
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            if (txtDersNo.Text == "")
            {
                if (txtDersAd.Text != "")
                {
                    dersEkle();
                    MessageBox.Show("Ders Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dersGridDoldur();
                    DersTemizle();
                }
                else
                    MessageBox.Show("Ders Bilgilerini Giriniz. Tekrar Deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ders Bilgileriniz Temizleniyor. Tekrar Deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DersTemizle();
            }
        }

        // Ders Güncelleme

        void dersGuncelle()
        {
            Ders lesson = new Ders();
            lesson.DersID = Convert.ToInt16(txtDersNo.Text);
            lesson.DersAD = txtDersAd.Text;
            ogrt.DersGuncelle(lesson);
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            if (txtDersNo.Text != "")
            {
                dersGuncelle();
                MessageBox.Show("Ders Guncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dersGridDoldur();
                DersTemizle();
            }
            else
                MessageBox.Show("Ders Seçiniz. Tekrar Deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //
        //  Konu İşlemleri
        //


        void konuGridDoldur()
        {
            konu.TumKonular();
            DataTable konuTable = new DataTable();
            konuTable.Columns.Add("KonuID", typeof(int));
            konuTable.Columns.Add("KonuAD", typeof(string));
            konuTable.Columns.Add("Ders", typeof(string));
            foreach (Konu topic in konu.Konular)
            {
                konuTable.Rows.Add(topic.KonuID, topic.KonuAD, topic.DersAD);
                gridKonu.DataSource = konuTable;
            }
            konu.Konular.Clear();
        }
        private void gridKonuView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow konuDataRow = gridKonuView3.GetDataRow(gridKonuView3.FocusedRowHandle);
            txtKonuNo.Text = konuDataRow[0].ToString();
            txtKonu.Text = konuDataRow[1].ToString();
            cmbKonuDers.Text = konuDataRow[2].ToString();
        }

        void KonuTemizle()
        {
            txtKonu.Text = "";
            txtKonuNo.Text = "";
            cmbKonuDers.SelectedIndex = -1;
        }

        private void btnKonuTemizle_Click(object sender, EventArgs e)
        {
            KonuTemizle();
        }

        // Konu Ekleme 

        void konuEkle()
        {
            Konu sub = new Konu();
            sub.KonuAD = txtKonu.Text;
            ogrt.KonuEkle(sub, Convert.ToInt32(cmbKonuDers.SelectedIndex + 1));
        }

        private void btnKomuEkle_Click(object sender, EventArgs e)
        {
            if (txtKonuNo.Text == "")
            {
                if (txtKonu.Text != "" && cmbKonuDers.Text != "")
                {
                    konuEkle();
                    MessageBox.Show("Konu Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    konuGridDoldur();
                    KonuTemizle();
                }
                else
                    MessageBox.Show("Konu Seçiniz. Tekrar Deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Konu Bilgileriniz Temizleniyor. Tekrar Deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KonuTemizle();
            }
        }

        // Konu Guncelleme

        void konuGuncelle()
        {
            Konu sub = new Konu();
            sub.KonuID = Convert.ToInt32(txtKonuNo.Text);
            sub.KonuAD = txtKonu.Text;
            ogrt.KonuGuncelle(sub, Convert.ToInt32(cmbKonuDers.SelectedIndex + 1));
        }

        private void btnKonuGuncelle_Click(object sender, EventArgs e)
        {
            if (txtKonuNo.Text != "")
            {
                konuGuncelle();
                MessageBox.Show("Konu Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                konuGridDoldur();
                KonuTemizle();
            }
            else
                MessageBox.Show("Konu Seçiniz. Tekrar Deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
