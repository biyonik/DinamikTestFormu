using DinamikTestFormu.BusinessLogic.Abstract;
using DinamikTestFormu.BusinessLogic.Concrete;
using DinamikTestFormu.BusinessLogic.Workers.Abstract;
using DinamikTestFormu.DataAccess.UnitOfWork.Abstract;
using DinamikTestFormu.DataAccess.UnitOfWork.Concrete;

namespace DinamikTestFormu.BusinessLogic.Workers.Concrete
{
    public class DtfWorker: IWorker
    {
        private readonly IUnitOfWork _unitOfWork;

        public IDersService DersService { get; set; }
        public ISecenekService SecenekService { get; set; }
        public ISinavService SinavService { get; set; }
        public ISinavSoruService SinavSoruService { get; set; }
        public ISoruService SoruService { get; set; }
        

        public DtfWorker(string connectionString = null)
        {
            _unitOfWork = new DtfUnitOfWork(connectionString);
            DersService = new DersManager(_unitOfWork);
            SecenekService = new SecenekManager(_unitOfWork);
            SinavService = new SinavManager(_unitOfWork);
            SinavSoruService = new SinavSoruManager(_unitOfWork);
            SoruService = new SoruManager(_unitOfWork);
        }
        
        public void Dispose()
        {
        }

        public bool HasChanges()
        {
            return _unitOfWork.HasChanges();
        }

        public void DetectChanges()
        {
            _unitOfWork.DetectChanges();
        }

        public bool Commit()
        {
            return _unitOfWork.Commit();
        }
    }
}