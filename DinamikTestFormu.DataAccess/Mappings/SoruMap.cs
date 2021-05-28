using DinamikTestFormu.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DinamikTestFormu.DataAccess.Mappings
{
    /// <summary>
    /// SoruMap sınıfı Sinav entity için Entity Framework tarafında kolon ve tablo konfigürasyonlarını yapar
    /// </summary>
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
