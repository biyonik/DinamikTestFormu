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
    /// <summary>
    /// IUnitOfWork arayüzü ile kontrat imzayan UnitOfWork implemente sınıfı
    /// </summary>
    public class DtfUnitOfWork: IUnitOfWork
    {
        /// <summary>
        /// DtfContext nesnesi bir entity framework DbContext sınıfından katılılan sınıftır
        /// Yapıcı metotta verilen connection string bu contexte parametre geçilerek unitofwork tarafında veritabanı işlemlerinin kotarılmasını sağlar
        /// </summary>
        private readonly DtfContext _context;
        private bool disposedValue;

        /// <summary>
        /// IDersDal arayüzü tipinde bir property
        /// </summary>
        public IDersDal DersDal { get; set; }
        /// <summary>
        /// ISecenekDal arayüzü tipinde bir property
        /// </summary>
        public ISecenekDal SecenekDal { get; set; }
        /// <summary>
        /// ISinavDal arayüzü tipinde bir property
        /// </summary>
        public ISinavDal SinavDal { get; set; }
        /// <summary>
        /// ISinavSoruDal arayüzü tipinde bir property
        /// </summary>
        public ISinavSoruDal SinavSoruDal { get; set; }
        /// <summary>
        /// ISoruDal arayüzü tipinde bir property
        /// </summary>
        public ISoruDal SoruDal { get; set; }
        
        /// <summary>
        /// Yapıcı metot
        /// bir string parametre alır. Eğer parametre null gelirse ConnectionStringProviver sınıfının Get metodundan gelen değere göre
        /// DtfContext sınıfından bir örnek oluşturur
        /// Parametre null değilse DtfContext sınıfına bu parametreyi göndererek bir sınıf DtfContext sınıf örneği oluşturur
        /// </summary>
        /// <param name="connectionString"></param>
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
            /**
             * 
             * IDersDal arayüzü ile kontrat imzalayan DersDal burada somut olarak örnekleniyor ve _context değişkeni yapıcı parametresine gönderiliyor
             * ISecenekDal arayüzü ile kontrat imzalayan SecenekDal burada somut olarak örnekleniyor ve _context değişkeni yapıcı parametresine gönderiliyor
             * ISinavDal arayüzü ile kontrat imzalayan SinavDal burada somut olarak örnekleniyor ve _context değişkeni yapıcı parametresine gönderiliyor
             * ISinavSoruDal arayüzü ile kontrat imzalayan SinavSoruDal burada somut olarak örnekleniyor ve _context değişkeni yapıcı parametresine gönderiliyor
             * ISoruDal arayüzü ile kontrat imzalayan SoruDal burada somut olarak örnekleniyor ve _context değişkeni yapıcı parametresine gönderiliyor
             * 
             * */
            DersDal = new DersDal(_context);
            SecenekDal = new SecenekDal(_context);
            SinavDal = new SinavDal(_context);
            SinavSoruDal = new SinavSoruDal(_context);
            SoruDal = new SoruDal(_context);
        }

        /// <summary>
        /// Bu metot jenerik TEntity parametresi alarak Repository sınıfının bir örneğini oluşturur
        /// TEntity öyle bir tip ki sınıf olmalı, IEntity arayüzü ile kontrat imzalamlı ve örneği alınabilmelidir
        /// Aslında somut olarak oluşturulan <Entity>Dal sınıflarının teknik olarak yaptığı iş bu metotta kotarılabilmektedir
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public IRepository<TEntity> Dal<TEntity>() where TEntity : class, IEntity, new()
        {
            return new Repository<TEntity>(_context);
        }

        /// <summary>
        /// Entity Framework context nesnesi üzerinde bağlı entitylerde bir değişiklik olup, olmadığını döner
        /// </summary>
        /// <returns></returns>
        public bool HasChanges()
        {
            return _context.ChangeTracker.HasChanges();
        }

        /// <summary>
        /// Entity framework context nesnesi üzerinde bağlı entitylerdeki değişiklikleri orjinal entitynin üstüne yazar
        /// </summary>
        public void DetectChanges()
        {
            _context.ChangeTracker.DetectChanges();
        }

        /// <summary>
        /// Entity Framework context nesnesi üzerindeki değişiklikleri commit (göndermek, uygulamak) eder
        /// EntityBaseInfo sınıfınaki Add metodu ile EntityBase sınıfındaki propertlerin değerler doldurulur
        /// try bloğu içinde ise context nesnesinin SaveChanges metodu çalıştırılır ve tüm değişiklikler veritabanı tarafında kaydedilmiş olur
        /// Başarılı ise true döner, değilse false döner
        /// </summary>
        /// <returns></returns>
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

        /**
         * 
         *  Diposable Pattern
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
        // ~DtfUnitOfWork()
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