using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using DinamikTestFormu.Core.Extension;
using DinamikTestFormu.DataAccess.Abstract.Base;
using DinamikTestFormu.Entities.Abstract;

namespace DinamikTestFormu.DataAccess.Concrete.Base
{
    /// <summary>
    /// Jenerik Repository Sınıfı
    /// IRepository arayüzü ve IDisposable arayüzü ile kontrat imzalar ve Jenerik bir TEntity tipinden parametre alır
    /// TEntity bir sınıf olmalı, IEntity arayüzü ile kontrat imzalamalı ve örneği alınabilmelidir
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Repository<TEntity> : IRepository<TEntity>, IDisposable where TEntity : class, IEntity, new()
    {
        /// <summary>
        /// DbContext tipinde bir field.
        /// </summary>
        private readonly DbContext _context;
        private bool disposedValue;

        /// <summary>
        /// Yapıcı metot
        /// Parametre olarak DbContext tipinde bir parametre alır
        /// Dependency injection ile parametre, field olan context nesnesine atanır
        /// </summary>
        /// <param name="context"></param>
        public Repository(DbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Bir entity ekler
        /// Statetrackere göre Entity State added ise parametre olarak verilen entity ekleme kuyruğuna alınır
        /// </summary>
        /// <param name="entity"></param>
        public void Add(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        /// <summary>
        /// Birden fazla entity ekler
        /// parametre olarak verilen entities üzerinde bir iterasyon işletilir ve her iterasyon adımında
        /// Statetrackere göre Entity State added ise parametre olarak verilen entity ekleme kuyruğuna alınır
        /// </summary>
        /// <param name="entities"></param>
        public void Add(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
        }

        /// <summary>
        /// Ya Ekleme ya da Güncelleme işlemi yapan metot
        /// Teknik olarak sql tarafında upsert işlemini yapar
        /// context nesnesi üzerinde Set<TEntity> metodu ile DbSet<TEntity> örneği alınmış olur ve AddOrUpdate(entity) ile de aksiyon tamamlanır
        /// </summary>
        /// <param name="entity"></param>
        public void AddOrUpdate(TEntity entity)
        {
            _context.Set<TEntity>().AddOrUpdate(entity);
        }

        /// <summary>
        /// Birden fazla entity için ya Ekleme ya da Güncelleme işlemi yapan metot
        /// Parametre olarak verilen entities üzerinde iterasyon yapılır
        /// Teknik olarak sql tarafında upsert işlemini yapar
        /// context nesnesi üzerinde Set<TEntity> metodu ile DbSet<TEntity> örneği alınmış olur ve AddOrUpdate(entity) ile de aksiyon tamamlanır
        /// </summary>
        /// <param name="entity"></param>
        public void AddOrUpdate(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Set<TEntity>().AddOrUpdate(entity);
            }
        }

        /// <summary>
        /// Bir entity günceller
        /// Statetrackere göre Entity State modified ise parametre olarak verilen entity güncelleme kuyruğuna alınır
        /// </summary>
        /// <param name="entity"></param>
        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Birden fazla entity günceller
        /// parametre olarak verilen entities üzerinde bir iterasyon işletilir ve her iterasyon adımında
        /// Statetrackere göre Entity State modified ise parametre olarak verilen entity güncelleme kuyruğuna alınır
        /// </summary>
        /// <param name="entities"></param>
        public void Update(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

        /// <summary>
        /// Bir entity siler
        /// Statetrackere göre Entity State Deleted ise parametre olarak verilen entity silme kuyruğuna alınır
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        /// <summary>
        /// Birden fazla entity siler
        /// parametre olarak verilen entities üzerinde bir iterasyon işletilir ve her iterasyon adımında
        /// Statetrackere göre Entity State deleted ise parametre olarak verilen entity silme kuyruğuna alınır
        /// </summary>
        /// <param name="entities"></param>
        public void Delete(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }
        }

        /// <summary>
        /// Entity siler
        /// Verilen filtre parametresine göre eşleşen bir veya birden fazla entity olduğunda silme işlemini gerçekleştirir.
        /// Set<T> = DbSet<T> instance anlamına gelir.
        /// RemoveRange metodunda ise filter parametresi yine Where metoduna pass geçilerek işletilir
        /// Örneğin x => x.Adi.StartsWith('a') ifadesi entity deki Adi kolonunun içindeki değerlerden a ile başlayanları sil anlamına gelir
        /// </summary>
        /// <param name="filter"></param>
        public void Delete(Expression<Func<TEntity, bool>> filter)
        {
            _context.Set<TEntity>().RemoveRange(_context.Set<TEntity>().Where(filter));
        }

        /// <summary>
        /// Tek bir kaydı getirir. Dönen kayıt tipi TEntity jenerik tipinde olacaktır. 
        /// Bir filtre alır, filtre yok ise null verilmelidir.
        /// İkinci parametre ise yine bir expression dur fakat dizi tipindedir ve params ile birden çok parametre metoda geçilebilir.
        /// Bir entitynin değerini getirirken, ilişkili diğer enttitynin de değeri alınabilir
        /// context.Set<T>() ile DbSet<T> tipinde bir sınıf örneği oluşturulur ve contextin ilgili entitysi üzerinde işlemler yürütülür
        /// MultipleInclude statik metodu ise gelen includes parametrelerini sorguya ekler
        /// SingleOrDefault ise koşula göre tek bir kayıt döner
        /// Örneğin (soru => soru.Id == 3, x => x.Secenekler, x => x.Ders) dendiğinde Id si 3 olan soruya ait tüm bilgiler ile yanında seçenekleri ve ders bilgisi alınabilir
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _context.Set<TEntity>().MultipleInclude(includes).SingleOrDefault(filter);
        }

        /// <summary>
        /// Bir entitynin var oluğ olmadığı bilgisini döner
        /// context.Set<T>() ile DbSet<T> tipinde bir sınıf örneği oluşturulur ve contextin ilgili entitysi üzerinde işlemler yürütülür
        /// Bir filtre alır
        /// Örneğin (soru => soru.Id == 3) Id si 3 olan soru veritabanında var mı? bilgisini döner
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public bool Exist(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Any(filter);
        }

        /// <summary>
        /// Bir IEnumerable entity koleksiyonu döner.
        /// İlk parametre filtre değeridir.
        /// İkinci parametre ise yine bir expression dur fakat dizi tipindedir ve params ile birden çok parametre metoda geçilebilir.
        /// Entitylerin değerini getirirken, ilişkili diğer entity değerleride alınabilir alınabilir
        /// context.Set<T>() ile DbSet<T> tipinde bir sınıf örneği oluşturulur ve contextin ilgili entitysi üzerinde işlemler yürütülür
        /// MultipleInclude statik metodu ise gelen includes parametrelerini sorguya ekler
        /// AsNoTracking ise entity framework entity state tracker i pass geçer ve performans artışı sağlar
        /// Örneğin tüm sorular alınırken (null, x => x.Secenekler) ile soruların seçeneklerinde alınabilir
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter,
            params Expression<Func<TEntity, object>>[] includes)
        {
            return filter == null
                ? _context.Set<TEntity>().MultipleInclude(includes).AsNoTracking().ToList()
                : _context.Set<TEntity>().MultipleInclude(includes).Where(filter).AsNoTracking().ToList();
        }

