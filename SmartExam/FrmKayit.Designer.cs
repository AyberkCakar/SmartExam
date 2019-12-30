namespace SmartExam
{
    partial class FrmKayit
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
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbOgretmen = new System.Windows.Forms.RadioButton();
            this.rdbOgrenci = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCinsiyet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.dtDogumTarihi = new DevExpress.XtraEditors.DateEdit();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mskTC
            // 
            this.mskTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.mskTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.mskTC.Location = new System.Drawing.Point(169, 285);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(210, 27);
            this.mskTC.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSifre.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.txtSifre.Location = new System.Drawing.Point(169, 433);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(210, 28);
            this.txtSifre.TabIndex = 7;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.txtKullaniciID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtKullaniciID.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.txtKullaniciID.Location = new System.Drawing.Point(169, 395);
            this.txtKullaniciID.Multiline = true;
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(210, 28);
            this.txtKullaniciID.TabIndex = 6;
            this.txtKullaniciID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKullaniciID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciID_KeyPress);
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSoyad.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.txtSoyad.Location = new System.Drawing.Point(169, 247);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(210, 28);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAd.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.txtAd.Location = new System.Drawing.Point(169, 210);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(210, 28);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.label8.Location = new System.Drawing.Point(96, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 127;
            this.label8.Text = "Soyad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.label7.Location = new System.Drawing.Point(129, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 21);
            this.label7.TabIndex = 126;
            this.label7.Text = "TC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.label6.Location = new System.Drawing.Point(63, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 21);
            this.label6.TabIndex = 125;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.label5.Location = new System.Drawing.Point(8, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 21);
            this.label5.TabIndex = 124;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.label4.Location = new System.Drawing.Point(96, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 123;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.label3.Location = new System.Drawing.Point(129, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 122;
            this.label3.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(179, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 57);
            this.label1.TabIndex = 120;
            this.label1.Text = "Register";
            // 
            // rdbOgretmen
            // 
            this.rdbOgretmen.AutoSize = true;
            this.rdbOgretmen.BackColor = System.Drawing.Color.Transparent;
            this.rdbOgretmen.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbOgretmen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.rdbOgretmen.Location = new System.Drawing.Point(263, 146);
            this.rdbOgretmen.Name = "rdbOgretmen";
            this.rdbOgretmen.Size = new System.Drawing.Size(116, 25);
            this.rdbOgretmen.TabIndex = 119;
            this.rdbOgretmen.Text = "Öğretmen";
            this.rdbOgretmen.UseVisualStyleBackColor = false;
            this.rdbOgretmen.CheckedChanged += new System.EventHandler(this.rdbOgretmen_CheckedChanged);
            // 
            // rdbOgrenci
            // 
            this.rdbOgrenci.AutoSize = true;
            this.rdbOgrenci.BackColor = System.Drawing.Color.Transparent;
            this.rdbOgrenci.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbOgrenci.Checked = true;
            this.rdbOgrenci.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbOgrenci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.rdbOgrenci.Location = new System.Drawing.Point(130, 146);
            this.rdbOgrenci.Name = "rdbOgrenci";
            this.rdbOgrenci.Size = new System.Drawing.Size(105, 25);
            this.rdbOgrenci.TabIndex = 118;
            this.rdbOgrenci.TabStop = true;
            this.rdbOgrenci.Text = "Öğrenci";
            this.rdbOgrenci.UseVisualStyleBackColor = false;
            this.rdbOgrenci.CheckedChanged += new System.EventHandler(this.rdbOgrenci_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(92, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 57);
            this.label2.TabIndex = 121;
            this.label2.Text = "_____________";
            // 
            // btnKaydet
            // 
            this.btnKaydet.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.btnKaydet.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.btnKaydet.AppearanceHovered.Options.UseBackColor = true;
            this.btnKaydet.AppearanceHovered.Options.UseBorderColor = true;
            this.btnKaydet.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.btnKaydet.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.btnKaydet.AppearancePressed.Options.UseBackColor = true;
            this.btnKaydet.AppearancePressed.Options.UseBorderColor = true;
            this.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnKaydet.Image = global::SmartExam.Properties.Resources.save;
            this.btnKaydet.Location = new System.Drawing.Point(100, 543);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(315, 50);
            this.btnKaydet.TabIndex = 136;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.btnCikis.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(75)))), ((int)(((byte)(77)))));
            this.btnCikis.AppearancePressed.Options.UseBackColor = true;
            this.btnCikis.AppearancePressed.Options.UseBorderColor = true;
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCikis.Image = global::SmartExam.Properties.Resources.c2;
            this.btnCikis.Location = new System.Drawing.Point(500, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(32, 52);
            this.btnCikis.TabIndex = 135;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Location = new System.Drawing.Point(169, 321);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.cmbCinsiyet.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbCinsiyet.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.cmbCinsiyet.Properties.Appearance.Options.UseBackColor = true;
            this.cmbCinsiyet.Properties.Appearance.Options.UseFont = true;
            this.cmbCinsiyet.Properties.Appearance.Options.UseForeColor = true;
            this.cmbCinsiyet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCinsiyet.Properties.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbCinsiyet.Size = new System.Drawing.Size(210, 28);
            this.cmbCinsiyet.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.label9.Location = new System.Drawing.Point(19, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 21);
            this.label9.TabIndex = 139;
            this.label9.Text = "Doğum Tarihi:";
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.EditValue = null;
            this.dtDogumTarihi.Location = new System.Drawing.Point(169, 361);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.dtDogumTarihi.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtDogumTarihi.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.dtDogumTarihi.Properties.Appearance.Options.UseBackColor = true;
            this.dtDogumTarihi.Properties.Appearance.Options.UseFont = true;
            this.dtDogumTarihi.Properties.Appearance.Options.UseForeColor = true;
            this.dtDogumTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDogumTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDogumTarihi.Size = new System.Drawing.Size(210, 28);
            this.dtDogumTarihi.TabIndex = 5;
            this.dtDogumTarihi.EditValueChanged += new System.EventHandler(this.dtDogumTarihi_EditValueChanged);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.lblTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.lblTelefon.Location = new System.Drawing.Point(74, 476);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(98, 21);
            this.lblTelefon.TabIndex = 141;
            this.lblTelefon.Text = "Telefon:";
            this.lblTelefon.Visible = false;
            // 
            // mskTelefon
            // 
            this.mskTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.mskTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.mskTelefon.Location = new System.Drawing.Point(170, 470);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(210, 27);
            this.mskTelefon.TabIndex = 8;
            this.mskTelefon.Visible = false;
            // 
            // FrmKayit
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(530, 678);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.dtDogumTarihi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciID);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbOgretmen);
            this.Controls.Add(this.rdbOgrenci);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKayit";
            this.Text = "FrmKayit";
            this.Load += new System.EventHandler(this.FrmKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTC;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbOgretmen;
        private System.Windows.Forms.RadioButton rdbOgrenci;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCinsiyet;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.DateEdit dtDogumTarihi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
    }
}