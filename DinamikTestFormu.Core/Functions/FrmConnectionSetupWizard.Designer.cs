
namespace DinamikTestFormu.Core.Functions
{
    partial class FrmConnectionSetupWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnectionSetupWizard));
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAyarlariKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnBaglantiyiTestEt = new DevExpress.XtraEditors.SimpleButton();
            this.tbxPassword = new DevExpress.XtraEditors.TextEdit();
            this.tbxUser = new DevExpress.XtraEditors.TextEdit();
            this.tbxServer = new DevExpress.XtraEditors.TextEdit();
            this.cbxSqlAuth = new DevExpress.XtraEditors.CheckButton();
            this.cbxWinAuth = new DevExpress.XtraEditors.CheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxServer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(411, 372);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(215, 50);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAyarlariKaydet
            // 
            this.btnAyarlariKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlariKaydet.ImageOptions.Image")));
            this.btnAyarlariKaydet.Location = new System.Drawing.Point(200, 372);
            this.btnAyarlariKaydet.Name = "btnAyarlariKaydet";
            this.btnAyarlariKaydet.Size = new System.Drawing.Size(205, 50);
            this.btnAyarlariKaydet.TabIndex = 10;
            this.btnAyarlariKaydet.Text = "Ayarları Kaydet";
            this.btnAyarlariKaydet.Click += new System.EventHandler(this.btnAyarlariKaydet_Click);
            // 
            // btnBaglantiyiTestEt
            // 
            this.btnBaglantiyiTestEt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaglantiyiTestEt.ImageOptions.Image")));
            this.btnBaglantiyiTestEt.Location = new System.Drawing.Point(12, 372);
            this.btnBaglantiyiTestEt.Name = "btnBaglantiyiTestEt";
            this.btnBaglantiyiTestEt.Size = new System.Drawing.Size(182, 50);
            this.btnBaglantiyiTestEt.TabIndex = 11;
            this.btnBaglantiyiTestEt.Text = "Bağlantıyı Test Et";
            this.btnBaglantiyiTestEt.Click += new System.EventHandler(this.btnBaglantiyiTestEt_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Enabled = false;
            this.tbxPassword.Location = new System.Drawing.Point(12, 330);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword.Properties.Appearance.Options.UseFont = true;
            this.tbxPassword.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tbxPassword.Properties.ContextImageOptions.SvgImage")));
            this.tbxPassword.Size = new System.Drawing.Size(614, 36);
            this.tbxPassword.TabIndex = 6;
            // 
            // tbxUser
            // 
            this.tbxUser.Enabled = false;
            this.tbxUser.Location = new System.Drawing.Point(12, 291);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUser.Properties.Appearance.Options.UseFont = true;
            this.tbxUser.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tbxUser.Properties.ContextImageOptions.SvgImage")));
            this.tbxUser.Size = new System.Drawing.Size(614, 36);
            this.tbxUser.TabIndex = 7;
            // 
            // tbxServer
            // 
            this.tbxServer.EditValue = ".\\SQLEXPRESS";
            this.tbxServer.Location = new System.Drawing.Point(12, 253);
            this.tbxServer.Name = "tbxServer";
            this.tbxServer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxServer.Properties.Appearance.Options.UseFont = true;
            this.tbxServer.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tbxServer.Properties.ContextImageOptions.SvgImage")));
            this.tbxServer.Size = new System.Drawing.Size(614, 36);
            this.tbxServer.TabIndex = 8;
            // 
            // cbxSqlAuth
            // 
            this.cbxSqlAuth.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxSqlAuth.Appearance.Options.UseFont = true;
            this.cbxSqlAuth.GroupIndex = 1;
            this.cbxSqlAuth.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cbxSqlAuth.ImageOptions.Image")));
            this.cbxSqlAuth.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cbxSqlAuth.Location = new System.Drawing.Point(326, 12);
            this.cbxSqlAuth.Name = "cbxSqlAuth";
            this.cbxSqlAuth.Size = new System.Drawing.Size(300, 235);
            this.cbxSqlAuth.TabIndex = 4;
            this.cbxSqlAuth.TabStop = false;
            this.cbxSqlAuth.Text = "SQL Server Oturumu";
            this.cbxSqlAuth.CheckedChanged += new System.EventHandler(this.cbxSqlAuth_CheckedChanged);
            // 
            // cbxWinAuth
            // 
            this.cbxWinAuth.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxWinAuth.Appearance.Options.UseFont = true;
            this.cbxWinAuth.Checked = true;
            this.cbxWinAuth.GroupIndex = 1;
            this.cbxWinAuth.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cbxWinAuth.ImageOptions.Image")));
            this.cbxWinAuth.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cbxWinAuth.Location = new System.Drawing.Point(12, 12);
            this.cbxWinAuth.Name = "cbxWinAuth";
            this.cbxWinAuth.Size = new System.Drawing.Size(308, 235);
            this.cbxWinAuth.TabIndex = 5;
            this.cbxWinAuth.Text = "Windows Oturumu";
            // 
            // FrmConnectionSetupWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 448);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnAyarlariKaydet);
            this.Controls.Add(this.btnBaglantiyiTestEt);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.tbxServer);
            this.Controls.Add(this.cbxSqlAuth);
            this.Controls.Add(this.cbxWinAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConnectionSetupWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı Bağlantı Sihirbazı";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tbxPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxServer.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAyarlariKaydet;
        private DevExpress.XtraEditors.SimpleButton btnBaglantiyiTestEt;
        private DevExpress.XtraEditors.TextEdit tbxPassword;
        private DevExpress.XtraEditors.TextEdit tbxUser;
        private DevExpress.XtraEditors.TextEdit tbxServer;
        private DevExpress.XtraEditors.CheckButton cbxSqlAuth;
        private DevExpress.XtraEditors.CheckButton cbxWinAuth;
    }
}