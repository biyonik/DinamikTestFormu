
namespace DinamikTestFormu.WinUI.Forms.Sinavlar
{
    partial class FrmSinavOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinavOlustur));
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.lblSorular = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnPdfOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.btnFormOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.panelGridSorular = new System.Windows.Forms.Panel();
            this.gridControlSoruListesi = new DevExpress.XtraGrid.GridControl();
            this.winExplorerViewSorular = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDersAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoruGorsel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMetin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelAraMenu = new System.Windows.Forms.Panel();
            this.btnTumSorulariCikar = new DevExpress.XtraEditors.SimpleButton();
            this.btnTumunuAktar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSeciliSoruyuCikar = new DevExpress.XtraEditors.SimpleButton();
            this.btnListeyeAktar = new DevExpress.XtraEditors.SimpleButton();
            this.panelSoruListesi = new System.Windows.Forms.Panel();
            this.lstSecilenSorular = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.panelGridSorular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSoruListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerViewSorular)).BeginInit();
            this.panelAraMenu.SuspendLayout();
            this.panelSoruListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstSecilenSorular)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // lblSorular
            // 
            this.lblSorular.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSorular.Appearance.Options.UseFont = true;
            this.lblSorular.Appearance.Options.UseTextOptions = true;
            this.lblSorular.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSorular.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblSorular.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSorular.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblSorular.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSorular.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSorular.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblSorular.ImageOptions.Image")));
            this.lblSorular.Location = new System.Drawing.Point(0, 0);
            this.lblSorular.Name = "lblSorular";
            this.lblSorular.Size = new System.Drawing.Size(1278, 69);
            this.lblSorular.TabIndex = 5;
            this.lblSorular.Text = "Sınav Oluşturma Formu";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnPdfOlustur);
            this.grpMenu.Controls.Add(this.btnFormOlustur);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 687);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1278, 81);
            this.grpMenu.TabIndex = 6;
            this.grpMenu.Text = "Menü";
            // 
            // btnPdfOlustur
            // 
            this.btnPdfOlustur.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPdfOlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPdfOlustur.ImageOptions.Image")));
            this.btnPdfOlustur.Location = new System.Drawing.Point(1070, 23);
            this.btnPdfOlustur.Name = "btnPdfOlustur";
            this.btnPdfOlustur.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPdfOlustur.Size = new System.Drawing.Size(103, 56);
            this.btnPdfOlustur.TabIndex = 0;
            this.btnPdfOlustur.Text = "PDF Oluştur";
            // 
            // btnFormOlustur
            // 
            this.btnFormOlustur.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFormOlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFormOlustur.ImageOptions.Image")));
            this.btnFormOlustur.Location = new System.Drawing.Point(1173, 23);
            this.btnFormOlustur.Name = "btnFormOlustur";
            this.btnFormOlustur.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnFormOlustur.Size = new System.Drawing.Size(103, 56);
            this.btnFormOlustur.TabIndex = 0;
            this.btnFormOlustur.Text = "Form Oluştur";
            this.btnFormOlustur.Click += new System.EventHandler(this.btnFormOlustur_Click);
            // 
            // panelGridSorular
            // 
            this.panelGridSorular.Controls.Add(this.gridControlSoruListesi);
            this.panelGridSorular.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGridSorular.Location = new System.Drawing.Point(0, 69);
            this.panelGridSorular.Name = "panelGridSorular";
            this.panelGridSorular.Size = new System.Drawing.Size(798, 618);
            this.panelGridSorular.TabIndex = 7;
            // 
            // gridControlSoruListesi
            // 
            this.gridControlSoruListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSoruListesi.EmbeddedNavigator.ShowToolTips = false;
            this.gridControlSoruListesi.Location = new System.Drawing.Point(0, 0);
            this.gridControlSoruListesi.MainView = this.winExplorerViewSorular;
            this.gridControlSoruListesi.Name = "gridControlSoruListesi";
            this.gridControlSoruListesi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControlSoruListesi.Size = new System.Drawing.Size(798, 618);
            this.gridControlSoruListesi.TabIndex = 0;
            this.gridControlSoruListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerViewSorular});
            // 
            // winExplorerViewSorular
            // 
            this.winExplorerViewSorular.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.winExplorerViewSorular.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.winExplorerViewSorular.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.winExplorerViewSorular.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.winExplorerViewSorular.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.winExplorerViewSorular.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.winExplorerViewSorular.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.winExplorerViewSorular.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.winExplorerViewSorular.Appearance.FilterPanel.Options.UseBackColor = true;
            this.winExplorerViewSorular.Appearance.FilterPanel.Options.UseForeColor = true;
            this.winExplorerViewSorular.Appearance.ItemHovered.BackColor = System.Drawing.Color.MistyRose;
            this.winExplorerViewSorular.Appearance.ItemHovered.BackColor2 = System.Drawing.Color.SandyBrown;
            this.winExplorerViewSorular.Appearance.ItemHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.winExplorerViewSorular.Appearance.ItemHovered.Options.UseBackColor = true;
            this.winExplorerViewSorular.Appearance.ItemHovered.Options.UseFont = true;
            this.winExplorerViewSorular.Appearance.ItemSelected.BackColor = System.Drawing.Color.MistyRose;
            this.winExplorerViewSorular.Appearance.ItemSelected.BackColor2 = System.Drawing.Color.SandyBrown;
            this.winExplorerViewSorular.Appearance.ItemSelected.BorderColor = System.Drawing.Color.Chocolate;
            this.winExplorerViewSorular.Appearance.ItemSelected.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.winExplorerViewSorular.Appearance.ItemSelected.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.winExplorerViewSorular.Appearance.ItemSelected.Options.UseBackColor = true;
            this.winExplorerViewSorular.Appearance.ItemSelected.Options.UseBorderColor = true;
            this.winExplorerViewSorular.Appearance.ItemSelected.Options.UseFont = true;
            this.winExplorerViewSorular.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.colDersAdi,
            this.colSoruGorsel,
            this.colMetin});
            this.winExplorerViewSorular.ColumnSet.CheckBoxColumn = this.Id;
            this.winExplorerViewSorular.ColumnSet.ExtraLargeImageColumn = this.colSoruGorsel;
            this.winExplorerViewSorular.ColumnSet.GroupColumn = this.colDersAdi;
            this.winExplorerViewSorular.ColumnSet.TextColumn = this.colMetin;
            this.winExplorerViewSorular.GridControl = this.gridControlSoruListesi;
            this.winExplorerViewSorular.GroupCount = 1;
            this.winExplorerViewSorular.Name = "winExplorerViewSorular";
            this.winExplorerViewSorular.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.winExplorerViewSorular.OptionsView.ItemHoverBordersShowMode = DevExpress.XtraGrid.WinExplorer.ItemHoverBordersShowMode.Always;
            this.winExplorerViewSorular.OptionsView.ShowViewCaption = true;
            this.winExplorerViewSorular.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.ExtraLarge;
            this.winExplorerViewSorular.PaintStyleName = "Win8";
            this.winExplorerViewSorular.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDersAdi, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 1;
            // 
            // colDersAdi
            // 
            this.colDersAdi.Caption = "Ders";
            this.colDersAdi.FieldName = "Ders.Adi";
            this.colDersAdi.Name = "colDersAdi";
            this.colDersAdi.Visible = true;
            this.colDersAdi.VisibleIndex = 0;
            // 
            // colSoruGorsel
            // 
            this.colSoruGorsel.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colSoruGorsel.FieldName = "Gorsel";
            this.colSoruGorsel.Name = "colSoruGorsel";
            this.colSoruGorsel.OptionsColumn.AllowEdit = false;
            this.colSoruGorsel.Visible = true;
            this.colSoruGorsel.VisibleIndex = 1;
            // 
            // colMetin
            // 
            this.colMetin.Caption = "Metin";
            this.colMetin.FieldName = "Metin";
            this.colMetin.Name = "colMetin";
            this.colMetin.Visible = true;
            this.colMetin.VisibleIndex = 0;
            // 
            // panelAraMenu
            // 
            this.panelAraMenu.Controls.Add(this.btnTumSorulariCikar);
            this.panelAraMenu.Controls.Add(this.btnTumunuAktar);
            this.panelAraMenu.Controls.Add(this.btnSeciliSoruyuCikar);
            this.panelAraMenu.Controls.Add(this.btnListeyeAktar);
            this.panelAraMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAraMenu.Location = new System.Drawing.Point(798, 69);
            this.panelAraMenu.Name = "panelAraMenu";
            this.panelAraMenu.Size = new System.Drawing.Size(107, 618);
            this.panelAraMenu.TabIndex = 8;
            // 
            // btnTumSorulariCikar
            // 
            this.btnTumSorulariCikar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumSorulariCikar.Appearance.Options.UseFont = true;
            this.btnTumSorulariCikar.Location = new System.Drawing.Point(6, 300);
            this.btnTumSorulariCikar.Name = "btnTumSorulariCikar";
            this.btnTumSorulariCikar.Size = new System.Drawing.Size(95, 30);
            this.btnTumSorulariCikar.TabIndex = 0;
            this.btnTumSorulariCikar.Text = "<<";
            this.btnTumSorulariCikar.ToolTip = "Tüm Soruları Çıkar";
            // 
            // btnTumunuAktar
            // 
            this.btnTumunuAktar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumunuAktar.Appearance.Options.UseFont = true;
            this.btnTumunuAktar.Location = new System.Drawing.Point(6, 228);
            this.btnTumunuAktar.Name = "btnTumunuAktar";
            this.btnTumunuAktar.Size = new System.Drawing.Size(95, 30);
            this.btnTumunuAktar.TabIndex = 0;
            this.btnTumunuAktar.Text = ">>";
            this.btnTumunuAktar.ToolTip = "Tüm Soruları Aktar";
            // 
            // btnSeciliSoruyuCikar
            // 
            this.btnSeciliSoruyuCikar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeciliSoruyuCikar.Appearance.Options.UseFont = true;
            this.btnSeciliSoruyuCikar.Location = new System.Drawing.Point(6, 264);
            this.btnSeciliSoruyuCikar.Name = "btnSeciliSoruyuCikar";
            this.btnSeciliSoruyuCikar.Size = new System.Drawing.Size(95, 30);
            this.btnSeciliSoruyuCikar.TabIndex = 0;
            this.btnSeciliSoruyuCikar.Text = "<";
            this.btnSeciliSoruyuCikar.ToolTip = "Seçili Soruyu Çıkar";
            // 
            // btnListeyeAktar
            // 
            this.btnListeyeAktar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeyeAktar.Appearance.Options.UseFont = true;
            this.btnListeyeAktar.Location = new System.Drawing.Point(6, 192);
            this.btnListeyeAktar.Name = "btnListeyeAktar";
            this.btnListeyeAktar.Size = new System.Drawing.Size(95, 30);
            this.btnListeyeAktar.TabIndex = 0;
            this.btnListeyeAktar.Text = ">";
            this.btnListeyeAktar.ToolTip = "Seçili Soruyu Aktar";
            this.btnListeyeAktar.Click += new System.EventHandler(this.btnListeyeAktar_Click);
            // 
            // panelSoruListesi
            // 
            this.panelSoruListesi.Controls.Add(this.lstSecilenSorular);
            this.panelSoruListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSoruListesi.Location = new System.Drawing.Point(905, 69);
            this.panelSoruListesi.Name = "panelSoruListesi";
            this.panelSoruListesi.Size = new System.Drawing.Size(373, 618);
            this.panelSoruListesi.TabIndex = 9;
            // 
            // lstSecilenSorular
            // 
            this.lstSecilenSorular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSecilenSorular.HorizontalScrollbar = true;
            this.lstSecilenSorular.Location = new System.Drawing.Point(0, 0);
            this.lstSecilenSorular.Name = "lstSecilenSorular";
            this.lstSecilenSorular.Size = new System.Drawing.Size(373, 618);
            this.lstSecilenSorular.TabIndex = 0;
            // 
            // FrmSinavOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 768);
            this.Controls.Add(this.panelSoruListesi);
            this.Controls.Add(this.panelAraMenu);
            this.Controls.Add(this.panelGridSorular);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblSorular);
            this.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSinavOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav Oluşturma Formu";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.panelGridSorular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSoruListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerViewSorular)).EndInit();
            this.panelAraMenu.ResumeLayout(false);
            this.panelSoruListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstSecilenSorular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblSorular;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnPdfOlustur;
        private DevExpress.XtraEditors.SimpleButton btnFormOlustur;
        private System.Windows.Forms.Panel panelGridSorular;
        private DevExpress.XtraGrid.GridControl gridControlSoruListesi;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.Panel panelAraMenu;
        private DevExpress.XtraEditors.SimpleButton btnTumSorulariCikar;
        private DevExpress.XtraEditors.SimpleButton btnTumunuAktar;
        private DevExpress.XtraEditors.SimpleButton btnSeciliSoruyuCikar;
        private DevExpress.XtraEditors.SimpleButton btnListeyeAktar;
        private System.Windows.Forms.Panel panelSoruListesi;
        private DevExpress.XtraEditors.ListBoxControl lstSecilenSorular;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerViewSorular;
        private DevExpress.XtraGrid.Columns.GridColumn colDersAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoruGorsel;
        private DevExpress.XtraGrid.Columns.GridColumn colMetin;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
    }
}