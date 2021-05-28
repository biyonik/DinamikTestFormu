using DinamikTestFormu.BusinessLogic.Abstract;
using DinamikTestFormu.BusinessLogic.Concrete.Base;
using DinamikTestFormu.DataAccess.UnitOfWork.Abstract;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.BusinessLogic.Concrete
{
    /// <summary>
    /// SinavManager, BaseManager sınıfından kalıtılır ve ISinavService arayüzü ile kontrat imzalar
    /// SinavManager, Sinav entity için BaseManager sınıfındaki işlemleri yapan sınıftır
    /// Yapıcı metodunda IUnitOfWork arayüzünden bir parametre alır ve üst sınıfa gönderir
    /// </summary>
    public class SinavManager: BaseManager<Sinav>, ISinavService
    {
        public SinavManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}