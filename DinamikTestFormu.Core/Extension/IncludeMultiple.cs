using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DinamikTestFormu.Entities.Abstract;

namespace DinamikTestFormu.Core.Extension
{
    /// <summary>
    /// IQuerayable jenerik sınıfına "extension method" tanımlayan sınıf
    /// includes parametresi null değilse IQueryable jenerik tipine LINQ extension Aggerate metodu olarak zincirleme query ekler
    /// Böylece ilişkili entitylere ait tüm veriler alınabilir
    /// </summary>
    public static class IncludeMultiple
    {
        public static IQueryable<TEntity> MultipleInclude<TEntity>(this IQueryable<TEntity> query, params Expression<Func<TEntity, object>>[] includes)
            where TEntity: class, IEntity, new()
        {
            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }
            return query;
        }
    }
}