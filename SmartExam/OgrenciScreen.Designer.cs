namespace SmartExam
{
    partial class OgrenciScreen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblSinif = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnBilgilerim = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnSinavlarim = new System.Windows.Forms.Button();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbSınıf = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbSoruSayisi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbDers = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBos = new System.Windows.Forms.TextBox();
            this.btnSinaviBaslat = new System.Windows.Forms.Button();
            this.txtDers = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoruSayısı = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSinavNo = new System.Windows.Forms.TextBox();
            this.txtSinavDogru = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSinavYanlis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSinavDurum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnOgrenciGuncelle = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnSifreGoster = new System.Windows.Forms.Button();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtYAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSinavSinif = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSınıf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSoruSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDers.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblNo);
            this.panel1.Controls.Add(this.lblSoyad);
            this.panel1.Controls.Add(this.lblSinif);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 434);
            this.panel1.TabIndex = 124;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartExam.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(30, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNo.ForeColor = System.Drawing.Color.White;
            this.lblNo.Location = new System.Drawing.Point(32, 337);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(36, 21);
            this.lblNo.TabIndex = 120;
            this.lblNo.Text = "No:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblSoyad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.White;
            this.lblSoyad.Location = new System.Drawing.Point(8, 299);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(62, 21);
            this.lblSoyad.TabIndex = 120;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblSinif
            // 
            this.lblSinif.AutoSize = true;
            this.lblSinif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblSinif.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinif.ForeColor = System.Drawing.Color.White;
            this.lblSinif.Location = new System.Drawing.Point(26, 379);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(43, 21);
            this.lblSinif.TabIndex = 121;
            this.lblSinif.Text = "Sınıf:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblAd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.White;
            this.lblAd.Location = new System.Drawing.Point(32, 264);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(38, 21);
            this.lblAd.TabIndex = 118;
            this.lblAd.Text = "Ad:";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCikis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(2, 684);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(264, 80);
            this.btnCikis.TabIndex = 125;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnBilgilerim
            // 
            this.btnBilgilerim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnBilgilerim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBilgilerim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilgilerim.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgilerim.ForeColor = System.Drawing.Color.White;
            this.btnBilgilerim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilgilerim.Location = new System.Drawing.Point(3, 605);
            this.btnBilgilerim.Margin = new System.Windows.Forms.Padding(4);
            this.btnBilgilerim.Name = "btnBilgilerim";
            this.btnBilgilerim.Size = new System.Drawing.Size(264, 80);
            this.btnBilgilerim.TabIndex = 123;
            this.btnBilgilerim.Text = "Bilgilerim";
            this.btnBilgilerim.UseVisualStyleBackColor = false;
            this.btnBilgilerim.Click += new System.EventHandler(this.btnBilgilerim_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnIstatistik.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIstatistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIstatistik.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstatistik.ForeColor = System.Drawing.Color.White;
            this.btnIstatistik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIstatistik.Location = new System.Drawing.Point(3, 524);
            this.btnIstatistik.Margin = new System.Windows.Forms.Padding(4);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(264, 82);
            this.btnIstatistik.TabIndex = 122;
            this.btnIstatistik.Text = "İstatistiklerim";
            this.btnIstatistik.UseVisualStyleBackColor = false;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnSinavlarim
            // 
            this.btnSinavlarim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSinavlarim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSinavlarim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSinavlarim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSinavlarim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinavlarim.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavlarim.ForeColor = System.Drawing.Color.White;
            this.btnSinavlarim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinavlarim.Location = new System.Drawing.Point(3, 443);
            this.btnSinavlarim.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinavlarim.Name = "btnSinavlarim";
            this.btnSinavlarim.Size = new System.Drawing.Size(264, 82);
            this.btnSinavlarim.TabIndex = 121;
            this.btnSinavlarim.Text = "Sınavlarım";
            this.btnSinavlarim.UseVisualStyleBackColor = false;
            this.btnSinavlarim.Click += new System.EventHandler(this.btnSinavlarim_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(268, -5);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1096, 787);
            this.xtraTabControl1.TabIndex = 126;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1090, 759);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Controls.Add(this.button4);
            this.xtraTabPage2.Controls.Add(this.panel3);
            this.xtraTabPage2.Controls.Add(this.panel2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1090, 759);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1082, 298);
            this.gridControl1.TabIndex = 144;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::SmartExam.Properties.Resources.exam75;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(338, 15);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(389, 78);
            this.button4.TabIndex = 143;
            this.button4.Text = "Sınavlarım";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbSınıf);
            this.panel3.Controls.Add(this.cmbSoruSayisi);
            this.panel3.Controls.Add(this.cmbDers);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(565, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 352);
            this.panel3.TabIndex = 142;
            // 
            // cmbSınıf
            // 
            this.cmbSınıf.Location = new System.Drawing.Point(199, 139);
            this.cmbSınıf.Name = "cmbSınıf";
            this.cmbSınıf.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cmbSınıf.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmbSınıf.Properties.Appearance.Options.UseFont = true;
            this.cmbSınıf.Properties.Appearance.Options.UseForeColor = true;
            this.cmbSınıf.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cmbSınıf.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSınıf.Properties.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.cmbSınıf.Size = new System.Drawing.Size(155, 26);
            this.cmbSınıf.TabIndex = 155;
            // 
            // cmbSoruSayisi
            // 
            this.cmbSoruSayisi.Location = new System.Drawing.Point(199, 181);
            this.cmbSoruSayisi.Name = "cmbSoruSayisi";
            this.cmbSoruSayisi.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cmbSoruSayisi.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmbSoruSayisi.Properties.Appearance.Options.UseFont = true;
            this.cmbSoruSayisi.Properties.Appearance.Options.UseForeColor = true;
            this.cmbSoruSayisi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cmbSoruSayisi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSoruSayisi.Properties.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cmbSoruSayisi.Size = new System.Drawing.Size(155, 26);
            this.cmbSoruSayisi.TabIndex = 154;
            // 
            // cmbDers
            // 
            this.cmbDers.Location = new System.Drawing.Point(199, 97);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cmbDers.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmbDers.Properties.Appearance.Options.UseFont = true;
            this.cmbDers.Properties.Appearance.Options.UseForeColor = true;
            this.cmbDers.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cmbDers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDers.Properties.Items.AddRange(new object[] {
            "Matematik",
            "Fizik",
            "Kimya",
            "Biyoloji",
            "İngilizce",
            "Türkçe"});
            this.cmbDers.Size = new System.Drawing.Size(155, 26);
            this.cmbDers.TabIndex = 153;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(128, 98);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 22);
            this.label21.TabIndex = 152;
            this.label21.Text = "Ders:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(134, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 22);
            this.label20.TabIndex = 151;
            this.label20.Text = "Sınıf:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(77, 182);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 22);
            this.label19.TabIndex = 150;
            this.label19.Text = "Soru Sayısı:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(138, 287);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 40);
            this.button3.TabIndex = 149;
            this.button3.Text = "Sınav Oluştur";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::SmartExam.Properties.Resources.exam__1_50;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(119, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 57);
            this.button2.TabIndex = 148;
            this.button2.Text = "Sınav Oluştur";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSinavSinif);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtBos);
            this.panel2.Controls.Add(this.btnSinaviBaslat);
            this.panel2.Controls.Add(this.txtDers);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtSoruSayısı);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSinavNo);
            this.panel2.Controls.Add(this.txtSinavDogru);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSinavYanlis);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSinavDurum);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(5, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 352);
            this.panel2.TabIndex = 141;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(14, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 22);
            this.label15.TabIndex = 151;
            this.label15.Text = "Soru Sayısı:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::SmartExam.Properties.Resources.exam__2_50;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(157, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 57);
            this.button1.TabIndex = 147;
            this.button1.Text = "Sınav Bilgileri";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBos
            // 
            this.txtBos.BackColor = System.Drawing.Color.White;
            this.txtBos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBos.Enabled = false;
            this.txtBos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBos.ForeColor = System.Drawing.Color.Black;
            this.txtBos.Location = new System.Drawing.Point(412, 221);
            this.txtBos.Multiline = true;
            this.txtBos.Name = "txtBos";
            this.txtBos.Size = new System.Drawing.Size(110, 29);
            this.txtBos.TabIndex = 146;
            // 
            // btnSinaviBaslat
            // 
            this.btnSinaviBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSinaviBaslat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSinaviBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinaviBaslat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinaviBaslat.ForeColor = System.Drawing.Color.Black;
            this.btnSinaviBaslat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinaviBaslat.Location = new System.Drawing.Point(155, 287);
            this.btnSinaviBaslat.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinaviBaslat.Name = "btnSinaviBaslat";
            this.btnSinaviBaslat.Size = new System.Drawing.Size(251, 40);
            this.btnSinaviBaslat.TabIndex = 124;
            this.btnSinaviBaslat.Text = "Sınavı Başlat";
            this.btnSinaviBaslat.UseVisualStyleBackColor = false;
            this.btnSinaviBaslat.Click += new System.EventHandler(this.btnSinaviBaslat_Click);
            // 
            // txtDers
            // 
            this.txtDers.BackColor = System.Drawing.Color.White;
            this.txtDers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDers.Enabled = false;
            this.txtDers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDers.ForeColor = System.Drawing.Color.Black;
            this.txtDers.Location = new System.Drawing.Point(125, 138);
            this.txtDers.Multiline = true;
            this.txtDers.Name = "txtDers";
            this.txtDers.Size = new System.Drawing.Size(92, 29);
            this.txtDers.TabIndex = 144;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(65, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 22);
            this.label10.TabIndex = 143;
            this.label10.Text = "Ders:";
            // 
            // txtSoruSayısı
            // 
            this.txtSoruSayısı.BackColor = System.Drawing.Color.White;
            this.txtSoruSayısı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoruSayısı.Enabled = false;
            this.txtSoruSayısı.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoruSayısı.ForeColor = System.Drawing.Color.Black;
            this.txtSoruSayısı.Location = new System.Drawing.Point(125, 221);
            this.txtSoruSayısı.Multiline = true;
            this.txtSoruSayısı.Name = "txtSoruSayısı";
            this.txtSoruSayısı.Size = new System.Drawing.Size(92, 29);
            this.txtSoruSayısı.TabIndex = 142;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(361, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 22);
            this.label6.TabIndex = 141;
            this.label6.Text = "Boş:";
            // 
            // txtSinavNo
            // 
            this.txtSinavNo.BackColor = System.Drawing.Color.White;
            this.txtSinavNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSinavNo.Enabled = false;
            this.txtSinavNo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSinavNo.ForeColor = System.Drawing.Color.Black;
            this.txtSinavNo.Location = new System.Drawing.Point(125, 94);
            this.txtSinavNo.Multiline = true;
            this.txtSinavNo.Name = "txtSinavNo";
            this.txtSinavNo.Size = new System.Drawing.Size(92, 29);
            this.txtSinavNo.TabIndex = 136;
            // 
            // txtSinavDogru
            // 
            this.txtSinavDogru.BackColor = System.Drawing.Color.White;
            this.txtSinavDogru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSinavDogru.Enabled = false;
            this.txtSinavDogru.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSinavDogru.ForeColor = System.Drawing.Color.Black;
            this.txtSinavDogru.Location = new System.Drawing.Point(412, 133);
            this.txtSinavDogru.Multiline = true;
            this.txtSinavDogru.Name = "txtSinavDogru";
            this.txtSinavDogru.Size = new System.Drawing.Size(110, 29);
            this.txtSinavDogru.TabIndex = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 119;
            this.label2.Text = "Sınav No:";
            // 
            // txtSinavYanlis
            // 
            this.txtSinavYanlis.BackColor = System.Drawing.Color.White;
            this.txtSinavYanlis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSinavYanlis.Enabled = false;
            this.txtSinavYanlis.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSinavYanlis.ForeColor = System.Drawing.Color.Black;
            this.txtSinavYanlis.Location = new System.Drawing.Point(412, 177);
            this.txtSinavYanlis.Multiline = true;
            this.txtSinavYanlis.Name = "txtSinavYanlis";
            this.txtSinavYanlis.Size = new System.Drawing.Size(110, 29);
            this.txtSinavYanlis.TabIndex = 139;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(337, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 121;
            this.label7.Text = "Doğru:";
            // 
            // txtSinavDurum
            // 
            this.txtSinavDurum.BackColor = System.Drawing.Color.White;
            this.txtSinavDurum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSinavDurum.Enabled = false;
            this.txtSinavDurum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSinavDurum.ForeColor = System.Drawing.Color.Black;
            this.txtSinavDurum.Location = new System.Drawing.Point(412, 89);
            this.txtSinavDurum.Multiline = true;
            this.txtSinavDurum.Name = "txtSinavDurum";
            this.txtSinavDurum.Size = new System.Drawing.Size(110, 29);
            this.txtSinavDurum.TabIndex = 137;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(342, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 22);
            this.label8.TabIndex = 122;
            this.label8.Text = "Yanlış:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(266, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 22);
            this.label9.TabIndex = 123;
            this.label9.Text = "Sınav Durumu:";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1090, 759);
            this.xtraTabPage3.Text = "xtraTabPage3";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.textBox1);
            this.xtraTabPage4.Controls.Add(this.label22);
            this.xtraTabPage4.Controls.Add(this.txtSinif);
            this.xtraTabPage4.Controls.Add(this.label14);
            this.xtraTabPage4.Controls.Add(this.txtOgrenciNo);
            this.xtraTabPage4.Controls.Add(this.label11);
            this.xtraTabPage4.Controls.Add(this.btnOgrenciGuncelle);
            this.xtraTabPage4.Controls.Add(this.button11);
            this.xtraTabPage4.Controls.Add(this.btnSifreGoster);
            this.xtraTabPage4.Controls.Add(this.mskTelefon);
            this.xtraTabPage4.Controls.Add(this.txtMail);
            this.xtraTabPage4.Controls.Add(this.txtSoyad);
            this.xtraTabPage4.Controls.Add(this.txtYAd);
            this.xtraTabPage4.Controls.Add(this.txtSifre);
            this.xtraTabPage4.Controls.Add(this.label13);
            this.xtraTabPage4.Controls.Add(this.label12);
            this.xtraTabPage4.Controls.Add(this.label16);
            this.xtraTabPage4.Controls.Add(this.label17);
            this.xtraTabPage4.Controls.Add(this.label18);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1090, 759);
            this.xtraTabPage4.Text = "xtraTabPage4";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(722, 344);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 29);
            this.textBox1.TabIndex = 147;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(637, 343);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 24);
            this.label22.TabIndex = 146;
            this.label22.Text = "Şube:";
            // 
            // txtSinif
            // 
            this.txtSinif.BackColor = System.Drawing.Color.White;
            this.txtSinif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSinif.Enabled = false;
            this.txtSinif.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSinif.ForeColor = System.Drawing.Color.Black;
            this.txtSinif.Location = new System.Drawing.Point(722, 296);
            this.txtSinif.Multiline = true;
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(109, 29);
            this.txtSinif.TabIndex = 145;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(648, 295);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 24);
            this.label14.TabIndex = 144;
            this.label14.Text = "Sınıf:";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.BackColor = System.Drawing.Color.White;
            this.txtOgrenciNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOgrenciNo.Enabled = false;
            this.txtOgrenciNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciNo.ForeColor = System.Drawing.Color.Black;
            this.txtOgrenciNo.Location = new System.Drawing.Point(722, 248);
            this.txtOgrenciNo.Multiline = true;
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(109, 29);
            this.txtOgrenciNo.TabIndex = 143;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(570, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 24);
            this.label11.TabIndex = 142;
            this.label11.Text = "Öğrenci No:";
            // 
            // btnOgrenciGuncelle
            // 
            this.btnOgrenciGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOgrenciGuncelle.FlatAppearance.BorderSize = 0;
            this.btnOgrenciGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciGuncelle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnOgrenciGuncelle.Image = global::SmartExam.Properties.Resources.updated;
            this.btnOgrenciGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgrenciGuncelle.Location = new System.Drawing.Point(383, 586);
            this.btnOgrenciGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrenciGuncelle.Name = "btnOgrenciGuncelle";
            this.btnOgrenciGuncelle.Size = new System.Drawing.Size(373, 90);
            this.btnOgrenciGuncelle.TabIndex = 141;
            this.btnOgrenciGuncelle.Text = "Güncelle";
            this.btnOgrenciGuncelle.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Image = global::SmartExam.Properties.Resources.settings;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(328, 38);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(428, 90);
            this.button11.TabIndex = 140;
            this.button11.Text = "Hesap Bilgilerim";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // btnSifreGoster
            // 
            this.btnSifreGoster.FlatAppearance.BorderSize = 0;
            this.btnSifreGoster.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSifreGoster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSifreGoster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSifreGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSifreGoster.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreGoster.ForeColor = System.Drawing.Color.Black;
            this.btnSifreGoster.Image = global::SmartExam.Properties.Resources.password;
            this.btnSifreGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSifreGoster.Location = new System.Drawing.Point(722, 424);
            this.btnSifreGoster.Margin = new System.Windows.Forms.Padding(4);
            this.btnSifreGoster.Name = "btnSifreGoster";
            this.btnSifreGoster.Size = new System.Drawing.Size(176, 29);
            this.btnSifreGoster.TabIndex = 139;
            this.btnSifreGoster.Text = "Şifre Göster / Gizle";
            this.btnSifreGoster.UseVisualStyleBackColor = true;
            // 
            // mskTelefon
            // 
            this.mskTelefon.BackColor = System.Drawing.Color.White;
            this.mskTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefon.Enabled = false;
            this.mskTelefon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.ForeColor = System.Drawing.Color.Black;
            this.mskTelefon.Location = new System.Drawing.Point(253, 344);
            this.mskTelefon.Mask = "00000000000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(229, 27);
            this.mskTelefon.TabIndex = 138;
            this.mskTelefon.ValidatingType = typeof(int);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Enabled = false;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.ForeColor = System.Drawing.Color.Black;
            this.txtMail.Location = new System.Drawing.Point(253, 390);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(229, 29);
            this.txtMail.TabIndex = 137;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.White;
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtSoyad.Location = new System.Drawing.Point(253, 296);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(229, 29);
            this.txtSoyad.TabIndex = 136;
            // 
            // txtYAd
            // 
            this.txtYAd.BackColor = System.Drawing.Color.White;
            this.txtYAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYAd.Enabled = false;
            this.txtYAd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYAd.ForeColor = System.Drawing.Color.Black;
            this.txtYAd.Location = new System.Drawing.Point(253, 248);
            this.txtYAd.Multiline = true;
            this.txtYAd.Name = "txtYAd";
            this.txtYAd.Size = new System.Drawing.Size(229, 29);
            this.txtYAd.TabIndex = 135;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(722, 391);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(229, 25);
            this.txtSifre.TabIndex = 133;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(146, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 24);
            this.label13.TabIndex = 132;
            this.label13.Text = "Cinsiyet:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(197, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 24);
            this.label12.TabIndex = 131;
            this.label12.Text = "TC:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(648, 390);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 24);
            this.label16.TabIndex = 130;
            this.label16.Text = "Şifre:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(191, 247);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 24);
            this.label17.TabIndex = 129;
            this.label17.Text = "AD:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(159, 295);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 24);
            this.label18.TabIndex = 128;
            this.label18.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 153;
            this.label1.Text = "Sınıf:";
            // 
            // txtSinavSinif
            // 
            this.txtSinavSinif.BackColor = System.Drawing.Color.White;
            this.txtSinavSinif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSinavSinif.Enabled = false;
            this.txtSinavSinif.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSinavSinif.ForeColor = System.Drawing.Color.Black;
            this.txtSinavSinif.Location = new System.Drawing.Point(125, 182);
            this.txtSinavSinif.Multiline = true;
            this.txtSinavSinif.Name = "txtSinavSinif";
            this.txtSinavSinif.Size = new System.Drawing.Size(92, 29);
            this.txtSinavSinif.TabIndex = 152;
            // 
            // OgrenciScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1368, 879);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnBilgilerim);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnSinavlarim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OgrenciScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OgrenciScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSınıf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSoruSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDers.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnBilgilerim;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnSinavlarim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoruSayısı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSinavNo;
        private System.Windows.Forms.TextBox txtSinavDogru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSinavYanlis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSinavDurum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSinaviBaslat;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOgrenciGuncelle;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnSifreGoster;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtYAd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBos;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSınıf;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSoruSayisi;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDers;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSinavSinif;
    }
}

