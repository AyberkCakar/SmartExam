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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        public int skor,SinavID,ogrenciID;

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            lblSkor.Text = skor.ToString();
            Istatistik istatistik = new Istatistik();
            istatistik.IstatistikGetir(istatistik, Convert.ToInt32(1), ogrenciID,SinavID);
            foreach (Istatistik istatistiks in istatistik.IstatistiklerDogru)
            {
                chartControl1.Series["Doğru"].Points.AddPoint(istatistiks.Konu, istatistiks.Adet);
            }
            foreach (Istatistik istatistiks in istatistik.IstatistiklerYanlis)
            {
                chartControl1.Series["Yanlış"].Points.AddPoint(istatistiks.Konu, istatistiks.Adet);
            }
            istatistik.IstatistiklerYanlis.Clear();
            istatistik.IstatistiklerDogru.Clear();
        }
    }
}
