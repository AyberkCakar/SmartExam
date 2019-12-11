namespace SmartExam
{
    partial class FrmGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbOgretmen = new System.Windows.Forms.RadioButton();
            this.rdbOgrenci = new System.Windows.Forms.RadioButton();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnKayit = new DevExpress.XtraEditors.SimpleButton();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SmartExam.Properties.Resources.DhUkMUoUcAUlwRr1;
            this.panel2.Controls.Add(this.btnCikis);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 730);
            this.panel2.TabIndex = 1;
            // 
            // btnCikis
            // 
            this.btnCikis.AllowFocus = false;
            this.btnCikis.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnCikis.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnCikis.AppearancePressed.Options.UseBackColor = true;
            this.btnCikis.AppearancePressed.Options.UseBorderColor = true;
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCikis.Image = global::SmartExam.Properties.Resources.c2;
            this.btnCikis.Location = new System.Drawing.Point(992, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(32, 52);
            this.btnCikis.TabIndex = 94;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdbOgretmen);
            this.panel1.Controls.Add(this.rdbOgrenci);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Controls.Add(this.btnKayit);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(546, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 531);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(164, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 57);
            this.label1.TabIndex = 109;
            this.label1.Text = "Login";
            // 
            // rdbOgretmen
            // 
            this.rdbOgretmen.AutoSize = true;
            this.rdbOgretmen.BackColor = System.Drawing.Color.Transparent;
            this.rdbOgretmen.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbOgretmen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.rdbOgretmen.Location = new System.Drawing.Point(240, 136);
            this.rdbOgretmen.Name = "rdbOgretmen";
            this.rdbOgretmen.Size = new System.Drawing.Size(116, 25);
            this.rdbOgretmen.TabIndex = 107;
            this.rdbOgretmen.Text = "Öğretmen";
            this.rdbOgretmen.UseVisualStyleBackColor = false;
            // 
            // rdbOgrenci
            // 
            this.rdbOgrenci.AutoSize = true;
            this.rdbOgrenci.BackColor = System.Drawing.Color.Transparent;
            this.rdbOgrenci.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbOgrenci.Checked = true;
            this.rdbOgrenci.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbOgrenci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.rdbOgrenci.Location = new System.Drawing.Point(94, 136);
            this.rdbOgrenci.Name = "rdbOgrenci";
            this.rdbOgrenci.Size = new System.Drawing.Size(105, 25);
            this.rdbOgrenci.TabIndex = 106;
            this.rdbOgrenci.TabStop = true;
            this.rdbOgrenci.Text = "Öğrenci";
            this.rdbOgrenci.UseVisualStyleBackColor = false;
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnGiris.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnGiris.Appearance.Options.UseBorderColor = true;
            this.btnGiris.AppearanceDisabled.BackColor2 = System.Drawing.Color.Silver;
            this.btnGiris.AppearanceDisabled.BorderColor = System.Drawing.Color.Silver;
            this.btnGiris.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnGiris.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.btnGiris.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.btnGiris.AppearanceHovered.Options.UseBackColor = true;
            this.btnGiris.AppearanceHovered.Options.UseBorderColor = true;
            this.btnGiris.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.btnGiris.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.btnGiris.AppearancePressed.Options.UseBackColor = true;
            this.btnGiris.AppearancePressed.Options.UseBorderColor = true;
            this.btnGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnGiris.Image = global::SmartExam.Properties.Resources.login_thumb2222;
            this.btnGiris.Location = new System.Drawing.Point(67, 304);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(319, 52);
            this.btnGiris.TabIndex = 105;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnKayit.Image = global::SmartExam.Properties.Resources.login_22;
            this.btnKayit.Location = new System.Drawing.Point(65, 366);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(319, 52);
            this.btnKayit.TabIndex = 104;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSifre.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.txtSifre.Location = new System.Drawing.Point(78, 243);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSifre.Size = new System.Drawing.Size(301, 28);
            this.txtSifre.TabIndex = 103;
            this.txtSifre.Text = "Sifre";
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSifre.Click += new System.EventHandler(this.txtSifre_Click);
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(78, 201);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(301, 28);
            this.txtKullaniciAdi.TabIndex = 102;
            this.txtKullaniciAdi.Text = "Kullanıcı Adı";
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKullaniciAdi.Click += new System.EventHandler(this.txtKullaniciID_Click);
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(55, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 57);
            this.label2.TabIndex = 108;
            this.label2.Text = "_____________";
            // 
            // FrmGiris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 730);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiris";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbOgretmen;
        private System.Windows.Forms.RadioButton rdbOgrenci;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.SimpleButton btnKayit;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
    }
}