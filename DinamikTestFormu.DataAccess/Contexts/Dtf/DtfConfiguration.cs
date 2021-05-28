using System.Data.Entity.Migrations;

namespace DinamikTestFormu.DataAccess.Contexts.Dtf
{
    /// <summary>
    /// Bu configuration sınıfı EntityFramework migrasyon konfigürasyonlarını yapan sınıftır ve DbMigrationsConfiguration jenerik sınıfından kalıtılır
    /// Parametre olarak jenerik DtfContext nesnesi geçilir
    /// </summary>
    public class DtfConfiguration: DbMigrationsConfiguration<DtfContext>
    {
        public DtfConfiguration()
        {
            // Otomatik mgirasyon aktif edilir
            AutomaticMigrationsEnabled = true;
            // Tabloda veri olmasına rağmen yapısal(!) değişiklik yapılması aktif edilir
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}