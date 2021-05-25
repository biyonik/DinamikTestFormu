using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DinamikTestFormu.Core.Functions
{
    public partial class FrmConnectionSetupWizard : DevExpress.XtraEditors.XtraForm
    {
        SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
        public bool kaydedildiMi = false;

        public FrmConnectionSetupWizard()
        {
            InitializeComponent();
        }

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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}