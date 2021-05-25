using DinamikTestFormu.BusinessLogic.Workers.Concrete;
using DinamikTestFormu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DinamikTestFormu.WinUI.Forms.Dersler
{
    public partial class FrmDersler : DevExpress.XtraEditors.XtraForm
    {
        DtfWorker _worker = new DtfWorker();
        void Listele()
        {
            _worker.DersService.Load(null);
            gridControlDersler.DataSource = _worker.DersService.BindingList();
        }

        public FrmDersler()
        {
            InitializeComponent();
            Listele();
        }

        private void derslerAnaMenuAlt_ButtonClose(object sender, EventArgs e)
        {
            Close();
        }

        private void derslerAnaMenuAlt_ButtonAdd(object sender, EventArgs e)
        {
            FrmDersEkle frmDersEkle = new FrmDersEkle(new Ders());
            frmDersEkle.ShowDialog();
            if(frmDersEkle.kaydedildiMi == true)
            {
                Listele();
            } 
        }

        private void derslerAnaMenuAlt_ButtonUpdate(object sender, EventArgs e)
        {
            Listele();
        }

        private void derslerAnaMenuAlt_ButtonEdit(object sender, EventArgs e)
        {
            if (gridViewDersler.GetFocusedRow() == null) return;

            var _selectedEntity = (Ders)gridViewDersler.GetFocusedRow();
            FrmDersEkle frmDersEkle = new FrmDersEkle(_selectedEntity);
            frmDersEkle.ShowDialog();
            if(frmDersEkle.kaydedildiMi == true)
            {
                Listele();
            }
        }

        private void derslerAnaMenuAlt_ButtonDelete(object sender, EventArgs e)
        {
            var _selectedEntity = (Ders)gridViewDersler.GetFocusedRow();
            if (_selectedEntity == null) return;

            var questions = _worker.SoruService.GetList(x => x.DersId == _selectedEntity.Id);
            int count = new List<Soru>(questions).Count;
            if(count > 0)
            {
                MessageBox.Show("Bu ders altında soru kayıtlı olduğu için silme yapılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gridViewDersler.DeleteSelectedRows();
                    _worker.Commit();
                }
            }
            Listele();
        }
    }
}