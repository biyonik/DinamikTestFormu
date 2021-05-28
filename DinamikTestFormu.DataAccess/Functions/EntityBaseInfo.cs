using System;
using System.Data.Entity;
using DinamikTestFormu.Entities.Concrete.Base;

namespace DinamikTestFormu.DataAccess.Functions
{
    /// <summary>
    /// EntityBaseInfo sınıfı EntityBase sınıfındaki ilgili propertyleri, entity framework değişiklik izleyicisindeki duruma göre doldurur
    /// </summary>
    public class EntityBaseInfo
    {
        /// <summary>
        /// EntityBase sınıfındaki propertyleri EF durum değişiklik izleyicisine göre doldurur
        /// </summary>
        /// <param name="context"></param>
        public static void Add(DbContext context)
        {
            /***
             * 
             *  context üzerindeki değişikliğe uğrayan tüm kayıtlar üzerinde iterasyon yapılıyor
             *  her bir kayıt entitybase sınıfına cast ediliyor
             *  eğer entitystate bir ekleme işlemi ise entitybase sınıfındaki çeşitli propertyler dolduruluyor
             *  eğer entitystate bir oluşturma değil de değişiklik yakaladı ise sadece 2 property dolduruluyor
             * 
             * 
             */
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