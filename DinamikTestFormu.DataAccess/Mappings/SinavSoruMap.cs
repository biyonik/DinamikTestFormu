using DinamikTestFormu.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DinamikTestFormu.DataAccess.Mappings
{
    /// <summary>
    /// SinavSoruMap sınıfı Sinav entity için Entity Framework tarafında kolon ve tablo konfigürasyonlarını yapar
    /// </summary>
    public class SinavSoruMap: EntityTypeConfiguration<SinavSoru>
    {
        /// <summary>
        /// Yapıcı metot
        /// SinavSoru entity için veritabanı tarafında kolon ve tablo ayarları yapılıyor
        /// Metot içindeki kodlar Entity Framework'a öz metotlar olup, kodu okuyan kişinin EF bilgisi olması kavramayı kolaylaştıracaktır
        /// Her bir property LINQ expression olarak ele alınıp, kolon veri uzunluğu ve adı 
        /// ToTable ile de tablo adı konfigüre ediliyor
        /// </summary>
        public SinavSoruMap()
        {
            ToTable("SinavSorulari");
            Property(s => s.SoruId).HasColumnName("SoruId");
            Property(s => s.SinavId).HasColumnName("SinavId");
        }
    }
}
