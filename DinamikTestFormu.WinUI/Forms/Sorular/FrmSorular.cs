using DinamikTestFormu.BusinessLogic.Workers.Concrete;
using DinamikTestFormu.Core.Extension;
using DinamikTestFormu.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace DinamikTestFormu.WinUI.Forms.Sorular
{
    public partial class FrmSorular : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// DtfWorker tipinde _worker adında Business Katmanı ile iletişim kurulmasını sağlayan sınıf örneği
        /// </summary>
        DtfWorker _worker = new DtfWorker();

        /// <summary>
        /// Yapıcı metot
        /// SoruService servisinden Load metodu çalıştırılıyor
        /// Fakat tüm sorular bu servieste s => s.Ders ile ders bilgileri ile yüklenmiş olacak
        /// </summary>
        public FrmSorular()
        {
            InitializeComponent();
            _worker.SoruService.Load(null, s => s.Ders);
        }


        /// <summary>
        /// Yeni soru eklemeyi sağlayan butonun tetiklenme aksiyonu
        /// FrmSoruIslemleri sınıfından bir örnek alır ve parametre olarak bir Soru entity pas geçer
        /// Dialog penceresi olarak ekranda görüntülenir
        /// Eğer FrmSoruIslemleri sınıfnın kaydedildiMi property değeri true olursa Sorular formundaki grid için verilerin yenilenmesi işlemleri yapılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sorularAnaMenuAlt_ButtonAdd(object sender, EventArgs e)
        {
            FrmSoruIslemleri frmSoruIslemleri = new FrmSoruIslemleri(new Soru());
            frmSoruIslemleri.ShowDialog();
            if (frmSoruIslemleri.kaydedildiMi)
            {
                _worker.SoruService.Load(null, s => s.Ders);
                gridControlSorular.DataSource = _worker.SoruService.BindingList();
            }
        }

        /// <summary>
        /// Sorular formunun kapatılmasını sağlar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sorularAnaMenuAlt_ButtonClose(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Grid üzerinde görüntülenen bir soru için görsel eklemeyi sağlar
        /// Eğer grid üzerinde herhangi bir satıra odaklanılmamış ise metot işlem yapmaz
        /// Değilse odaklanılan satır bir Soru tipine cast edilir (soruEntity)
        /// FrmGorselEditoru sınıfından bir ornek alınır ve ekranda dialog olarak gösterilir
        /// Eğer FrmGorselEditoru sınıfının AktarilanResim propertysi null değilse
        /// soruEntity nin Gorsel fieldine AktarilanResim propertsi byte array e dönüştürülerek atanır
        /// tüm işlemler commit edilir
        /// Sorular formundaki grid yenilenir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// FrmSorular'ın Load metodu
        /// Sorular formundaki gridin veri kaynağı SorService servisindeki BindingList metodundan gelen veriler ile doldurulur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSorular_Load(object sender, EventArgs e)
        {
            gridControlSorular.DataSource = _worker.SoruService.BindingList();
        }

        /// <summary>
        /// Seçilen soruyu düzenleyen Düzenle butonunun aksiyonu
        /// Eğer grid üzerinde herhangi bir satıra odaklanılmamış ise metot işlem yapmaz
        /// FrmSoruIslemleri sınıfından bir örnek alır ve parametre olarak grid üzerinde odaklanılan satırı Soru tipine cast ederek gönderir
        /// FrmSoruIslemleri formu ekranda dialog olarak görünür
        /// Eğer frmSoruIslemleri sınıfının kaydedildiMi property si true ise SoruService ile tekrar sorular, dersleri ile birlikte yüklenir
        /// Ve gridin veri kaynağı tekrar bindinglist ile doldurulur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sorularAnaMenuAlt_ButtonEdit(object sender, EventArgs e)
        {
            if (gridViewSorular.GetFocusedRow() == null) return;
            FrmSoruIslemleri frmSoruIslemleri = new FrmSoruIslemleri((Soru)gridViewSorular.GetFocusedRow());
            frmSoruIslemleri.ShowDialog();
            if(frmSoruIslemleri.kaydedildiMi)
            {
                _worker.SoruService.Load(null, s => s.Ders);
                gridControlSorular.DataSource = _worker.SoruService.BindingList();
            }
        }

        /// <summary>
        /// Güncelle butonunun tıklanma aksiyonu
        /// Sorular ekranındaki grid in veri kaynağı SoruService servisinin BindingList metodu ile tekrar doldurulur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sorularAnaMenuAlt_ButtonUpdate(object sender, EventArgs e)
        {
            gridControlSorular.DataSource = _worker.SoruService.BindingList();
        }

        /// <summary>
        /// Sil butonunun tıklanma aksiyonu
        /// Eğer grid üzerindeki herhangi bir satıra odaklanılmamış ise kullanıcıya Hata(Exclamation) penceresi gösterilir
        /// Değilse grid üzerindeki odaklanılan satır Soru tipine cast edilir
        /// SecenekService servisinden GetList metoduna ise bir expression ile seçilen sorunun Id si ile eşleşen seçenekler alınır
        /// SecenekService servisinin Delete metodu ile önce eşleşen seçenekler
        /// SoruService servisinin Delete metodu ile seçilen soru silinir
        /// Tüm değişiklikler commit edilir
        /// grid'in veri kaynağı SoruService BindingList metodu ile tekrar doldurulur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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