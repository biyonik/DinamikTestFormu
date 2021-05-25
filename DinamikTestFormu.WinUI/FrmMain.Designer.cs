
namespace DinamikTestFormu.WinUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.rbControlMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnDersler = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDersEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSorular = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSoruEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSinavlar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSinavOlustur = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.rpAnaMenu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgDers = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSorular = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSinavlar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rbControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbControlMain
            // 
            this.rbControlMain.ExpandCollapseItem.Id = 0;
            this.rbControlMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbControlMain.ExpandCollapseItem,
            this.rbControlMain.SearchEditItem,
            this.barBtnDersler,
            this.barBtnDersEkle,
            this.barBtnSorular,
            this.barBtnSoruEkle,
            this.barBtnSinavlar,
            this.barBtnSinavOlustur});
            this.rbControlMain.Location = new System.Drawing.Point(0, 0);
            this.rbControlMain.MaxItemId = 7;
            this.rbControlMain.Name = "rbControlMain";
            this.rbControlMain.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.rbControlMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpAnaMenu});
            this.rbControlMain.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center;
            this.rbControlMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.rbControlMain.Size = new System.Drawing.Size(1278, 158);
            // 
            // barBtnDersler
            // 
            this.barBtnDersler.Caption = "Dersler";
            this.barBtnDersler.Id = 1;
            this.barBtnDersler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDersler.ImageOptions.Image")));
            this.barBtnDersler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDersler.ImageOptions.LargeImage")));
            this.barBtnDersler.Name = "barBtnDersler";
            this.barBtnDersler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDersler_ItemClick);
            // 
            // barBtnDersEkle
            // 
            this.barBtnDersEkle.Caption = "Ders Ekle";
            this.barBtnDersEkle.Id = 2;
            this.barBtnDersEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDersEkle.ImageOptions.Image")));
            this.barBtnDersEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDersEkle.ImageOptions.LargeImage")));
            this.barBtnDersEkle.Name = "barBtnDersEkle";
            this.barBtnDersEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDersEkle_ItemClick);
            // 
            // barBtnSorular
            // 
            this.barBtnSorular.Caption = "Sorular";
            this.barBtnSorular.Id = 3;
            this.barBtnSorular.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSorular.ImageOptions.Image")));
            this.barBtnSorular.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSorular.ImageOptions.LargeImage")));
            this.barBtnSorular.Name = "barBtnSorular";
            this.barBtnSorular.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSorular_ItemClick);
            // 
            // barBtnSoruEkle
            // 
            this.barBtnSoruEkle.Caption = "Soru Ekle";
            this.barBtnSoruEkle.Id = 4;
            this.barBtnSoruEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSoruEkle.ImageOptions.Image")));
            this.barBtnSoruEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSoruEkle.ImageOptions.LargeImage")));
            this.barBtnSoruEkle.Name = "barBtnSoruEkle";
            this.barBtnSoruEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSoruEkle_ItemClick);
            // 
            // barBtnSinavlar
            // 
            this.barBtnSinavlar.Caption = "Sınavlar";
            this.barBtnSinavlar.Id = 5;
            this.barBtnSinavlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSinavlar.ImageOptions.Image")));
            this.barBtnSinavlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSinavlar.ImageOptions.LargeImage")));
            this.barBtnSinavlar.Name = "barBtnSinavlar";
            // 
            // barBtnSinavOlustur
            // 
            this.barBtnSinavOlustur.Caption = "Sınav Oluştur";
            this.barBtnSinavOlustur.Id = 6;
            this.barBtnSinavOlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSinavOlustur.ImageOptions.Image")));
            this.barBtnSinavOlustur.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSinavOlustur.ImageOptions.LargeImage")));
            this.barBtnSinavOlustur.Name = "barBtnSinavOlustur";
            this.barBtnSinavOlustur.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSinavOlustur_ItemClick);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // rpAnaMenu
            // 
            this.rpAnaMenu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgDers,
            this.rpgSorular,
            this.rpgSinavlar});
            this.rpAnaMenu.Name = "rpAnaMenu";
            this.rpAnaMenu.Text = "Ana Menü";
            // 
            // rpgDers
            // 
            this.rpgDers.AllowTextClipping = false;
            this.rpgDers.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rpgDers.ItemLinks.Add(this.barBtnDersler);
            this.rpgDers.ItemLinks.Add(this.barBtnDersEkle);
            this.rpgDers.Name = "rpgDers";
            this.rpgDers.Text = "Ders İşlemleri";
            // 
            // rpgSorular
            // 
            this.rpgSorular.ItemLinks.Add(this.barBtnSorular);
            this.rpgSorular.ItemLinks.Add(this.barBtnSoruEkle);
            this.rpgSorular.Name = "rpgSorular";
            this.rpgSorular.Text = "Soru İşlemleri";
            // 
            // rpgSinavlar
            // 
            this.rpgSinavlar.ItemLinks.Add(this.barBtnSinavlar);
            this.rpgSinavlar.ItemLinks.Add(this.barBtnSinavOlustur);
            this.rpgSinavlar.Name = "rpgSinavlar";
            this.rpgSinavlar.Text = "Sınav İşlemleri";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 799);
            this.Controls.Add(this.rbControlMain);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmMain.IconOptions.LargeImage")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.rbControlMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dinamik Test Formu";
            ((System.ComponentModel.ISupportInitialize)(this.rbControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbControlMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAnaMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDers;
        private DevExpress.XtraBars.BarButtonItem barBtnDersler;
        private DevExpress.XtraBars.BarButtonItem barBtnDersEkle;
        private DevExpress.XtraBars.BarButtonItem barBtnSorular;
        private DevExpress.XtraBars.BarButtonItem barBtnSoruEkle;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSorular;
        private DevExpress.XtraBars.BarButtonItem barBtnSinavlar;
        private DevExpress.XtraBars.BarButtonItem barBtnSinavOlustur;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSinavlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

