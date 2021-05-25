using DinamikTestFormu.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DinamikTestFormu.DataAccess.Mappings
{
    public class SecenekMap: EntityTypeConfiguration<Secenek>
    {
        public SecenekMap()
        {
            Property(s => s.Opsiyon).HasMaxLength(300);

            ToTable("Secenekler");

            Property(s => s.Opsiyon).HasColumnName("Secenek");
            Property(s => s.SoruId).HasColumnName("SoruId");
        }
    }
}
