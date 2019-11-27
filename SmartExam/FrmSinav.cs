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
        Ogrenci ogr = new Ogrenci();
        SinavYap sinav = new SinavYap();
        Sinav exam = new Sinav();
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
                foreach (SinavYap sin in sinav.sinavYaps)
                {
                    i++;
                    if(SoruCevap[i] == null)
                    {
                        bos++;
                        sin.dogruYanlıs = false;
                        sinav.sinavKaydet.Add(sin);
                    }
                    else if (fonk(i, SoruCevap[i], sin.Cevap) == true)
                    {
                        dogru++;
                        sin.dogruYanlıs = true;
                        sinav.sinavKaydet.Add(sin);
                    }
                    else if (fonk(i, SoruCevap[i], sin.Cevap) == false)
                    {
                        yanlis++;
                        sin.dogruYanlıs = false;
                        sinav.sinavKaydet.Add(sin);
                    }   
                    else
                    {
                        continue;           
                    }
                }
                exam.DersID = ders;
                exam.Sinif = sinif;
                ogr.SinavCozulenSoruKaydet(sinav);
                ogr.SinavCozulenKaydet(exam,dogru,yanlis,bos);
                lblYanlis.Text = yanlis.ToString();
                lblDogru.Text = dogru.ToString();
                lblBos.Text=bos.ToString();
                pnlDogruYanlis.Visible = true;
                sinav.sinavYaps.Clear();
                sinav.sinavKaydet.Clear();
            }
            else
            {

            }
        }
        string[] SoruCevap = new string[11] {null,null,null,null,null,null,null,null,null,null,null};
        
        void bitirFunc()
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            lblCevap.Visible = true;
            lblSoruCevap.Visible = true;
        }
        private static bool durum;
        public Func<int, string, string, Boolean> fonk = (soruID, Cevap, DogruCevap) =>
        {
            if (Cevap == DogruCevap)
            {
                durum = true;
            }
            else
                durum = false;
            return durum;

        };
        public string dersAd;
        int saniye=59, dakika = 9;
        public int ders, sinif;
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

        private void FrmSinav_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = false;
            lblSure.Text = "9:59";
            timer1.Start();
            lblDers.Text = dersAd;
            gridDoldur();
        }

        void gridDoldur()
        {
            if (ogr.SinavSoruBilgileriniGetir(sinav, ders, sinif) == 10)
            {
                DataTable tablo = new DataTable();
                tablo.Columns.Add("Soru No", typeof(int));
                tablo.Columns.Add("SoruID", typeof(int));
                tablo.Columns.Add("SoruIcerik", typeof(string));
                tablo.Columns.Add("CevapA", typeof(string));
                tablo.Columns.Add("CevapB", typeof(string));
                tablo.Columns.Add("CevapC", typeof(string));
                tablo.Columns.Add("CevapD", typeof(string));
                tablo.Columns.Add("CevapE", typeof(string));
                tablo.Columns.Add("Cevap", typeof(string));
                tablo.Columns.Add("Resim", typeof(string));
                tablo.Columns.Add("KonuID", typeof(int));
                int SoruNo = 0;
                foreach (SinavYap sin in sinav.sinavYaps)
                {
                    SoruNo++;
                    tablo.Rows.Add(SoruNo, sin.SoruID, sin.SoruIcerik, sin.ACevabi, sin.BCevabi, sin.CCevabi, sin.DCevabi, sin.ECevabi, sin.Cevap, sin.Resim,sin.KonuID);
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

        private void btnA_Click(object sender, EventArgs e)
        {
            butunButonlar();
            SoruCevap[Convert.ToInt32(lblSoruNo1.Text)] = "A";
            btnA.BackColor = Color.LightGreen;

        }

        private void btnE_Click(object sender, EventArgs e)
        {
            butunButonlar();
            SoruCevap[Convert.ToInt32(lblSoruNo1.Text)] = "E";
            btnE.BackColor = Color.LightGreen;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            butunButonlar();
            SoruCevap[Convert.ToInt32(lblSoruNo1.Text)] = "B";
            btnB.BackColor = Color.LightGreen;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            butunButonlar();
            SoruCevap[Convert.ToInt32(lblSoruNo1.Text)] = "C";
            btnC.BackColor = Color.LightGreen;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            butunButonlar();
            SoruCevap[Convert.ToInt32(lblSoruNo1.Text)] = "D";
            btnD.BackColor = Color.LightGreen;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (btnBitir.Enabled == false)
            {
                this.Close();
            }
            else
                MessageBox.Show("Sınavı Bitiriniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        void butunButonlar()
        {
            btnA.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            btnB.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            btnC.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            btnD.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            btnE.BackColor = System.Drawing.Color.FromArgb(128,255,255);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            lblSoruSayisi.Text = "Soru - "+ Convert.ToInt32(dataRow[0]).ToString();
            lblSoruNo1.Text = Convert.ToInt32(dataRow[0]).ToString();
            lblSoruID.Text = dataRow[1].ToString();
            lblSoru.Text = dataRow[2].ToString();
            lblCevapA.Text = dataRow[3].ToString();
            lblCevapB.Text = dataRow[4].ToString();
            lblCevapC.Text = dataRow[5].ToString();
            lblCevapD.Text = dataRow[6].ToString();
            lblCevapE.Text= dataRow[7].ToString();
            lblSoruCevap.Text = dataRow[8].ToString();
            pictureBox1.ImageLocation = dataRow[9].ToString();
            if (SoruCevap[Convert.ToInt16(dataRow[0])] == "A")
            {
                butunButonlar();
                btnA.BackColor = Color.LightGreen;
            }
            else if (SoruCevap[Convert.ToInt16(dataRow[0])] == "B")
            {
                butunButonlar();
                btnB.BackColor = Color.LightGreen;
            }
            else if (SoruCevap[Convert.ToInt16(dataRow[0])] == "C")
            {
                butunButonlar();
                btnC.BackColor = Color.LightGreen;
            }
            else if (SoruCevap[Convert.ToInt16(dataRow[0])] == "D")
            {
                butunButonlar();
                btnD.BackColor = Color.LightGreen;
            }
            else if (SoruCevap[Convert.ToInt16(dataRow[0])] == "E")
            {
                butunButonlar();
                btnE.BackColor = Color.LightGreen;
            }
            else
            {
                butunButonlar();
            }
        }
    }
}
