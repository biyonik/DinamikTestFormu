using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using DinamikTestFormu.BusinessLogic.Abstract.Base;
using DinamikTestFormu.DataAccess.UnitOfWork.Abstract;
using DinamikTestFormu.Entities.Abstract;

namespace DinamikTestFormu.BusinessLogic.Concrete.Base
{
    public class BaseManager<TEntity>: IBaseService<TEntity> where TEntity: class, IEntity, new()
    {
        private IUnitOfWork _unitOfWork;

        public BaseManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public virtual void Add(TEntity entity)
        {
            _unitOfWork.Dal<TEntity>().Add(entity);
        }

        public virtual void Add(IEnumerable<TEntity> entities)
        {
            _unitOfWork.Dal<TEntity>().Add(entities);
        }

        public virtual void AddOrUpdate(TEntity entity)
        {
            _unitOfWork.Dal<TEntity>().AddOrUpdate(entity);
        }

        public virtual void AddOrUpdate(IEnumerable<TEntity> entities)
        {
            _unitOfWork.Dal<TEntity>().AddOrUpdate(entities);
        }

        public virtual void Update(TEntity entity)
        {
            _unitOfWork.Dal<TEntity>().Update(entity);
        }

        public virtual void Update(IEnumerable<TEntity> entities)
        {
            _unitOfWork.Dal<TEntity>().Update(entities);
        }

        public virtual void Delete(TEntity entity)
        {
            _unitOfWork.Dal<TEntity>().Delete(entity);
        }

        public virtual void Delete(IEnumerable<TEntity> entities)
        {
            _unitOfWork.Dal<TEntity>().Delete(entities);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> filter)
        {
            _unitOfWork.Dal<TEntity>().Delete(filter);
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _unitOfWork.Dal<TEntity>().Get(filter, includes);
        }

        public virtual bool Exist(Expression<Func<TEntity, bool>> filter)
        {
            return _unitOfWork.Dal<TEntity>().Exist(filter);
        }

        public virtual IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _unitOfWork.Dal<TEntity>().GetList(filter, includes);
        }

        public virtual IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return _unitOfWork.Dal<TEntity>().Select(filter, selector, includes);
        }

        public virtual IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return _unitOfWork.Dal<TEntity>().Select(filter, selector, includes);
        }

        public virtual void Load(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            _unitOfWork.Dal<TEntity>().Load(filter, includes);
        }

        public virtual bool HasChanges()
        {
            return _unitOfWork.Dal<TEntity>().HasChanges();
        }

        public virtual BindingList<TEntity> BindingList()
        {
            return _unitOfWork.Dal<TEntity>().BindingList();
        }
        
        public void Dispose()
        {
            
        }
    }
}