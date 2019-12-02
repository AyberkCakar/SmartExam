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
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void rdbOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            lblTelefon.Visible = false;
            mskTelefon.Visible = false;
        }

        private void rdbOgretmen_CheckedChanged(object sender, EventArgs e)
        {

            lblTelefon.Visible = true;
            mskTelefon.Visible = true; ;
            mskTelefon.Text = "";
        }

        private void FrmKayit_Load(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
        }
    }
}
