using DinamikTestFormu.Core.Functions;
using DinamikTestFormu.Entities.Concrete;
using DinamikTestFormu.WinUI.Forms.Dersler;
using DinamikTestFormu.WinUI.Forms.Sinavlar;
using DinamikTestFormu.WinUI.Forms.Sorular;

namespace DinamikTestFormu.WinUI
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /// <summary>
        /// Yapıcı metot
        /// ConnectionStringProiver sınıfının Check metodu çalıştırılır
        /// Eğer Veritabanı sunucu bağlantısı yapılamaz ise Veritabanı sunucu yapılandırma sihirbazı açılır
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            if (!ConnectionStringProvider.Check())
            {
                FrmConnectionSetupWizard frmConnectionSetupWizard = new FrmConnectionSetupWizard();
                frmConnectionSetupWizard.ShowDialog();
            }
        }

        /// <summary>
        /// Dersler formunu açan butonun tıklanma aksiyonu
        /// FrmDersler sınıfından bir örnek alır.
        /// MdiParent özelliği FrmMain olarak atanır
        /// Bu form ekranda açıldığında çocuk form olarak açılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnDersler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDersler frmDersler = new FrmDersler();
            frmDersler.MdiParent = this;
            frmDersler.Show();
        }

        /// <summary>
        /// Ders Ekle formunu açan butonun tıklanma aksiyonu
        /// FrmDersEkle sınıfından bir örnek oluşturur ve parametre olarak bir Ders entity pas geçer
        /// Dialog olarak ekranda açılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnDersEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDersEkle frmDersEkle = new FrmDersEkle(new Ders());
            frmDersEkle.ShowDialog();
        }

        /// <summary>
        /// Sorular formunu açan butonun tıklanma aksiyonu
        /// FrmSorular sınıfından bir örnek alır.
        /// MdiParent özelliği FrmMain olarak atanır
        /// Bu form ekranda açıldığında çocuk form olarak açılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnSorular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            frmSorular.MdiParent = this;
            frmSorular.Show();
        }

        /// <summary>
        /// Soru Ekle formunu açan butonun tıklanma aksiyonu
        /// FrmSoruEkle sınıfından bir örnek oluşturur ve parametre olarak bir Soru entity pas geçer
        /// Dialog olarak ekranda açılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnSoruEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSoruIslemleri frmSoruIslemleri = new FrmSoruIslemleri(new Soru());
            frmSoruIslemleri.ShowDialog();
        }

        /// <summary>
        /// FrmSoruOlustur sınıfından bir örnek oluşturur
        /// Dialog olarak ekranda açılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnSinavOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSinavOlustur frmSinavOlustur = new FrmSinavOlustur();
            frmSinavOlustur.ShowDialog();
        }
    }
}
