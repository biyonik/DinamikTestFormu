using DinamikTestFormu.BusinessLogic.Workers.Concrete;
using DinamikTestFormu.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace DinamikTestFormu.WinUI.Forms.Sorular
{
    public partial class FrmSoruIslemleri : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Soru tipinde _soruEntity adında bir Field
        /// Secenek tipinde _secenekEntity adında bir Field
        /// bool tipinde kaydedildiMi adında bir field
        /// DtfWorker tipinde _worker adında bir nesne örneği
        /// </summary>
        private Soru _soruEntity;
        private Secenek _secenekEntity;
        public bool kaydedildiMi = false;
        private DtfWorker _worker = new DtfWorker(null);

        /// <summary>
        /// Yapıcı metot
        /// Soru tipinde bir parametre alır
        /// _soruEntity, dependency injection ile parametre olara gelen soruEntity e bağlanır
        /// Eğer soruEntity.Id propertsi null ise bu nesnenin ilk oluşturulması anlamına gelir ve şart bloğunda soruEntity.Id değeri yeni bir Guid değeri alır
        /// </summary>
        /// <param name="soruEntity"></param>
        public FrmSoruIslemleri(Soru soruEntity)
        {
            InitializeComponent();
            _soruEntity = soruEntity;
            if(_soruEntity.Id == Guid.Empty)
            {
                _soruEntity.Id = Guid.NewGuid();
            }
            // DersService Load ile tüm dersler yükleniyor
            _worker.DersService.Load(null);
            // SecenekService Load ile bu sorunun Id değeri ile eşleşen seçenekler yükleniyor, devamında Soru bilgisi de alınıyor
            _worker.SecenekService.Load(x => x.SoruId == _soruEntity.Id, x => x.Soru);
            // SoruService Load ile parametre olarak gelen soruEntity.Id değeri ile eşleşen sorular getiriliyor, devamında ilişkili Ders bilgisi alınıyor
            _worker.SoruService.Load(x => x.Id == _soruEntity.Id, x => x.Ders);
            // Seçenekler tabındaki Gridin veri kaynağı SecenekService servisinden BindingList metodundan gelen değerler ile dolduruluyor
            gridControlSoruSecenekler.DataSource = _worker.SecenekService.BindingList();

            // Soru bilgisi tabındaki Dersler combobox nesnesinin veri kaynağı DersService servisindeki BindingList metodundan gelen değerler ile dolduruluyor
            cbxDersler.DataSource = _worker.DersService.BindingList();
            // combobox'un görüntülenen değeri Adi propertysi, değer fieldi ise Id propertysi ile dolduruluyor
            cbxDersler.DisplayMember = "Adi";
            cbxDersler.ValueMember = "Id";
            // SoruBinding metodu çalıştırlıyor
            SoruBinding();
            // soruEntity nin DersId propertysi, soru bilgisi tabındaki combobox'un seçili öğesinin Ders tipine cast edilmesiyle elde edilen entitynin Id değerine atanıyor
            _soruEntity.DersId = ((Ders)cbxDersler.SelectedItem).Id;
        }

        /// <summary>
        /// Bu metot, Soru Bilgisi tabındaki öğelerin DataBindings değerlerini temizler ve ekler
        /// DataBindings ile Soru entitynin Metin fieldi, memoedit üzerindeki her değişiklikte güncellenir
        /// DataBindings ile Soru entitynin Gorsel fieldi, picture üzerindeki her değişiklikte güncellenir
        /// </summary>
        void SoruBinding()
        {
            cbxDersler.DataBindings.Clear();
            pctGorsel.DataBindings.Clear();
            memoSoruMetni.DataBindings.Clear();

            memoSoruMetni.DataBindings.Add("Text", _soruEntity, "Metin", false, DataSourceUpdateMode.OnPropertyChanged);
            pctGorsel.DataBindings.Add("EditValue", _soruEntity, "Gorsel", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        /// <summary>
        /// Bu metot, Seçenekler tabındaki  seçenek textbox ı için veri bağlama işlemini yapar
        /// DataBindings ile Secenek entitynin Opsiyon fieldi, textbox üzerindeki her değişiklikte güncellenir
        /// </summary>
        void SecenekBinding()
        {
            tbxSoruSecenek.DataBindings.Clear();
            tbxSoruSecenek.DataBindings.Add(new Binding("EditValue", _secenekEntity, "Opsiyon", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        /// <summary>
        /// Görsel Seç butonunun click aksiyonu
        /// FrmGorselEditoru sınıfından bir örnek alır
        /// Dialog olarak ekranda görüntülenir
        /// frmGorselEditor sınıfının AktarilanResim propertysi null değilse PictureEdit'in Image değeri bu propert'nin değerini alır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSoruGorselEkle_Click(object sender, EventArgs e)
        {
            FrmGorselEditoru frmGorselEditoru = new FrmGorselEditoru();
            frmGorselEditoru.ShowDialog();
            if(frmGorselEditoru.AktarilanResim != null)
            {
                pctGorsel.Image = frmGorselEditoru.AktarilanResim;
            }
        }

        /// <summary>
        /// Soru İşlemleri Formunu kapatır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSoruKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Kaydet butonu click aksiyonu
        /// Seçenekler tabındaki gridview üzerindeki satır sayısı 4 veya 5 değilse kullanıcıya Uyarı penceresi gösterir
        /// Devamında eğer soru metni boş ise kullanıcıya hata penceresi gösterir
        /// Tüm adımlar doğru ise SoruService servisinin AddOrUpdate metoduna soruEntity parametre olarak verilir ve eklenmek/güncellenmek için entity state te geçilir
        /// commit ile tüm işlemler veritabanına gönderilir
        /// kaydedildiMi fieldine true atanır
        /// Pencere kapatılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSoruKaydet_Click(object sender, EventArgs e)
        {
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

        /// <summary>
        /// Seçenekler tabı ekle butonu aksiyonu
        /// Eğer seçenekler metin kutusu boş ise ekrana hata penceresi gösterilir
        /// Değilse secenekEntity sınıfı oluşturulur
        /// secenekEntity.SoruId değeri soruEntity nin Id propertysinin değerini alır
        /// secenekEntity.Opsiyon değeri secenek metin kutusunun değerini alır
        /// textBox un DataBinding özelliği temizlenir
        /// textBox resetlenir
        /// SecenekService servisi AddOrUpdate ile secenekEntity eklemek/güncellemek üzere hazırlanır
        /// DetectChanges ile commit öncesi seçenekler kuyruğa alınmış olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEkle_Click(object sender, EventArgs e)
        {
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

        /// <summary>
        /// Seçenekler tabı düzenle butonu
        /// Secenekler tabındaki gridview de eğer bir satıra odaklanılmamış ise metot işlem yapmaz
        /// Odaklanılmış ise secenekEntity odaklanılan satırın Secenek tipine cast edilmesiyle gelen değeri alır
        /// SecenekBinding ile bağlama işlemi yapılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (gridViewSoruSecenekler.GetFocusedRow() == null) return; 
            _secenekEntity = (Secenek)gridViewSoruSecenekler.GetFocusedRow();
            SecenekBinding();
        }

        /// <summary>
        /// Seçenekler tabı Sil butonu aksiyonu
        /// Secenekler tabındaki gridview de eğer bir satıra odaklanılmamış ise metot işlem yapmaz
        /// Değilse kullanıcıya bir seçim penceresi ekranı çıkartır ve seçenek evet ise grid üzerinden silme işlemi yapar (sadece grid üzerinde, henüz commit edilmedi)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gridViewSoruSecenekler.GetFocusedRow() == null) return;
            if (MessageBox.Show("Seçili olan seçeneği silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridViewSoruSecenekler.DeleteSelectedRows();
            }
        }

        /// <summary>
        /// Seçenekler tabı Kaydet butonu
        /// SecenekServisi servisinin AddOrUpdate metodu ile secenekEntity ekleme/güncelleme için hazırlanır
        /// DetectChanges ile commit öncesi seçenekler entity üzerinde kuyruğa alınmış olur
        /// Seçenekler gridi güncellenir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _worker.SecenekService.AddOrUpdate(_secenekEntity);
            _worker.DetectChanges();
            gridViewSoruSecenekler.RefreshData();
        }

        /// <summary>
        /// Soru Bilgisi tabındaki Dersler comboboxunun her indexi değiştiğinde
        /// sender bir ComboBox a dönüştürülür ve comboBox adında bir Değişkene atanır
        /// Guid tipinde selectedValue değişkenine comboboxun seçili değerinin Ders tipine cast edilmesi ile gelen Ders entitynin Id değeri atanıyor
        /// soruEntity.DersId propertysine selectedValue değeri atanıyor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            //int selectedIndex = comboBox.SelectedIndex;
            Guid selectedValue = ((Ders)comboBox.SelectedItem).Id;
            _soruEntity.DersId = selectedValue;
        }
    }
}