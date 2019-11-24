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
    }
}
