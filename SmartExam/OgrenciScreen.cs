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
            FrmSinav frmSınav = new FrmSinav();
            frmSınav.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSinavlarim_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
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
        void GridDoldur()
        {
            Sinav sinav = new Sinav();
            sinav.SinavlariGetir();
            DataTable tablo = new DataTable();
            tablo.Columns.Add("SinavID", typeof(int));
            tablo.Columns.Add("Ders", typeof(string));
            tablo.Columns.Add("Sınıf", typeof(int));
            tablo.Columns.Add("Soru Sayısı", typeof(int));
            tablo.Columns.Add("Durum", typeof(string));
            tablo.Columns.Add("Doğru", typeof(int));
            tablo.Columns.Add("Yanlış", typeof(int));
            tablo.Columns.Add("Boşş", typeof(int));
            foreach (Sinav sin in sinav.Sinavlar)
            {
                tablo.Rows.Add(sin.SinavID,sin.Ders,sin.Sinif,sin.SoruSayisi,sin.sinavDet.Durum,sin.sinavDet.Dogru,sin.sinavDet.Yanliş,sin.sinavDet.Bos);
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
            txtSoruSayısı.Text = Convert.ToInt32(dataRow[3]).ToString();
            txtSinavDurum.Text = dataRow[4].ToString();
            txtSinavDogru.Text = Convert.ToInt32(dataRow[5]).ToString();
            txtSinavYanlis.Text= Convert.ToInt32(dataRow[6]).ToString();
            txtBos.Text= Convert.ToInt32(dataRow[7]).ToString();
        }

        private void OgrenciScreen_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
    }
}
