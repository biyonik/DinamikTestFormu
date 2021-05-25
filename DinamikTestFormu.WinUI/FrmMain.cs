using DinamikTestFormu.Core.Functions;
using DinamikTestFormu.Entities.Concrete;
using DinamikTestFormu.WinUI.Forms.Dersler;
using DinamikTestFormu.WinUI.Forms.Sinavlar;
using DinamikTestFormu.WinUI.Forms.Sorular;

namespace DinamikTestFormu.WinUI
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            if (!ConnectionStringProvider.Check())
            {
                FrmConnectionSetupWizard frmConnectionSetupWizard = new FrmConnectionSetupWizard();
                frmConnectionSetupWizard.ShowDialog();
            }
        }

        private void barBtnDersler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDersler frmDersler = new FrmDersler();
            frmDersler.MdiParent = this;
            frmDersler.Show();
        }

        private void barBtnDersEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDersEkle frmDersEkle = new FrmDersEkle(new Ders());
            frmDersEkle.ShowDialog();
        }

        private void barBtnSorular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSorular frmSorular = new FrmSorular();
            frmSorular.MdiParent = this;
            frmSorular.Show();
        }

        private void barBtnSoruEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSoruIslemleri frmSoruIslemleri = new FrmSoruIslemleri(new Soru());
            frmSoruIslemleri.ShowDialog();
        }

        private void barBtnSinavOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSinavOlustur frmSinavOlustur = new FrmSinavOlustur();
            frmSinavOlustur.ShowDialog();
        }
    }
}
