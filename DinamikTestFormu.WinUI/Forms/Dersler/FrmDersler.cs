using DinamikTestFormu.BusinessLogic.Workers.Concrete;
using DinamikTestFormu.Entities.Concrete;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DinamikTestFormu.WinUI.Forms.Dersler
{
    public partial class FrmDersler : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// DtfWorker tipinde _worker adında Business Katmanı ile iletişim kurulmasını sağlayan sınıf örneği
        /// </summary>
        DtfWorker _worker = new DtfWorker();

        /// <summary>
        /// Bu metot DersService servisinden Load metodunu çalıştırır ve tüm dersleri hafızaya alır
        /// Dersler formundaki gridin veri kaynağına ise yine DerService servisinden BindingList metodu ile veriler aktarılır 
        /// </summary>
        void Listele()
        {
            _worker.DersService.Load(null);
            gridControlDersler.DataSource = _worker.DersService.BindingList();
        }

        /// <summary>
        /// Yapıcı metot
        /// Listele metodu çalıştırılır
        /// </summary>
        public FrmDersler()
        {
            InitializeComponent();
            Listele();
        }

        /// <summary>
        /// Dersler formunu kapatan buton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void derslerAnaMenuAlt_ButtonClose(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Bir ders ekleme formunu açan butonun aksiyonu
        /// Ders Ekle formunu açan butonun tıklanma aksiyonu
        /// FrmDersEkle sınıfından bir örnek oluşturur ve parametre olarak bir Ders entity pas geçer
        /// Dialog olarak ekranda açılır
        /// Eğer frmDersEkle sınıfnın kaydedildiMi property değeri true olursa Listele metodu çalıştırılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void derslerAnaMenuAlt_ButtonAdd(object sender, EventArgs e)
        {
            FrmDersEkle frmDersEkle = new FrmDersEkle(new Ders());
            frmDersEkle.ShowDialog();
            if(frmDersEkle.kaydedildiMi == true)
            {
                Listele();
            } 
        }

        /// <summary>
        /// Dersler ekranındaki gridi güncellemek için Güncelle butonu aksiyonu
        /// Listele metodunu çalıştırır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void derslerAnaMenuAlt_ButtonUpdate(object sender, EventArgs e)
        {
            Listele();
        }

        /// <summary>
        /// Ekranda seçili dersi düzenlemek için Düzenle butonu aksiyonu
        /// Eğer grid üzerindeki herhangi bir satıra odaklanmamış ise metot işlem yapmaz
        /// Değilse grid üzerindeki satır bir Ders entity tipine cast edilir
        /// FrmDersEkle sınıfından bir örnek oluşturur ve parametre olarak bir seçilen ders entity gönderilir
        /// Dialog olarak ekranda açılır. 
        /// Eğer frmDersEkle sınıfnın kaydedildiMi property değeri true olursa Listele metodu çalıştırılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Ekranda seçili dersi silmek için Sil butonu aksiyonu
        /// Eğer grid üzerindeki herhangi bir satıra odaklanmamış ise metot işlem yapmaz
        /// Değilse grid üzerindeki satır bir Ders entity tipine cast edilir
        /// Ayrıca bu metotta ders ile ilişki soru sayısıda SoruService üzerinden bir filtre ile alınır
        /// Eğer ders ile ilişkili soru var ise silme işlemi yapmaz ve kullanıcıya bilgi verir
        /// Değilse kullanıcıya onay ekranı açarak silme işlemini grid üzerinde yapar ve _worker.Commit ile tüm değişiklikler commit edilir
        /// Listele metodu ile dersler grid tekrar güncellenmiş olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void derslerAnaMenuAlt_ButtonDelete(object sender, EventArgs e)
        {
            
            if (gridViewDersler.GetFocusedRow() == null) return;
            var _selectedEntity = (Ders)gridViewDersler.GetFocusedRow();

            var questionCount = _worker.SoruService.GetList(x => x.DersId == _selectedEntity.Id).Count();
            if(questionCount > 0)
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