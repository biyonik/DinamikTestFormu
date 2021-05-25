using System.Data.Entity.Migrations;

namespace DinamikTestFormu.DataAccess.Contexts.Dtf
{
    public class DtfConfiguration: DbMigrationsConfiguration<DtfContext>
    {
        public DtfConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}