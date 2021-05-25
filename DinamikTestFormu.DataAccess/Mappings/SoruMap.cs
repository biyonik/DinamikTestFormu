using DinamikTestFormu.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DinamikTestFormu.DataAccess.Mappings
{
    public class SoruMap: EntityTypeConfiguration<Soru>
    {
        public SoruMap()
        {
            Property(s => s.Metin).HasMaxLength(500);

            ToTable("Sorular");

            Property(s => s.Gorsel).HasColumnName("Gorsel");
            Property(s => s.Metin).HasColumnName("Metin");
            Property(s => s.DersId).HasColumnName("DersId");
            Property(s => s.DogruSecenekId).HasColumnName("DogruSecenekId");
        }
    }
}
