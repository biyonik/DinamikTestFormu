using DinamikTestFormu.BusinessLogic.Abstract;
using DinamikTestFormu.BusinessLogic.Concrete;
using DinamikTestFormu.BusinessLogic.Workers.Abstract;
using DinamikTestFormu.DataAccess.UnitOfWork.Abstract;
using DinamikTestFormu.DataAccess.UnitOfWork.Concrete;

namespace DinamikTestFormu.BusinessLogic.Workers.Concrete
{
    /// <summary>
    /// DtfWorker sınıfı IWorker arayüzü ile bir kontrat imzalar
    /// </summary>
    public class DtfWorker: IWorker
    {
        /// <summary>
        /// IUnitOfWork arayüzünden bir field
        /// Yapıcı metot içerisinde somut sınıf ile örneği alınmış böylece UnitOfWork operasyonlarına erişim sağlanmıştır
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;
        private bool disposedValue;

        /// <summary>
        /// IDersService arayüzü tipinde bir field
        /// </summary>
        public IDersService DersService { get; set; }
        /// <summary>
        /// ISecenekService arayüzü tipinde bir field
        /// </summary>
        public ISecenekService SecenekService { get; set; }
        /// <summary>
        /// ISinavService arayüzü tipinde bir field
        /// </summary>
        public ISinavService SinavService { get; set; }
        /// <summary>
        /// ISinavSoruService arayüzü tipinde bir field
        /// </summary>
        public ISinavSoruService SinavSoruService { get; set; }
        /// <summary>
        /// ISoruService arayüzü tipinde bir field
        /// </summary>
        public ISoruService SoruService { get; set; }
        

        /// <summary>
        /// Yapıcı metot
        /// string tipinde bir parametre alır ve bu parametreyi DtfUnitOfWork sınıfının yapıcı metoduna gönderir
        /// Bu metot içinde soyut arayüz fieldlerin somut sınıflardan bir örneği alınmıştır
        /// </summary>
        /// <param name="connectionString"></param>
        public DtfWorker(string connectionString = null)
        {
            _unitOfWork = new DtfUnitOfWork(connectionString);
            DersService = new DersManager(_unitOfWork);
            SecenekService = new SecenekManager(_unitOfWork);
            SinavService = new SinavManager(_unitOfWork);
            SinavSoruService = new SinavSoruManager(_unitOfWork);
            SoruService = new SoruManager(_unitOfWork);
        }

        /// <summary>
        /// UnitOfWork içindeki HasChanges metodunu çağırır
        /// </summary>
        /// <returns></returns>
        public bool HasChanges()
        {
            return _unitOfWork.HasChanges();
        }

        /// <summary>
        /// UnitOfOwkr içindeki DetectChanges metodunu çağırır
        /// </summary>
        public void DetectChanges()
        {
            _unitOfWork.DetectChanges();
        }

        /// <summary>
        /// UnitOfWork içindeki Commit metodunu çağırır
        /// </summary>
        /// <returns></returns>
        public bool Commit()
        {
            return _unitOfWork.Commit();
        }

        /**
         * 
         *  Disposable Pattern
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
        // ~DtfWorker()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            System.GC.SuppressFinalize(this);
        }
    }
}