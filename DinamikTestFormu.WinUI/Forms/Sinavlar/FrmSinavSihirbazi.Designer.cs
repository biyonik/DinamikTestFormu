
namespace DinamikTestFormu.WinUI.Forms.Sinavlar
{
    partial class FrmSinavSihirbazi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinavSihirbazi));
            this.grpAltMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnIlkSoru = new DevExpress.XtraEditors.SimpleButton();
            this.btnOncekiSoru = new DevExpress.XtraEditors.SimpleButton();
            this.btnSonSoru = new DevExpress.XtraEditors.SimpleButton();
            this.btnSonrakiSoru = new DevExpress.XtraEditors.SimpleButton();
            this.panelSoruAlani = new System.Windows.Forms.Panel();
            this.panelSecenekAlani = new System.Windows.Forms.Panel();
            this.pctSoruGorseli = new DevExpress.XtraEditors.PictureEdit();
            this.lblSoruMetni = new DevExpress.XtraEditors.LabelControl();
            this.lblToplamSoruSayisi = new DevExpress.XtraEditors.LabelControl();
            this.groupSoruSecenekleri = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpAltMenu)).BeginInit();
            this.grpAltMenu.SuspendLayout();
            this.panelSoruAlani.SuspendLayout();
            this.panelSecenekAlani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSoruGorseli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSoruSecenekleri)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAltMenu
            // 
            this.grpAltMenu.Controls.Add(this.lblToplamSoruSayisi);
            this.grpAltMenu.Controls.Add(this.btnSonrakiSoru);
            this.grpAltMenu.Controls.Add(this.btnSonSoru);
            this.grpAltMenu.Controls.Add(this.btnOncekiSoru);
            this.grpAltMenu.Controls.Add(this.btnIlkSoru);
            this.grpAltMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpAltMenu.Location = new System.Drawing.Point(0, 529);
            this.grpAltMenu.Name = "grpAltMenu";
            this.grpAltMenu.Size = new System.Drawing.Size(638, 79);
            this.grpAltMenu.TabIndex = 0;
            this.grpAltMenu.Text = "Menü";
            // 
            // btnIlkSoru
            // 
            this.btnIlkSoru.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIlkSoru.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIlkSoru.ImageOptions.SvgImage")));
            this.btnIlkSoru.Location = new System.Drawing.Point(2, 23);
            this.btnIlkSoru.Name = "btnIlkSoru";
            this.btnIlkSoru.Size = new System.Drawing.Size(120, 54);
            this.btnIlkSoru.TabIndex = 0;
            this.btnIlkSoru.Text = "İlk Soru";
            this.btnIlkSoru.Click += new System.EventHandler(this.btnIlkSoru_Click);
            // 
            // btnOncekiSoru
            // 
            this.btnOncekiSoru.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOncekiSoru.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOncekiSoru.ImageOptions.SvgImage")));
            this.btnOncekiSoru.Location = new System.Drawing.Point(122, 23);
            this.btnOncekiSoru.Name = "btnOncekiSoru";
            this.btnOncekiSoru.Size = new System.Drawing.Size(120, 54);
            this.btnOncekiSoru.TabIndex = 1;
            this.btnOncekiSoru.Text = "Önceki Soru";
            this.btnOncekiSoru.Click += new System.EventHandler(this.btnOncekiSoru_Click);
            // 
            // btnSonSoru
            // 
            this.btnSonSoru.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSonSoru.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSonSoru.ImageOptions.SvgImage")));
            this.btnSonSoru.Location = new System.Drawing.Point(516, 23);
            this.btnSonSoru.Name = "btnSonSoru";
            this.btnSonSoru.Size = new System.Drawing.Size(120, 54);
            this.btnSonSoru.TabIndex = 2;
            this.btnSonSoru.Text = "Son Soru";
            this.btnSonSoru.Click += new System.EventHandler(this.btnSonSoru_Click);
            // 
            // btnSonrakiSoru
            // 
            this.btnSonrakiSoru.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSonrakiSoru.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSonrakiSoru.ImageOptions.SvgImage")));
            this.btnSonrakiSoru.Location = new System.Drawing.Point(396, 23);
            this.btnSonrakiSoru.Name = "btnSonrakiSoru";
            this.btnSonrakiSoru.Size = new System.Drawing.Size(120, 54);
            this.btnSonrakiSoru.TabIndex = 3;
            this.btnSonrakiSoru.Text = "Sonraki Soru";
            this.btnSonrakiSoru.Click += new System.EventHandler(this.btnSonrakiSoru_Click);
            // 
            // panelSoruAlani
            // 
            this.panelSoruAlani.Controls.Add(this.lblSoruMetni);
            this.panelSoruAlani.Controls.Add(this.pctSoruGorseli);
            this.panelSoruAlani.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSoruAlani.Location = new System.Drawing.Point(0, 0);
            this.panelSoruAlani.Name = "panelSoruAlani";
            this.panelSoruAlani.Size = new System.Drawing.Size(638, 326);
            this.panelSoruAlani.TabIndex = 1;
            // 
            // panelSecenekAlani
            // 
            this.panelSecenekAlani.Controls.Add(this.groupSoruSecenekleri);
            this.panelSecenekAlani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSecenekAlani.Location = new System.Drawing.Point(0, 326);
            this.panelSecenekAlani.Name = "panelSecenekAlani";
            this.panelSecenekAlani.Size = new System.Drawing.Size(638, 203);
            this.panelSecenekAlani.TabIndex = 2;
            // 
            // pctSoruGorseli
            // 
            this.pctSoruGorseli.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctSoruGorseli.Location = new System.Drawing.Point(0, 0);
            this.pctSoruGorseli.Name = "pctSoruGorseli";
            this.pctSoruGorseli.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.pctSoruGorseli.Properties.ShowEditMenuItem = DevExpress.Utils.DefaultBoolean.False;
            this.pctSoruGorseli.Properties.ShowMenu = false;
            this.pctSoruGorseli.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pctSoruGorseli.Size = new System.Drawing.Size(638, 156);
            this.pctSoruGorseli.TabIndex = 0;
            // 
            // lblSoruMetni
            // 
            this.lblSoruMetni.Appearance.Options.UseTextOptions = true;
            this.lblSoruMetni.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblSoruMetni.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblSoruMetni.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSoruMetni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoruMetni.Location = new System.Drawing.Point(0, 156);
            this.lblSoruMetni.Name = "lblSoruMetni";
            this.lblSoruMetni.Size = new System.Drawing.Size(638, 170);
            this.lblSoruMetni.TabIndex = 1;
            // 
            // lblToplamSoruSayisi
            // 
            this.lblToplamSoruSayisi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblToplamSoruSayisi.Location = new System.Drawing.Point(248, 43);
            this.lblToplamSoruSayisi.Name = "lblToplamSoruSayisi";
            this.lblToplamSoruSayisi.Size = new System.Drawing.Size(142, 24);
            this.lblToplamSoruSayisi.TabIndex = 4;
            // 
            // groupSoruSecenekleri
            // 
            this.groupSoruSecenekleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSoruSecenekleri.Location = new System.Drawing.Point(0, 0);
            this.groupSoruSecenekleri.Name = "groupSoruSecenekleri";
            this.groupSoruSecenekleri.Size = new System.Drawing.Size(638, 203);
            this.groupSoruSecenekleri.TabIndex = 0;
            this.groupSoruSecenekleri.Text = "Soru Seçenekleri";
            // 
            // FrmSinavSihirbazi
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.BackColor2 = System.Drawing.Color.Gainsboro;
            this.Appearance.BorderColor = System.Drawing.Color.DimGray;
            this.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 608);
            this.Controls.Add(this.panelSecenekAlani);
            this.Controls.Add(this.panelSoruAlani);
            this.Controls.Add(this.grpAltMenu);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSinavSihirbazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav Sihirbazı";
            ((System.ComponentModel.ISupportInitialize)(this.grpAltMenu)).EndInit();
            this.grpAltMenu.ResumeLayout(false);
            this.panelSoruAlani.ResumeLayout(false);
            this.panelSecenekAlani.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctSoruGorseli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSoruSecenekleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpAltMenu;
        private DevExpress.XtraEditors.SimpleButton btnSonrakiSoru;
        private DevExpress.XtraEditors.SimpleButton btnSonSoru;
        private DevExpress.XtraEditors.SimpleButton btnOncekiSoru;
        private DevExpress.XtraEditors.SimpleButton btnIlkSoru;
        private System.Windows.Forms.Panel panelSoruAlani;
        private DevExpress.XtraEditors.LabelControl lblSoruMetni;
        private DevExpress.XtraEditors.PictureEdit pctSoruGorseli;
        private System.Windows.Forms.Panel panelSecenekAlani;
        private DevExpress.XtraEditors.LabelControl lblToplamSoruSayisi;
        private DevExpress.XtraEditors.GroupControl groupSoruSecenekleri;
    }
}