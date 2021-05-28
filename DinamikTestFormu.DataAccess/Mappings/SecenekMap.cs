using DinamikTestFormu.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DinamikTestFormu.DataAccess.Mappings
{
    /// <summary>
    /// SecenekMap sınıfı Secenek entity için Entity Framework tarafında kolon ve tablo konfigürasyonlarını yapar
    /// </summary>
    public class SecenekMap: EntityTypeConfiguration<Secenek>
    {
        /// <summary>
        /// Yapıcı metot
        /// Secenek entity için veritabanı tarafında kolon ve tablo ayarları yapılıyor
        /// Metot içindeki kodlar Entity Framework'a öz metotlar olup, kodu okuyan kişinin EF bilgisi olması kavramayı kolaylaştıracaktır
        /// Her bir property LINQ expression olarak ele alınıp, kolon veri uzunluğu ve adı 
        /// ToTable ile de tablo adı konfigüre ediliyor
        /// </summary>
        public SecenekMap()
        {
            Property(s => s.Opsiyon).HasMaxLength(300);

            ToTable("Secenekler");

            Property(s => s.Opsiyon).HasColumnName("Secenek");
            Property(s => s.SoruId).HasColumnName("SoruId");
        }
    }
}
