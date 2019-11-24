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

        private void btnBitir_Click(object sender, EventArgs e)
        {
            OgrenciScreen ogrenciScreen = new OgrenciScreen();
            MessageBox.Show("Sınav Bitti");
            ogrenciScreen.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}
