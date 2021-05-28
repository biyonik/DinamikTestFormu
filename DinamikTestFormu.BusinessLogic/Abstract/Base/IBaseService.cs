using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using DinamikTestFormu.Entities.Abstract;

namespace DinamikTestFormu.BusinessLogic.Abstract.Base
{
    /// <summary>
    /// Jenerik IBase arayüzü
    /// IDisposable arayüzü ile bir kontrat imzalar
    /// Kendisine verilen TEntity parametresi bir sınıf olmalı, IEntity ile kontrat imzalamalı ve bir örneği alınabilmelidir(new)
    /// İş katmanındaki temel operasyonları barındıdır
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseService<TEntity>: IDisposable where TEntity: class, IEntity, new()
    {
        /// <summary>
        /// Tek bir entity ekler
        /// </summary>
        /// <param name="entity"></param>
        void Add(TEntity entity);
        /// <summary>
        /// Birden fazla entity ekler
        /// </summary>
        /// <param name="entities"></param>
        void Add(IEnumerable<TEntity> entities);
        /// <summary>
        /// Tek bir entity ekler veya günceller
        /// SQL tarafında Merge - Upsert işlemini yapar
        /// </summary>
        /// <param name="entity"></param>
        void AddOrUpdate(TEntity entity);
        /// <summary>
        /// Birden fazla entity ekler veya günceller
        /// SQL tarafında Merge - Upsert işlemini yapar
        /// </summary>
        /// <param name="entities"></param>
        void AddOrUpdate(IEnumerable<TEntity> entities);
        /// <summary>
        /// Tek bir entityi günceller
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);
        /// <summary>
        /// Birden fazla entity günceller
        /// </summary>
        /// <param name="entities"></param>
        void Update(IEnumerable<TEntity> entities);
        /// <summary>
        /// Tek bir entity siler
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);
        /// <summary>
        /// Birden fazla entity siler
        /// </summary>
        /// <param name="entities"></param>
        void Delete(IEnumerable<TEntity> entities);
        /// <summary>
        /// Entity siler fakat kendisine linq expression ile bir filtre verilir
        /// Bu filtreleme işlemi sonucu eşleşen kaydı siler.
        /// Örneğin: soru => soru.Id == 3. Id değeri 3 olan soruyu sil gibi.
        /// </summary>
        /// <param name="filter"></param>
        void Delete(Expression<Func<TEntity, bool>> filter);
        /// <summary>
        /// Tek bir kaydı getirir. Dönen kayıt tipi TEntity jenerik tipinde olacaktır. 
        /// Bir filtre alır, filtre yok ise null verilmelidir.
        /// İkinci parametre ise yine bir expression dur fakat dizi tipindedir ve params ile birden çok parametre metoda geçilebilir.
        /// Bir entitynin değerini getirirken, ilişkili diğer enttitynin de değeri alınabilir
        /// Örneğin (soru => soru.Id == 3, x => x.Secenekler, x => x.Ders) dendiğinde Id si 3 olan soruya ait tüm bilgiler ile yanında seçenekleri ve ders bilgisi alınabilir
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes);
        /// <summary>
        /// Bir entitynin var oluğ olmadığı bilgisini döner
        /// Bir filtre alır
        /// Örneğin (soru => soru.Id == 3) Id si 3 olan soru veritabanında var mı? bilgisini döner
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        bool Exist(Expression<Func<TEntity, bool>> filter);
        /// <summary>
        /// Bir IEnumerable entity koleksiyonu döner.
        /// İlk parametre filtre değeridir.
        /// İkinci parametre ise yine bir expression dur fakat dizi tipindedir ve params ile birden çok parametre metoda geçilebilir.
        /// Entitylerin değerini getirirken, ilişkili diğer entity değerleride alınabilir alınabilir
        /// Örneğin tüm sorular alınırken (null, x => x.Secenekler) ile soruların seçeneklerinde alınabilir
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes);
        /// <summary>
        /// Veritabanından verilerin alınıp, hafıza üzerine yüklenmesini sağlayan metod
        /// filtre adında bir expression parametre alır
        /// kinci parametre ise yine bir expression dur fakat dizi tipindedir ve params ile birden çok parametre metoda geçilebilir.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        void Load(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes);
        /// <summary>
        /// Veritabanında bir değişiklik olup olmadığını döndüren metod
        /// </summary>
        /// <returns></returns>
        bool HasChanges();
        /// <summary>
        /// BindingList tipinde değer dönen metot. Load metodu ile efektif çalışır.
        /// Öğelerin datasource parametresine listeyi bind etmek (yüklemek, bağlamak) için kullanılır
        /// </summary>
        /// <returns></returns>
        BindingList<TEntity> BindingList();
    }
}