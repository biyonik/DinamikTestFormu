
namespace DinamikTestFormu.WinUI.Forms.Sorular
{
    partial class FrmSoruIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSoruIslemleri));
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnSoruKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSoruKapat = new DevExpress.XtraEditors.SimpleButton();
            this.lblSoruIslem = new DevExpress.XtraEditors.LabelControl();
            this.tabSoruPaneli = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabSoruBilgisi = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.cbxDersler = new System.Windows.Forms.ComboBox();
            this.pctGorsel = new DevExpress.XtraEditors.PictureEdit();
            this.btnSoruGorselSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnSoruGorselEkle = new DevExpress.XtraEditors.SimpleButton();
            this.memoSoruMetni = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblDers = new DevExpress.XtraEditors.LabelControl();
            this.tabSecenekBilgisi = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControlSoruSecenekler = new DevExpress.XtraGrid.GridControl();
            this.gridViewSoruSecenekler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSecenek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpSecenekMenusu = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.grpSecenekBilgisi = new DevExpress.XtraEditors.GroupControl();
            this.tbxSoruSecenek = new DevExpress.XtraEditors.TextEdit();
            this.lblSecenek = new DevExpress.XtraEditors.LabelControl();
            this.pctGorsel1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabSoruPaneli)).BeginInit();
            this.tabSoruPaneli.SuspendLayout();
            this.tabSoruBilgisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctGorsel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoSoruMetni.Properties)).BeginInit();
            this.tabSecenekBilgisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSoruSecenekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSoruSecenekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSecenekMenusu)).BeginInit();
            this.grpSecenekMenusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSecenekBilgisi)).BeginInit();
            this.grpSecenekBilgisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxSoruSecenek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGorsel1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnSoruKaydet);
            this.grpMenu.Controls.Add(this.btnSoruKapat);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 540);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(551, 81);
            this.grpMenu.TabIndex = 4;
            this.grpMenu.Text = "Menü";
            // 
            // btnSoruKaydet
            // 
            this.btnSoruKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSoruKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSoruKaydet.ImageOptions.Image")));
            this.btnSoruKaydet.Location = new System.Drawing.Point(343, 23);
            this.btnSoruKaydet.Name = "btnSoruKaydet";
            this.btnSoruKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSoruKaydet.Size = new System.Drawing.Size(103, 56);
            this.btnSoruKaydet.TabIndex = 0;
            this.btnSoruKaydet.Text = "Kaydet";
            this.btnSoruKaydet.Click += new System.EventHandler(this.btnSoruKaydet_Click);
            // 
            // btnSoruKapat
            // 
            this.btnSoruKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSoruKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSoruKapat.ImageOptions.Image")));
            this.btnSoruKapat.Location = new System.Drawing.Point(446, 23);
            this.btnSoruKapat.Name = "btnSoruKapat";
            this.btnSoruKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSoruKapat.Size = new System.Drawing.Size(103, 56);
            this.btnSoruKapat.TabIndex = 0;
            this.btnSoruKapat.Text = "Kapat";
            this.btnSoruKapat.Click += new System.EventHandler(this.btnSoruKapat_Click);
            // 
            // lblSoruIslem
            // 
            this.lblSoruIslem.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoruIslem.Appearance.Options.UseFont = true;
            this.lblSoruIslem.Appearance.Options.UseTextOptions = true;
            this.lblSoruIslem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSoruIslem.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblSoruIslem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSoruIslem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblSoruIslem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSoruIslem.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSoruIslem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblSoruIslem.ImageOptions.Image")));
            this.lblSoruIslem.Location = new System.Drawing.Point(0, 0);
            this.lblSoruIslem.Name = "lblSoruIslem";
            this.lblSoruIslem.Size = new System.Drawing.Size(551, 69);
            this.lblSoruIslem.TabIndex = 3;
            this.lblSoruIslem.Text = "Soru işlem Formu";
            // 
            // tabSoruPaneli
            // 
            this.tabSoruPaneli.Controls.Add(this.tabSoruBilgisi);
            this.tabSoruPaneli.Controls.Add(this.tabSecenekBilgisi);
            this.tabSoruPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSoruPaneli.Location = new System.Drawing.Point(0, 69);
            this.tabSoruPaneli.Name = "tabSoruPaneli";
            this.tabSoruPaneli.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabSoruBilgisi,
            this.tabSecenekBilgisi});
            this.tabSoruPaneli.RegularSize = new System.Drawing.Size(551, 471);
            this.tabSoruPaneli.SelectedPage = this.tabSoruBilgisi;
            this.tabSoruPaneli.Size = new System.Drawing.Size(551, 471);
            this.tabSoruPaneli.TabIndex = 5;
            // 
            // tabSoruBilgisi
            // 
            this.tabSoruBilgisi.Caption = "Soru Bilgisi";
            this.tabSoruBilgisi.Controls.Add(this.cbxDersler);
            this.tabSoruBilgisi.Controls.Add(this.pctGorsel);
            this.tabSoruBilgisi.Controls.Add(this.btnSoruGorselSil);
            this.tabSoruBilgisi.Controls.Add(this.btnSoruGorselEkle);
            this.tabSoruBilgisi.Controls.Add(this.memoSoruMetni);
            this.tabSoruBilgisi.Controls.Add(this.labelControl1);
            this.tabSoruBilgisi.Controls.Add(this.labelControl2);
            this.tabSoruBilgisi.Controls.Add(this.lblDers);
            this.tabSoruBilgisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabSoruBilgisi.ImageOptions.Image")));
            this.tabSoruBilgisi.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabSoruBilgisi.Name = "tabSoruBilgisi";
            this.tabSoruBilgisi.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabSoruBilgisi.Size = new System.Drawing.Size(551, 432);
            // 
            // cbxDersler
            // 
            this.cbxDersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDersler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDersler.FormattingEnabled = true;
            this.cbxDersler.Location = new System.Drawing.Point(145, 18);
            this.cbxDersler.Name = "cbxDersler";
            this.cbxDersler.Size = new System.Drawing.Size(394, 21);
            this.cbxDersler.TabIndex = 7;
            this.cbxDersler.SelectedIndexChanged += new System.EventHandler(this.cbxDersler_SelectedIndexChanged);
            // 
            // pctGorsel
            // 
            this.pctGorsel.Location = new System.Drawing.Point(145, 48);
            this.pctGorsel.Name = "pctGorsel";
            this.pctGorsel.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.pctGorsel.Properties.ShowEditMenuItem = DevExpress.Utils.DefaultBoolean.False;
            this.pctGorsel.Properties.ShowMenu = false;
            this.pctGorsel.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            this.pctGorsel.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pctGorsel.Size = new System.Drawing.Size(301, 120);
            this.pctGorsel.TabIndex = 6;
            // 
            // btnSoruGorselSil
            // 
            this.btnSoruGorselSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSoruGorselSil.ImageOptions.Image")));
            this.btnSoruGorselSil.Location = new System.Drawing.Point(452, 126);
            this.btnSoruGorselSil.Name = "btnSoruGorselSil";
            this.btnSoruGorselSil.Size = new System.Drawing.Size(90, 42);
            this.btnSoruGorselSil.TabIndex = 4;
            this.btnSoruGorselSil.Text = "İptal";
            // 
            // btnSoruGorselEkle
            // 
            this.btnSoruGorselEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSoruGorselEkle.ImageOptions.Image")));
            this.btnSoruGorselEkle.Location = new System.Drawing.Point(452, 48);
            this.btnSoruGorselEkle.Name = "btnSoruGorselEkle";
            this.btnSoruGorselEkle.Size = new System.Drawing.Size(90, 42);
            this.btnSoruGorselEkle.TabIndex = 4;
            this.btnSoruGorselEkle.Text = "Görsel Seç";
            this.btnSoruGorselEkle.Click += new System.EventHandler(this.btnSoruGorselEkle_Click);
            // 
            // memoSoruMetni
            // 
            this.memoSoruMetni.Location = new System.Drawing.Point(145, 174);
            this.memoSoruMetni.Name = "memoSoruMetni";
            this.memoSoruMetni.Size = new System.Drawing.Size(397, 251);
            this.memoSoruMetni.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Location = new System.Drawing.Point(3, 174);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(136, 251);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Soru Metni:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(3, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(136, 120);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Görsel:";
            // 
            // lblDers
            // 
            this.lblDers.Appearance.Options.UseTextOptions = true;
            this.lblDers.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblDers.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDers.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lblDers.Location = new System.Drawing.Point(3, 19);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(136, 23);
            this.lblDers.TabIndex = 0;
            this.lblDers.Text = "Ders Adı:";
            // 
            // tabSecenekBilgisi
            // 
            this.tabSecenekBilgisi.Caption = "Seçenekler";
            this.tabSecenekBilgisi.Controls.Add(this.gridControlSoruSecenekler);
            this.tabSecenekBilgisi.Controls.Add(this.grpSecenekMenusu);
            this.tabSecenekBilgisi.Controls.Add(this.grpSecenekBilgisi);
            this.tabSecenekBilgisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabSecenekBilgisi.ImageOptions.Image")));
            this.tabSecenekBilgisi.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabSecenekBilgisi.Name = "tabSecenekBilgisi";
            this.tabSecenekBilgisi.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabSecenekBilgisi.Size = new System.Drawing.Size(551, 432);
            // 
            // gridControlSoruSecenekler
            // 
            this.gridControlSoruSecenekler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSoruSecenekler.Location = new System.Drawing.Point(0, 149);
            this.gridControlSoruSecenekler.MainView = this.gridViewSoruSecenekler;
            this.gridControlSoruSecenekler.Name = "gridControlSoruSecenekler";
            this.gridControlSoruSecenekler.Size = new System.Drawing.Size(551, 283);
            this.gridControlSoruSecenekler.TabIndex = 4;
            this.gridControlSoruSecenekler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSoruSecenekler});
            // 
            // gridViewSoruSecenekler
            // 
            this.gridViewSoruSecenekler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSecenek});
            this.gridViewSoruSecenekler.GridControl = this.gridControlSoruSecenekler;
            this.gridViewSoruSecenekler.Name = "gridViewSoruSecenekler";
            // 
            // colSecenek
            // 
            this.colSecenek.Caption = "Seçenek";
            this.colSecenek.FieldName = "Opsiyon";
            this.colSecenek.Name = "colSecenek";
            this.colSecenek.Visible = true;
            this.colSecenek.VisibleIndex = 0;
            // 
            // grpSecenekMenusu
            // 
            this.grpSecenekMenusu.Controls.Add(this.btnKaydet);
            this.grpSecenekMenusu.Controls.Add(this.btnSil);
            this.grpSecenekMenusu.Controls.Add(this.btnDuzenle);
            this.grpSecenekMenusu.Controls.Add(this.btnEkle);
            this.grpSecenekMenusu.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSecenekMenusu.Location = new System.Drawing.Point(0, 70);
            this.grpSecenekMenusu.Name = "grpSecenekMenusu";
            this.grpSecenekMenusu.Size = new System.Drawing.Size(551, 79);
            this.grpSecenekMenusu.TabIndex = 3;
            this.grpSecenekMenusu.Text = "Seçenek Menüsü";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(451, 23);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(98, 54);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(194, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 54);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(99, 23);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(95, 54);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(2, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(97, 54);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // grpSecenekBilgisi
            // 
            this.grpSecenekBilgisi.Controls.Add(this.tbxSoruSecenek);
            this.grpSecenekBilgisi.Controls.Add(this.lblSecenek);
            this.grpSecenekBilgisi.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSecenekBilgisi.Location = new System.Drawing.Point(0, 0);
            this.grpSecenekBilgisi.Name = "grpSecenekBilgisi";
            this.grpSecenekBilgisi.Size = new System.Drawing.Size(551, 70);
            this.grpSecenekBilgisi.TabIndex = 0;
            this.grpSecenekBilgisi.Text = "Seçenek Bilgisi";
            // 
            // tbxSoruSecenek
            // 
            this.tbxSoruSecenek.Location = new System.Drawing.Point(139, 30);
            this.tbxSoruSecenek.Name = "tbxSoruSecenek";
            this.tbxSoruSecenek.Size = new System.Drawing.Size(403, 20);
            this.tbxSoruSecenek.TabIndex = 3;
            // 
            // lblSecenek
            // 
            this.lblSecenek.Appearance.Options.UseTextOptions = true;
            this.lblSecenek.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblSecenek.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSecenek.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lblSecenek.Location = new System.Drawing.Point(12, 26);
            this.lblSecenek.Name = "lblSecenek";
            this.lblSecenek.Size = new System.Drawing.Size(121, 27);
            this.lblSecenek.TabIndex = 2;
            this.lblSecenek.Text = "Seçenek:";
            // 
            // pctGorsel1
            // 
            this.pctGorsel1.Location = new System.Drawing.Point(0, 0);
            this.pctGorsel1.Name = "pctGorsel1";
            this.pctGorsel1.Size = new System.Drawing.Size(100, 96);
            this.pctGorsel1.TabIndex = 0;
            // 
            // FrmSoruIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 621);
            this.Controls.Add(this.tabSoruPaneli);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblSoruIslem);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSoruIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soru İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabSoruPaneli)).EndInit();
            this.tabSoruPaneli.ResumeLayout(false);
            this.tabSoruBilgisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctGorsel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoSoruMetni.Properties)).EndInit();
            this.tabSecenekBilgisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSoruSecenekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSoruSecenekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSecenekMenusu)).EndInit();
            this.grpSecenekMenusu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpSecenekBilgisi)).EndInit();
            this.grpSecenekBilgisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxSoruSecenek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGorsel1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnSoruKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSoruKapat;
        private DevExpress.XtraEditors.LabelControl lblSoruIslem;
        private DevExpress.XtraBars.Navigation.TabPane tabSoruPaneli;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabSoruBilgisi;
        private DevExpress.XtraEditors.SimpleButton btnSoruGorselSil;
        private DevExpress.XtraEditors.SimpleButton btnSoruGorselEkle;
        private DevExpress.XtraEditors.MemoEdit memoSoruMetni;
        private DevExpress.XtraEditors.PictureEdit pctGorsel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblDers;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabSecenekBilgisi;
        private DevExpress.XtraGrid.GridControl gridControlSoruSecenekler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSoruSecenekler;
        private DevExpress.XtraEditors.GroupControl grpSecenekMenusu;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.GroupControl grpSecenekBilgisi;
        private DevExpress.XtraEditors.TextEdit tbxSoruSecenek;
        private DevExpress.XtraEditors.LabelControl lblSecenek;
        private DevExpress.XtraEditors.PictureEdit pctGorsel;
        private DevExpress.XtraGrid.Columns.GridColumn colSecenek;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.ComboBox cbxDersler;
    }
}