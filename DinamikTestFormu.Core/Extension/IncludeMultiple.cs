using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DinamikTestFormu.Entities.Abstract;

namespace DinamikTestFormu.Core.Extension
{
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