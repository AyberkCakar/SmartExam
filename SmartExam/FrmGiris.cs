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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        // Yeni Üyelik Ana İşlemler

        private void btnKayit_Click(object sender, EventArgs e)
        {
            FrmKayit frmKayit = new FrmKayit();
            frmKayit.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Txt'lerin Tıklanma Davranışları

        private void txtKullaniciID_Click(object sender, EventArgs e)
        {
            if (txtKullaniciID.Text == "Kullanıcı ID")
            {
                txtKullaniciID.Text = "";
            }
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Sifre";
            }
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Sifre")
            {
                txtSifre.Text = "";
            }
            if (txtKullaniciID.Text == "")
            {
                txtKullaniciID.Text = "Kullanıcı ID";
            }
        }

        // Giriş

        private void btnGiris_Click(object sender, EventArgs e)
        {
           
        }
    }
}
