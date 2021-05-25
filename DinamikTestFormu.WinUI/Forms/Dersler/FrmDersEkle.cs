using DinamikTestFormu.BusinessLogic.Workers.Concrete;
using DinamikTestFormu.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace DinamikTestFormu.WinUI.Forms.Dersler
{
    public partial class FrmDersEkle : DevExpress.XtraEditors.XtraForm
    {
        private Ders _dersEntity;
        private readonly DtfWorker _worker = new DtfWorker();
        public bool kaydedildiMi = false;
        public FrmDersEkle(Ders dersEntity)
        {
            InitializeComponent();
            _dersEntity = dersEntity;
            if(_dersEntity.Id == Guid.Empty)
            {
                _dersEntity.Id = Guid.NewGuid();
            }
            DersBinding();
        }

        void DersBinding()
        {
            tbxDersAdi.DataBindings.Clear();
            tbxDersAdi.DataBindings.Add("Text", _dersEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnDersKayitVazgec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbxDersAdi.Text))
            {
                _worker.DersService.AddOrUpdate(_dersEntity);
                this.kaydedildiMi = true;
                _worker.Commit();
                Close();
            } else
            {
                errorProvider.SetError(tbxDersAdi, "Ders adı alanı boş bırakılamaz");
            }
        }
    }
}