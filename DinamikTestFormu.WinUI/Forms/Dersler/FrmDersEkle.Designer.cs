
namespace DinamikTestFormu.WinUI.Forms.Dersler
{
    partial class FrmDersEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDersEkle));
            this.lblDersAdi = new DevExpress.XtraEditors.LabelControl();
            this.tbxDersAdi = new DevExpress.XtraEditors.TextEdit();
            this.btnDersKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnDersKayitVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbxDersAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.Location = new System.Drawing.Point(12, 34);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(40, 13);
            this.lblDersAdi.TabIndex = 0;
            this.lblDersAdi.Text = "Ders Adı";
            // 
            // tbxDersAdi
            // 
            this.tbxDersAdi.Location = new System.Drawing.Point(97, 31);
            this.tbxDersAdi.Name = "tbxDersAdi";
            this.tbxDersAdi.Size = new System.Drawing.Size(302, 20);
            this.tbxDersAdi.TabIndex = 1;
            // 
            // btnDersKaydet
            // 
            this.btnDersKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDersKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDersKaydet.ImageOptions.Image")));
            this.btnDersKaydet.Location = new System.Drawing.Point(2, 23);
            this.btnDersKaydet.Name = "btnDersKaydet";
            this.btnDersKaydet.Size = new System.Drawing.Size(114, 47);
            this.btnDersKaydet.TabIndex = 2;
            this.btnDersKaydet.Text = "Kaydet";
            this.btnDersKaydet.Click += new System.EventHandler(this.btnDersKaydet_Click);
            // 
            // btnDersKayitVazgec
            // 
            this.btnDersKayitVazgec.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDersKayitVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDersKayitVazgec.ImageOptions.Image")));
            this.btnDersKayitVazgec.Location = new System.Drawing.Point(295, 23);
            this.btnDersKayitVazgec.Name = "btnDersKayitVazgec";
            this.btnDersKayitVazgec.Size = new System.Drawing.Size(114, 47);
            this.btnDersKayitVazgec.TabIndex = 2;
            this.btnDersKayitVazgec.Text = "Vazgeç";
            this.btnDersKayitVazgec.Click += new System.EventHandler(this.btnDersKayitVazgec_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnDersKayitVazgec);
            this.groupControl1.Controls.Add(this.btnDersKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 87);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(411, 72);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Menü";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmDersEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 159);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tbxDersAdi);
            this.Controls.Add(this.lblDersAdi);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "Office 2019 Dark Gray";
            this.LookAndFeel.UseWindowsXPTheme = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDersEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ders Ekleme Formu";
            ((System.ComponentModel.ISupportInitialize)(this.tbxDersAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDersAdi;
        private DevExpress.XtraEditors.TextEdit tbxDersAdi;
        private DevExpress.XtraEditors.SimpleButton btnDersKaydet;
        private DevExpress.XtraEditors.SimpleButton btnDersKayitVazgec;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
    }
}