using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DinamikTestFormu.DataAccess.Contexts.Base;
using DinamikTestFormu.DataAccess.Mappings;
using DinamikTestFormu.Entities.Concrete;
using DinamikTestFormu.Entities.Concrete.Base;

namespace DinamikTestFormu.DataAccess.Contexts.Dtf
{
    /// <summary>
    /// Entity Framework context sınıfıdır
    /// BaseContext sınıfından kalıtılır ki BaseContext asıl işi yapan DbContext sınıfından kalıtılmıştır
    /// </summary>
    public class DtfContext: BaseContext<DtfContext>
    {
        /// <summary>
        /// Yapıcı metot
        /// </summary>
        public DtfContext()
        {
            
        }

        /// <summary>
        /// Yapıcı metot, parametre olarak bir string parametre alır ve üst sınıfa da bu parametreyi gönderir
        /// </summary>
        /// <param name="connectionString"></param>
        public DtfContext(string connectionString): base(connectionString)
        {
            // Veritabanı başlatıcı metot
            // Veritabanı başlatılırken konfigürasyon dosyasındaki migrasyon özelliklerine göre başlatmamız ayarlanıyor
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DtfContext, DtfConfiguration>());
        }

        /// <summary>
        /// DbSet sınıfı ve kendisine geçen jenerik parametreler EntityFramework için veritabanında bir tabloyu temsil eder
        /// Property adı (Dersler, Sınavlar) eğer kısıtlama(mapping) getirilmez ise birebir tablo adıdır
        /// </summary>
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Sinav> Sinavlar { get; set; }
        public DbSet<Soru> Sorular { get; set; }
        public DbSet<Secenek> Secenekler { get; set; }
        public DbSet<SinavSoru> SinavSoru { get; set; }

        /// <summary>
        /// Modeller oluşturulurken,
        ///     - Tüm ilişkiler
        ///     - Varsayılan varlık konfigürasyonları
        ///     - Mapping işlemleri bu metot içinde kotarılır
        /// DbModelBuilder tipinde bir parametre alır ve bu parametre içinden entity ile ilgili tüm işlemler(ilişki, kolon özellikleri, kısıtlama) yapılır
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            /**
             * 
             * EntityBase sınıfındaki propertylerin veritananı tablosundaki 
             * özelliklerinin tanımlandığı yer
             * HasMaxLength ile kolonun taşıyabileceği maksimum uzunluk
             * HasColunmName ile veritabanındaki ilgili tablodaki kolonların isimleri tanımlanır
             * Teknik olarak bu kısım entity framework bilgisi gerektirir
             * Kod okuması yapan kişilerin bu bilgiye haiz olması işleyişi anlamak açısından daha kolay kavramalarını sağlar
             * 
             */
            modelBuilder.Types<EntityBase>().Configure(c =>
            {
                c.HasKey(e => e.Id);
                c.Property(e => e.Ekleyen).HasMaxLength(30);
                c.Property(e => e.Duzenleyen).HasMaxLength(30);
                c.Property(e => e.Aciklama).HasMaxLength(250);
                
                c.Property(e => e.Id).HasColumnName("Id");
                c.Property(e => e.Aciklama).HasColumnName("Aciklama");
                c.Property(e => e.Duzenleyen).HasColumnName("Duzenleyen");
                c.Property(e => e.Ekleyen).HasColumnName("Ekleyen");
                c.Property(e => e.EklenmeTarihi).HasColumnName("EklenmeTarihi");
                c.Property(e => e.DuzenlenmeTarihi).HasColumnName("DuzenlenmeTarihi");
            });

            /**
             * 
             *  Veritabanı tabloları arasında
             *  Bire-Bir
             *  Bire-Çok
             *  Çoka-Çok ilişkiler burada tanımlanmıştır
             * 
             * */
            modelBuilder.Entity<Soru>().HasRequired(c => c.Ders).WithOptional().Map(c => c.MapKey("DersId"));
            modelBuilder.Entity<Soru>().HasRequired(c => c.Secenek).WithOptional().Map(c => c.MapKey("DogruSecenekId"));
            modelBuilder.Entity<Secenek>().HasRequired(c => c.Soru).WithMany(c => c.Secenekler).HasForeignKey(c => c.SoruId);

            modelBuilder.Entity<SinavSoru>().HasKey(c => new
            {
                c.SinavId,
                c.SoruId
            });

            /**
             * Tabloların özelliklerini tanımlayan mapping sınıflarının konfigürasyonlarının tanımlanma işlemleri 
             * 
             * */
            modelBuilder.Configurations.Add(new DersMap());
            modelBuilder.Configurations.Add(new SoruMap());
            modelBuilder.Configurations.Add(new SinavMap());
            modelBuilder.Configurations.Add(new SinavSoruMap());
            modelBuilder.Configurations.Add(new SecenekMap());
        }
    }
}