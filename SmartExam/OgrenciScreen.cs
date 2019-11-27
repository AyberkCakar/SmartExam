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
    public partial class OgrenciScreen : Form
    {
        public OgrenciScreen()
        {
            InitializeComponent();
        }

        private void btnSinaviBaslat_Click(object sender, EventArgs e)
        {

            if (cmbDers.SelectedIndex != -1 && cmbSınıf.SelectedIndex != -1)
            {
                FrmSinav frmSınav = new FrmSinav();
                frmSınav.dersAd = cmbDers.Text;
                frmSınav.ders = cmbDers.SelectedIndex + 1;
                frmSınav.sinif = Convert.ToInt32(cmbSınıf.Text);
                frmSınav.Show();
            }
            else
            {
                MessageBox.Show("Ders , Soru Sayisi ve Sınıf Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
   
        private void btnSinavlarim_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
            GridDoldur();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 2;
        }

        private void btnBilgilerim_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 3;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmSinav frmSınav = new FrmSinav();
            if (Application.OpenForms[frmSınav.Name] == null)
            {
                this.Close();
            }
        }
        Ogrenci ogr = new Ogrenci();
        Sinav sinav = new Sinav();
        void GridDoldur()
        {
            ogr.SinavBilgileriniGetir(sinav);
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
                tablo.Rows.Add(sin.SinavID,sin.DersAD,sin.Sinif,sin.sinavDet.Dogru,sin.sinavDet.Yanliş,sin.sinavDet.Bos,sin.sinavDet.Tarih);
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
            txtSinavYanlis.Text= Convert.ToInt32(dataRow[4]).ToString();
            txtBos.Text= Convert.ToInt32(dataRow[5]).ToString();
            txtTarih.Text = Convert.ToDateTime(dataRow[6]).ToString();
        }
        
        private void OgrenciScreen_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

    }
}
