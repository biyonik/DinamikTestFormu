
namespace DinamikTestFormu.WinUI.Forms.Sorular
{
    partial class FrmGorselEditoru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGorselEditoru));
            this.panelUstMenu = new DevExpress.XtraEditors.PanelControl();
            this.btnAc = new DevExpress.XtraEditors.SimpleButton();
            this.btnCevir = new DevExpress.XtraEditors.SimpleButton();
            this.btnAktar = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ztbZoomPercent = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.spinZoomPercent = new DevExpress.XtraEditors.SpinEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblCropArea = new DevExpress.XtraEditors.LabelControl();
            this.pctMain = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUstMenu)).BeginInit();
            this.panelUstMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ztbZoomPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbZoomPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinZoomPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMain.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUstMenu
            // 
            this.panelUstMenu.Controls.Add(this.spinZoomPercent);
            this.panelUstMenu.Controls.Add(this.ztbZoomPercent);
            this.panelUstMenu.Controls.Add(this.btnKapat);
            this.panelUstMenu.Controls.Add(this.btnAktar);
            this.panelUstMenu.Controls.Add(this.btnCevir);
            this.panelUstMenu.Controls.Add(this.btnAc);
            this.panelUstMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUstMenu.Location = new System.Drawing.Point(0, 0);
            this.panelUstMenu.Name = "panelUstMenu";
            this.panelUstMenu.Size = new System.Drawing.Size(1278, 68);
            this.panelUstMenu.TabIndex = 0;
            // 
            // btnAc
            // 
            this.btnAc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAc.ImageOptions.Image")));
            this.btnAc.Location = new System.Drawing.Point(2, 2);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(106, 64);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "Aç";
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnCevir
            // 
            this.btnCevir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCevir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCevir.ImageOptions.Image")));
            this.btnCevir.Location = new System.Drawing.Point(108, 2);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(106, 64);
            this.btnCevir.TabIndex = 0;
            this.btnCevir.Text = "Çevir";
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // btnAktar
            // 
            this.btnAktar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAktar.ImageOptions.Image")));
            this.btnAktar.Location = new System.Drawing.Point(214, 2);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(106, 64);
            this.btnAktar.TabIndex = 1;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(1184, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(92, 64);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ztbZoomPercent
            // 
            this.ztbZoomPercent.EditValue = 100;
            this.ztbZoomPercent.Location = new System.Drawing.Point(426, 26);
            this.ztbZoomPercent.Name = "ztbZoomPercent";
            this.ztbZoomPercent.Properties.Maximum = 500;
            this.ztbZoomPercent.Properties.SmallChangeUseMode = DevExpress.XtraEditors.Repository.SmallChangeUseMode.ArrowKeysAndMouse;
            this.ztbZoomPercent.Size = new System.Drawing.Size(517, 16);
            this.ztbZoomPercent.TabIndex = 3;
            this.ztbZoomPercent.Value = 100;
            this.ztbZoomPercent.ValueChanged += new System.EventHandler(this.ztbZoomPercent_ValueChanged);
            // 
            // spinZoomPercent
            // 
            this.spinZoomPercent.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinZoomPercent.Location = new System.Drawing.Point(964, 24);
            this.spinZoomPercent.Name = "spinZoomPercent";
            this.spinZoomPercent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinZoomPercent.Properties.MaxValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinZoomPercent.Size = new System.Drawing.Size(116, 20);
            this.spinZoomPercent.TabIndex = 4;
            this.spinZoomPercent.EditValueChanged += new System.EventHandler(this.spinZoomPercent_EditValueChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblCropArea);
            this.panelControl1.Controls.Add(this.pctMain);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 68);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1278, 540);
            this.panelControl1.TabIndex = 1;
            // 
            // lblCropArea
            // 
            this.lblCropArea.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblCropArea.Appearance.Options.UseBackColor = true;
            this.lblCropArea.Appearance.Options.UseTextOptions = true;
            this.lblCropArea.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCropArea.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblCropArea.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCropArea.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.lblCropArea.Location = new System.Drawing.Point(12, 6);
            this.lblCropArea.Name = "lblCropArea";
            this.lblCropArea.Size = new System.Drawing.Size(300, 200);
            this.lblCropArea.TabIndex = 4;
            this.lblCropArea.Text = "300x200\r\nLütfen kesmek istediğiniz bölümü çerçeve içine yerleştiriniz";
            // 
            // pctMain
            // 
            this.pctMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctMain.Location = new System.Drawing.Point(2, 2);
            this.pctMain.Name = "pctMain";
            this.pctMain.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            this.pctMain.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            this.pctMain.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pctMain.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pctMain.Properties.ShowEditMenuItem = DevExpress.Utils.DefaultBoolean.False;
            this.pctMain.Properties.ShowMenu = false;
            this.pctMain.Properties.ZoomingOperationMode = DevExpress.XtraEditors.Repository.ZoomingOperationMode.MouseWheel;
            this.pctMain.Size = new System.Drawing.Size(1274, 536);
            this.pctMain.TabIndex = 3;
            this.pctMain.ZoomPercentChanged += new System.EventHandler(this.pctMain_ZoomPercentChanged);
            // 
            // FrmGorselEditoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 608);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelUstMenu);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGorselEditoru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soru Görsel Editörü";
            ((System.ComponentModel.ISupportInitialize)(this.panelUstMenu)).EndInit();
            this.panelUstMenu.ResumeLayout(false);
            this.panelUstMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ztbZoomPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbZoomPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinZoomPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctMain.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelUstMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAktar;
        private DevExpress.XtraEditors.SimpleButton btnCevir;
        private DevExpress.XtraEditors.SimpleButton btnAc;
        private DevExpress.XtraEditors.SpinEdit spinZoomPercent;
        private DevExpress.XtraEditors.ZoomTrackBarControl ztbZoomPercent;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblCropArea;
        private DevExpress.XtraEditors.PictureEdit pctMain;
    }
}