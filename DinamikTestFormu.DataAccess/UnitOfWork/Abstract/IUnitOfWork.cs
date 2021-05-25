using System;
using DinamikTestFormu.DataAccess.Abstract.Base;
using DinamikTestFormu.Entities.Abstract;

namespace DinamikTestFormu.DataAccess.UnitOfWork.Abstract
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<TEntity> Dal<TEntity>() where TEntity : class, IEntity, new();
        bool HasChanges();
        void DetectChanges();
        bool Commit();
    }
}