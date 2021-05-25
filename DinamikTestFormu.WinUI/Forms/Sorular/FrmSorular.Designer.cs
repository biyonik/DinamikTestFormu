
namespace DinamikTestFormu.WinUI.Forms.Sorular
{
    partial class FrmSorular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSorular));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.sorularAnaMenuAlt = new DinamikTestFormu.UserControls.AnaMenuAlt();
            this.lblSorular = new DevExpress.XtraEditors.LabelControl();
            this.gridControlSorular = new DevExpress.XtraGrid.GridControl();
            this.gridViewSorular = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorsel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPctSoruGorsel = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colMetin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoruGorselEkleButton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribGorselEkle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSorular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSorular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colPctSoruGorsel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribGorselEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.sorularAnaMenuAlt);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 500);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1033, 123);
            this.grpMenu.TabIndex = 5;
            this.grpMenu.Text = "Menü";
            // 
            // sorularAnaMenuAlt
            // 
            this.sorularAnaMenuAlt.ButtonFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.sorularAnaMenuAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sorularAnaMenuAlt.Location = new System.Drawing.Point(2, 23);
            this.sorularAnaMenuAlt.Name = "sorularAnaMenuAlt";
            this.sorularAnaMenuAlt.Size = new System.Drawing.Size(1029, 98);
            this.sorularAnaMenuAlt.TabIndex = 0;
            this.sorularAnaMenuAlt.ButtonAdd += new System.EventHandler(this.sorularAnaMenuAlt_ButtonAdd);
            this.sorularAnaMenuAlt.ButtonEdit += new System.EventHandler(this.sorularAnaMenuAlt_ButtonEdit);
            this.sorularAnaMenuAlt.ButtonDelete += new System.EventHandler(this.sorularAnaMenuAlt_ButtonDelete);
            this.sorularAnaMenuAlt.ButtonUpdate += new System.EventHandler(this.sorularAnaMenuAlt_ButtonUpdate);
            this.sorularAnaMenuAlt.ButtonClose += new System.EventHandler(this.sorularAnaMenuAlt_ButtonClose);
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
            this.lblSorular.Size = new System.Drawing.Size(1033, 69);
            this.lblSorular.TabIndex = 4;
            this.lblSorular.Text = "Sorular";
            // 
            // gridControlSorular
            // 
            this.gridControlSorular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSorular.Location = new System.Drawing.Point(0, 69);
            this.gridControlSorular.MainView = this.gridViewSorular;
            this.gridControlSorular.Name = "gridControlSorular";
            this.gridControlSorular.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colPctSoruGorsel,
            this.ribGorselEkle});
            this.gridControlSorular.Size = new System.Drawing.Size(1033, 431);
            this.gridControlSorular.TabIndex = 6;
            this.gridControlSorular.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSorular});
            // 
            // gridViewSorular
            // 
            this.gridViewSorular.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDers,
            this.colGorsel,
            this.colMetin,
            this.colSoruGorselEkleButton});
            this.gridViewSorular.GridControl = this.gridControlSorular;
            this.gridViewSorular.Name = "gridViewSorular";
            this.gridViewSorular.RowHeight = 150;
            // 
            // colDers
            // 
            this.colDers.Caption = "Ders";
            this.colDers.FieldName = "Ders.Adi";
            this.colDers.Name = "colDers";
            this.colDers.OptionsColumn.AllowEdit = false;
            this.colDers.Visible = true;
            this.colDers.VisibleIndex = 0;
            this.colDers.Width = 103;
            // 
            // colGorsel
            // 
            this.colGorsel.Caption = "Görsel";
            this.colGorsel.ColumnEdit = this.colPctSoruGorsel;
            this.colGorsel.FieldName = "Gorsel";
            this.colGorsel.MaxWidth = 250;
            this.colGorsel.MinWidth = 250;
            this.colGorsel.Name = "colGorsel";
            this.colGorsel.OptionsColumn.AllowEdit = false;
            this.colGorsel.Visible = true;
            this.colGorsel.VisibleIndex = 1;
            this.colGorsel.Width = 250;
            // 
            // colPctSoruGorsel
            // 
            this.colPctSoruGorsel.Name = "colPctSoruGorsel";
            this.colPctSoruGorsel.ShowMenu = false;
            this.colPctSoruGorsel.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // colMetin
            // 
            this.colMetin.Caption = "Soru Metni";
            this.colMetin.FieldName = "Metin";
            this.colMetin.Name = "colMetin";
            this.colMetin.OptionsColumn.AllowEdit = false;
            this.colMetin.Visible = true;
            this.colMetin.VisibleIndex = 2;
            this.colMetin.Width = 584;
            // 
            // colSoruGorselEkleButton
            // 
            this.colSoruGorselEkleButton.Caption = "Görsel Ekle";
            this.colSoruGorselEkleButton.ColumnEdit = this.ribGorselEkle;
            this.colSoruGorselEkleButton.Name = "colSoruGorselEkleButton";
            this.colSoruGorselEkleButton.Visible = true;
            this.colSoruGorselEkleButton.VisibleIndex = 3;
            this.colSoruGorselEkleButton.Width = 71;
            // 
            // ribGorselEkle
            // 
            this.ribGorselEkle.AutoHeight = false;
            editorButtonImageOptions3.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions3.SvgImage")));
            this.ribGorselEkle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ribGorselEkle.Name = "ribGorselEkle";
            this.ribGorselEkle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribGorselEkle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ribGorselEkle_ButtonClick);
            // 
            // FrmSorular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 623);
            this.Controls.Add(this.gridControlSorular);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblSorular);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Name = "FrmSorular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sorular";
            this.Load += new System.EventHandler(this.FrmSorular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSorular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSorular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colPctSoruGorsel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribGorselEkle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpMenu;
        private UserControls.AnaMenuAlt sorularAnaMenuAlt;
        private DevExpress.XtraEditors.LabelControl lblSorular;
        private DevExpress.XtraGrid.GridControl gridControlSorular;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSorular;
        private DevExpress.XtraGrid.Columns.GridColumn colGorsel;
        private DevExpress.XtraGrid.Columns.GridColumn colDers;
        //private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit pctSoruGorsel;
        private DevExpress.XtraGrid.Columns.GridColumn colMetin;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit colPctSoruGorsel;
        private DevExpress.XtraGrid.Columns.GridColumn colSoruGorselEkleButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribGorselEkle;
    }
}