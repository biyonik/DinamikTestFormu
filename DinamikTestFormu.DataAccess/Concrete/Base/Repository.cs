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
    public class Repository<TEntity> : IRepository<TEntity>, IDisposable where TEntity : class, IEntity, new()
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Add(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Add(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
        }

        public void AddOrUpdate(TEntity entity)
        {
            _context.Set<TEntity>().AddOrUpdate(entity);
        }

        public void AddOrUpdate(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Set<TEntity>().AddOrUpdate(entity);
            }
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }
        }

        public void Delete(Expression<Func<TEntity, bool>> filter)
        {
            _context.Set<TEntity>().RemoveRange(_context.Set<TEntity>().Where(filter));
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _context.Set<TEntity>().MultipleInclude(includes).SingleOrDefault(filter);
        }

        public bool Exist(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Any(filter);
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter,
            params Expression<Func<TEntity, object>>[] includes)
        {
            return filter == null
                ? _context.Set<TEntity>().MultipleInclude(includes).AsNoTracking().ToList()
                : _context.Set<TEntity>().MultipleInclude(includes).Where(filter).AsNoTracking().ToList();
        }

        public IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter,
            Expression<Func<TEntity, TEntity>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return filter == null
                ? _context.Set<TEntity>().MultipleInclude(includes).Select(selector)
                : _context.Set<TEntity>().MultipleInclude(includes).Where(filter).Select(selector);
        }

        public IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter,
            Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return filter == null
                ? _context.Set<TEntity>().MultipleInclude(includes).Select(selector)
                : _context.Set<TEntity>().MultipleInclude(includes).Where(filter).Select(selector);
        }

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

        public bool HasChanges()
        {
            return _context.ChangeTracker.Entries<TEntity>().Any();
        }

        public BindingList<TEntity> BindingList()
        {
            return _context.Set<TEntity>().Local.ToBindingList();
        }
    }
}