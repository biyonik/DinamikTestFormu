using System;
using System.ComponentModel;
using System.Drawing;

namespace DinamikTestFormu.UserControls
{
    /// <summary>
    /// Altmenu user control nesnesi
    /// Butonlar için EventHandler tipinde eventler tanımlanıyor
    /// Category ise görsel ekranda Properties menusunda eğer "Categorized" olarak listelenirse bu eventlerin İşlemler altına listelenmesini sağlayacak
    /// </summary>
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

        /// <summary>
        /// Font tipinde _buttonFont adında field
        /// </summary>
        private Font _buttonFont = new Font("Tahoma", 8, FontStyle.Bold);
        /// <summary>
        /// Font tipinde ButtonFont adında Field, _buttonFont fieldinin ve componentteki butonların değerini günceller
        /// </summary>
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

        /// <summary>
        /// btnAdd butonuna tıklandığında ButtonAdd eventi Invoke ile çağrılır, böylece ilgili event tetiklenmiş olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ButtonAdd?.Invoke(this, e);
        }

        /// <summary>
        /// btnEdit butonuna tıklandığında ButtonEdit eventi Invoke ile çağrılır, böylece ilgili event tetiklenmiş olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ButtonEdit?.Invoke(this, e);
        }

        /// <summary>
        /// btnDelete butonuna tıklandığında ButtonDelete eventi Invoke ile çağrılır, böylece ilgili event tetiklenmiş olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ButtonDelete?.Invoke(this, e);
        }

        /// <summary>
        /// btnUpdate butonuna tıklandığında ButtonUpdate eventi Invoke ile çağrılır, böylece ilgili event tetiklenmiş olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ButtonUpdate?.Invoke(this, e);
        }

        /// <summary>
        /// btnClose butonuna tıklandığında ButttonClose eventi Invoke ile çağrılır, böylece ilgili event tetiklenmiş olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            ButtonClose?.Invoke(this, e);
        }
    }
}
