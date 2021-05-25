using System;
using DinamikTestFormu.Core.Functions;
using DinamikTestFormu.DataAccess.Abstract;
using DinamikTestFormu.DataAccess.Abstract.Base;
using DinamikTestFormu.DataAccess.Concrete;
using DinamikTestFormu.DataAccess.Concrete.Base;
using DinamikTestFormu.DataAccess.Contexts.Dtf;
using DinamikTestFormu.DataAccess.Functions;
using DinamikTestFormu.DataAccess.UnitOfWork.Abstract;
using DinamikTestFormu.Entities.Abstract;

namespace DinamikTestFormu.DataAccess.UnitOfWork.Concrete
{
    public class DtfUnitOfWork: IUnitOfWork
    {
        private readonly DtfContext _context;
        public IDersDal DersDal { get; set; }
        public ISecenekDal SecenekDal { get; set; }
        public ISinavDal SinavDal { get; set; }
        public ISinavSoruDal SinavSoruDal { get; set; }
        public ISoruDal SoruDal { get; set; }
        
        public DtfUnitOfWork(string connectionString = null)
        {
            if (connectionString == null)
            {
                _context = new DtfContext(ConnectionStringProvider.Get());
            }
            else
            {
                _context = new DtfContext(connectionString);
            }
            DersDal = new DersDal(_context);
            SecenekDal = new SecenekDal(_context);
            SinavDal = new SinavDal(_context);
            SinavSoruDal = new SinavSoruDal(_context);
            SoruDal = new SoruDal(_context);
        }

        public IRepository<TEntity> Dal<TEntity>() where TEntity : class, IEntity, new()
        {
            return new Repository<TEntity>(_context);
        }

        public bool HasChanges()
        {
            return _context.ChangeTracker.HasChanges();
        }

        public void DetectChanges()
        {
            _context.ChangeTracker.DetectChanges();
        }

        public bool Commit()
        {
            EntityBaseInfo.Add(_context);
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public void Dispose()
        {
        }
    }
}