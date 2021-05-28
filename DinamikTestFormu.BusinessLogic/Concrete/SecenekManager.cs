using DinamikTestFormu.BusinessLogic.Abstract;
using DinamikTestFormu.BusinessLogic.Concrete.Base;
using DinamikTestFormu.DataAccess.UnitOfWork.Abstract;
using DinamikTestFormu.Entities.Concrete;

namespace DinamikTestFormu.BusinessLogic.Concrete
{
    /// <summary>
    /// SecenekManager, BaseManager sınıfından kalıtılır ve ISecenekService arayüzü ile kontrat imzalar
    /// SecenekManager, Secenek entity için BaseManager sınıfındaki işlemleri yapan sınıftır
    /// Yapıcı metodunda IUnitOfWork arayüzünden bir parametre alır ve üst sınıfa gönderir
    /// </summary>
    public class SecenekManager: BaseManager<Secenek>, ISecenekService
    {
        public SecenekManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}