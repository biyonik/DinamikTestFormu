using DinamikTestFormu.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DinamikTestFormu.DataAccess.Mappings
{
    public class SinavSoruMap: EntityTypeConfiguration<SinavSoru>
    {
        public SinavSoruMap()
        {
            ToTable("SinavSorulari");
            Property(s => s.SoruId).HasColumnName("SoruId");
            Property(s => s.SinavId).HasColumnName("SinavId");
        }
    }
}
