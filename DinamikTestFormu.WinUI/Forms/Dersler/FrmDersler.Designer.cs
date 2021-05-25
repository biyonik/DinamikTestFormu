
namespace DinamikTestFormu.WinUI.Forms.Dersler
{
    partial class FrmDersler
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
            this.btnUrunFotografEkle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.pctUrunFotograf = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.derslerAnaMenuAlt = new DinamikTestFormu.UserControls.AnaMenuAlt();
            this.lblDersler = new DevExpress.XtraEditors.LabelControl();
            this.gridControlDersler = new DevExpress.XtraGrid.GridControl();
            this.gridViewDersler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnUrunFotografEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUrunFotograf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDersler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunFotografEkle
            // 
            this.btnUrunFotografEkle.AutoHeight = false;
            this.btnUrunFotografEkle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnUrunFotografEkle.Name = "btnUrunFotografEkle";
            this.btnUrunFotografEkle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // pctUrunFotograf
            // 
            this.pctUrunFotograf.Name = "pctUrunFotograf";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.derslerAnaMenuAlt);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 500);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1033, 123);
            this.grpMenu.TabIndex = 3;
            this.grpMenu.Text = "Menü";
            // 
            // derslerAnaMenuAlt
            // 
            this.derslerAnaMenuAlt.ButtonFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.derslerAnaMenuAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.derslerAnaMenuAlt.Location = new System.Drawing.Point(2, 23);
            this.derslerAnaMenuAlt.Name = "derslerAnaMenuAlt";
            this.derslerAnaMenuAlt.Size = new System.Drawing.Size(1029, 98);
            this.derslerAnaMenuAlt.TabIndex = 0;
            this.derslerAnaMenuAlt.ButtonAdd += new System.EventHandler(this.derslerAnaMenuAlt_ButtonAdd);
            this.derslerAnaMenuAlt.ButtonEdit += new System.EventHandler(this.derslerAnaMenuAlt_ButtonEdit);
            this.derslerAnaMenuAlt.ButtonDelete += new System.EventHandler(this.derslerAnaMenuAlt_ButtonDelete);
            this.derslerAnaMenuAlt.ButtonUpdate += new System.EventHandler(this.derslerAnaMenuAlt_ButtonUpdate);
            this.derslerAnaMenuAlt.ButtonClose += new System.EventHandler(this.derslerAnaMenuAlt_ButtonClose);
            // 
            // lblDersler
            // 
            this.lblDersler.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersler.Appearance.Options.UseFont = true;
            this.lblDersler.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDersler.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblDersler.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDersler.Location = new System.Drawing.Point(0, 0);
            this.lblDersler.Name = "lblDersler";
            this.lblDersler.Size = new System.Drawing.Size(1033, 69);
            this.lblDersler.TabIndex = 2;
            this.lblDersler.Text = "Dersler";
            // 
            // gridControlDersler
            // 
            this.gridControlDersler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDersler.Location = new System.Drawing.Point(0, 69);
            this.gridControlDersler.MainView = this.gridViewDersler;
            this.gridControlDersler.Name = "gridControlDersler";
            this.gridControlDersler.Size = new System.Drawing.Size(1033, 431);
            this.gridControlDersler.TabIndex = 4;
            this.gridControlDersler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDersler});
            // 
            // gridViewDersler
            // 
            this.gridViewDersler.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridViewDersler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdi});
            this.gridViewDersler.GridControl = this.gridControlDersler;
            this.gridViewDersler.Name = "gridViewDersler";
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            // 
            // FrmDersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 623);
            this.Controls.Add(this.gridControlDersler);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblDersler);
            this.Name = "FrmDersler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dersler";
            ((System.ComponentModel.ISupportInitialize)(this.btnUrunFotografEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUrunFotograf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDersler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDersler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnUrunFotografEkle;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit pctUrunFotograf;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.LabelControl lblDersler;
        private UserControls.AnaMenuAlt derslerAnaMenuAlt;
        private DevExpress.XtraGrid.GridControl gridControlDersler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDersler;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
    }
}