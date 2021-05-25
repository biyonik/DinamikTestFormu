using System;
using System.Data.Entity;
using DinamikTestFormu.Entities.Concrete.Base;

namespace DinamikTestFormu.DataAccess.Functions
{
    public class EntityBaseInfo
    {
        public static void Add(DbContext context)
        {
            foreach (var entry in context.ChangeTracker.Entries())
            {
                EntityBase changedEntity = (EntityBase) entry.Entity;
                switch (entry.State)
                {
                    case EntityState.Added:
                        if (changedEntity.Id == Guid.Empty)
                        {
                            changedEntity.Id = Guid.NewGuid();
                        }
                        changedEntity.EklenmeTarihi = DateTime.Now;
                        changedEntity.Ekleyen = "Admin";
                        changedEntity.DuzenlenmeTarihi = DateTime.Now;
                        changedEntity.Duzenleyen = "Admin";
                        break;
                    case EntityState.Modified:
                        changedEntity.DuzenlenmeTarihi = DateTime.Now;
                        changedEntity.Duzenleyen = "Admin";
                        break;
                }
            }
        }
    }
}