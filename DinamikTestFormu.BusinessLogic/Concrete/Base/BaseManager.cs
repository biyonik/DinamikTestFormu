using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using DinamikTestFormu.BusinessLogic.Abstract.Base;
using DinamikTestFormu.DataAccess.UnitOfWork.Abstract;
using DinamikTestFormu.Entities.Abstract;

namespace DinamikTestFormu.BusinessLogic.Concrete.Base
{
    /// <summary>
    /// Jenerik BaseManager sınıfı
    /// IBaseService arayüzünden kalıtılır. TEntity tipinde bir parametre alır ki bu TEntity bir sınıf olmalı, IEntity ile kontrat imzalamalı ve örneği alınabilmelidir
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class BaseManager<TEntity>: IBaseService<TEntity> where TEntity: class, IEntity, new()
    {
        /// <summary>
        /// IUnitOfWork arayüzünden bir private field
        /// Burada Dependency Injection uygulanmış, sınıfın yapıcı metodunun parametresinde de bir IUnitOfWork arayüzünden parametre verilerek,
        /// metod içinde birbirine atanmıştır.
        /// </summary>
        private IUnitOfWork _unitOfWork;
        private bool disposedValue;

        public BaseManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Tek bir entity ekler
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki Add metodunu çalıştırır
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Add(TEntity entity)
        {
            _unitOfWork.Dal<TEntity>().Add(entity);
        }

        /// <summary>
        /// Birden fazla entity ekler
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki Add metodunu çalıştırır
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Add(IEnumerable<TEntity> entities)
        {
            _unitOfWork.Dal<TEntity>().Add(entities);
        }

        /// <summary>
        /// Tek bir entity ekler veya günceller
        /// SQL tarafında Merge - Upsert işlemini yapar
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki AddOrUpdate metodunu çalıştırır
        /// </summary>
        /// <param name="entity"></param>
        public virtual void AddOrUpdate(TEntity entity)
        {
            _unitOfWork.Dal<TEntity>().AddOrUpdate(entity);
        }

        /// <summary>
        /// Birden fazla entity ekler veya günceller
        /// SQL tarafında Merge - Upsert işlemini yapar
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki AddOrUpdate metodunu çalıştırır
        /// </summary>
        /// <param name="entity"></param>
        public virtual void AddOrUpdate(IEnumerable<TEntity> entities)
        {
            _unitOfWork.Dal<TEntity>().AddOrUpdate(entities);
        }

        /// <summary>
        /// Tek bir entity günceller
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki Update metodunu çalıştırır
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Update(TEntity entity)
        {
            _unitOfWork.Dal<TEntity>().Update(entity);
        }

        /// <summary>
        /// Birden fazla entity günceller
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki Update metodunu çalıştırır
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Update(IEnumerable<TEntity> entities)
        {
            _unitOfWork.Dal<TEntity>().Update(entities);
        }

        /// <summary>
        /// Tek bir entity siler
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki Delete metodunu çalıştırır
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Delete(TEntity entity)
        {
            _unitOfWork.Dal<TEntity>().Delete(entity);
        }

        /// <summary>
        /// Brden fazla entity siler
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki Update metodunu çalıştırır
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Delete(IEnumerable<TEntity> entities)
        {
            _unitOfWork.Dal<TEntity>().Delete(entities);
        }

        /// <summary>
        /// Entity siler fakat kendisine linq expression ile bir filtre verilir
        /// Bu filtreleme işlemi sonucu eşleşen kaydı siler.
        /// Örneğin: soru => soru.Id == 3. Id değeri 3 olan soruyu sil gibi.
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki Delete metodunu çalıştırır
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Delete(Expression<Func<TEntity, bool>> filter)
        {
            _unitOfWork.Dal<TEntity>().Delete(filter);
        }

        /// <summary>
        /// Tek bir kaydı getirir. Dönen kayıt tipi TEntity jenerik tipinde olacaktır. 
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki Get metodunu çalıştırır
        /// Bir filtre alır, filtre yok ise null verilmelidir.
        /// İkinci parametre ise yine bir expression dur fakat dizi tipindedir ve params ile birden çok parametre metoda geçilebilir.
        /// Bir entitynin değerini getirirken, ilişkili diğer enttitynin de değeri alınabilir
        /// Örneğin (soru => soru.Id == 3, x => x.Secenekler, x => x.Ders) dendiğinde Id si 3 olan soruya ait tüm bilgiler ile yanında seçenekleri ve ders bilgisi alınabilir
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public virtual TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _unitOfWork.Dal<TEntity>().Get(filter, includes);
        }

        /// <summary>
        /// Bir entitynin var oluğ olmadığı bilgisini döner
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki Exist metodunu çalıştırır
        /// Bir filtre alır
        /// Örneğin (soru => soru.Id == 3) Id si 3 olan soru veritabanında var mı? bilgisini döner
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public virtual bool Exist(Expression<Func<TEntity, bool>> filter)
        {
            return _unitOfWork.Dal<TEntity>().Exist(filter);
        }

        /// <summary>
        /// Bir IEnumerable entity koleksiyonu döner.
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki GetList metodunu çalıştırır
        /// İlk parametre filtre değeridir.
        /// İkinci parametre ise yine bir expression dur fakat dizi tipindedir ve params ile birden çok parametre metoda geçilebilir.
        /// Entitylerin değerini getirirken, ilişkili diğer entity değerleride alınabilir alınabilir
        /// Örneğin tüm sorular alınırken (null, x => x.Secenekler) ile soruların seçeneklerinde alınabilir
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _unitOfWork.Dal<TEntity>().GetList(filter, includes);
        }

        /// <summary>
        /// Veritabanından verilerin alınıp, hafıza üzerine yüklenmesini sağlayan metod
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki Load metodunu çalıştırır
        /// filtre adında bir expression parametre alır
        /// ikinci parametre ise yine bir expression dur fakat dizi tipindedir ve params ile birden çok parametre metoda geçilebilir.
        /// Entitylerin değerini getirirken, ilişkili diğer entity değerleride alınabilir
        /// Örneğin tüm sorular alınırken (null, x => x.Secenekler) ile soruların seçeneklerinde alınabilir
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        public virtual void Load(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            _unitOfWork.Dal<TEntity>().Load(filter, includes);
        }

        /// <summary>
        /// Veritabanında bir değişiklik olup olmadığını döndüren metod
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki HasChanges metodunu çalıştırır
        /// </summary>
        /// <returns></returns>
        public virtual bool HasChanges()
        {
            return _unitOfWork.Dal<TEntity>().HasChanges();
        }

        /// <summary>
        /// BindingList tipinde değer dönen metot. Load metodu ile efektif çalışır.
        /// IUnitOfWork içinde Jenerik Dal(DataAccessLayer) metodu aslında Repository<TEntity> sınıfından bir örnek oluşturup,
        /// bu sınıf içindeki BindingList metodunu çalıştırır
        /// Öğelerin datasource parametresine listeyi bind etmek (yüklemek, bağlamak) için kullanılır
        /// </summary>
        /// <returns></returns>
        public virtual BindingList<TEntity> BindingList()
        {
            return _unitOfWork.Dal<TEntity>().BindingList();
        }

        /**
         * 
         *  Disposable Pattern
         * 
         * 
         * */

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~BaseManager()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}