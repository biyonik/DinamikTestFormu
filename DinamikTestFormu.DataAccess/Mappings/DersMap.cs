using DinamikTestFormu.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DinamikTestFormu.DataAccess.Mappings
{
    /// <summary>
    /// DersMap sınıfı Ders entity için Entity Framework tarafında kolon ve tablo konfigürasyonlarını yapar
    /// </summary>
    public class DersMap: EntityTypeConfiguration<Ders>
    {
        /// <summary>
        /// Yapıcı metot
        /// Ders entity için veritabanı tarafında kolon ve tablo ayarları yapılıyor
        /// Metot içindeki kodlar Entity Framework'a öz metotlar olup, kodu okuyan kişinin EF bilgisi olması kavramayı kolaylaştıracaktır
        /// Her bir property LINQ expression olarak ele alınıp, kolon veri uzunluğu ve adı 
        /// ToTable ile de tablo adı konfigüre ediliyor
        /// </summary>
        public DersMap()
        {
            Property(d => d.Adi).HasMaxLength(50);

            ToTable("Dersler");

            Property(d => d.Adi).HasColumnName("Adi");
        }
    }
}
