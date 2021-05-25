using DinamikTestFormu.BusinessLogic.Abstract;
using DinamikTestFormu.BusinessLogic.Concrete.Base;
using DinamikTestFormu.DataAccess.UnitOfWork.Abstract;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.BusinessLogic.Concrete
{
    public class SinavManager: BaseManager<Sinav>, ISinavService
    {
        public SinavManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}