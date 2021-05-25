using DinamikTestFormu.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DinamikTestFormu.DataAccess.Mappings
{
    public class SinavMap: EntityTypeConfiguration<Sinav>
    {
        public SinavMap()
        {
            Property(s => s.Adi).HasMaxLength(200);

            ToTable("Sinavlar");

            Property(s => s.Adi).HasColumnName("Adi");
        }
    }
}
