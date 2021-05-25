using DinamikTestFormu.BusinessLogic.Abstract;
using DinamikTestFormu.BusinessLogic.Concrete.Base;
using DinamikTestFormu.DataAccess.UnitOfWork.Abstract;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.BusinessLogic.Concrete
{
    public class SecenekManager: BaseManager<Secenek>, ISecenekService
    {
        public SecenekManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}