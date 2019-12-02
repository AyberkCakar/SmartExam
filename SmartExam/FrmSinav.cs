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
    public partial class FrmSinav : Form
    {
        public FrmSinav()
        {
            InitializeComponent();
        }

        //
        //  Ana Tanımlar
        //

        Ogrenci ogr = new Ogrenci();
        SinavYap sinavYap = new SinavYap();
        Sinav sinav = new Sinav();
        public string dersAd;
        public int saniye = 59, dakika = 9;
        public int ders, sinif, ogrenciID;
        string[] SoruCevap = new string[11] { null, null, null, null, null, null, null, null, null, null, null };  // Sorunun Öğrenci Tarafından Verilen Cevabı Tutuluyor.

        // Soru Cevap Kontrolleri İçin TFunc
        
        private static bool durum;
        public Func<string, string, Boolean> funcSoruCevap = (Cevap, DogruCevap) =>
        {
            if (Cevap == DogruCevap)
            {
                durum = true;
            }
            else
                durum = false;
            return durum;

        };

        //
        // Ana Menü İşlemleri
        //

        private void FrmSinav_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = false;
            lblSure.Text = "9:59";
            timer1.Start();
            lblDers.Text = dersAd;
            gridSoruDoldur();
            SoruIleriGeri(0);
        }

        //
        // Sınav İşlemleri
        //

        void gridSoruDoldur()
        {
            if (ogr.SinavinSorulariniGetir(sinavYap, ders, sinif, ogrenciID) == 10)
            {
                DataTable tablo = new DataTable();
                tablo.Columns.Add("Soru No", typeof(int));
                tablo.Columns.Add("SoruID", typeof(int));
                tablo.Columns.Add("SoruIcerik", typeof(string));
                tablo.Columns.Add("ŞıkA", typeof(string));
                tablo.Columns.Add("ŞıkB", typeof(string));
                tablo.Columns.Add("ŞıkC", typeof(string));
                tablo.Columns.Add("ŞıkD", typeof(string));
                tablo.Columns.Add("ŞıkE", typeof(string));
                tablo.Columns.Add("Cevap", typeof(string));
                tablo.Columns.Add("Resim", typeof(string));
                tablo.Columns.Add("KonuID", typeof(int));
                int SoruNo = 0;
                foreach (SinavYap sin in sinavYap.sinavYaps)
                {
                    SoruNo++;
                    tablo.Rows.Add(SoruNo, sin.SoruID, sin.SoruIcerik, sin.ACevabi, sin.BCevabi, sin.CCevabi, sin.DCevabi, sin.ECevabi, sin.Cevap, sin.Resim, sin.KonuID);
                    gridControl1.DataSource = tablo;
                }
                gridView1.OptionsBehavior.Editable = false;
            }
            else
            {
                this.Close();
                MessageBox.Show("Yeterli Soru Yok", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bir Sonraki Soruyu Getir

        int index = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(index != 9)
            {
                index++;
                SoruIleriGeri(index);
                btnBack.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }
        }

        // Bir Önceki Soruyu Getir

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (index == 0)
            { 
                btnBack.Enabled = false;
            }
            else
            {
                index--;
                SoruIleriGeri(index);
                btnNext.Enabled = true;
            }
        }

        void SoruIleriGeri(int index)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.GetDataSourceRowIndex(index));
            lblSoruSayisi.Text = "Soru - " + Convert.ToInt32(dataRow[0]).ToString();
            lblSoruNo1.Text = Convert.ToInt32(dataRow[0]).ToString();
            lblSoruID.Text = dataRow[1].ToString();
            lblSoru.Text = dataRow[2].ToString();
            lblCevapA.Text = dataRow[3].ToString();
            lblCevapB.Text = dataRow[4].ToString();
            lblCevapC.Text = dataRow[5].ToString();
            lblCevapD.Text = dataRow[6].ToString();
            lblCevapE.Text = dataRow[7].ToString();
            lblSoruCevap.Text = dataRow[8].ToString();
            pictureBox1.ImageLocation = dataRow[9].ToString(); 
            if (SoruCevap[Convert.ToInt16(dataRow[0])] == "A")     // Soruya Cevap Verdiysem, Cevap Verdiğim Şıkkı Yeşil Yap.
            {                                                     
                butunButonlariBoya();
                btnA.BackColor = Color.LightGreen;
            }
            else if (SoruCevap[Convert.ToInt16(dataRow[0])] == "B")
            {
                butunButonlariBoya();
                btnB.BackColor = Color.LightGreen;
            }
            else if (SoruCevap[Convert.ToInt16(dataRow[0])] == "C")
            {
                butunButonlariBoya();
                btnC.BackColor = Color.LightGreen;
            }
            else if (SoruCevap[Convert.ToInt16(dataRow[0])] == "D")
            {
                butunButonlariBoya();
                btnD.BackColor = Color.LightGreen;
            }
            else if (SoruCevap[Convert.ToInt16(dataRow[0])] == "E")
            {
                butunButonlariBoya();
                btnE.BackColor = Color.LightGreen;
            }
            else
            {
                butunButonlariBoya();
            }
        }

        void butunButonlariBoya()             // Soru Geçişlerinde Buton Renkleri Aynı Kalmaması İçin Önce Bütün Butonları Orjinal Rengine Getir.
        {
            btnA.BackColor = Color.FromArgb(128, 255, 255);
            btnB.BackColor = Color.FromArgb(128, 255, 255);
            btnC.BackColor = Color.FromArgb(128, 255, 255);
            btnD.BackColor = Color.FromArgb(128, 255, 255);
            btnE.BackColor = Color.FromArgb(128, 255, 255);
        }

        // Soru Cevaplama

        private void btnA_Click(object sender, EventArgs e)
        {
            butunButonlariBoya();
            SoruCevap[Convert.ToInt32(lblSoruNo1.Text)] = "A";
            btnA.BackColor = Color.LightGreen;

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            butunButonlariBoya();
            SoruCevap[Convert.ToInt32(lblSoruNo1.Text)] = "B";
            btnB.BackColor = Color.LightGreen;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            butunButonlariBoya();
            SoruCevap[Convert.ToInt32(lblSoruNo1.Text)] = "C";
            btnC.BackColor = Color.LightGreen;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            butunButonlariBoya();
            SoruCevap[Convert.ToInt32(lblSoruNo1.Text)] = "D";
            btnD.BackColor = Color.LightGreen;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            butunButonlariBoya();
            SoruCevap[Convert.ToInt32(lblSoruNo1.Text)] = "E";
            btnE.BackColor = Color.LightGreen;
        }

        // Timer İşlemleri

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            if (saniye == 0)
            {
                if (saniye == 0 && dakika == 0)
                {
                    timer1.Enabled = true;
                    timer1.Stop();
                    btnBitir.Enabled = false;
                    MessageBox.Show("Sınav Bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dakika--;
                    saniye = 59;
                }
            }
            lblSure.Text = dakika.ToString() + ":" + saniye.ToString();
        }



        // Sınav Bitirme İşlemleri

        private void btnBitir_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Sınavı Bitirmek İstediğine Emin Misin?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("Sınav Bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Enabled = false;
                btnBitir.Enabled = false;
                bitirFunc();

                int i =0,dogru=0,yanlis=0,bos=0;

                foreach (SinavYap sin in sinavYap.sinavYaps)  // Doğru ,Yanlış , Noş Sayısını Hesapla, Doğru ise Doğru İşaretleyip Listeye Ekle
                {                                                // Yanlış veya Boş ise Yanlış İşartleyip Listeye Ekle
                    i++;
                    if (SoruCevap[i] == null)
                    {
                        bos++;
                        sin.dogruYanlıs = false;
                        sinavYap.sinavKaydet.Add(sin);
                    }
                    else if (funcSoruCevap( SoruCevap[i], sin.Cevap) == true)
                    {
                        dogru++;
                        sin.dogruYanlıs = true;
                        sinavYap.sinavKaydet.Add(sin);
                    }
                    else if (funcSoruCevap( SoruCevap[i], sin.Cevap) == false)
                    {
                        yanlis++;
                        sin.dogruYanlıs = false;
                        sinavYap.sinavKaydet.Add(sin);
                    }   
                    else
                    {
                        continue;           
                    }
                    
                }

                sinav.DersID = ders;
                sinav.Sinif = sinif;

                ogr.SinavCozulenSoruKaydet(sinavYap,ogrenciID);

                ogr.CozulenSinavKaydet(sinav,dogru,yanlis,bos,ogrenciID);

                lblYanlis.Text = yanlis.ToString();
                lblDogru.Text = dogru.ToString();
                lblBos.Text=bos.ToString();
                pnlDogruYanlis.Visible = true;

                sinavYap.sinavYaps.Clear();
                sinavYap.sinavKaydet.Clear();
            }
            else
            {

            }
        }
        
        
        void bitirFunc()                    // Bitir Dediğimde Sınavın Cevap Şıklarını Kilitle
        {                                   //  Sorunun Cevaplarını Kontrol Edebilmek İçin Cevapları Görünür Yap
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            lblCevap.Visible = true;
            lblSoruCevap.Visible = true;
        }

        private void btnCikis_Click(object sender, EventArgs e)  // Sınavdan Çıkmak İçin Bitirmek (Sonlandırmak) Gerekir
        {
            if (btnBitir.Enabled == false)
            {
                this.Close();
            }
            else
                MessageBox.Show("Sınavı Bitiriniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }
    }
}
