using DinamikTestFormu.BusinessLogic.Workers.Concrete;
using DinamikTestFormu.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace DinamikTestFormu.WinUI.Forms.Dersler
{
    public partial class FrmDersEkle : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Ders tipinde bir _dersEntity field
        /// Business katmanı ile iletişime geçecek DtfWorker tipinde _worker field
        /// kayıt ve güncelleme işleminin yapıldığını tutan kaydedildiMi field
        /// </summary>
        private Ders _dersEntity;
        private readonly DtfWorker _worker = new DtfWorker();
        public bool kaydedildiMi = false;

        /// <summary>
        /// Yapıcı metot
        /// Ders tipinde bir entity parametre alır
        /// Dependency injection ile _dersEntity fieldi parametre olarak gelen dersEntity e bağlanıyor
        /// Eğer _dersEntity nin Id değeri boş ise (ilk oluşturma anlamına gelir, düzenlemede bu bilgi dolu gelecektir) Id fieldine yeni bir Guid atanır
        /// DersBinding() metodu çalıştırılıyor
        /// </summary>
        /// <param name="dersEntity"></param>
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

        /// <summary>
        /// Bu metot, formdaki ders adı textbox ı için veri bağlama işlemini yapar
        /// DataBindings ile Ders entitynin Adi fieldi, textbox üzerindeki her değişiklikte güncellenir
        /// </summary>
        void DersBinding()
        {
            tbxDersAdi.DataBindings.Clear();
            tbxDersAdi.DataBindings.Add("Text", _dersEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        /// <summary>
        /// Dialog formunu kapatır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDersKayitVazgec_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Kaydet butonu click aksiyonu
        /// Eğer textbox'un text değeri tanımsız veya boş değilse 
        /// DersService servisinin AddOrUpdate metodu ile dersEntity eklemek veya güncellemek için state trackera tanımlanır
        /// kaydedildiMi fieldi ne true atanır
        /// Commit ile tüm değişiklikler veritabanına yansıtılır ve form kapatılır
        /// Fakat textbox'un text değeri boş ise errorprovider nesnesinin hata kısmı uyarı mesajı ile doldurulur ve textbox yanında uyarı verilir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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