        /// <summary>
        /// context.Set<T>() ile DbSet<T> tipinde bir sınıf örneği oluşturulur ve contextin ilgili entitysi üzerinde işlemler yürütülür
        /// filtre null ise MultipleInclude statik metodu ise gelen includes parametrelerini sorguya ekler ve ilgili entity i hafızaya yükler
        /// filtre null değilse filtreleme işlemi uygular ve diğer adımları işletir
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        public void Load(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            if (filter == null)
            {
                _context.Set<TEntity>().MultipleInclude(includes).Load();
            }
            else
            {
                _context.Set<TEntity>().MultipleInclude(includes).Where(filter).Load();
            }
        }

        /// <summary>
        /// Entity framework state tracker üzerinde ilgili entity için bir değişiklik olup olmadığını döndüren metot
        /// </summary>
        /// <returns></returns>
        public bool HasChanges()
        {
            return _context.ChangeTracker.Entries<TEntity>().Any();
        }

        /// <summary>
        /// BindingList tipinde değer dönen metot. Load metodu ile efektif çalışır.
        /// context.Set<T>() ile DbSet<T> tipinde bir sınıf örneği oluşturulur ve contextin ilgili entitysi üzerinde işlemler yürütülür
        /// Öğelerin datasource parametresine listeyi bind etmek (yüklemek, bağlamak) için kullanılır
        /// </summary>
        /// <returns></returns>
        public BindingList<TEntity> BindingList()
        {
            return _context.Set<TEntity>().Local.ToBindingList();
        }

        /**
         * 
         *  Disposable Pattern
         * 
         * 
         */

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
        // ~Repository()
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