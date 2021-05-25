using System;
using System.ComponentModel;
using System.Drawing;

namespace DinamikTestFormu.UserControls
{
    public partial class AnaMenuAlt : DevExpress.XtraEditors.XtraUserControl
    {
        [Category("İşlemler")]
        public event EventHandler ButtonAdd;
        [Category("İşlemler")]
        public event EventHandler ButtonEdit;
        [Category("İşlemler")]
        public event EventHandler ButtonDelete;
        [Category("İşlemler")]
        public event EventHandler ButtonUpdate;
        [Category("İşlemler")]
        public event EventHandler ButtonClose;

        private Font _buttonFont = new Font("Tahoma", 8, FontStyle.Bold);
        public Font ButtonFont
        {
            get
            {
                return _buttonFont;
            }
            set
            {
                btnAdd.Font = value;
                btnEdit.Font = value;
                btnDelete.Font = value;
                btnUpdate.Font = value;
                btnClose.Font = value;
                _buttonFont = value;
            }
        }

        public AnaMenuAlt()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ButtonAdd?.Invoke(this, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ButtonEdit?.Invoke(this, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ButtonDelete?.Invoke(this, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ButtonUpdate?.Invoke(this, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ButtonClose?.Invoke(this, e);
        }
    }
}
