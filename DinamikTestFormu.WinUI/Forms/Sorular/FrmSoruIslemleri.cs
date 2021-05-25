using DinamikTestFormu.BusinessLogic.Workers.Concrete;
using DinamikTestFormu.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace DinamikTestFormu.WinUI.Forms.Sorular
{
    public partial class FrmSoruIslemleri : DevExpress.XtraEditors.XtraForm
    {
        private Soru _soruEntity;
        private Secenek _secenekEntity;
        public bool kaydedildiMi { get; set; } = false;
        private DtfWorker _worker = new DtfWorker(null);

        public FrmSoruIslemleri(Soru soruEntity)
        {
            InitializeComponent();
            _soruEntity = soruEntity;
            if(_soruEntity.Id == Guid.Empty)
            {
                _soruEntity.Id = Guid.NewGuid();
            }
            _worker.DersService.Load(null);
            _worker.SecenekService.Load(x => x.SoruId == _soruEntity.Id, x => x.Soru);
            _worker.SoruService.Load(x => x.Id == _soruEntity.Id, x => x.Ders);

            gridControlSoruSecenekler.DataSource = _worker.SecenekService.BindingList();

            cbxDersler.DataSource = _worker.DersService.BindingList();
            cbxDersler.DisplayMember = "Adi";
            cbxDersler.ValueMember = "Id";
            SoruBinding();
            _soruEntity.DersId = ((Ders)cbxDersler.SelectedItem).Id;
        }

        void SoruBinding()
        {
            cbxDersler.DataBindings.Clear();
            pctGorsel.DataBindings.Clear();
            memoSoruMetni.DataBindings.Clear();

            //cbxDersler.DataBindings.Add(new Binding("SelectedValue", _soruEntity.Ders ?? new Ders(), "Id", false, DataSourceUpdateMode.OnPropertyChanged));
            memoSoruMetni.DataBindings.Add("Text", _soruEntity, "Metin", false, DataSourceUpdateMode.OnPropertyChanged);
            pctGorsel.DataBindings.Add("EditValue", _soruEntity, "Gorsel", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        void SecenekBinding()
        {
            tbxSoruSecenek.DataBindings.Clear();
            tbxSoruSecenek.DataBindings.Add(new Binding("EditValue", _secenekEntity, "Opsiyon", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btnSoruGorselEkle_Click(object sender, EventArgs e)
        {
            FrmGorselEditoru frmGorselEditoru = new FrmGorselEditoru();
            frmGorselEditoru.ShowDialog();
            if(frmGorselEditoru.AktarilanResim != null)
            {
                pctGorsel.Image = frmGorselEditoru.AktarilanResim;
            }
        }

        private void btnSoruKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSoruKaydet_Click(object sender, EventArgs e)
        {
            //var secenekCount = _worker.SoruService.GetList(x => x.DersId == _soruEntity.Id).Count();
            if(gridViewSoruSecenekler.DataRowCount < 4 || gridViewSoruSecenekler.DataRowCount > 5 )
            {
                MessageBox.Show("Seçenek sayısı minimum 4, maksimum 5 olmalıdır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else if(string.IsNullOrEmpty(memoSoruMetni.Text))
            {
                MessageBox.Show("Soru metni boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _worker.SoruService.AddOrUpdate(_soruEntity);
            _worker.Commit();
            this.kaydedildiMi = true;
            Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //if (gridViewSoruSecenekler.DataRowCount >= 4 || gridViewSoruSecenekler.DataRowCount >= 5)
            //{
            //    MessageBox.Show("Seçenek sayısı minimum 4, maksimum 5 olmalıdır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if(string.IsNullOrEmpty(tbxSoruSecenek.Text))
            {
                MessageBox.Show("Seçenek boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            _secenekEntity = new Secenek();
            _secenekEntity.SoruId = _soruEntity.Id;
            _secenekEntity.Opsiyon = tbxSoruSecenek.Text;
            tbxSoruSecenek.DataBindings.Clear();
            tbxSoruSecenek.ResetText();
            _worker.SecenekService.AddOrUpdate(_secenekEntity);
            _worker.DetectChanges();
        }

        //private void btnKaydet_Click(object sender, EventArgs e)
        //{
        
        //}

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (gridViewSoruSecenekler.GetFocusedRow() == null) return; 
            _secenekEntity = (Secenek)gridViewSoruSecenekler.GetFocusedRow();
            SecenekBinding();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gridViewSoruSecenekler.GetFocusedRow() == null) return;
            if (MessageBox.Show("Seçili olan seçeneği silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridViewSoruSecenekler.DeleteSelectedRows();
            }
            _worker.Commit();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SoruBinding();
            SecenekBinding();
            _worker.SecenekService.AddOrUpdate(_secenekEntity);
            _worker.DetectChanges();
            gridViewSoruSecenekler.RefreshData();
        }

        private void cbxDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            //int selectedIndex = comboBox.SelectedIndex;
            Guid selectedValue = ((Ders)comboBox.SelectedItem).Id;
            _soruEntity.DersId = selectedValue;
        }
    }
}