namespace SmartExam
{
    partial class FrmSinav
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
            this.components = new System.ComponentModel.Container();
            this.lblDers = new DevExpress.XtraEditors.LabelControl();
            this.lblSoruSayisi = new DevExpress.XtraEditors.LabelControl();
            this.lblSoru = new DevExpress.XtraEditors.LabelControl();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.lblCevapA = new DevExpress.XtraEditors.LabelControl();
            this.lblCevapB = new DevExpress.XtraEditors.LabelControl();
            this.lblCevapC = new DevExpress.XtraEditors.LabelControl();
            this.lblCevapD = new DevExpress.XtraEditors.LabelControl();
            this.lblCevapE = new DevExpress.XtraEditors.LabelControl();
            this.lblSure = new DevExpress.XtraEditors.LabelControl();
            this.btnBitir = new DevExpress.XtraEditors.SimpleButton();
            this.button11 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.lblSoruNo1 = new DevExpress.XtraEditors.LabelControl();
            this.pnlDogruYanlis = new System.Windows.Forms.Panel();
            this.lblBos = new DevExpress.XtraEditors.LabelControl();
            this.lblYanlis = new DevExpress.XtraEditors.LabelControl();
            this.lblDogru = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblCevap = new DevExpress.XtraEditors.LabelControl();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.lblSoruID = new DevExpress.XtraEditors.LabelControl();
            this.lblSoruCevap = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnlDogruYanlis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDers
            // 
            this.lblDers.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblDers.Appearance.Font = new System.Drawing.Font("Century Schoolbook", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDers.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblDers.Appearance.Options.UseBackColor = true;
            this.lblDers.Appearance.Options.UseFont = true;
            this.lblDers.Appearance.Options.UseForeColor = true;
            this.lblDers.Location = new System.Drawing.Point(623, -3);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(94, 50);
            this.lblDers.TabIndex = 0;
            this.lblDers.Text = "Ders";
            // 
            // lblSoruSayisi
            // 
            this.lblSoruSayisi.Appearance.BackColor = System.Drawing.Color.White;
            this.lblSoruSayisi.Appearance.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoruSayisi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblSoruSayisi.Appearance.Options.UseBackColor = true;
            this.lblSoruSayisi.Appearance.Options.UseFont = true;
            this.lblSoruSayisi.Appearance.Options.UseForeColor = true;
            this.lblSoruSayisi.Location = new System.Drawing.Point(91, 226);
            this.lblSoruSayisi.Name = "lblSoruSayisi";
            this.lblSoruSayisi.Size = new System.Drawing.Size(147, 36);
            this.lblSoruSayisi.TabIndex = 1;
            this.lblSoruSayisi.Text = "Soru Sayısı:";
            // 
            // lblSoru
            // 
            this.lblSoru.Appearance.BackColor = System.Drawing.Color.White;
            this.lblSoru.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblSoru.Appearance.Options.UseBackColor = true;
            this.lblSoru.Appearance.Options.UseFont = true;
            this.lblSoru.Appearance.Options.UseForeColor = true;
            this.lblSoru.Location = new System.Drawing.Point(262, 236);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(48, 24);
            this.lblSoru.TabIndex = 2;
            this.lblSoru.Text = "Soru:";
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.ForeColor = System.Drawing.Color.Black;
            this.btnA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnA.Location = new System.Drawing.Point(199, 371);
            this.btnA.Margin = new System.Windows.Forms.Padding(4);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(41, 39);
            this.btnA.TabIndex = 125;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.ForeColor = System.Drawing.Color.Black;
            this.btnB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnB.Location = new System.Drawing.Point(199, 437);
            this.btnB.Margin = new System.Windows.Forms.Padding(4);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(41, 39);
            this.btnB.TabIndex = 126;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.ForeColor = System.Drawing.Color.Black;
            this.btnC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnC.Location = new System.Drawing.Point(199, 503);
            this.btnC.Margin = new System.Windows.Forms.Padding(4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(41, 39);
            this.btnC.TabIndex = 127;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnD.ForeColor = System.Drawing.Color.Black;
            this.btnD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnD.Location = new System.Drawing.Point(199, 569);
            this.btnD.Margin = new System.Windows.Forms.Padding(4);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(41, 39);
            this.btnD.TabIndex = 128;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnE.ForeColor = System.Drawing.Color.Black;
            this.btnE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnE.Location = new System.Drawing.Point(199, 635);
            this.btnE.Margin = new System.Windows.Forms.Padding(4);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(41, 39);
            this.btnE.TabIndex = 129;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // lblCevapA
            // 
            this.lblCevapA.Appearance.BackColor = System.Drawing.Color.White;
            this.lblCevapA.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblCevapA.Appearance.Options.UseBackColor = true;
            this.lblCevapA.Appearance.Options.UseFont = true;
            this.lblCevapA.Location = new System.Drawing.Point(262, 377);
            this.lblCevapA.Name = "lblCevapA";
            this.lblCevapA.Size = new System.Drawing.Size(140, 24);
            this.lblCevapA.TabIndex = 130;
            this.lblCevapA.Text = "labelControl4";
            // 
            // lblCevapB
            // 
            this.lblCevapB.Appearance.BackColor = System.Drawing.Color.White;
            this.lblCevapB.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblCevapB.Appearance.Options.UseBackColor = true;
            this.lblCevapB.Appearance.Options.UseFont = true;
            this.lblCevapB.Location = new System.Drawing.Point(262, 443);
            this.lblCevapB.Name = "lblCevapB";
            this.lblCevapB.Size = new System.Drawing.Size(140, 24);
            this.lblCevapB.TabIndex = 131;
            this.lblCevapB.Text = "labelControl5";
            // 
            // lblCevapC
            // 
            this.lblCevapC.Appearance.BackColor = System.Drawing.Color.White;
            this.lblCevapC.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblCevapC.Appearance.Options.UseBackColor = true;
            this.lblCevapC.Appearance.Options.UseFont = true;
            this.lblCevapC.Location = new System.Drawing.Point(262, 509);
            this.lblCevapC.Name = "lblCevapC";
            this.lblCevapC.Size = new System.Drawing.Size(140, 24);
            this.lblCevapC.TabIndex = 132;
            this.lblCevapC.Text = "labelControl6";
            // 
            // lblCevapD
            // 
            this.lblCevapD.Appearance.BackColor = System.Drawing.Color.White;
            this.lblCevapD.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblCevapD.Appearance.Options.UseBackColor = true;
            this.lblCevapD.Appearance.Options.UseFont = true;
            this.lblCevapD.Location = new System.Drawing.Point(262, 575);
            this.lblCevapD.Name = "lblCevapD";
            this.lblCevapD.Size = new System.Drawing.Size(112, 24);
            this.lblCevapD.TabIndex = 133;
            this.lblCevapD.Text = "lblCevapD";
            // 
            // lblCevapE
            // 
            this.lblCevapE.Appearance.BackColor = System.Drawing.Color.White;
            this.lblCevapE.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblCevapE.Appearance.Options.UseBackColor = true;
            this.lblCevapE.Appearance.Options.UseFont = true;
            this.lblCevapE.Location = new System.Drawing.Point(262, 641);
            this.lblCevapE.Name = "lblCevapE";
            this.lblCevapE.Size = new System.Drawing.Size(140, 24);
            this.lblCevapE.TabIndex = 134;
            this.lblCevapE.Text = "labelControl8";
            // 
            // lblSure
            // 
            this.lblSure.Appearance.BackColor = System.Drawing.Color.White;
            this.lblSure.Appearance.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblSure.Appearance.Options.UseBackColor = true;
            this.lblSure.Appearance.Options.UseFont = true;
            this.lblSure.Appearance.Options.UseForeColor = true;
            this.lblSure.Location = new System.Drawing.Point(1199, 263);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(55, 36);
            this.lblSure.TabIndex = 139;
            this.lblSure.Text = "6:30";
            // 
            // btnBitir
            // 
            this.btnBitir.Appearance.BackColor = System.Drawing.Color.White;
            this.btnBitir.Appearance.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBitir.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnBitir.Appearance.Options.UseBackColor = true;
            this.btnBitir.Appearance.Options.UseFont = true;
            this.btnBitir.Appearance.Options.UseForeColor = true;
            this.btnBitir.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.btnBitir.AppearancePressed.Options.UseBackColor = true;
            this.btnBitir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnBitir.Image = global::SmartExam.Properties.Resources.racing_flag75;
            this.btnBitir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnBitir.Location = new System.Drawing.Point(1097, 350);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(183, 91);
            this.btnBitir.TabIndex = 138;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Image = global::SmartExam.Properties.Resources.hourglass75;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(1131, 236);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(71, 90);
            this.button11.TabIndex = 141;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblSure);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.lblSoruNo1);
            this.panel1.Controls.Add(this.pnlDogruYanlis);
            this.panel1.Controls.Add(this.lblCevap);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.lblSoruID);
            this.panel1.Controls.Add(this.lblSoruCevap);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCevapA);
            this.panel1.Controls.Add(this.btnBitir);
            this.panel1.Controls.Add(this.btnA);
            this.panel1.Controls.Add(this.lblSoru);
            this.panel1.Controls.Add(this.lblCevapE);
            this.panel1.Controls.Add(this.lblSoruSayisi);
            this.panel1.Controls.Add(this.btnB);
            this.panel1.Controls.Add(this.lblCevapD);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.lblCevapC);
            this.panel1.Controls.Add(this.btnD);
            this.panel1.Controls.Add(this.lblCevapB);
            this.panel1.Controls.Add(this.btnE);
            this.panel1.Location = new System.Drawing.Point(39, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 802);
            this.panel1.TabIndex = 142;
            // 
            // btnBack
            // 
            this.btnBack.Appearance.BackColor = System.Drawing.Color.White;
            this.btnBack.Appearance.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.btnBack.AppearancePressed.Options.UseBackColor = true;
            this.btnBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnBack.Enabled = false;
            this.btnBack.Image = global::SmartExam.Properties.Resources.left_arrow;
            this.btnBack.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnBack.Location = new System.Drawing.Point(958, 681);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 99);
            this.btnBack.TabIndex = 153;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(654, 226);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1012, 302);
            this.gridControl1.TabIndex = 145;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridView1.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.gridView1.OptionsBehavior.KeepGroupExpandedOnSorting = false;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowColumnResizing = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsDetail.AllowZoomDetail = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridView1.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.gridView1.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gridView1.OptionsMenu.ShowSplitItem = false;
            this.gridView1.OptionsSelection.InvertSelection = true;
            this.gridView1.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnNext
            // 
            this.btnNext.Appearance.BackColor = System.Drawing.Color.White;
            this.btnNext.Appearance.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Appearance.Options.UseBackColor = true;
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Appearance.Options.UseForeColor = true;
            this.btnNext.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.btnNext.AppearancePressed.Options.UseBackColor = true;
            this.btnNext.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnNext.Image = global::SmartExam.Properties.Resources.right_arrow;
            this.btnNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnNext.Location = new System.Drawing.Point(1117, 681);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(153, 99);
            this.btnNext.TabIndex = 152;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblSoruNo1
            // 
            this.lblSoruNo1.Appearance.BackColor = System.Drawing.Color.White;
            this.lblSoruNo1.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblSoruNo1.Appearance.Options.UseBackColor = true;
            this.lblSoruNo1.Appearance.Options.UseFont = true;
            this.lblSoruNo1.Location = new System.Drawing.Point(476, 775);
            this.lblSoruNo1.Name = "lblSoruNo1";
            this.lblSoruNo1.Size = new System.Drawing.Size(12, 24);
            this.lblSoruNo1.TabIndex = 151;
            this.lblSoruNo1.Text = "0";
            this.lblSoruNo1.Visible = false;
            // 
            // pnlDogruYanlis
            // 
            this.pnlDogruYanlis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDogruYanlis.Controls.Add(this.lblBos);
            this.pnlDogruYanlis.Controls.Add(this.lblYanlis);
            this.pnlDogruYanlis.Controls.Add(this.lblDogru);
            this.pnlDogruYanlis.Controls.Add(this.labelControl3);
            this.pnlDogruYanlis.Controls.Add(this.labelControl2);
            this.pnlDogruYanlis.Controls.Add(this.labelControl1);
            this.pnlDogruYanlis.Location = new System.Drawing.Point(1046, 18);
            this.pnlDogruYanlis.Name = "pnlDogruYanlis";
            this.pnlDogruYanlis.Size = new System.Drawing.Size(224, 192);
            this.pnlDogruYanlis.TabIndex = 150;
            this.pnlDogruYanlis.Visible = false;
            // 
            // lblBos
            // 
            this.lblBos.Appearance.BackColor = System.Drawing.Color.White;
            this.lblBos.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblBos.Appearance.Options.UseBackColor = true;
            this.lblBos.Appearance.Options.UseFont = true;
            this.lblBos.Location = new System.Drawing.Point(143, 123);
            this.lblBos.Name = "lblBos";
            this.lblBos.Size = new System.Drawing.Size(12, 24);
            this.lblBos.TabIndex = 136;
            this.lblBos.Text = "0";
            // 
            // lblYanlis
            // 
            this.lblYanlis.Appearance.BackColor = System.Drawing.Color.White;
            this.lblYanlis.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblYanlis.Appearance.Options.UseBackColor = true;
            this.lblYanlis.Appearance.Options.UseFont = true;
            this.lblYanlis.Location = new System.Drawing.Point(143, 80);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(12, 24);
            this.lblYanlis.TabIndex = 135;
            this.lblYanlis.Text = "0";
            // 
            // lblDogru
            // 
            this.lblDogru.Appearance.BackColor = System.Drawing.Color.White;
            this.lblDogru.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblDogru.Appearance.Options.UseBackColor = true;
            this.lblDogru.Appearance.Options.UseFont = true;
            this.lblDogru.Location = new System.Drawing.Point(143, 37);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(12, 24);
            this.lblDogru.TabIndex = 134;
            this.lblDogru.Text = "0";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(83, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 24);
            this.labelControl3.TabIndex = 133;
            this.labelControl3.Text = "Boş:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(59, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 24);
            this.labelControl2.TabIndex = 132;
            this.labelControl2.Text = "Yanlış:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(54, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 24);
            this.labelControl1.TabIndex = 131;
            this.labelControl1.Text = "Doğru:";
            // 
            // lblCevap
            // 
            this.lblCevap.Appearance.BackColor = System.Drawing.Color.White;
            this.lblCevap.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblCevap.Appearance.Options.UseBackColor = true;
            this.lblCevap.Appearance.Options.UseFont = true;
            this.lblCevap.Location = new System.Drawing.Point(47, 751);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(77, 24);
            this.lblCevap.TabIndex = 149;
            this.lblCevap.Text = "Cevap:";
            this.lblCevap.Visible = false;
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.BackColor = System.Drawing.Color.White;
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnCikis.Appearance.Options.UseBackColor = true;
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.Appearance.Options.UseForeColor = true;
            this.btnCikis.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.btnCikis.AppearancePressed.Options.UseBackColor = true;
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCikis.Image = global::SmartExam.Properties.Resources.cancel775;
            this.btnCikis.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(1097, 470);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(181, 91);
            this.btnCikis.TabIndex = 148;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblSoruID
            // 
            this.lblSoruID.Appearance.BackColor = System.Drawing.Color.White;
            this.lblSoruID.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblSoruID.Appearance.Options.UseBackColor = true;
            this.lblSoruID.Appearance.Options.UseFont = true;
            this.lblSoruID.Location = new System.Drawing.Point(411, 775);
            this.lblSoruID.Name = "lblSoruID";
            this.lblSoruID.Size = new System.Drawing.Size(12, 24);
            this.lblSoruID.TabIndex = 147;
            this.lblSoruID.Text = "0";
            this.lblSoruID.Visible = false;
            // 
            // lblSoruCevap
            // 
            this.lblSoruCevap.Appearance.BackColor = System.Drawing.Color.White;
            this.lblSoruCevap.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblSoruCevap.Appearance.Options.UseBackColor = true;
            this.lblSoruCevap.Appearance.Options.UseFont = true;
            this.lblSoruCevap.Location = new System.Drawing.Point(134, 751);
            this.lblSoruCevap.Name = "lblSoruCevap";
            this.lblSoruCevap.Size = new System.Drawing.Size(72, 24);
            this.lblSoruCevap.TabIndex = 146;
            this.lblSoruCevap.Text = "Cevap";
            this.lblSoruCevap.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(476, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1368, 879);
            this.Controls.Add(this.lblDers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSinav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSinav";
            this.Load += new System.EventHandler(this.FrmSinav_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnlDogruYanlis.ResumeLayout(false);
            this.pnlDogruYanlis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDers;
        private DevExpress.XtraEditors.LabelControl lblSoruSayisi;
        private DevExpress.XtraEditors.LabelControl lblSoru;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnE;
        private DevExpress.XtraEditors.LabelControl lblCevapA;
        private DevExpress.XtraEditors.LabelControl lblCevapB;
        private DevExpress.XtraEditors.LabelControl lblCevapC;
        private DevExpress.XtraEditors.LabelControl lblCevapD;
        private DevExpress.XtraEditors.LabelControl lblCevapE;
        private DevExpress.XtraEditors.SimpleButton btnBitir;
        private DevExpress.XtraEditors.LabelControl lblSure;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblSoruID;
        private DevExpress.XtraEditors.LabelControl lblSoruCevap;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.LabelControl lblCevap;
        private System.Windows.Forms.Panel pnlDogruYanlis;
        private DevExpress.XtraEditors.LabelControl lblBos;
        private DevExpress.XtraEditors.LabelControl lblYanlis;
        private DevExpress.XtraEditors.LabelControl lblDogru;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblSoruNo1;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnBack;
    }
}