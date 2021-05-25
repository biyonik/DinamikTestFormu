using DinamikTestFormu.BusinessLogic.Workers.Concrete;
using DinamikTestFormu.Core.Extension;
using DinamikTestFormu.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace DinamikTestFormu.WinUI.Forms.Sorular
{
    public partial class FrmSorular : DevExpress.XtraEditors.XtraForm
    {
        DtfWorker _worker = new DtfWorker();

        public FrmSorular()
        {
            InitializeComponent();
            _worker.SoruService.Load(null, s => s.Ders);
        }

        

        private void sorularAnaMenuAlt_ButtonAdd(object sender, EventArgs e)
        {
            FrmSoruIslemleri frmSoruIslemleri = new FrmSoruIslemleri(new Soru());
            frmSoruIslemleri.ShowDialog();
        }

        private void sorularAnaMenuAlt_ButtonClose(object sender, EventArgs e)
        {
            Close();
        }

        private void ribGorselEkle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridViewSorular.GetFocusedRow() == null) return;
            
            Soru soruEntity = (Soru)gridViewSorular.GetFocusedRow();
            FrmGorselEditoru frmGorselEditoru = new FrmGorselEditoru();
            frmGorselEditoru.ShowDialog();
            if(frmGorselEditoru.AktarilanResim != null)
            {
                soruEntity.Gorsel = frmGorselEditoru.AktarilanResim.ImageToByteArray();
                _worker.Commit();
                gridViewSorular.RefreshData();
            }
        }

        private void FrmSorular_Load(object sender, EventArgs e)
        {
            gridControlSorular.DataSource = _worker.SoruService.BindingList();
        }

        private void sorularAnaMenuAlt_ButtonEdit(object sender, EventArgs e)
        {
            if (gridViewSorular.GetFocusedRow() == null) return;
            FrmSoruIslemleri frmSoruIslemleri = new FrmSoruIslemleri((Soru)gridViewSorular.GetFocusedRow());
            frmSoruIslemleri.ShowDialog();
            if(frmSoruIslemleri.kaydedildiMi)
            {
                gridControlSorular.DataSource = _worker.SoruService.BindingList();
            }
        }

        private void sorularAnaMenuAlt_ButtonUpdate(object sender, EventArgs e)
        {
            gridControlSorular.DataSource = _worker.SoruService.BindingList();
        }

        private void sorularAnaMenuAlt_ButtonDelete(object sender, EventArgs e)
        {
            if(gridViewSorular.GetFocusedRow() == null)
            {
                MessageBox.Show("Lütfen silmek için bir soru seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Seçili soruyu silmek istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var silinecekSoru = gridViewSorular.GetFocusedRow() as Soru;
                var silinecekSoruSecenekleri = _worker.SecenekService.GetList(x => x.SoruId == silinecekSoru.Id);
                _worker.SecenekService.Delete(silinecekSoruSecenekleri);
                _worker.SoruService.Delete(silinecekSoru);
                _worker.Commit();
                gridControlSorular.DataSource = _worker.SoruService.BindingList();
            }
        }
    }
}