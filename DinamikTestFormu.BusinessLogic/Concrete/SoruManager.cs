using DinamikTestFormu.BusinessLogic.Abstract;
using DinamikTestFormu.BusinessLogic.Concrete.Base;
using DinamikTestFormu.DataAccess.UnitOfWork.Abstract;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.BusinessLogic.Concrete
{
    public class SoruManager: BaseManager<Soru>, ISoruService
    {
        public SoruManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}