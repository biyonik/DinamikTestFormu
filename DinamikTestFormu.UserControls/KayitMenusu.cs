using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikTestFormu.UserControls
{
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

        private void btnSec_Click(object sender, EventArgs e)
        {
            SecClick?.Invoke(this, e);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EkleClick?.Invoke(this, e);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DuzenleClick?.Invoke(this, e);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SilClick?.Invoke(this, e);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KaydetClick?.Invoke(this, e);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            VazgecClick?.Invoke(this, e);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            KapatClick?.Invoke(this, e);
        }
    }
}
