using DinamikTestFormu.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DinamikTestFormu.DataAccess.Mappings
{
    /// <summary>
    /// SinavMap sınıfı Sinav entity için Entity Framework tarafında kolon ve tablo konfigürasyonlarını yapar
    /// </summary>
    public class SinavMap: EntityTypeConfiguration<Sinav>
    {
        /// <summary>
        /// Yapıcı metot
        /// Sinav entity için veritabanı tarafında kolon ve tablo ayarları yapılıyor
        /// Metot içindeki kodlar Entity Framework'a öz metotlar olup, kodu okuyan kişinin EF bilgisi olması kavramayı kolaylaştıracaktır
        /// Her bir property LINQ expression olarak ele alınıp, kolon veri uzunluğu ve adı 
        /// ToTable ile de tablo adı konfigüre ediliyor
        /// </summary>
        public SinavMap()
        {
            Property(s => s.Adi).HasMaxLength(200);

            ToTable("Sinavlar");

            Property(s => s.Adi).HasColumnName("Adi");
        }
    }
}
