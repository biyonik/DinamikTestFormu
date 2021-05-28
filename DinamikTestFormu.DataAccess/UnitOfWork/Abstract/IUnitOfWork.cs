using System;
using DinamikTestFormu.DataAccess.Abstract.Base;
using DinamikTestFormu.Entities.Abstract;

namespace DinamikTestFormu.DataAccess.UnitOfWork.Abstract
{
    /// <summary>
    /// IUnitOfWork arayüzü.
    /// </summary>
    public interface IUnitOfWork: IDisposable
    {
        /// <summary>
        /// IRepository jenerik arayüzü tipinde değer dönen metot (Aslında IRepository jenerik arayüzü ile kontrat imzalamış bir sınıf tipinde döner)
        /// Generic repository pattern yapısında Repository jenerik sınıfının bir örneğini oluşturur
        /// Böylece DataAccessLayer deki her bir entity için IRepository arayüzündeki metotlar çağrılabilir olur
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IRepository<TEntity> Dal<TEntity>() where TEntity : class, IEntity, new();
        
        /// <summary>
        /// bool tipinde entity durumlarında bir değişiklik olup olmadığını dönen metot 
        /// </summary>
        /// <returns></returns>
        bool HasChanges();
        
        /// <summary>
        /// void tipinde entity durum izleyicisindeki değişiklikleri tespit ederek entitnin orjinal değerlerinin üzerine yazar
        /// </summary>
        void DetectChanges();

        /// <summary>
        /// Bu metot ile veritabanı işlemleri için biriken işlemler commit(gönderme, uygulama) edilir
        /// </summary>
        /// <returns></returns>
        bool Commit();
    }
}