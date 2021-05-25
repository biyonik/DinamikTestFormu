using DinamikTestFormu.BusinessLogic.Abstract;
using DinamikTestFormu.BusinessLogic.Concrete.Base;
using DinamikTestFormu.DataAccess.UnitOfWork.Abstract;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.BusinessLogic.Concrete
{
    public class SinavSoruManager: BaseManager<SinavSoru>, ISinavSoruService
    {
        public SinavSoruManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}