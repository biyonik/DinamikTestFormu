using DinamikTestFormu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamikTestFormu.DataAccess.Mappings
{
    public class DersMap: EntityTypeConfiguration<Ders>
    {
        public DersMap()
        {
            Property(d => d.Adi).HasMaxLength(50);

            ToTable("Dersler");

            Property(d => d.Adi).HasColumnName("Adi");
        }
    }
}
