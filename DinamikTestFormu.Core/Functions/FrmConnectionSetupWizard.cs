using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DinamikTestFormu.Core.Functions
{
    /// <summary>
    /// Programın ilk açılışında çalışan ve sunucu ile bağlantı kurma ayarlarını yapan form
    /// </summary>
    public partial class FrmConnectionSetupWizard : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// bağlantı cümlesini tutan bir field
        /// </summary>
        SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
        /// <summary>
        /// Bağlantı ayarları kaydedildiğinde, kayıt işleminin yapılıp, program akışına devam edilmesi bilgisini tutan tutucu değişken
        /// </summary>
        public bool kaydedildiMi = false;

        public FrmConnectionSetupWizard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bağlantıyı test et aksiyonu için bağantı cümlesi oluşturan metod
        /// WinAuth ve SqlServerAuth için formdan gelen bilgilere göre bir bağlantı cümlesi oluşturur
        /// </summary>
        private void BaglantiCumlesiOlustur()
        {
            sqlConnectionStringBuilder.InitialCatalog = "master";
            sqlConnectionStringBuilder.DataSource = tbxServer.Text;
            if (cbxWinAuth.Checked == true)
            {
                sqlConnectionStringBuilder.IntegratedSecurity = true;
            }
            else
            {
                sqlConnectionStringBuilder.UserID = tbxUser.Text;
                sqlConnectionStringBuilder.Password = tbxPassword.Text;
                sqlConnectionStringBuilder.IntegratedSecurity = false;
            }
        }
        /// <summary>
        /// Eğer SqlServer Auth seçilmişse tetiklenecek aksiyon
        /// Bu durumda kullanıcı adı ve parola bileşenleri aktif olur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxSqlAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSqlAuth.Checked == true)
            {
                tbxUser.Enabled = true;
                tbxPassword.Enabled = true;
            }
            else
            {
                tbxUser.Enabled = false;
                tbxPassword.Enabled = false;
            }
        }

        /// <summary>
        /// Bağlantının test edilmesini sağlayan butonun aksiyonu
        /// BaglantiCumlesiOlustur metodu tetiklenerek bir bağlantı cümlesi oluşturulur
        /// ConnectionStrinProvider sınfıının check metodu ile oluşturulan bağlantı cümlesi parametre geçilerek bağlantı kontrol edilir
        /// Başarılı ve başarısız durumlarına göre kullanıcıya bilgi penceresi gösterilir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBaglantiyiTestEt_Click(object sender, EventArgs e)
        {
            BaglantiCumlesiOlustur();
            if (ConnectionStringProvider.Check(sqlConnectionStringBuilder.ConnectionString))
            {
                MessageBox.Show("Bağlantı Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bağlantı Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Bağlantı ayarlarının kaydedilmesini sağlayan butonun tetiklendiğinde yapılacak işlemler
        /// BaglantiCumlesiOlustur metodu tetiklenerek bir bağlantı cümlesi oluşturulur
        /// ConnectionStrinProvider sınfıının check metodu ile oluşturulan bağlantı cümlesi parametre geçilerek bağlantı kontrol edilir
        /// Eğer bağlantı sağlanırsa
        /// Burada InitialCatalog, DinamikTestFormu olarak atanır. Bu bizim veritabanımızın adı
        /// ConnectionStrinProvider sınfıının set metodu ile parametre olarak verilen bağlantı cümlesi dosyaya yazılır ve dizine kaydedilir
        /// Kaydedildimi bilgisi true atanır ve ekran kapatılır
        /// Bağlantı başarısız ise kullanıcıya bilgi penceresi gösterilir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAyarlariKaydet_Click(object sender, EventArgs e)
        {
            BaglantiCumlesiOlustur();
            if (ConnectionStringProvider.Check(sqlConnectionStringBuilder.ConnectionString))
            {
                sqlConnectionStringBuilder.InitialCatalog = "DinamikTestFormu";
                ConnectionStringProvider.Set(sqlConnectionStringBuilder.ConnectionString);
                kaydedildiMi = true;
                Close();
            }
            else
            {
                MessageBox.Show("Bağlantı Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Kapat butonuna tıklanınca uygulama sonlandırılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}