using System;
using System.ComponentModel;

namespace DinamikTestFormu.UserControls
{
    /// <summary>
    /// KayitMenusu user control nesnesi
    /// Butonlar için EventHandler tipinde eventler tanımlanıyor
    /// Category ise görsel ekranda Properties menusunda eğer "Categorized" olarak listelenirse bu eventlerin İşlem Butonları altına listelenmesini sağlayacak
    /// </summary>
    public partial class KayitMenusu : DevExpress.XtraEditors.XtraUserControl
    {
        private bool kayitAc = false;
        [Category("İşlem Butonları")]
        public event EventHandler SecClick;
        [Category("İşlem Butonları")]
        public event EventHandler DuzenleClick;
        [Category("İşlem Butonları")]
        public event EventHandler EkleClick;
        [Category("İşlem Butonları")]
        public event EventHandler SilClick;
        [Category("İşlem Butonları")]
        public event EventHandler KaydetClick;
        [Category("İşlem Butonları")]
        public event EventHandler VazgecClick;
        [Category("İşlem Butonları")]
        public event EventHandler KapatClick;
        /// <summary>
        /// KayitAc fullproperty
        /// set kısmında bu propertynin aldığı değere göre butonların aktiflik durumları güncellenir
        /// </summary>
        public bool KayitAc
        {
            get
            {
                return kayitAc;
            }
            set
            {
                btnEkle.Enabled = !value;
                btnDuzenle.Enabled = !value;
                btnSil.Enabled = !value;
                btnSec.Enabled = !value;
                btnKapat.Enabled = !value;
                btnKaydet.Enabled = value;
                btnVazgec.Enabled = value;
                kayitAc = value;
            }
        }
        public KayitMenusu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btnSec butonuna tıklandığında SetClick eventi Invoke ile çağrılır, böylece ilgili event tetiklenmiş olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSec_Click(object sender, EventArgs e)
        {
            SecClick?.Invoke(this, e);
        }

        /// <summary>
        /// btnEkle butonuna tıklandığında EkleClick eventi Invoke ile çağrılır, böylece ilgili event tetiklenmiş olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEkle_Click(object sender, EventArgs e)
        {
            EkleClick?.Invoke(this, e);
        }

        /// <summary>
        /// btnDuzenle butonuna tıklandığında DuzenleClick eventi Invoke ile çağrılır, böylece ilgili event tetiklenmiş olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DuzenleClick?.Invoke(this, e);
        }

        /// <summary>
        /// btnSil butonuna tıklandığında SilClick eventi Invoke ile çağrılır, böylece ilgili event tetiklenmiş olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSil_Click(object sender, EventArgs e)
        {
            SilClick?.Invoke(this, e);
        }

        /// <summary>
        /// btnKaydet butonuna tıklandığında KaydetClick eventi Invoke ile çağrılır, böylece ilgili event tetiklenmiş olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KaydetClick?.Invoke(this, e);
        }

        /// <summary>
        /// btnVazgec butonuna tıklandığında VazgecClick eventi Invoke ile çağrılır, böylece ilgili event tetiklenmiş olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            VazgecClick?.Invoke(this, e);
        }

        /// <summary>
        /// btnKapat butonuna tıklandığında KapatClick eventi Invoke ile çağrılır, böylece ilgili event tetiklenmiş olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKapat_Click(object sender, EventArgs e)
        {
            KapatClick?.Invoke(this, e);
        }
    }
}
