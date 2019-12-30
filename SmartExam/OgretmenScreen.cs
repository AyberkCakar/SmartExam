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

        Ogretmen ogretmen = new Ogretmen();
        Soru soru = new Soru();
        Konu konu = new Konu();
        public string kullanici;

        TFuncKontrol FuncKontrol = new TFuncKontrol();
       
        //
        //  Ana Menü İşlemleri
        //

        private void OgretmenScreen_Load(object sender, EventArgs e)
        {
            OgretmenBilgiGetir();
            soruGridDoldur();
        }

        private void btnSoru_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 0;
            soruGridDoldur();
        }

        private void btnDersKonu_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
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
            txtSifre.Text = ogretmen.Sifre;
            mskTC.Text = ogretmen.TC;
            txtKullaniciAdi.Text = ogretmen.KullanıcıID;
            mskTelefon.Text = ogretmen.Telefon;
        }

        // Öğretmen Bilgi Güncelleme

        void OgretmenBilgiGuncelle()
        {
            Sifrele sifre = new Sifrele();
            ogretmen.ID = Convert.ToInt32(txtOgretmenID.Text);
            ogretmen.Sifre = sifre.SifreOlustur(txtSifre.Text);
            ogretmen.Resim = txtResim.Text;
            ogretmen.Telefon = mskTelefon.Text;
            ogretmen.KisiBilgiGuncelle(0);
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
            soruTable.Columns.Add("Cevap", typeof(string));
            soruTable.Columns.Add("Resim", typeof(string));
            soruTable.Columns.Add("Ders", typeof(string));
            soruTable.Columns.Add("Konu", typeof(string));
            foreach (Soru question in soru.Sorular)
            {
                soruTable.Rows.Add(question.SoruID, question.SoruIcerik, question.ACevabi, question.BCevabi, question.CCevabi, question.DCevabi, question.Cevap, question.Resim,  question.Ders, question.Konu);
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
            cmbCevap.Text = soruDataRow[6].ToString();
            txtSoruResim.Text = soruDataRow[7].ToString();
            cmbSoruDers.Text = soruDataRow[8].ToString(); ;
            cmbSoruKonu.Text = soruDataRow[9].ToString(); ;
        }

        void SoruBilgiTemizle()
        {
            txtSoruNo.Text = "";
            txtSoruResim.Text = "";
            rchA.Text = "";
            rchB.Text = "";
            rchC.Text = "";
            rchD.Text = "";
            rchSoru.Text = "";
            cmbCevap.SelectedIndex = -1;
            cmbSoruKonu.SelectedIndex = -1;
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

        // Soru Ekleme

        void soruEkle()
        {
            Soru question = new Soru();
            question.SoruIcerik = rchSoru.Text;
            question.ACevabi = rchA.Text;
            question.BCevabi = rchB.Text;
            question.CCevabi = rchC.Text;
            question.DCevabi = rchD.Text;
            question.Cevap = cmbCevap.Text;
            question.Resim = txtSoruResim.Text;

            string yasakKontrol = (FuncKontrol.formYasakKontrol(rchSoru.Text, rchA.Text, rchB.Text, rchC.Text, rchD.Text));
            string nullKontrol = FuncKontrol.formNullKontrol(rchSoru.Text, rchA.Text, rchB.Text, rchC.Text, rchD.Text, cmbCevap.Text, cmbSoruDers.Text, cmbSoruKonu.Text);

            if (yasakKontrol == "Başarılı" && nullKontrol == "Başarılı")
            {
                ogretmen.SoruEkle(question, Convert.ToInt32(cmbSoruDers.SelectedIndex + 1), Convert.ToInt32(cmbSoruKonu.SelectedIndex + 1), Convert.ToInt32(txtOgretmenID.Text));
                MessageBox.Show("Soru Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SoruBilgiTemizle();
            }
            else if(yasakKontrol == "Başarılı" && nullKontrol != "Başarılı")
            {
                MessageBox.Show(nullKontrol, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (yasakKontrol != "Başarılı" && nullKontrol == "Başarılı")
            {
                MessageBox.Show(yasakKontrol, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            if (txtSoruNo.Text == "")
            {
                soruEkle();
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
            question.Cevap = cmbCevap.Text;
            question.Resim = txtSoruResim.Text;
            ogretmen.SoruGuncelle(question, Convert.ToInt32(cmbSoruDers.SelectedIndex + 1), Convert.ToInt32(cmbSoruKonu.SelectedIndex + 1));
        }

        private void btnSoruGuncelle_Click(object sender, EventArgs e)
        {
            if (txtSoruNo.Text != "")
            {
                if (FuncKontrol.formYasakKontrol(rchSoru.Text, rchA.Text, rchB.Text, rchC.Text, rchD.Text) == "Başarılı" && FuncKontrol.formNullKontrol(rchSoru.Text, rchA.Text, rchB.Text, rchC.Text, rchD.Text, cmbCevap.Text, cmbSoruDers.Text, cmbSoruKonu.Text) == "Başarılı")
                {
                    soruGuncelle();
                    MessageBox.Show("Soru Guncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SoruBilgiTemizle();
                    soruGridDoldur();
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
            ogretmen.SoruSil(question);
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
    }
}

