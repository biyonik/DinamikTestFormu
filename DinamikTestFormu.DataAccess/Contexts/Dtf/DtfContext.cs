using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DinamikTestFormu.DataAccess.Contexts.Base;
using DinamikTestFormu.DataAccess.Mappings;
using DinamikTestFormu.Entities.Concrete;
using DinamikTestFormu.Entities.Concrete.Base;

namespace DinamikTestFormu.DataAccess.Contexts.Dtf
{
    public class DtfContext: BaseContext<DtfContext>
    {
        public DtfContext()
        {
            
        }

        public DtfContext(string connectionString): base(connectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DtfContext, DtfConfiguration>());
        }

        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Sinav> Sinavlar { get; set; }
        public DbSet<Soru> Sorular { get; set; }
        public DbSet<Secenek> Secenekler { get; set; }
        public DbSet<SinavSoru> SinavSoru { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

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

            modelBuilder.Entity<Soru>().HasRequired(c => c.Ders).WithOptional().Map(c => c.MapKey("DersId"));
            modelBuilder.Entity<Soru>().HasRequired(c => c.Secenek).WithOptional().Map(c => c.MapKey("DogruSecenekId"));
            modelBuilder.Entity<Secenek>().HasRequired(c => c.Soru).WithMany(c => c.Secenekler).HasForeignKey(c => c.SoruId);

            modelBuilder.Entity<SinavSoru>().HasKey(c => new
            {
                c.SinavId,
                c.SoruId
            });

            modelBuilder.Configurations.Add(new DersMap());
            modelBuilder.Configurations.Add(new SoruMap());
            modelBuilder.Configurations.Add(new SinavMap());
            modelBuilder.Configurations.Add(new SinavSoruMap());
            modelBuilder.Configurations.Add(new SecenekMap());
        }
    }
}